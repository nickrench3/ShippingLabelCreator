namespace ShippingLabel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.enterButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clrbutton2 = new System.Windows.Forms.Button();
            this.StateComboBox2 = new System.Windows.Forms.ComboBox();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.StreetTextBox2 = new System.Windows.Forms.TextBox();
            this.CityTextBox2 = new System.Windows.Forms.TextBox();
            this.ZIPTextBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clrbutton1 = new System.Windows.Forms.Button();
            this.StateComboBox1 = new System.Windows.Forms.ComboBox();
            this.ZIPTextBox1 = new System.Windows.Forms.TextBox();
            this.CityTextBox1 = new System.Windows.Forms.TextBox();
            this.StreetTextBox1 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printButton = new System.Windows.Forms.Button();
            this.LabelTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.enterButton);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Addresses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(275, 328);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(303, 43);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clrbutton2);
            this.groupBox2.Controls.Add(this.StateComboBox2);
            this.groupBox2.Controls.Add(this.NameTextBox2);
            this.groupBox2.Controls.Add(this.StreetTextBox2);
            this.groupBox2.Controls.Add(this.CityTextBox2);
            this.groupBox2.Controls.Add(this.ZIPTextBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(463, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TO";
            // 
            // clrbutton2
            // 
            this.clrbutton2.Location = new System.Drawing.Point(195, 228);
            this.clrbutton2.Name = "clrbutton2";
            this.clrbutton2.Size = new System.Drawing.Size(75, 32);
            this.clrbutton2.TabIndex = 13;
            this.clrbutton2.Text = "CLEAR";
            this.clrbutton2.UseVisualStyleBackColor = true;
            this.clrbutton2.Click += new System.EventHandler(this.clrbutton2_Click);
            // 
            // StateComboBox2
            // 
            this.StateComboBox2.FormattingEnabled = true;
            this.StateComboBox2.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateComboBox2.Location = new System.Drawing.Point(137, 149);
            this.StateComboBox2.MaxLength = 2;
            this.StateComboBox2.Name = "StateComboBox2";
            this.StateComboBox2.Size = new System.Drawing.Size(186, 24);
            this.StateComboBox2.TabIndex = 9;
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(137, 30);
            this.NameTextBox2.MaxLength = 40;
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(186, 23);
            this.NameTextBox2.TabIndex = 6;
            // 
            // StreetTextBox2
            // 
            this.StreetTextBox2.Location = new System.Drawing.Point(137, 70);
            this.StreetTextBox2.MaxLength = 50;
            this.StreetTextBox2.Name = "StreetTextBox2";
            this.StreetTextBox2.Size = new System.Drawing.Size(186, 23);
            this.StreetTextBox2.TabIndex = 7;
            // 
            // CityTextBox2
            // 
            this.CityTextBox2.Location = new System.Drawing.Point(137, 110);
            this.CityTextBox2.MaxLength = 50;
            this.CityTextBox2.Name = "CityTextBox2";
            this.CityTextBox2.Size = new System.Drawing.Size(186, 23);
            this.CityTextBox2.TabIndex = 8;
            // 
            // ZIPTextBox2
            // 
            this.ZIPTextBox2.Location = new System.Drawing.Point(137, 190);
            this.ZIPTextBox2.MaxLength = 5;
            this.ZIPTextBox2.Name = "ZIPTextBox2";
            this.ZIPTextBox2.Size = new System.Drawing.Size(186, 23);
            this.ZIPTextBox2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "ZIP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clrbutton1);
            this.groupBox1.Controls.Add(this.StateComboBox1);
            this.groupBox1.Controls.Add(this.ZIPTextBox1);
            this.groupBox1.Controls.Add(this.CityTextBox1);
            this.groupBox1.Controls.Add(this.StreetTextBox1);
            this.groupBox1.Controls.Add(this.NameTextBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FROM";
            // 
            // clrbutton1
            // 
            this.clrbutton1.Location = new System.Drawing.Point(187, 228);
            this.clrbutton1.Name = "clrbutton1";
            this.clrbutton1.Size = new System.Drawing.Size(75, 32);
            this.clrbutton1.TabIndex = 12;
            this.clrbutton1.Text = "CLEAR";
            this.clrbutton1.UseVisualStyleBackColor = true;
            this.clrbutton1.Click += new System.EventHandler(this.clrbutton1_Click);
            // 
            // StateComboBox1
            // 
            this.StateComboBox1.FormattingEnabled = true;
            this.StateComboBox1.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateComboBox1.Location = new System.Drawing.Point(134, 156);
            this.StateComboBox1.MaxLength = 2;
            this.StateComboBox1.Name = "StateComboBox1";
            this.StateComboBox1.Size = new System.Drawing.Size(186, 24);
            this.StateComboBox1.TabIndex = 4;
            // 
            // ZIPTextBox1
            // 
            this.ZIPTextBox1.Location = new System.Drawing.Point(134, 193);
            this.ZIPTextBox1.MaxLength = 5;
            this.ZIPTextBox1.Name = "ZIPTextBox1";
            this.ZIPTextBox1.Size = new System.Drawing.Size(186, 23);
            this.ZIPTextBox1.TabIndex = 5;
            // 
            // CityTextBox1
            // 
            this.CityTextBox1.Location = new System.Drawing.Point(134, 116);
            this.CityTextBox1.MaxLength = 50;
            this.CityTextBox1.Name = "CityTextBox1";
            this.CityTextBox1.Size = new System.Drawing.Size(186, 23);
            this.CityTextBox1.TabIndex = 3;
            // 
            // StreetTextBox1
            // 
            this.StreetTextBox1.Location = new System.Drawing.Point(134, 76);
            this.StreetTextBox1.MaxLength = 50;
            this.StreetTextBox1.Name = "StreetTextBox1";
            this.StreetTextBox1.Size = new System.Drawing.Size(186, 23);
            this.StreetTextBox1.TabIndex = 2;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(134, 36);
            this.NameTextBox1.MaxLength = 40;
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(186, 23);
            this.NameTextBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ZIP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.printButton);
            this.tabPage2.Controls.Add(this.LabelTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Print Label";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(273, 292);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(180, 43);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Location = new System.Drawing.Point(83, 71);
            this.LabelTextBox.Multiline = true;
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.Size = new System.Drawing.Size(577, 182);
            this.LabelTextBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(518, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Confirm addresses are correct, if incorrect go to previous page and correct them." +
    "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Shipping Label Creator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.TextBox StreetTextBox2;
        private System.Windows.Forms.TextBox CityTextBox2;
        private System.Windows.Forms.TextBox ZIPTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ZIPTextBox1;
        private System.Windows.Forms.TextBox CityTextBox1;
        private System.Windows.Forms.TextBox StreetTextBox1;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.ComboBox StateComboBox2;
        private System.Windows.Forms.ComboBox StateComboBox1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button clrbutton2;
        private System.Windows.Forms.Button clrbutton1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.Label label11;
        private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog1;
	}
}

