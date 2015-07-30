namespace ExportToHtml
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMultiLineItem = new System.Windows.Forms.RadioButton();
            this.rbSingleLineItem = new System.Windows.Forms.RadioButton();
            this.tbDateOfPost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPostedBy = new System.Windows.Forms.TextBox();
            this.tbLineOfText = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddALineToAMultilineItem = new System.Windows.Forms.Button();
            this.btnAddAnItem = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowAllSinglelineItems = new System.Windows.Forms.Button();
            this.btnExportToHtml = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(487, 372);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.rbMultiLineItem);
            this.panel1.Controls.Add(this.rbSingleLineItem);
            this.panel1.Controls.Add(this.tbDateOfPost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbPostedBy);
            this.panel1.Controls.Add(this.tbLineOfText);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddALineToAMultilineItem);
            this.panel1.Controls.Add(this.btnAddAnItem);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(533, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 368);
            this.panel1.TabIndex = 1;
            // 
            // rbMultiLineItem
            // 
            this.rbMultiLineItem.AutoSize = true;
            this.rbMultiLineItem.Location = new System.Drawing.Point(55, 242);
            this.rbMultiLineItem.Name = "rbMultiLineItem";
            this.rbMultiLineItem.Size = new System.Drawing.Size(185, 20);
            this.rbMultiLineItem.TabIndex = 13;
            this.rbMultiLineItem.TabStop = true;
            this.rbMultiLineItem.Text = "want to add a multiline-item";
            this.rbMultiLineItem.UseVisualStyleBackColor = true;
            // 
            // rbSingleLineItem
            // 
            this.rbSingleLineItem.AutoSize = true;
            this.rbSingleLineItem.Checked = true;
            this.rbSingleLineItem.Location = new System.Drawing.Point(55, 206);
            this.rbSingleLineItem.Name = "rbSingleLineItem";
            this.rbSingleLineItem.Size = new System.Drawing.Size(194, 20);
            this.rbSingleLineItem.TabIndex = 12;
            this.rbSingleLineItem.TabStop = true;
            this.rbSingleLineItem.Text = "want to add a singleline-item";
            this.rbSingleLineItem.UseVisualStyleBackColor = true;
            // 
            // tbDateOfPost
            // 
            this.tbDateOfPost.Location = new System.Drawing.Point(88, 156);
            this.tbDateOfPost.Name = "tbDateOfPost";
            this.tbDateOfPost.Size = new System.Drawing.Size(109, 22);
            this.tbDateOfPost.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "date of post";
            // 
            // tbPostedBy
            // 
            this.tbPostedBy.Location = new System.Drawing.Point(88, 119);
            this.tbPostedBy.Name = "tbPostedBy";
            this.tbPostedBy.Size = new System.Drawing.Size(109, 22);
            this.tbPostedBy.TabIndex = 9;
            // 
            // tbLineOfText
            // 
            this.tbLineOfText.Location = new System.Drawing.Point(88, 82);
            this.tbLineOfText.Name = "tbLineOfText";
            this.tbLineOfText.Size = new System.Drawing.Size(272, 22);
            this.tbLineOfText.TabIndex = 8;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(88, 45);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(272, 22);
            this.tbTitle.TabIndex = 7;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(88, 8);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 22);
            this.tbId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "posted by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "line of text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // btnAddALineToAMultilineItem
            // 
            this.btnAddALineToAMultilineItem.Location = new System.Drawing.Point(68, 321);
            this.btnAddALineToAMultilineItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddALineToAMultilineItem.Name = "btnAddALineToAMultilineItem";
            this.btnAddALineToAMultilineItem.Size = new System.Drawing.Size(292, 36);
            this.btnAddALineToAMultilineItem.TabIndex = 1;
            this.btnAddALineToAMultilineItem.Text = "Add a line to a Multiline-item";
            this.btnAddALineToAMultilineItem.UseVisualStyleBackColor = true;
            this.btnAddALineToAMultilineItem.Click += new System.EventHandler(this.btnAddALineToAMultilineItem_Click);
            // 
            // btnAddAnItem
            // 
            this.btnAddAnItem.Location = new System.Drawing.Point(68, 277);
            this.btnAddAnItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnItem.Name = "btnAddAnItem";
            this.btnAddAnItem.Size = new System.Drawing.Size(292, 36);
            this.btnAddAnItem.TabIndex = 0;
            this.btnAddAnItem.Text = "Add an item";
            this.btnAddAnItem.UseVisualStyleBackColor = true;
            this.btnAddAnItem.Click += new System.EventHandler(this.btnAddAnItem_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(26, 401);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(199, 44);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowAllSinglelineItems
            // 
            this.btnShowAllSinglelineItems.Location = new System.Drawing.Point(246, 404);
            this.btnShowAllSinglelineItems.Name = "btnShowAllSinglelineItems";
            this.btnShowAllSinglelineItems.Size = new System.Drawing.Size(208, 40);
            this.btnShowAllSinglelineItems.TabIndex = 3;
            this.btnShowAllSinglelineItems.Text = "Show all Singleline-items";
            this.btnShowAllSinglelineItems.UseVisualStyleBackColor = true;
            this.btnShowAllSinglelineItems.Click += new System.EventHandler(this.btnShowAllSinglelineItems_Click);
            // 
            // btnExportToHtml
            // 
            this.btnExportToHtml.Location = new System.Drawing.Point(601, 403);
            this.btnExportToHtml.Name = "btnExportToHtml";
            this.btnExportToHtml.Size = new System.Drawing.Size(164, 40);
            this.btnExportToHtml.TabIndex = 4;
            this.btnExportToHtml.Text = "Export to Html";
            this.btnExportToHtml.UseVisualStyleBackColor = true;
            this.btnExportToHtml.Click += new System.EventHandler(this.btnExportToHtml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 458);
            this.Controls.Add(this.btnExportToHtml);
            this.Controls.Add(this.btnShowAllSinglelineItems);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Controlling my news-items, made by <<Zanub Khan>>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddALineToAMultilineItem;
        private System.Windows.Forms.Button btnAddAnItem;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowAllSinglelineItems;
        private System.Windows.Forms.Button btnExportToHtml;
        private System.Windows.Forms.TextBox tbDateOfPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPostedBy;
        private System.Windows.Forms.TextBox tbLineOfText;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMultiLineItem;
        private System.Windows.Forms.RadioButton rbSingleLineItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

