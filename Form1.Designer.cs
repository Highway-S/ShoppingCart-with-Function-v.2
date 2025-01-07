namespace WinFormsApp1
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
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            tbCoffeePrice = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tbTotal = new TextBox();
            label2 = new Label();
            tbCash = new TextBox();
            label3 = new Label();
            tbChange = new TextBox();
            label4 = new Label();
            tb1000 = new TextBox();
            label5 = new Label();
            tb500 = new TextBox();
            label6 = new Label();
            tb100 = new TextBox();
            label7 = new Label();
            tb50 = new TextBox();
            label8 = new Label();
            tb20 = new TextBox();
            label9 = new Label();
            tb10 = new TextBox();
            label10 = new Label();
            tb5 = new TextBox();
            label11 = new Label();
            tb2 = new TextBox();
            label12 = new Label();
            tb1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chbNoodle = new CheckBox();
            chbPizza = new CheckBox();
            tbPizzaQuantity = new TextBox();
            tbNoodlePrice = new TextBox();
            tbNoodleQuantity = new TextBox();
            tbPizzaPrice = new TextBox();
            groupBox3 = new GroupBox();
            tbDcFood = new TextBox();
            tbDcBeverage = new TextBox();
            tbDcAll = new TextBox();
            chbDcFood = new CheckBox();
            chbDcBeverage = new CheckBox();
            chbDcAll = new CheckBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(32, 31);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(32, 75);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(78, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "Green Tea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(148, 29);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 2;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(148, 75);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 3;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(309, 29);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 4;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(309, 75);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(497, 31);
            button1.Name = "button1";
            button1.Size = new Size(56, 355);
            button1.TabIndex = 6;
            button1.Text = "Check Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 32);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 7;
            label1.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(630, 29);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 74);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Cash";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(630, 71);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(100, 23);
            tbCash.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 103);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Change";
            // 
            // tbChange
            // 
            tbChange.Location = new Point(630, 100);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(100, 23);
            tbChange.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 132);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "1000";
            // 
            // tb1000
            // 
            tb1000.Location = new Point(630, 129);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(100, 23);
            tb1000.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(559, 161);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 7;
            label5.Text = "500";
            // 
            // tb500
            // 
            tb500.Location = new Point(630, 158);
            tb500.Name = "tb500";
            tb500.Size = new Size(100, 23);
            tb500.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(559, 190);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 7;
            label6.Text = "100";
            // 
            // tb100
            // 
            tb100.Location = new Point(630, 187);
            tb100.Name = "tb100";
            tb100.Size = new Size(100, 23);
            tb100.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(559, 219);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 7;
            label7.Text = "50";
            // 
            // tb50
            // 
            tb50.Location = new Point(630, 216);
            tb50.Name = "tb50";
            tb50.Size = new Size(100, 23);
            tb50.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 248);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 7;
            label8.Text = "20";
            // 
            // tb20
            // 
            tb20.Location = new Point(630, 245);
            tb20.Name = "tb20";
            tb20.Size = new Size(100, 23);
            tb20.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(559, 277);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 7;
            label9.Text = "10";
            // 
            // tb10
            // 
            tb10.Location = new Point(630, 274);
            tb10.Name = "tb10";
            tb10.Size = new Size(100, 23);
            tb10.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(559, 306);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 7;
            label10.Text = "5";
            // 
            // tb5
            // 
            tb5.Location = new Point(630, 303);
            tb5.Name = "tb5";
            tb5.Size = new Size(100, 23);
            tb5.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(559, 335);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 7;
            label11.Text = "2";
            // 
            // tb2
            // 
            tb2.Location = new Point(630, 332);
            tb2.Name = "tb2";
            tb2.Size = new Size(100, 23);
            tb2.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(559, 364);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 7;
            label12.Text = "1";
            // 
            // tb1
            // 
            tb1.Location = new Point(630, 361);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chbCoffee);
            groupBox1.Controls.Add(chbGreenTea);
            groupBox1.Controls.Add(tbCoffeePrice);
            groupBox1.Controls.Add(tbGreenTeaPrice);
            groupBox1.Controls.Add(tbCoffeeQuantity);
            groupBox1.Controls.Add(tbGreenTeaQuantity);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 124);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbNoodle);
            groupBox2.Controls.Add(chbPizza);
            groupBox2.Controls.Add(tbPizzaQuantity);
            groupBox2.Controls.Add(tbNoodlePrice);
            groupBox2.Controls.Add(tbNoodleQuantity);
            groupBox2.Controls.Add(tbPizzaPrice);
            groupBox2.Location = new Point(12, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 124);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // chbNoodle
            // 
            chbNoodle.AutoSize = true;
            chbNoodle.Location = new Point(32, 30);
            chbNoodle.Name = "chbNoodle";
            chbNoodle.Size = new Size(65, 19);
            chbNoodle.TabIndex = 6;
            chbNoodle.Text = "Noodle";
            chbNoodle.UseVisualStyleBackColor = true;
            // 
            // chbPizza
            // 
            chbPizza.AutoSize = true;
            chbPizza.Location = new Point(32, 74);
            chbPizza.Name = "chbPizza";
            chbPizza.Size = new Size(52, 19);
            chbPizza.TabIndex = 7;
            chbPizza.Text = "Pizza";
            chbPizza.UseVisualStyleBackColor = true;
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(309, 74);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(100, 23);
            tbPizzaQuantity.TabIndex = 11;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(148, 28);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(100, 23);
            tbNoodlePrice.TabIndex = 8;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(309, 28);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(100, 23);
            tbNoodleQuantity.TabIndex = 10;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(148, 74);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(100, 23);
            tbPizzaPrice.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(tbDcFood);
            groupBox3.Controls.Add(tbDcBeverage);
            groupBox3.Controls.Add(tbDcAll);
            groupBox3.Controls.Add(chbDcFood);
            groupBox3.Controls.Add(chbDcBeverage);
            groupBox3.Controls.Add(chbDcAll);
            groupBox3.Location = new Point(12, 303);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(458, 124);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discount";
            // 
            // tbDcFood
            // 
            tbDcFood.Location = new Point(309, 91);
            tbDcFood.Name = "tbDcFood";
            tbDcFood.Size = new Size(100, 23);
            tbDcFood.TabIndex = 16;
            // 
            // tbDcBeverage
            // 
            tbDcBeverage.Location = new Point(309, 56);
            tbDcBeverage.Name = "tbDcBeverage";
            tbDcBeverage.Size = new Size(100, 23);
            tbDcBeverage.TabIndex = 15;
            // 
            // tbDcAll
            // 
            tbDcAll.Location = new Point(309, 20);
            tbDcAll.Name = "tbDcAll";
            tbDcAll.Size = new Size(100, 23);
            tbDcAll.TabIndex = 12;
            // 
            // chbDcFood
            // 
            chbDcFood.AutoSize = true;
            chbDcFood.Location = new Point(32, 93);
            chbDcFood.Name = "chbDcFood";
            chbDcFood.Size = new Size(53, 19);
            chbDcFood.TabIndex = 14;
            chbDcFood.Text = "Food";
            chbDcFood.UseVisualStyleBackColor = true;
            // 
            // chbDcBeverage
            // 
            chbDcBeverage.AutoSize = true;
            chbDcBeverage.Location = new Point(32, 57);
            chbDcBeverage.Name = "chbDcBeverage";
            chbDcBeverage.Size = new Size(74, 19);
            chbDcBeverage.TabIndex = 13;
            chbDcBeverage.Text = "Beverage";
            chbDcBeverage.UseVisualStyleBackColor = true;
            // 
            // chbDcAll
            // 
            chbDcAll.AutoSize = true;
            chbDcAll.Location = new Point(32, 22);
            chbDcAll.Name = "chbDcAll";
            chbDcAll.Size = new Size(40, 19);
            chbDcAll.TabIndex = 12;
            chbDcAll.Text = "All";
            chbDcAll.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(415, 23);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 17;
            label13.Text = "%";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(415, 58);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 18;
            label14.Text = "%";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(415, 94);
            label15.Name = "label15";
            label15.Size = new Size(17, 15);
            label15.TabIndex = 19;
            label15.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tb1);
            Controls.Add(label12);
            Controls.Add(tb2);
            Controls.Add(label11);
            Controls.Add(tb5);
            Controls.Add(label10);
            Controls.Add(tb10);
            Controls.Add(label9);
            Controls.Add(tb20);
            Controls.Add(label8);
            Controls.Add(tb50);
            Controls.Add(label7);
            Controls.Add(tb100);
            Controls.Add(label6);
            Controls.Add(tb500);
            Controls.Add(label5);
            Controls.Add(tb1000);
            Controls.Add(label4);
            Controls.Add(tbChange);
            Controls.Add(label3);
            Controls.Add(tbCash);
            Controls.Add(label2);
            Controls.Add(tbTotal);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private TextBox tbCoffeePrice;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Button button1;
        private Label label1;
        private TextBox tbTotal;
        private Label label2;
        private TextBox tbCash;
        private Label label3;
        private TextBox tbChange;
        private Label label4;
        private TextBox tb1000;
        private Label label5;
        private TextBox tb500;
        private Label label6;
        private TextBox tb100;
        private Label label7;
        private TextBox tb50;
        private Label label8;
        private TextBox tb20;
        private Label label9;
        private TextBox tb10;
        private Label label10;
        private TextBox tb5;
        private Label label11;
        private TextBox tb2;
        private Label label12;
        private TextBox tb1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chbNoodle;
        private CheckBox chbPizza;
        private TextBox tbPizzaQuantity;
        private TextBox tbNoodlePrice;
        private TextBox tbNoodleQuantity;
        private TextBox tbPizzaPrice;
        private GroupBox groupBox3;
        private CheckBox chbDcFood;
        private CheckBox chbDcAll;
        private TextBox tbDcFood;
        private TextBox tbDcBeverage;
        private TextBox tbDcAll;
        private CheckBox chbDcBeverage;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}
