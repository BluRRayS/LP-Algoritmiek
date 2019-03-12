namespace Casus_Container_Vervoer
{
    partial class Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SortContainersBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxContainers = new System.Windows.Forms.ListBox();
            this.AddContainerBtn = new System.Windows.Forms.Button();
            this.ComboBoxFreightTypes = new System.Windows.Forms.ComboBox();
            this.NUDContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddShipBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.NUDWidth = new System.Windows.Forms.NumericUpDown();
            this.NUDLenght = new System.Windows.Forms.NumericUpDown();
            this.ListBoxShipContainers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDContainerWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxShipContainers);
            this.groupBox1.Controls.Add(this.SortContainersBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ship View";
            // 
            // SortContainersBtn
            // 
            this.SortContainersBtn.Location = new System.Drawing.Point(282, 519);
            this.SortContainersBtn.Name = "SortContainersBtn";
            this.SortContainersBtn.Size = new System.Drawing.Size(149, 23);
            this.SortContainersBtn.TabIndex = 0;
            this.SortContainersBtn.Text = "Sort Containers";
            this.SortContainersBtn.UseVisualStyleBackColor = true;
            this.SortContainersBtn.Click += new System.EventHandler(this.SortContainersBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listBoxContainers);
            this.groupBox3.Controls.Add(this.AddContainerBtn);
            this.groupBox3.Controls.Add(this.ComboBoxFreightTypes);
            this.groupBox3.Controls.Add(this.NUDContainerWeight);
            this.groupBox3.Location = new System.Drawing.Point(725, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 399);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Containers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight:";
            // 
            // listBoxContainers
            // 
            this.listBoxContainers.FormattingEnabled = true;
            this.listBoxContainers.Location = new System.Drawing.Point(10, 149);
            this.listBoxContainers.Name = "listBoxContainers";
            this.listBoxContainers.Size = new System.Drawing.Size(184, 238);
            this.listBoxContainers.TabIndex = 3;
            // 
            // AddContainerBtn
            // 
            this.AddContainerBtn.Location = new System.Drawing.Point(119, 90);
            this.AddContainerBtn.Name = "AddContainerBtn";
            this.AddContainerBtn.Size = new System.Drawing.Size(75, 23);
            this.AddContainerBtn.TabIndex = 2;
            this.AddContainerBtn.Text = "Add ";
            this.AddContainerBtn.UseVisualStyleBackColor = true;
            this.AddContainerBtn.Click += new System.EventHandler(this.AddContainerBtn_Click);
            // 
            // ComboBoxFreightTypes
            // 
            this.ComboBoxFreightTypes.FormattingEnabled = true;
            this.ComboBoxFreightTypes.Location = new System.Drawing.Point(73, 63);
            this.ComboBoxFreightTypes.Name = "ComboBoxFreightTypes";
            this.ComboBoxFreightTypes.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFreightTypes.TabIndex = 1;
            // 
            // NUDContainerWeight
            // 
            this.NUDContainerWeight.DecimalPlaces = 1;
            this.NUDContainerWeight.Location = new System.Drawing.Point(74, 37);
            this.NUDContainerWeight.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NUDContainerWeight.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.NUDContainerWeight.Name = "NUDContainerWeight";
            this.NUDContainerWeight.Size = new System.Drawing.Size(120, 20);
            this.NUDContainerWeight.TabIndex = 0;
            this.NUDContainerWeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddShipBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NUDMaxWeight);
            this.groupBox2.Controls.Add(this.NUDWidth);
            this.groupBox2.Controls.Add(this.NUDLenght);
            this.groupBox2.Location = new System.Drawing.Point(725, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Ships";
            // 
            // AddShipBtn
            // 
            this.AddShipBtn.Location = new System.Drawing.Point(119, 108);
            this.AddShipBtn.Name = "AddShipBtn";
            this.AddShipBtn.Size = new System.Drawing.Size(75, 23);
            this.AddShipBtn.TabIndex = 6;
            this.AddShipBtn.Text = "Add Ship";
            this.AddShipBtn.UseVisualStyleBackColor = true;
            this.AddShipBtn.Click += new System.EventHandler(this.AddShipButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Weight (Ton);";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Widht:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lenght:";
            // 
            // NUDMaxWeight
            // 
            this.NUDMaxWeight.Location = new System.Drawing.Point(108, 72);
            this.NUDMaxWeight.Name = "NUDMaxWeight";
            this.NUDMaxWeight.Size = new System.Drawing.Size(86, 20);
            this.NUDMaxWeight.TabIndex = 2;
            // 
            // NUDWidth
            // 
            this.NUDWidth.Location = new System.Drawing.Point(108, 45);
            this.NUDWidth.Name = "NUDWidth";
            this.NUDWidth.Size = new System.Drawing.Size(86, 20);
            this.NUDWidth.TabIndex = 1;
            // 
            // NUDLenght
            // 
            this.NUDLenght.Location = new System.Drawing.Point(108, 19);
            this.NUDLenght.Name = "NUDLenght";
            this.NUDLenght.Size = new System.Drawing.Size(86, 20);
            this.NUDLenght.TabIndex = 0;
            // 
            // ListBoxShipContainers
            // 
            this.ListBoxShipContainers.FormattingEnabled = true;
            this.ListBoxShipContainers.Location = new System.Drawing.Point(6, 18);
            this.ListBoxShipContainers.Name = "ListBoxShipContainers";
            this.ListBoxShipContainers.Size = new System.Drawing.Size(202, 446);
            this.ListBoxShipContainers.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 573);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "Container Planner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDContainerWeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddShipBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDMaxWeight;
        private System.Windows.Forms.NumericUpDown NUDWidth;
        private System.Windows.Forms.NumericUpDown NUDLenght;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxContainers;
        private System.Windows.Forms.Button AddContainerBtn;
        private System.Windows.Forms.ComboBox ComboBoxFreightTypes;
        private System.Windows.Forms.NumericUpDown NUDContainerWeight;
        private System.Windows.Forms.Button SortContainersBtn;
        private System.Windows.Forms.ListBox ListBoxShipContainers;
    }
}

