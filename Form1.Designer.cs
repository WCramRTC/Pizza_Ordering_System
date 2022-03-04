namespace Pizza_Ordering_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbReciept = new System.Windows.Forms.RichTextBox();
            this.btnCompleteTransaction = new System.Windows.Forms.Button();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbExtraLarge = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMushroom = new System.Windows.Forms.CheckBox();
            this.cbFreshBasil = new System.Windows.Forms.CheckBox();
            this.cbTomato = new System.Windows.Forms.CheckBox();
            this.cbGarlic = new System.Windows.Forms.CheckBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbBlackOlives = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbReciept
            // 
            this.rtbReciept.Location = new System.Drawing.Point(427, 25);
            this.rtbReciept.Name = "rtbReciept";
            this.rtbReciept.Size = new System.Drawing.Size(540, 957);
            this.rtbReciept.TabIndex = 0;
            this.rtbReciept.Text = "";
            // 
            // btnCompleteTransaction
            // 
            this.btnCompleteTransaction.Location = new System.Drawing.Point(509, 1001);
            this.btnCompleteTransaction.Name = "btnCompleteTransaction";
            this.btnCompleteTransaction.Size = new System.Drawing.Size(345, 78);
            this.btnCompleteTransaction.TabIndex = 1;
            this.btnCompleteTransaction.Text = "Complete Transaction";
            this.btnCompleteTransaction.UseVisualStyleBackColor = true;
            this.btnCompleteTransaction.Click += new System.EventHandler(this.btnCompleteTransaction_Click);
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Location = new System.Drawing.Point(54, 41);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(208, 30);
            this.lblCustomerNumber.TabIndex = 2;
            this.lblCustomerNumber.Text = "Customer #: 0000001";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbSize);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 293);
            this.panel1.TabIndex = 3;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.label4);
            this.gbSize.Controls.Add(this.label3);
            this.gbSize.Controls.Add(this.label2);
            this.gbSize.Controls.Add(this.label1);
            this.gbSize.Controls.Add(this.rbExtraLarge);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(15, 17);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(350, 258);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "$20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "$17";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "$13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "$10";
            // 
            // rbExtraLarge
            // 
            this.rbExtraLarge.AutoSize = true;
            this.rbExtraLarge.Location = new System.Drawing.Point(27, 200);
            this.rbExtraLarge.Name = "rbExtraLarge";
            this.rbExtraLarge.Size = new System.Drawing.Size(141, 34);
            this.rbExtraLarge.TabIndex = 7;
            this.rbExtraLarge.TabStop = true;
            this.rbExtraLarge.Text = "Extra Large";
            this.rbExtraLarge.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(27, 150);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(89, 34);
            this.rbLarge.TabIndex = 6;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(27, 100);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(115, 34);
            this.rbMedium.TabIndex = 5;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(27, 50);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(88, 34);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbMushroom);
            this.panel2.Controls.Add(this.cbFreshBasil);
            this.panel2.Controls.Add(this.cbTomato);
            this.panel2.Controls.Add(this.cbGarlic);
            this.panel2.Controls.Add(this.cbGreenPeppers);
            this.panel2.Controls.Add(this.cbBlackOlives);
            this.panel2.Controls.Add(this.cbOnion);
            this.panel2.Controls.Add(this.cbSausage);
            this.panel2.Controls.Add(this.cbExtraCheese);
            this.panel2.Controls.Add(this.cbPepperoni);
            this.panel2.Location = new System.Drawing.Point(12, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 567);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Extra Toppings";
            // 
            // cbMushroom
            // 
            this.cbMushroom.AutoSize = true;
            this.cbMushroom.Location = new System.Drawing.Point(42, 119);
            this.cbMushroom.Name = "cbMushroom";
            this.cbMushroom.Size = new System.Drawing.Size(215, 34);
            this.cbMushroom.TabIndex = 9;
            this.cbMushroom.Text = "Mushroom - $ 1.50";
            this.cbMushroom.UseVisualStyleBackColor = true;
            // 
            // cbFreshBasil
            // 
            this.cbFreshBasil.AutoSize = true;
            this.cbFreshBasil.Location = new System.Drawing.Point(42, 519);
            this.cbFreshBasil.Name = "cbFreshBasil";
            this.cbFreshBasil.Size = new System.Drawing.Size(178, 34);
            this.cbFreshBasil.TabIndex = 8;
            this.cbFreshBasil.Text = "Fresh Basil - $3";
            this.cbFreshBasil.UseVisualStyleBackColor = true;
            // 
            // cbTomato
            // 
            this.cbTomato.AutoSize = true;
            this.cbTomato.Location = new System.Drawing.Point(42, 469);
            this.cbTomato.Name = "cbTomato";
            this.cbTomato.Size = new System.Drawing.Size(150, 34);
            this.cbTomato.TabIndex = 7;
            this.cbTomato.Text = "Tomato - $1";
            this.cbTomato.UseVisualStyleBackColor = true;
            // 
            // cbGarlic
            // 
            this.cbGarlic.AutoSize = true;
            this.cbGarlic.Location = new System.Drawing.Point(42, 419);
            this.cbGarlic.Name = "cbGarlic";
            this.cbGarlic.Size = new System.Drawing.Size(188, 34);
            this.cbGarlic.TabIndex = 6;
            this.cbGarlic.Text = "Fresh Garlic - $2";
            this.cbGarlic.UseVisualStyleBackColor = true;
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Location = new System.Drawing.Point(42, 369);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(215, 34);
            this.cbGreenPeppers.TabIndex = 5;
            this.cbGreenPeppers.Text = "Green Peppers - $1";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // cbBlackOlives
            // 
            this.cbBlackOlives.AutoSize = true;
            this.cbBlackOlives.Location = new System.Drawing.Point(42, 319);
            this.cbBlackOlives.Name = "cbBlackOlives";
            this.cbBlackOlives.Size = new System.Drawing.Size(218, 34);
            this.cbBlackOlives.TabIndex = 4;
            this.cbBlackOlives.Text = "Black Olives - $1.50";
            this.cbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(42, 269);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(165, 34);
            this.cbOnion.TabIndex = 3;
            this.cbOnion.Text = "Onion - $1.50";
            this.cbOnion.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(42, 219);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(158, 34);
            this.cbSausage.TabIndex = 2;
            this.cbSausage.Text = "Sausage - $2";
            this.cbSausage.UseVisualStyleBackColor = true;
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(42, 169);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(200, 34);
            this.cbExtraCheese.TabIndex = 1;
            this.cbExtraCheese.Text = "Extra Cheese - $1";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(42, 69);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(174, 34);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Pepperoni - $2";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbSize);
            this.panel3.Controls.Add(this.cmbDrink);
            this.panel3.Location = new System.Drawing.Point(1001, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 269);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Drink";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(37, 163);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(322, 38);
            this.cmbSize.TabIndex = 1;
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(37, 72);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(322, 38);
            this.cmbDrink.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.txtZip);
            this.panel4.Controls.Add(this.txtCityState);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(1001, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 639);
            this.panel4.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 30);
            this.label13.TabIndex = 10;
            this.label13.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 30);
            this.label12.TabIndex = 9;
            this.label12.Text = "Zip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 30);
            this.label11.TabIndex = 8;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "City and State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(101, 567);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 35);
            this.txtPhone.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(101, 458);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(258, 35);
            this.txtZip.TabIndex = 4;
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(101, 354);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(258, 35);
            this.txtCityState.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 250);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 35);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 35);
            this.txtName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 1136);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCustomerNumber);
            this.Controls.Add(this.btnCompleteTransaction);
            this.Controls.Add(this.rtbReciept);
            this.Name = "Form1";
            this.Text = "House of Pi(e) - Point of Sale";
            this.panel1.ResumeLayout(false);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReciept;
        private System.Windows.Forms.Button btnCompleteTransaction;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbExtraLarge;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMushroom;
        private System.Windows.Forms.CheckBox cbFreshBasil;
        private System.Windows.Forms.CheckBox cbTomato;
        private System.Windows.Forms.CheckBox cbGarlic;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbBlackOlives;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
    }
}
