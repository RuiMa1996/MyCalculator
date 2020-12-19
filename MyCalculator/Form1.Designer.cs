namespace MyCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.BinaryToInt = new System.Windows.Forms.Button();
            this.DemicalToBinary = new System.Windows.Forms.Button();
            this.equalSign = new System.Windows.Forms.Button();
            this.LocationNumerals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textBox1.Location = new System.Drawing.Point(57, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(57, 95);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(70, 70);
            this.number7.TabIndex = 1;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(133, 95);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(70, 70);
            this.number8.TabIndex = 2;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(209, 95);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(70, 70);
            this.number9.TabIndex = 3;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(285, 95);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(70, 70);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(57, 171);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(70, 70);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(133, 171);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(70, 70);
            this.number5.TabIndex = 6;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(209, 171);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(70, 70);
            this.number6.TabIndex = 7;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(285, 171);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(70, 70);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(57, 247);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(70, 70);
            this.number1.TabIndex = 9;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(133, 247);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(70, 70);
            this.number2.TabIndex = 10;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(209, 247);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(70, 70);
            this.number3.TabIndex = 11;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(285, 247);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 70);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(57, 323);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(70, 70);
            this.dot.TabIndex = 13;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(133, 323);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(70, 70);
            this.number0.TabIndex = 14;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(285, 323);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 70);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(361, 95);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(70, 70);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BinaryToInt
            // 
            this.BinaryToInt.Location = new System.Drawing.Point(361, 171);
            this.BinaryToInt.Name = "BinaryToInt";
            this.BinaryToInt.Size = new System.Drawing.Size(70, 70);
            this.BinaryToInt.TabIndex = 18;
            this.BinaryToInt.Text = "Bin";
            this.BinaryToInt.UseVisualStyleBackColor = true;
            this.BinaryToInt.Click += new System.EventHandler(this.BinaryToInt_Click);
            // 
            // DemicalToBinary
            // 
            this.DemicalToBinary.Location = new System.Drawing.Point(361, 247);
            this.DemicalToBinary.Name = "DemicalToBinary";
            this.DemicalToBinary.Size = new System.Drawing.Size(70, 70);
            this.DemicalToBinary.TabIndex = 19;
            this.DemicalToBinary.Text = "Dec";
            this.DemicalToBinary.UseVisualStyleBackColor = true;
            this.DemicalToBinary.Click += new System.EventHandler(this.DemicalToBinary_Click);
            // 
            // equalSign
            // 
            this.equalSign.Location = new System.Drawing.Point(209, 323);
            this.equalSign.Name = "equalSign";
            this.equalSign.Size = new System.Drawing.Size(70, 70);
            this.equalSign.TabIndex = 20;
            this.equalSign.Text = "=";
            this.equalSign.UseVisualStyleBackColor = true;
            this.equalSign.Click += new System.EventHandler(this.equalSign_Click);
            // 
            // LocationNumerals
            // 
            this.LocationNumerals.Location = new System.Drawing.Point(361, 323);
            this.LocationNumerals.Name = "LocationNumerals";
            this.LocationNumerals.Size = new System.Drawing.Size(70, 70);
            this.LocationNumerals.TabIndex = 21;
            this.LocationNumerals.Text = "LC";
            this.LocationNumerals.UseVisualStyleBackColor = true;
            this.LocationNumerals.Click += new System.EventHandler(this.LocationNumerals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LocationNumerals);
            this.Controls.Add(this.equalSign);
            this.Controls.Add(this.DemicalToBinary);
            this.Controls.Add(this.BinaryToInt);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BinaryToInt;
        private System.Windows.Forms.Button DemicalToBinary;
        private System.Windows.Forms.Button equalSign;
        private System.Windows.Forms.Button LocationNumerals;
    }
}

