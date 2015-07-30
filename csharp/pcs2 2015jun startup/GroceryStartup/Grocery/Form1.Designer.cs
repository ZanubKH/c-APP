namespace Grocery
{
    partial class GroceryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAvailableProducts = new System.Windows.Forms.ListBox();
            this.gbManageProductDetails = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.rbVegetable = new System.Windows.Forms.RadioButton();
            this.rbFruit = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSellProduct = new System.Windows.Forms.GroupBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.cbxDiscount = new System.Windows.Forms.CheckBox();
            this.nudQuantityToSell = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVegFruit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSelectFruit = new System.Windows.Forms.RadioButton();
            this.rbSelectVegetable = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSalesInformation = new System.Windows.Forms.ListBox();
            this.gbAddNewProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbOutOfStockProducts = new System.Windows.Forms.ListBox();
            this.gbManageProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.gbSellProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToSell)).BeginInit();
            this.gbAddNewProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAvailableProducts
            // 
            this.lbAvailableProducts.FormattingEnabled = true;
            this.lbAvailableProducts.Location = new System.Drawing.Point(413, 52);
            this.lbAvailableProducts.Name = "lbAvailableProducts";
            this.lbAvailableProducts.Size = new System.Drawing.Size(311, 147);
            this.lbAvailableProducts.TabIndex = 0;
            // 
            // gbManageProductDetails
            // 
            this.gbManageProductDetails.Controls.Add(this.btnRemove);
            this.gbManageProductDetails.Controls.Add(this.btnChange);
            this.gbManageProductDetails.Controls.Add(this.tbPrice);
            this.gbManageProductDetails.Controls.Add(this.lbPrice);
            this.gbManageProductDetails.Controls.Add(this.nudQuantity);
            this.gbManageProductDetails.Controls.Add(this.label2);
            this.gbManageProductDetails.Controls.Add(this.label1);
            this.gbManageProductDetails.Controls.Add(this.cbProduct);
            this.gbManageProductDetails.Location = new System.Drawing.Point(46, 168);
            this.gbManageProductDetails.Name = "gbManageProductDetails";
            this.gbManageProductDetails.Size = new System.Drawing.Size(306, 200);
            this.gbManageProductDetails.TabIndex = 1;
            this.gbManageProductDetails.TabStop = false;
            this.gbManageProductDetails.Text = "Manage product details";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(34, 154);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(190, 154);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(118, 113);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 20);
            this.tbPrice.TabIndex = 8;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(31, 120);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Price";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(118, 77);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(117, 36);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbProduct.TabIndex = 0;
            // 
            // rbVegetable
            // 
            this.rbVegetable.AutoSize = true;
            this.rbVegetable.Location = new System.Drawing.Point(94, 62);
            this.rbVegetable.Name = "rbVegetable";
            this.rbVegetable.Size = new System.Drawing.Size(73, 17);
            this.rbVegetable.TabIndex = 4;
            this.rbVegetable.TabStop = true;
            this.rbVegetable.Text = "Vegetable";
            this.rbVegetable.UseVisualStyleBackColor = true;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(94, 80);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(45, 17);
            this.rbFruit.TabIndex = 5;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "Fruit";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sort";
            // 
            // gbSellProduct
            // 
            this.gbSellProduct.Controls.Add(this.btnSell);
            this.gbSellProduct.Controls.Add(this.cbxDiscount);
            this.gbSellProduct.Controls.Add(this.nudQuantityToSell);
            this.gbSellProduct.Controls.Add(this.label5);
            this.gbSellProduct.Controls.Add(this.cbVegFruit);
            this.gbSellProduct.Controls.Add(this.label4);
            this.gbSellProduct.Controls.Add(this.rbSelectFruit);
            this.gbSellProduct.Controls.Add(this.rbSelectVegetable);
            this.gbSellProduct.Location = new System.Drawing.Point(49, 374);
            this.gbSellProduct.Name = "gbSellProduct";
            this.gbSellProduct.Size = new System.Drawing.Size(303, 178);
            this.gbSellProduct.TabIndex = 2;
            this.gbSellProduct.TabStop = false;
            this.gbSellProduct.Text = "Sell product from store";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(187, 129);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.AutoSize = true;
            this.cbxDiscount.Location = new System.Drawing.Point(26, 129);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(94, 17);
            this.cbxDiscount.TabIndex = 6;
            this.cbxDiscount.Text = "Discount price";
            this.cbxDiscount.UseVisualStyleBackColor = true;
            // 
            // nudQuantityToSell
            // 
            this.nudQuantityToSell.Location = new System.Drawing.Point(114, 87);
            this.nudQuantityToSell.Name = "nudQuantityToSell";
            this.nudQuantityToSell.Size = new System.Drawing.Size(120, 20);
            this.nudQuantityToSell.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity to sell";
            // 
            // cbVegFruit
            // 
            this.cbVegFruit.FormattingEnabled = true;
            this.cbVegFruit.Location = new System.Drawing.Point(115, 48);
            this.cbVegFruit.Name = "cbVegFruit";
            this.cbVegFruit.Size = new System.Drawing.Size(121, 21);
            this.cbVegFruit.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product";
            // 
            // rbSelectFruit
            // 
            this.rbSelectFruit.AutoSize = true;
            this.rbSelectFruit.Location = new System.Drawing.Point(146, 19);
            this.rbSelectFruit.Name = "rbSelectFruit";
            this.rbSelectFruit.Size = new System.Drawing.Size(45, 17);
            this.rbSelectFruit.TabIndex = 1;
            this.rbSelectFruit.TabStop = true;
            this.rbSelectFruit.Text = "Fruit";
            this.rbSelectFruit.UseVisualStyleBackColor = true;
            this.rbSelectFruit.CheckedChanged += new System.EventHandler(this.rbSelectFruit_CheckedChanged);
            // 
            // rbSelectVegetable
            // 
            this.rbSelectVegetable.AutoSize = true;
            this.rbSelectVegetable.Location = new System.Drawing.Point(26, 19);
            this.rbSelectVegetable.Name = "rbSelectVegetable";
            this.rbSelectVegetable.Size = new System.Drawing.Size(73, 17);
            this.rbSelectVegetable.TabIndex = 0;
            this.rbSelectVegetable.TabStop = true;
            this.rbSelectVegetable.Text = "Vegetable";
            this.rbSelectVegetable.UseVisualStyleBackColor = true;
            this.rbSelectVegetable.CheckedChanged += new System.EventHandler(this.rbSelectVegetable_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available products";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sales information";
            // 
            // lbSalesInformation
            // 
            this.lbSalesInformation.FormattingEnabled = true;
            this.lbSalesInformation.Location = new System.Drawing.Point(413, 392);
            this.lbSalesInformation.Name = "lbSalesInformation";
            this.lbSalesInformation.Size = new System.Drawing.Size(311, 160);
            this.lbSalesInformation.TabIndex = 5;
            // 
            // gbAddNewProduct
            // 
            this.gbAddNewProduct.Controls.Add(this.btnAdd);
            this.gbAddNewProduct.Controls.Add(this.label3);
            this.gbAddNewProduct.Controls.Add(this.tbName);
            this.gbAddNewProduct.Controls.Add(this.rbFruit);
            this.gbAddNewProduct.Controls.Add(this.label8);
            this.gbAddNewProduct.Controls.Add(this.rbVegetable);
            this.gbAddNewProduct.Location = new System.Drawing.Point(46, 12);
            this.gbAddNewProduct.Name = "gbAddNewProduct";
            this.gbAddNewProduct.Size = new System.Drawing.Size(306, 139);
            this.gbAddNewProduct.TabIndex = 6;
            this.gbAddNewProduct.TabStop = false;
            this.gbAddNewProduct.Text = "Add new product to the store";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Out of stock products";
            // 
            // lbOutOfStockProducts
            // 
            this.lbOutOfStockProducts.FormattingEnabled = true;
            this.lbOutOfStockProducts.Location = new System.Drawing.Point(413, 239);
            this.lbOutOfStockProducts.Name = "lbOutOfStockProducts";
            this.lbOutOfStockProducts.Size = new System.Drawing.Size(311, 121);
            this.lbOutOfStockProducts.TabIndex = 8;
            // 
            // GroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 583);
            this.Controls.Add(this.lbOutOfStockProducts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbAddNewProduct);
            this.Controls.Add(this.lbSalesInformation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbSellProduct);
            this.Controls.Add(this.gbManageProductDetails);
            this.Controls.Add(this.lbAvailableProducts);
            this.Name = "GroceryForm";
            this.Text = "Grocery store";
            this.gbManageProductDetails.ResumeLayout(false);
            this.gbManageProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.gbSellProduct.ResumeLayout(false);
            this.gbSellProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToSell)).EndInit();
            this.gbAddNewProduct.ResumeLayout(false);
            this.gbAddNewProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailableProducts;
        private System.Windows.Forms.GroupBox gbManageProductDetails;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.RadioButton rbFruit;
        private System.Windows.Forms.RadioButton rbVegetable;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.GroupBox gbSellProduct;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.CheckBox cbxDiscount;
        private System.Windows.Forms.NumericUpDown nudQuantityToSell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVegFruit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSelectFruit;
        private System.Windows.Forms.RadioButton rbSelectVegetable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSalesInformation;
        private System.Windows.Forms.GroupBox gbAddNewProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbOutOfStockProducts;
        private System.Windows.Forms.Button btnRemove;
    }
}

