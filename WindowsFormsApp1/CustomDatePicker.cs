using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomDatePicker: UserControl
    {

        private TextBox textBox;
        private MonthCalendar monthCalendar;
        private ToolStripDropDown dropDown;

        public DateTime? Value
        {
            get => SelectedDate;
            set
            {
                SelectedDate = value;
                if (value.HasValue)
                    textBox.Text = value.Value.ToString("dd/MM/yyyy");
                else
                    textBox.Text = "";
            }
        }

        public DateTime? SelectedDate { get; private set; }
        public CustomDatePicker()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            // size mặc định (có thể thay đổi trong designer)
            this.Height = 24;

            // TextBox (hiện ngày, không cho gõ)
            textBox = new TextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                BackColor = SystemColors.Window,
                Cursor = Cursors.Hand
            };
            textBox.Click += TextBox_Click;
            textBox.KeyDown += TextBox_KeyDown;
            this.Controls.Add(textBox);

            // MonthCalendar
            monthCalendar = new MonthCalendar
            {
                MaxSelectionCount = 1
            };
            monthCalendar.DateSelected += MonthCalendar_DateSelected;

            // Host calendar vào ToolStripDropDown để hiện popup (không bị clipping)
            var host = new ToolStripControlHost(monthCalendar)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = false
            };
            host.Size = monthCalendar.Size;

            dropDown = new ToolStripDropDown
            {
                Padding = Padding.Empty,
                AutoClose = true
            };
            dropDown.Items.Add(host);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                ShowCalendar();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (dropDown.Visible) dropDown.Close();
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            ShowCalendar();
        }

        private void ShowCalendar()
        {
            if (!dropDown.Visible)
            {
                // cập nhật kích thước host trước khi show (trong trường hợp calendar thay đổi)
                ((ToolStripControlHost)dropDown.Items[0]).Size = monthCalendar.Size;
                dropDown.Show(this, new Point(0, this.Height)); // show bên dưới control
            }
            else
            {
                dropDown.Close();
            }
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = e.Start;
            textBox.Text = e.Start.ToString("dd/MM/yyyy");
            dropDown.Close();
            OnDateChanged(EventArgs.Empty);
        }

        public void Clear()
        {
            SelectedDate = null;
            textBox.Text = "";
        }

        // Sự kiện để form phía ngoài có thể lắng nghe khi ngày thay đổi
        public event EventHandler DateChanged;
        protected virtual void OnDateChanged(EventArgs e) => DateChanged?.Invoke(this, e);
    }
}
