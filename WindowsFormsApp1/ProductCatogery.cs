using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ProductCategory
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ProductCategory(string CategoryName, string Description)
        {
            this.CategoryName = CategoryName;
            this.Description = Description;
        }
    }
}
