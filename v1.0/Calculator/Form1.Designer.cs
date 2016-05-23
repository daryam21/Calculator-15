namespace Calculator
{
    partial class calculator_form
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
            this.result_txt = new System.Windows.Forms.TextBox();
            this.seven_b = new System.Windows.Forms.Button();
            this.eight_b = new System.Windows.Forms.Button();
            this.nine_b = new System.Windows.Forms.Button();
            this.plus_b = new System.Windows.Forms.Button();
            this.divide_b = new System.Windows.Forms.Button();
            this.six_b = new System.Windows.Forms.Button();
            this.five_b = new System.Windows.Forms.Button();
            this.four_b = new System.Windows.Forms.Button();
            this.multiply_b = new System.Windows.Forms.Button();
            this.three_b = new System.Windows.Forms.Button();
            this.two_b = new System.Windows.Forms.Button();
            this.one_b = new System.Windows.Forms.Button();
            this.equals_b = new System.Windows.Forms.Button();
            this.dot_b = new System.Windows.Forms.Button();
            this.zero_b = new System.Windows.Forms.Button();
            this.minusb = new System.Windows.Forms.Button();
            this.x_b = new System.Windows.Forms.Button();
            this.ce_b = new System.Windows.Forms.Button();
            this.c_b = new System.Windows.Forms.Button();
            this.operationperformed_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_txt
            // 
            this.result_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_txt.Location = new System.Drawing.Point(3, 34);
            this.result_txt.Multiline = true;
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(257, 37);
            this.result_txt.TabIndex = 0;
            this.result_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven_b
            // 
            this.seven_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven_b.Font = new System.Drawing.Font("Verdana Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seven_b.Location = new System.Drawing.Point(3, 139);
            this.seven_b.Name = "seven_b";
            this.seven_b.Size = new System.Drawing.Size(50, 45);
            this.seven_b.TabIndex = 1;
            this.seven_b.Text = "7";
            this.seven_b.UseVisualStyleBackColor = true;
            this.seven_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // eight_b
            // 
            this.eight_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_b.Location = new System.Drawing.Point(68, 139);
            this.eight_b.Name = "eight_b";
            this.eight_b.Size = new System.Drawing.Size(50, 45);
            this.eight_b.TabIndex = 2;
            this.eight_b.Text = "8";
            this.eight_b.UseVisualStyleBackColor = true;
            this.eight_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // nine_b
            // 
            this.nine_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_b.Location = new System.Drawing.Point(141, 139);
            this.nine_b.Name = "nine_b";
            this.nine_b.Size = new System.Drawing.Size(50, 45);
            this.nine_b.TabIndex = 3;
            this.nine_b.Text = "9";
            this.nine_b.UseVisualStyleBackColor = true;
            this.nine_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // plus_b
            // 
            this.plus_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_b.Location = new System.Drawing.Point(207, 139);
            this.plus_b.Name = "plus_b";
            this.plus_b.Size = new System.Drawing.Size(50, 45);
            this.plus_b.TabIndex = 4;
            this.plus_b.Text = "+";
            this.plus_b.UseVisualStyleBackColor = true;
            this.plus_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // divide_b
            // 
            this.divide_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_b.Location = new System.Drawing.Point(207, 201);
            this.divide_b.Name = "divide_b";
            this.divide_b.Size = new System.Drawing.Size(50, 45);
            this.divide_b.TabIndex = 8;
            this.divide_b.Text = "/";
            this.divide_b.UseVisualStyleBackColor = true;
            this.divide_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // six_b
            // 
            this.six_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_b.Location = new System.Drawing.Point(141, 201);
            this.six_b.Name = "six_b";
            this.six_b.Size = new System.Drawing.Size(50, 45);
            this.six_b.TabIndex = 7;
            this.six_b.Text = "6";
            this.six_b.UseVisualStyleBackColor = true;
            this.six_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // five_b
            // 
            this.five_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_b.Location = new System.Drawing.Point(68, 201);
            this.five_b.Name = "five_b";
            this.five_b.Size = new System.Drawing.Size(50, 45);
            this.five_b.TabIndex = 6;
            this.five_b.Text = "5";
            this.five_b.UseVisualStyleBackColor = true;
            this.five_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // four_b
            // 
            this.four_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four_b.Font = new System.Drawing.Font("Verdana Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_b.Location = new System.Drawing.Point(3, 201);
            this.four_b.Name = "four_b";
            this.four_b.Size = new System.Drawing.Size(50, 45);
            this.four_b.TabIndex = 5;
            this.four_b.Text = "4";
            this.four_b.UseVisualStyleBackColor = true;
            this.four_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiply_b
            // 
            this.multiply_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_b.Location = new System.Drawing.Point(207, 262);
            this.multiply_b.Name = "multiply_b";
            this.multiply_b.Size = new System.Drawing.Size(50, 45);
            this.multiply_b.TabIndex = 12;
            this.multiply_b.Text = "*";
            this.multiply_b.UseVisualStyleBackColor = true;
            this.multiply_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // three_b
            // 
            this.three_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_b.Location = new System.Drawing.Point(141, 262);
            this.three_b.Name = "three_b";
            this.three_b.Size = new System.Drawing.Size(50, 45);
            this.three_b.TabIndex = 11;
            this.three_b.Text = "3";
            this.three_b.UseVisualStyleBackColor = true;
            this.three_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // two_b
            // 
            this.two_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_b.Location = new System.Drawing.Point(68, 262);
            this.two_b.Name = "two_b";
            this.two_b.Size = new System.Drawing.Size(50, 45);
            this.two_b.TabIndex = 10;
            this.two_b.Text = "2";
            this.two_b.UseVisualStyleBackColor = true;
            this.two_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // one_b
            // 
            this.one_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_b.Font = new System.Drawing.Font("Verdana Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_b.Location = new System.Drawing.Point(6, 262);
            this.one_b.Name = "one_b";
            this.one_b.Size = new System.Drawing.Size(50, 45);
            this.one_b.TabIndex = 9;
            this.one_b.Text = "1";
            this.one_b.UseVisualStyleBackColor = true;
            this.one_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // equals_b
            // 
            this.equals_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals_b.Location = new System.Drawing.Point(207, 322);
            this.equals_b.Name = "equals_b";
            this.equals_b.Size = new System.Drawing.Size(50, 45);
            this.equals_b.TabIndex = 16;
            this.equals_b.Text = "=";
            this.equals_b.UseVisualStyleBackColor = true;
            this.equals_b.Click += new System.EventHandler(this.equals_b_Click);
            // 
            // dot_b
            // 
            this.dot_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot_b.Location = new System.Drawing.Point(141, 322);
            this.dot_b.Name = "dot_b";
            this.dot_b.Size = new System.Drawing.Size(50, 45);
            this.dot_b.TabIndex = 15;
            this.dot_b.Text = ".";
            this.dot_b.UseVisualStyleBackColor = true;
            this.dot_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // zero_b
            // 
            this.zero_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_b.Location = new System.Drawing.Point(68, 322);
            this.zero_b.Name = "zero_b";
            this.zero_b.Size = new System.Drawing.Size(50, 45);
            this.zero_b.TabIndex = 14;
            this.zero_b.Text = "0";
            this.zero_b.UseVisualStyleBackColor = true;
            this.zero_b.Click += new System.EventHandler(this.Button_Click);
            // 
            // minusb
            // 
            this.minusb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusb.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusb.Location = new System.Drawing.Point(207, 77);
            this.minusb.Name = "minusb";
            this.minusb.Size = new System.Drawing.Size(50, 45);
            this.minusb.TabIndex = 20;
            this.minusb.Text = "-";
            this.minusb.UseVisualStyleBackColor = true;
            this.minusb.Click += new System.EventHandler(this.Operator_Click);
            // 
            // x_b
            // 
            this.x_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_b.Location = new System.Drawing.Point(141, 77);
            this.x_b.Name = "x_b";
            this.x_b.Size = new System.Drawing.Size(50, 45);
            this.x_b.TabIndex = 19;
            this.x_b.Text = "X";
            this.x_b.UseVisualStyleBackColor = true;
            this.x_b.Click += new System.EventHandler(this.x_b_Click);
            // 
            // ce_b
            // 
            this.ce_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ce_b.Font = new System.Drawing.Font("Verdana Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce_b.Location = new System.Drawing.Point(68, 77);
            this.ce_b.Name = "ce_b";
            this.ce_b.Size = new System.Drawing.Size(50, 45);
            this.ce_b.TabIndex = 18;
            this.ce_b.Text = "CE";
            this.ce_b.UseVisualStyleBackColor = true;
            this.ce_b.Click += new System.EventHandler(this.ce_b_Click);
            // 
            // c_b
            // 
            this.c_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_b.Font = new System.Drawing.Font("Verdana Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.c_b.Location = new System.Drawing.Point(3, 77);
            this.c_b.Name = "c_b";
            this.c_b.Size = new System.Drawing.Size(50, 45);
            this.c_b.TabIndex = 17;
            this.c_b.Text = "C";
            this.c_b.UseVisualStyleBackColor = true;
            this.c_b.Click += new System.EventHandler(this.c_b_Click);
            // 
            // operationperformed_l
            // 
            this.operationperformed_l.AutoSize = true;
            this.operationperformed_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationperformed_l.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.operationperformed_l.Location = new System.Drawing.Point(3, 9);
            this.operationperformed_l.Name = "operationperformed_l";
            this.operationperformed_l.Size = new System.Drawing.Size(0, 24);
            this.operationperformed_l.TabIndex = 21;
            // 
            // calculator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 380);
            this.Controls.Add(this.operationperformed_l);
            this.Controls.Add(this.minusb);
            this.Controls.Add(this.x_b);
            this.Controls.Add(this.ce_b);
            this.Controls.Add(this.c_b);
            this.Controls.Add(this.equals_b);
            this.Controls.Add(this.dot_b);
            this.Controls.Add(this.zero_b);
            this.Controls.Add(this.multiply_b);
            this.Controls.Add(this.three_b);
            this.Controls.Add(this.two_b);
            this.Controls.Add(this.one_b);
            this.Controls.Add(this.divide_b);
            this.Controls.Add(this.six_b);
            this.Controls.Add(this.five_b);
            this.Controls.Add(this.four_b);
            this.Controls.Add(this.plus_b);
            this.Controls.Add(this.nine_b);
            this.Controls.Add(this.eight_b);
            this.Controls.Add(this.seven_b);
            this.Controls.Add(this.result_txt);
            this.Name = "calculator_form";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Button seven_b;
        private System.Windows.Forms.Button eight_b;
        private System.Windows.Forms.Button nine_b;
        private System.Windows.Forms.Button plus_b;
        private System.Windows.Forms.Button divide_b;
        private System.Windows.Forms.Button six_b;
        private System.Windows.Forms.Button five_b;
        private System.Windows.Forms.Button four_b;
        private System.Windows.Forms.Button multiply_b;
        private System.Windows.Forms.Button three_b;
        private System.Windows.Forms.Button two_b;
        private System.Windows.Forms.Button one_b;
        private System.Windows.Forms.Button equals_b;
        private System.Windows.Forms.Button dot_b;
        private System.Windows.Forms.Button zero_b;
        private System.Windows.Forms.Button minusb;
        private System.Windows.Forms.Button x_b;
        private System.Windows.Forms.Button ce_b;
        private System.Windows.Forms.Button c_b;
        private System.Windows.Forms.Label operationperformed_l;
    }
}

