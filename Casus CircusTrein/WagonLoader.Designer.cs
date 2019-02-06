namespace Casus_CircusTrein
{
    partial class WagonLoader
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
            this.ListBoxAnimals = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBoxSize = new System.Windows.Forms.ComboBox();
            this.ComboBoxDiet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddAnimal = new System.Windows.Forms.Button();
            this.BtnClearList = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxAnimals
            // 
            this.ListBoxAnimals.FormattingEnabled = true;
            this.ListBoxAnimals.Location = new System.Drawing.Point(6, 19);
            this.ListBoxAnimals.Name = "ListBoxAnimals";
            this.ListBoxAnimals.Size = new System.Drawing.Size(120, 186);
            this.ListBoxAnimals.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxAnimals);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animals not loaded";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClearList);
            this.groupBox2.Controls.Add(this.BtnAddAnimal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtBoxName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ComboBoxDiet);
            this.groupBox2.Controls.Add(this.ComboBoxSize);
            this.groupBox2.Location = new System.Drawing.Point(152, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a animal";
            // 
            // ComboBoxSize
            // 
            this.ComboBoxSize.AutoCompleteCustomSource.AddRange(new string[] {
            "Small",
            "Medium",
            "Large"});
            this.ComboBoxSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboBoxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.ComboBoxSize.Location = new System.Drawing.Point(42, 34);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSize.TabIndex = 0;
            // 
            // ComboBoxDiet
            // 
            this.ComboBoxDiet.AutoCompleteCustomSource.AddRange(new string[] {
            "Herbivore",
            "Carnivore"});
            this.ComboBoxDiet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboBoxDiet.Items.AddRange(new object[] {
            "Herbivore",
            "Carnivore"});
            this.ComboBoxDiet.Location = new System.Drawing.Point(42, 61);
            this.ComboBoxDiet.Name = "ComboBoxDiet";
            this.ComboBoxDiet.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDiet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diet:";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(51, 88);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(112, 20);
            this.TxtBoxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // BtnAddAnimal
            // 
            this.BtnAddAnimal.Location = new System.Drawing.Point(10, 153);
            this.BtnAddAnimal.Name = "BtnAddAnimal";
            this.BtnAddAnimal.Size = new System.Drawing.Size(157, 23);
            this.BtnAddAnimal.TabIndex = 6;
            this.BtnAddAnimal.Text = "Add Animal";
            this.BtnAddAnimal.UseVisualStyleBackColor = true;
            this.BtnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // BtnClearList
            // 
            this.BtnClearList.Location = new System.Drawing.Point(10, 182);
            this.BtnClearList.Name = "BtnClearList";
            this.BtnClearList.Size = new System.Drawing.Size(157, 23);
            this.BtnClearList.TabIndex = 7;
            this.BtnClearList.Text = "Clear List";
            this.BtnClearList.UseVisualStyleBackColor = true;
            this.BtnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(12, 230);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(315, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate Wagon Count";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // WagonLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 257);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "WagonLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WagonLoader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxAnimals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboBoxDiet;
        private System.Windows.Forms.ComboBox ComboBoxSize;
        private System.Windows.Forms.Button BtnClearList;
        private System.Windows.Forms.Button BtnAddAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

