using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery
{
    public partial class GroceryForm : Form
    {
        private ProductStore productStore = new ProductStore("Zanub Khan"); // an airlines object
        public GroceryForm()
        {
            InitializeComponent();
            UpdateGroceryStoreText();
        }
        private void UpdateGroceryStoreText()
        {
           
            this.Text = " Store of " + productStore.Owner + " have products " + productStore.GetNoOfProduct();
        }
        private void UpdateListBoxes()
        {
            List<Product> products = productStore.GetAllProduct();
            lbAvailableProducts.Items.Clear();
            lbOutOfStockProducts.Items.Clear();
            foreach (Product p in products)
            {
                if (p.Quantity == 0)
                {
                    lbOutOfStockProducts.Items.Add(p.AsString());

                }
                else
                {
                    lbAvailableProducts.Items.Add(p.AsString());

                }
            }
        }
        private bool InAssortiment(string name)
        {
            foreach (Product p in productStore.GetAllProduct())
            {
                if (p.Name == name)
                {
                    return true;

                }
            }
            return false;
        }
        private bool AddProduct(string productNAME, ProductType TYPE)
        {
            List<Product> products = productStore.GetAllProduct();
            if (InAssortiment(productNAME) == false)
            {
                Product newcreated = new Product(productNAME, TYPE);
                products.Add(newcreated);
                return true;
            }
            else
            { return false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = null;
            if (tbName.Text == null)
            {
                MessageBox.Show("Please enter name");
            }
            else
            {
                if (rbFruit.Checked)
                {
                    p = new Product(tbName.Text, ProductType.Fruit);
                   
                }
                if (rbVegetable.Checked)
                {
                     p = new Product(tbName.Text, ProductType.Vegetable);
                }

                else
                {
                    if (!rbFruit.Checked && !rbVegetable.Checked)
                    {
                         p = new Product(tbName.Text, ProductType.Unknown);
                    }
                }
                   
                if (AddProduct(p.Name,p.Type) == true)
                    {
                        MessageBox.Show("Added successfuly");
                    }
                    else
                    { MessageBox.Show("Already EXISTS"); }
             
            }
            cbProduct.Items.Add("" + tbName.Text);
            UpdateListBoxes();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbProduct.Text != null)
            {
            string name = cbProduct.Text;
            productStore.ChangeProductDetail(name, Convert.ToInt32(nudQuantity.Value), Convert.ToDouble(tbPrice.Text));
            UpdateListBoxes();
            }
            else { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem != null)
            {
                string s = cbProduct.SelectedItem.ToString();
                productStore.RemoveProduct(s);
                cbProduct.Items.Remove(s);

                UpdateListBoxes();
            }
            else { }
        }

        private void rbSelectVegetable_CheckedChanged(object sender, EventArgs e)
        {
            cbVegFruit.Items.Clear();
            string[] Vege = new string[productStore.NoOfVegetablesInStock()];
            Vege = productStore.GetVegetableStock();
            foreach (string s in Vege)
            {
                cbVegFruit.Items.Add(s);
            }
        }

        private void rbSelectFruit_CheckedChanged(object sender, EventArgs e)
        {
            cbVegFruit.Items.Clear();
            string[] Fruit = new string[productStore.NoOfFruitsInStock()];
            Fruit = productStore.GetFruitStock();
            foreach (string s in Fruit)
            {
                cbVegFruit.Items.Add(s);
            }
        }
    }
}
