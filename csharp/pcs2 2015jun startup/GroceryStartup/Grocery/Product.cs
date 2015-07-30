using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    public enum ProductType
    {Fruit, Vegetable,Unknown }
    class Product
    {
        private static int CreatedNo = 0;
        public string Name { get; private set; }
        private ProductType type;
        public ProductType Type
        {
            get { return  type; }
            private set
            {
                if ((value == ProductType.Fruit) || (value == ProductType.Vegetable) || (value == ProductType.Unknown))
                {
                    type = value;
                }
               
            }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                    quantity = 0;
            }
        }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                    price = 0;
            }
        }

        public int ProId { get; private set; }
        //*************Constructor////*****************???
        public Product(string name, ProductType tp)
        {
            Name = name;
            Type = tp;
            Quantity = 0;
            Price = 0.0M;
            ProId = ++CreatedNo;
        }
        public string AsString()
        {
            if (this.Type == ProductType.Fruit)
            {
                return " Id " + ProId + " Name :  " + Name + " Type : Frt  Quantity :  " + Quantity + "Price: " + Price;
            }
            if (this.Type == ProductType.Vegetable)
            {
                return " Id " + ProId + " Name :  " + Name + " Type : Veg  Quantity :  " + Quantity + "Price: " + Price;
            }
            else
            {
                return " Id " + ProId + " Name :  " + Name + " Type : Unk  Quantity :  " + Quantity + "Price: " + Price;
            }

        }
        public bool InStock()
        {
            if (this.Quantity > 0)
            {
                return true;
            }
            else
            { return false; }
        }
        public bool IsFruit()
        {
            if (this.Type == ProductType.Fruit)
            {
                return true;
            }
            else
            { return false; }
        }
        public bool IsVegetable()
        {
            if (this.Type == ProductType.Vegetable)
            {
                return true;
            }
            else
            { return false; }
        }
    }
}
