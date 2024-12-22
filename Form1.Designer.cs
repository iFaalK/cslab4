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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            button1 = new Button();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(101, 37);
            label1.TabIndex = 0;
            label1.Text = "CIRCLE\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(33, 326);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 1;
            label2.Text = "TRAPEZOID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(33, 159);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 2;
            label3.Text = "RECTANGLE\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(429, 391);
            button2.Name = "button2";
            button2.Size = new Size(126, 36);
            button2.TabIndex = 4;
            button2.Text = "CALCULATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 402);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 402);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(161, 402);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(33, 250);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(185, 250);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(122, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(33, 98);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(122, 23);
            textBox8.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(63, 374);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 14;
            label4.Text = "Side A";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(319, 239);
            button4.Name = "button4";
            button4.Size = new Size(126, 36);
            button4.TabIndex = 15;
            button4.Text = "CALCULATE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(185, 87);
            button1.Name = "button1";
            button1.Size = new Size(126, 36);
            button1.TabIndex = 16;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(185, 374);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 17;
            label5.Text = "Side B";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(319, 374);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 20;
            label8.Text = "Height";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(62, 222);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 21;
            label9.Text = "Side A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(210, 222);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 22;
            label10.Text = "Side B";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(59, 70);
            label11.Name = "label11";
            label11.Size = new Size(68, 25);
            label11.TabIndex = 23;
            label11.Text = "Radius";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(549, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(395, 341);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(679, 386);
            button3.Name = "button3";
            button3.Size = new Size(161, 52);
            button3.TabIndex = 25;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 514);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label4;
        private Button button4;
        private Button button1;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private RichTextBox richTextBox1;
        private Button button3;
    }
}
