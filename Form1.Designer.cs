namespace Cs_Fo_Project
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
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(250, 231, 201);
            label3.Location = new Point(397, 47);
            label3.Name = "label3";
            label3.Size = new Size(386, 78);
            label3.TabIndex = 3;
            label3.Text = "Library Search";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 199, 143);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(343, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 323);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 231, 201);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(183, 243);
            button2.Name = "button2";
            button2.Size = new Size(185, 36);
            button2.TabIndex = 5;
            button2.Text = "Login as Guest";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 231, 201);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(183, 187);
            button1.Name = "button1";
            button1.Size = new Size(185, 36);
            button1.TabIndex = 4;
            button1.Text = "Login as Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 133);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 134);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(238, 23);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += Pass_keyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += UserName_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 146, 106);
            ClientSize = new Size(1206, 561);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}