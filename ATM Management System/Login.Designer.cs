namespace ATM_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 139, 223);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 113);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(102, 22);
            label1.Name = "label1";
            label1.Size = new Size(604, 62);
            label1.TabIndex = 1;
            label1.Text = "ATM Management System";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(127, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 349);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 153);
            label5.Name = "label5";
            label5.Size = new Size(105, 31);
            label5.TabIndex = 3;
            label5.Text = "Pin Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 92);
            label6.Name = "label6";
            label6.Size = new Size(134, 31);
            label6.TabIndex = 2;
            label6.Text = "Account No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(167, 11);
            label7.Name = "label7";
            label7.Size = new Size(127, 54);
            label7.TabIndex = 1;
            label7.Text = "Login";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(86, 132, 207);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 349);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(141, 202, 255);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(331, 239);
            button2.Name = "button2";
            button2.Size = new Size(104, 49);
            button2.TabIndex = 7;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(199, 239);
            button1.Name = "button1";
            button1.Size = new Size(113, 49);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 27);
            textBox3.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 575);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}