using System;

namespace WindowsFormsApp1
{
    class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public float PurchaseCost { get; set; }
        public float ItemCost { get; set; }
        public string Note { get; set; }

        public ProductModel(int ProductID, string ProductName, int CategoryId, int Quantity, float PurchaseCost, float ItemCost, string Note)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.CategoryId = CategoryId;
            this.Quantity = Quantity;
            this.PurchaseCost = PurchaseCost;
            this.ItemCost = ItemCost;
            this.Note = Note;
        }

        public int getProductID()
        {
            return this.ProductID;
        }

        public void setProductID(int ProductID)
        {
            this.ProductID = ProductID;
        }

        public string getProductName()
        {
            return this.ProductName;
        }

        public void setProductName(string ProductName)
        {
            this.ProductName = ProductName;
        }

        public int getCategoryId()
        {
            return this.CategoryId;
        }

        public void setCategoryId(int CategoryId)
        {
            this.CategoryId = CategoryId;
        }

        public int getQuantity()
        {
            return this.Quantity;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }

        public float getPurchaseCost()
        {
            return this.PurchaseCost;
        }

        public void setPurchaseCost(float PurchaseCost)
        {
            this.PurchaseCost = PurchaseCost;
        }

        public float getItemCost()
        {
            return this.ItemCost;
        }

        public void setItemCost(float ItemCost)
        {
            this.ItemCost = ItemCost;
        }

        public string getNote()
        {
            return this.Note;
        }

        public void setNote(string Note)
        {
            this.Note = Note;
        }
    }
}