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
            label3 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            label11 = new Label();
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
            label1.Click += label1_Click;
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
            button4.Enabled = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Salmon;
            label3.Location = new Point(501, 9);
            label3.Name = "label3";
            label3.Size = new Size(285, 45);
            label3.TabIndex = 13;
            label3.Text = "DEVELOPER MENU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSalmon;
            label5.Location = new Point(542, 157);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 16;
            label5.Text = "Level:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkSalmon;
            label9.Location = new Point(501, 127);
            label9.Name = "label9";
            label9.Size = new Size(106, 30);
            label9.TabIndex = 15;
            label9.Text = "Multiplier:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSalmon;
            label10.Location = new Point(501, 97);
            label10.Name = "label10";
            label10.Size = new Size(106, 30);
            label10.TabIndex = 14;
            label10.Text = "Cupcakes:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(613, 104);
            textBox1.MaxLength = 19;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 17;
            textBox1.Text = "1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(613, 133);
            textBox2.MaxLength = 19;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 18;
            textBox2.Text = "1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(613, 162);
            textBox3.MaxLength = 19;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 19;
            textBox3.Text = "1";
            // 
            // button6
            // 
            button6.Location = new Point(719, 188);
            button6.Name = "button6";
            button6.Size = new Size(67, 23);
            button6.TabIndex = 20;
            button6.Text = "SET";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(613, 188);
            button7.Name = "button7";
            button7.Size = new Size(100, 23);
            button7.TabIndex = 21;
            button7.Text = "GET CURRENT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Tomato;
            label11.Location = new Point(463, 214);
            label11.Name = "label11";
            label11.Size = new Size(387, 60);
            label11.TabIndex = 22;
            label11.Text = "Tip: You can click on the version number\r\n to unlock the Developer Menu early.\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(852, 277);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label3);
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
        private Label label3;
        private Label label5;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button6;
        private Button button7;
        private Label label11;
    }
}