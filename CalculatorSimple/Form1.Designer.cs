using System;

namespace CalculatorSimple
{
    partial class CalculatorSimple
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
            this.ScreenText = new System.Windows.Forms.TextBox();
            this.No1 = new System.Windows.Forms.Button();
            this.No5 = new System.Windows.Forms.Button();
            this.No6 = new System.Windows.Forms.Button();
            this.No9 = new System.Windows.Forms.Button();
            this.No8 = new System.Windows.Forms.Button();
            this.No7 = new System.Windows.Forms.Button();
            this.No3 = new System.Windows.Forms.Button();
            this.No4 = new System.Windows.Forms.Button();
            this.No2 = new System.Windows.Forms.Button();
            this.No0 = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.SqrButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenText
            // 
            this.ScreenText.Enabled = false;
            this.ScreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ScreenText.Location = new System.Drawing.Point(65, 22);
            this.ScreenText.Multiline = true;
            this.ScreenText.Name = "ScreenText";
            this.ScreenText.Size = new System.Drawing.Size(218, 45);
            this.ScreenText.TabIndex = 0;
            this.ScreenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScreenText.TextChanged += new System.EventHandler(this.ScreenText_TextChanged);
            // 
            // No1
            // 
            this.No1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No1.Location = new System.Drawing.Point(65, 253);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(50, 50);
            this.No1.TabIndex = 1;
            this.No1.Text = "1";
            this.No1.UseVisualStyleBackColor = false;
            this.No1.Click += new System.EventHandler(this.No1_Click);
            // 
            // No5
            // 
            this.No5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No5.Location = new System.Drawing.Point(121, 197);
            this.No5.Name = "No5";
            this.No5.Size = new System.Drawing.Size(50, 50);
            this.No5.TabIndex = 2;
            this.No5.Text = "5";
            this.No5.UseVisualStyleBackColor = false;
            this.No5.Click += new System.EventHandler(this.No5_Click);
            // 
            // No6
            // 
            this.No6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No6.Location = new System.Drawing.Point(177, 197);
            this.No6.Name = "No6";
            this.No6.Size = new System.Drawing.Size(50, 50);
            this.No6.TabIndex = 3;
            this.No6.Text = "6";
            this.No6.UseVisualStyleBackColor = false;
            this.No6.Click += new System.EventHandler(this.No6_Click);
            // 
            // No9
            // 
            this.No9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No9.Location = new System.Drawing.Point(177, 141);
            this.No9.Name = "No9";
            this.No9.Size = new System.Drawing.Size(50, 50);
            this.No9.TabIndex = 4;
            this.No9.Text = "9";
            this.No9.UseVisualStyleBackColor = false;
            this.No9.Click += new System.EventHandler(this.No9_Click);
            // 
            // No8
            // 
            this.No8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No8.Location = new System.Drawing.Point(121, 141);
            this.No8.Name = "No8";
            this.No8.Size = new System.Drawing.Size(50, 50);
            this.No8.TabIndex = 5;
            this.No8.Text = "8";
            this.No8.UseVisualStyleBackColor = false;
            this.No8.Click += new System.EventHandler(this.No8_Click);
            // 
            // No7
            // 
            this.No7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No7.Location = new System.Drawing.Point(65, 141);
            this.No7.Name = "No7";
            this.No7.Size = new System.Drawing.Size(50, 50);
            this.No7.TabIndex = 6;
            this.No7.Text = "7";
            this.No7.UseVisualStyleBackColor = false;
            this.No7.Click += new System.EventHandler(this.No7_Click);
            // 
            // No3
            // 
            this.No3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No3.Location = new System.Drawing.Point(177, 253);
            this.No3.Name = "No3";
            this.No3.Size = new System.Drawing.Size(50, 50);
            this.No3.TabIndex = 7;
            this.No3.Text = "3";
            this.No3.UseVisualStyleBackColor = false;
            this.No3.Click += new System.EventHandler(this.No3_Click);
            // 
            // No4
            // 
            this.No4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No4.Location = new System.Drawing.Point(65, 197);
            this.No4.Name = "No4";
            this.No4.Size = new System.Drawing.Size(50, 50);
            this.No4.TabIndex = 8;
            this.No4.Text = "4";
            this.No4.UseVisualStyleBackColor = false;
            this.No4.Click += new System.EventHandler(this.No4_Click);
            // 
            // No2
            // 
            this.No2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No2.Location = new System.Drawing.Point(121, 253);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(50, 50);
            this.No2.TabIndex = 9;
            this.No2.Text = "2";
            this.No2.UseVisualStyleBackColor = false;
            this.No2.Click += new System.EventHandler(this.No2_Click);
            // 
            // No0
            // 
            this.No0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.No0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.No0.Location = new System.Drawing.Point(65, 309);
            this.No0.Name = "No0";
            this.No0.Size = new System.Drawing.Size(50, 50);
            this.No0.TabIndex = 10;
            this.No0.Text = "0";
            this.No0.UseVisualStyleBackColor = false;
            this.No0.Click += new System.EventHandler(this.No0_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PercentageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PercentageButton.Location = new System.Drawing.Point(65, 85);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(50, 50);
            this.PercentageButton.TabIndex = 11;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = false;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // SqrButton
            // 
            this.SqrButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SqrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SqrButton.Location = new System.Drawing.Point(121, 85);
            this.SqrButton.Name = "SqrButton";
            this.SqrButton.Size = new System.Drawing.Size(50, 50);
            this.SqrButton.TabIndex = 12;
            this.SqrButton.Text = "√";
            this.SqrButton.UseVisualStyleBackColor = false;
            this.SqrButton.Click += new System.EventHandler(this.SqrButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ClearButton.Location = new System.Drawing.Point(177, 85);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(50, 50);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "CE";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DivisionButton.Location = new System.Drawing.Point(233, 85);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(50, 50);
            this.DivisionButton.TabIndex = 14;
            this.DivisionButton.Text = "÷";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MultiplicationButton.Location = new System.Drawing.Point(233, 141);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(50, 50);
            this.MultiplicationButton.TabIndex = 15;
            this.MultiplicationButton.Text = "x";
            this.MultiplicationButton.UseVisualStyleBackColor = false;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinusButton.Location = new System.Drawing.Point(233, 197);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(50, 50);
            this.MinusButton.TabIndex = 16;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlusButton.Location = new System.Drawing.Point(233, 253);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(50, 106);
            this.PlusButton.TabIndex = 17;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EqualsButton.Location = new System.Drawing.Point(177, 309);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(50, 50);
            this.EqualsButton.TabIndex = 18;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DotButton.Location = new System.Drawing.Point(121, 309);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(50, 50);
            this.DotButton.TabIndex = 19;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // CalculatorSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(343, 402);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SqrButton);
            this.Controls.Add(this.PercentageButton);
            this.Controls.Add(this.No0);
            this.Controls.Add(this.No2);
            this.Controls.Add(this.No4);
            this.Controls.Add(this.No3);
            this.Controls.Add(this.No7);
            this.Controls.Add(this.No8);
            this.Controls.Add(this.No9);
            this.Controls.Add(this.No6);
            this.Controls.Add(this.No5);
            this.Controls.Add(this.No1);
            this.Controls.Add(this.ScreenText);
            this.Name = "CalculatorSimple";
            this.Text = "CalculatorSimple";
            this.Load += new System.EventHandler(this.CalculatorSimple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CalculatorSimple_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.TextBox ScreenText;
        private System.Windows.Forms.Button No1;
        private System.Windows.Forms.Button No5;
        private System.Windows.Forms.Button No6;
        private System.Windows.Forms.Button No9;
        private System.Windows.Forms.Button No8;
        private System.Windows.Forms.Button No7;
        private System.Windows.Forms.Button No3;
        private System.Windows.Forms.Button No4;
        private System.Windows.Forms.Button No2;
        private System.Windows.Forms.Button No0;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button SqrButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DotButton;
    }
}

