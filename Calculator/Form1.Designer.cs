namespace Calculator
{
    partial class Calculator
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
            this.screen = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.MaxLength = 500;
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(182, 20);
            this.screen.TabIndex = 0;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 172);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(41, 36);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.btn_click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 214);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 36);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.btn_click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(106, 172);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(41, 36);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.btn_click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(59, 172);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(41, 36);
            this.two.TabIndex = 4;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.btn_click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(106, 214);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(41, 36);
            this.point.TabIndex = 5;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.btn_click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(106, 130);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(41, 36);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.btn_click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(106, 88);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(41, 36);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.btn_click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(59, 88);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(41, 36);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.btn_click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 88);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(41, 36);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.btn_click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(59, 130);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(41, 36);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.btn_click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 130);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(41, 36);
            this.four.TabIndex = 11;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.btn_click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(153, 46);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(41, 36);
            this.division.TabIndex = 12;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operator_click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(12, 46);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(41, 36);
            this.c.TabIndex = 14;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(153, 130);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(41, 36);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operator_click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(153, 88);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(41, 36);
            this.times.TabIndex = 16;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(153, 214);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(41, 36);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(153, 172);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(41, 36);
            this.plus.TabIndex = 18;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operator_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = "+ / -";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.c);
            this.Controls.Add(this.division);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.point);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.screen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(230, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 300);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

