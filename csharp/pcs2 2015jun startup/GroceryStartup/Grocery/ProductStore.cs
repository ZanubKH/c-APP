using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    class ProductStore
    {
        public string Owner { get; set; }
        private List<Product> productAssortiment;
        public ProductStore(string ow)
        
       {
           Owner = ow;
           productAssortiment = new List<Product>();
        }
        public List<Product> GetAllProduct()
        {
            return productAssortiment;
        }
        public int GetNoOfProduct()
        {
            return productAssortiment.Count;
        }
        public Product FindInList(string name)
        {
            foreach (Product p in productAssortiment)
            {
                if (p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }
        public void ChangeProductDetail(string productname, int quantity, double price)
        {
            Product p = FindInList(productname);
            
            if (p != null)
            {
                p.Quantity = quantity;
                p.Price = Convert.ToDecimal(price);
            }
        }
        public void RemoveProduct(string name)
        {
            Product p = FindInList(name);

            if (p != null)
            {
                productAssortiment.Remove(p);
            }
            else
            { }
        }
        public int NoOfFruitsInStock()
        {
            int fruit = 0;
            foreach (Product p in productAssortiment)
            {
                if (p.IsFruit() == true && p.InStock() == true)
                {
                    fruit = fruit + 1;
                }
            }
            return fruit;
        }
        public int NoOfVegetablesInStock()
        {
            int vege = 0;
            foreach (Product p in productAssortiment)
            {
                if (p.IsVegetable() == true && p.InStock()==true)
                {
                    vege = vege + 1;
                }
            }
            return vege;
        }
         
        public string[] GetFruitStock()
        {
           string[] FruitArray = new string[NoOfFruitsInStock()];
            int index=0;
            foreach (Product p in productAssortiment)
            {
                if (p.IsFruit() == true  && p.InStock() == true)
                {
                    FruitArray[index] = p.Name;
                    index++;
                    
                }
            }
            return FruitArray;
        }
        public string[] GetVegetableStock()
        {
            string[] VegeArray = new string[NoOfVegetablesInStock()];
            int index = 0;
            foreach (Product p in productAssortiment)
            {
                if (p.IsVegetable() == true && p.InStock() == true)
                {
                   VegeArray[index] = p.Name;
                    index++;

                }
            }
            return VegeArray;
        }
    }
}
