namespace odev4
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(42, 45);
            label1.Name = "label1";
            label1.Size = new Size(284, 31);
            label1.TabIndex = 0;
            label1.Text = "Dizi Elemanları Ekleyin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Text", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(75, 127);
            button1.Name = "button1";
            button1.Size = new Size(112, 61);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(159, 272);
            button2.Name = "button2";
            button2.Size = new Size(167, 34);
            button2.TabIndex = 3;
            button2.Text = "BK_Sırala";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.FromArgb(192, 0, 192);
            button3.Location = new Point(159, 323);
            button3.Name = "button3";
            button3.Size = new Size(167, 34);
            button3.TabIndex = 4;
            button3.Text = "KB_Sırala";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MistyRose;
            listBox1.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(387, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 134);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.MistyRose;
            listBox2.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 26;
            listBox2.Location = new Point(387, 258);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(270, 134);
            listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}
