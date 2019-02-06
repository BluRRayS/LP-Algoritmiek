namespace Oefening
{
    partial class ProductForm
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
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnAvg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBoxMinimumPrice = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnMinimumPrice = new System.Windows.Forms.Button();
            this.NUDMinimum = new System.Windows.Forms.NumericUpDown();
            this.ListBoxSortedProducts = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinimum)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMax
            // 
            this.BtnMax.Location = new System.Drawing.Point(6, 32);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(144, 23);
            this.BtnMax.TabIndex = 11;
            this.BtnMax.Text = "Geef Maximum";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click_1);
            // 
            // BtnAvg
            // 
            this.BtnAvg.Location = new System.Drawing.Point(6, 65);
            this.BtnAvg.Name = "BtnAvg";
            this.BtnAvg.Size = new System.Drawing.Size(143, 23);
            this.BtnAvg.TabIndex = 12;
            this.BtnAvg.Text = "Geef gemiddelde";
            this.BtnAvg.UseVisualStyleBackColor = true;
            this.BtnAvg.Click += new System.EventHandler(this.BtnAvg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxSortedProducts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.TxtBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 267);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voeg product toe";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(3, 65);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(144, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Voeg Toe";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(47, 13);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxName.TabIndex = 7;
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Location = new System.Drawing.Point(47, 39);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prijs:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMax);
            this.groupBox2.Controls.Add(this.BtnAvg);
            this.groupBox2.Location = new System.Drawing.Point(172, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bereken";
            // 
            // ListBoxMinimumPrice
            // 
            this.ListBoxMinimumPrice.FormattingEnabled = true;
            this.ListBoxMinimumPrice.Location = new System.Drawing.Point(6, 19);
            this.ListBoxMinimumPrice.Name = "ListBoxMinimumPrice";
            this.ListBoxMinimumPrice.Size = new System.Drawing.Size(119, 173);
            this.ListBoxMinimumPrice.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NUDMinimum);
            this.groupBox3.Controls.Add(this.BtnMinimumPrice);
            this.groupBox3.Controls.Add(this.ListBoxMinimumPrice);
            this.groupBox3.Location = new System.Drawing.Point(334, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 267);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtreer prijs";
            // 
            // BtnMinimumPrice
            // 
            this.BtnMinimumPrice.Location = new System.Drawing.Point(6, 199);
            this.BtnMinimumPrice.Name = "BtnMinimumPrice";
            this.BtnMinimumPrice.Size = new System.Drawing.Size(119, 32);
            this.BtnMinimumPrice.TabIndex = 16;
            this.BtnMinimumPrice.Text = "minimum prijs";
            this.BtnMinimumPrice.UseVisualStyleBackColor = true;
            this.BtnMinimumPrice.Click += new System.EventHandler(this.BtnMinimumPrice_Click);
            // 
            // NUDMinimum
            // 
            this.NUDMinimum.Location = new System.Drawing.Point(7, 238);
            this.NUDMinimum.Name = "NUDMinimum";
            this.NUDMinimum.Size = new System.Drawing.Size(118, 20);
            this.NUDMinimum.TabIndex = 17;
            // 
            // ListBoxSortedProducts
            // 
            this.ListBoxSortedProducts.FormattingEnabled = true;
            this.ListBoxSortedProducts.Location = new System.Drawing.Point(3, 101);
            this.ListBoxSortedProducts.Name = "ListBoxSortedProducts";
            this.ListBoxSortedProducts.Size = new System.Drawing.Size(144, 147);
            this.ListBoxSortedProducts.TabIndex = 17;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnAvg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListBoxMinimumPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NUDMinimum;
        private System.Windows.Forms.Button BtnMinimumPrice;
        private System.Windows.Forms.ListBox ListBoxSortedProducts;
    }
}

