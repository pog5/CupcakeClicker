namespace ForceAdminClicker
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
            label1 = new Label();
            label2 = new Label();
            cupcakecount = new Label();
            label4 = new Label();
            multipliercount = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 45);
            label1.TabIndex = 0;
            label1.Text = "Cupcake Clicker v440.13";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.BurlyWood;
            label2.Location = new Point(33, 99);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 1;
            label2.Text = "Cupcakes:";
            // 
            // cupcakecount
            // 
            cupcakecount.AutoSize = true;
            cupcakecount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cupcakecount.ForeColor = Color.Orange;
            cupcakecount.Location = new Point(134, 99);
            cupcakecount.Name = "cupcakecount";
            cupcakecount.Size = new Size(27, 32);
            cupcakecount.TabIndex = 2;
            cupcakecount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.BurlyWood;
            label4.Location = new Point(33, 129);
            label4.Name = "label4";
            label4.Size = new Size(106, 30);
            label4.TabIndex = 3;
            label4.Text = "Multiplier:";
            // 
            // multipliercount
            // 
            multipliercount.AutoSize = true;
            multipliercount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multipliercount.ForeColor = Color.Orange;
            multipliercount.Location = new Point(134, 127);
            multipliercount.Name = "multipliercount";
            multipliercount.Size = new Size(27, 32);
            multipliercount.TabIndex = 4;
            multipliercount.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.SandyBrown;
            label6.Location = new Point(86, 54);
            label6.Name = "label6";
            label6.Size = new Size(247, 32);
            label6.TabIndex = 5;
            label6.Text = "Reach level 10 to win!";
            // 
            // button1
            // 
            button1.Location = new Point(12, 230);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 6;
            button1.Text = "Give me a cupcake!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 230);
            button2.Name = "button2";
            button2.Size = new Size(133, 39);
            button2.TabIndex = 7;
            button2.Text = "Increase Multiplier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(284, 230);
            button3.Name = "button3";
            button3.Size = new Size(157, 39);
            button3.TabIndex = 8;
            button3.Text = "Level Up! (2x for everything)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.BurlyWood;
            label7.Location = new Point(33, 159);
            label7.Name = "label7";
            label7.Size = new Size(65, 30);
            label7.TabIndex = 9;
            label7.Text = "Level:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(101, 157);
            label8.Name = "label8";
            label8.Size = new Size(27, 32);
            label8.TabIndex = 10;
            label8.Text = "1";
            // 
            // button4
            // 
            button4.Location = new Point(302, 188);
            button4.Name = "button4";
            button4.Size = new Size(124, 23);
            button4.TabIndex = 11;
            button4.Text = "WIN! (Level 10 Only)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(351, 54);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Show >>>";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(852, 277);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(multipliercount);
            Controls.Add(label4);
            Controls.Add(cupcakecount);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "CUPCAKE CLICKER >> REVISION v440.13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label cupcakecount;
        private Label label4;
        private Label multipliercount;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private Label label8;
        private Button button4;
        private Button button5;
    }
}