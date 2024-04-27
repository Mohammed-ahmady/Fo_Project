namespace Cs_Fo_Project
{
    partial class Admin
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
            label1 = new Label();
            Num_books = new TextBox();
            Num_files = new TextBox();
            panel1 = new Panel();
            Create_index_file = new Button();
            Create_File = new Button();
            add_into_index = new Button();
            Exit_file_btn = new Button();
            Add_btn = new Button();
            Clear_btn = new Button();
            Search_btn = new Button();
            Delete_btn = new Button();
            label7 = new Label();
            label6 = new Label();
            Price = new Label();
            Publisher_Date = new Label();
            Author = new Label();
            Title = new Label();
            ISPN = new Label();
            Publish_text = new TextBox();
            ISPN_text = new TextBox();
            Title_Text = new TextBox();
            Author_Text = new TextBox();
            Price_Text = new TextBox();
            File_Name = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            update = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(186, 419);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 56;
            label1.Text = "Number of Books";
            // 
            // Num_books
            // 
            Num_books.Location = new Point(383, 427);
            Num_books.Margin = new Padding(3, 2, 3, 2);
            Num_books.Name = "Num_books";
            Num_books.Size = new Size(65, 23);
            Num_books.TabIndex = 55;
            // 
            // Num_files
            // 
            Num_files.Location = new Point(383, 372);
            Num_files.Margin = new Padding(3, 2, 3, 2);
            Num_files.Name = "Num_files";
            Num_files.Size = new Size(65, 23);
            Num_files.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 231, 201);
            panel1.Controls.Add(update);
            panel1.Controls.Add(Create_index_file);
            panel1.Controls.Add(Create_File);
            panel1.Controls.Add(add_into_index);
            panel1.Controls.Add(Exit_file_btn);
            panel1.Controls.Add(Add_btn);
            panel1.Controls.Add(Clear_btn);
            panel1.Controls.Add(Search_btn);
            panel1.Controls.Add(Delete_btn);
            panel1.Location = new Point(867, 37);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 470);
            panel1.TabIndex = 53;
            // 
            // Create_index_file
            // 
            Create_index_file.BackColor = Color.FromArgb(112, 98, 51);
            Create_index_file.FlatStyle = FlatStyle.Popup;
            Create_index_file.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Create_index_file.ForeColor = Color.FromArgb(250, 231, 201);
            Create_index_file.Location = new Point(56, 58);
            Create_index_file.Margin = new Padding(3, 2, 3, 2);
            Create_index_file.Name = "Create_index_file";
            Create_index_file.Size = new Size(154, 38);
            Create_index_file.TabIndex = 2;
            Create_index_file.Text = "Create Index File ";
            Create_index_file.UseVisualStyleBackColor = false;
            Create_index_file.Click += Create_index_file_Click;
            // 
            // Create_File
            // 
            Create_File.BackColor = Color.FromArgb(112, 98, 51);
            Create_File.FlatStyle = FlatStyle.Popup;
            Create_File.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Create_File.ForeColor = Color.FromArgb(250, 231, 201);
            Create_File.Location = new Point(56, 10);
            Create_File.Margin = new Padding(3, 2, 3, 2);
            Create_File.Name = "Create_File";
            Create_File.Size = new Size(154, 38);
            Create_File.TabIndex = 0;
            Create_File.Text = "Create New File";
            Create_File.UseVisualStyleBackColor = false;
            Create_File.Click += Create_File_Click;
            // 
            // add_into_index
            // 
            add_into_index.BackColor = Color.FromArgb(112, 98, 51);
            add_into_index.FlatStyle = FlatStyle.Popup;
            add_into_index.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            add_into_index.ForeColor = Color.FromArgb(250, 231, 201);
            add_into_index.Location = new Point(56, 111);
            add_into_index.Margin = new Padding(3, 2, 3, 2);
            add_into_index.Name = "add_into_index";
            add_into_index.Size = new Size(154, 38);
            add_into_index.TabIndex = 3;
            add_into_index.Text = "Add into Index File ";
            add_into_index.UseVisualStyleBackColor = false;
            add_into_index.Click += add_into_index_Click;
            // 
            // Exit_file_btn
            // 
            Exit_file_btn.BackColor = Color.FromArgb(112, 98, 51);
            Exit_file_btn.Cursor = Cursors.Hand;
            Exit_file_btn.FlatStyle = FlatStyle.Popup;
            Exit_file_btn.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Exit_file_btn.ForeColor = Color.FromArgb(250, 231, 201);
            Exit_file_btn.Location = new Point(56, 428);
            Exit_file_btn.Margin = new Padding(3, 2, 3, 2);
            Exit_file_btn.Name = "Exit_file_btn";
            Exit_file_btn.Size = new Size(154, 38);
            Exit_file_btn.TabIndex = 8;
            Exit_file_btn.Text = "Exit";
            Exit_file_btn.UseVisualStyleBackColor = false;
            Exit_file_btn.Click += Exit_file_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.FromArgb(112, 98, 51);
            Add_btn.FlatStyle = FlatStyle.Popup;
            Add_btn.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Add_btn.ForeColor = Color.FromArgb(250, 231, 201);
            Add_btn.Location = new Point(56, 165);
            Add_btn.Margin = new Padding(3, 2, 3, 2);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(154, 38);
            Add_btn.TabIndex = 4;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // Clear_btn
            // 
            Clear_btn.BackColor = Color.FromArgb(112, 98, 51);
            Clear_btn.Cursor = Cursors.Hand;
            Clear_btn.FlatStyle = FlatStyle.Popup;
            Clear_btn.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Clear_btn.ForeColor = Color.FromArgb(250, 231, 201);
            Clear_btn.Location = new Point(56, 373);
            Clear_btn.Margin = new Padding(3, 2, 3, 2);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(154, 38);
            Clear_btn.TabIndex = 1;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = false;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.FromArgb(112, 98, 51);
            Search_btn.FlatStyle = FlatStyle.Popup;
            Search_btn.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Search_btn.ForeColor = Color.FromArgb(250, 231, 201);
            Search_btn.Location = new Point(56, 219);
            Search_btn.Margin = new Padding(3, 2, 3, 2);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(154, 38);
            Search_btn.TabIndex = 5;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Search_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Delete_btn.BackColor = Color.FromArgb(112, 98, 51);
            Delete_btn.FlatStyle = FlatStyle.Popup;
            Delete_btn.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Delete_btn.ForeColor = Color.FromArgb(250, 231, 201);
            Delete_btn.Location = new Point(56, 320);
            Delete_btn.Margin = new Padding(3, 2, 3, 2);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(154, 38);
            Delete_btn.TabIndex = 6;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(186, 364);
            label7.Name = "label7";
            label7.Size = new Size(129, 29);
            label7.TabIndex = 52;
            label7.Text = "Number Of  Files ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(186, 37);
            label6.Name = "label6";
            label6.Size = new Size(83, 29);
            label6.TabIndex = 51;
            label6.Text = "File Name ";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Price.Location = new Point(186, 302);
            Price.Name = "Price";
            Price.Size = new Size(47, 29);
            Price.TabIndex = 50;
            Price.Text = "Price";
            // 
            // Publisher_Date
            // 
            Publisher_Date.AutoSize = true;
            Publisher_Date.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Publisher_Date.Location = new Point(186, 246);
            Publisher_Date.Name = "Publisher_Date";
            Publisher_Date.Size = new Size(113, 29);
            Publisher_Date.TabIndex = 49;
            Publisher_Date.Text = "Publisher Date";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Author.Location = new Point(186, 192);
            Author.Name = "Author";
            Author.Size = new Size(62, 29);
            Author.TabIndex = 48;
            Author.Text = "Author";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Title.Location = new Point(186, 138);
            Title.Name = "Title";
            Title.Size = new Size(45, 29);
            Title.TabIndex = 47;
            Title.Text = "Title";
            // 
            // ISPN
            // 
            ISPN.AutoSize = true;
            ISPN.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ISPN.Location = new Point(186, 86);
            ISPN.Name = "ISPN";
            ISPN.Size = new Size(48, 29);
            ISPN.TabIndex = 46;
            ISPN.Text = "ISPN";
            // 
            // Publish_text
            // 
            Publish_text.Location = new Point(383, 257);
            Publish_text.Margin = new Padding(3, 2, 3, 2);
            Publish_text.Name = "Publish_text";
            Publish_text.Size = new Size(368, 23);
            Publish_text.TabIndex = 45;
            Publish_text.KeyDown += Publish_KeyDown;
            // 
            // ISPN_text
            // 
            ISPN_text.Location = new Point(383, 96);
            ISPN_text.Margin = new Padding(3, 2, 3, 2);
            ISPN_text.Name = "ISPN_text";
            ISPN_text.Size = new Size(368, 23);
            ISPN_text.TabIndex = 44;
            ISPN_text.KeyDown += ISPN_keyDown;
            // 
            // Title_Text
            // 
            Title_Text.Location = new Point(383, 149);
            Title_Text.Margin = new Padding(3, 2, 3, 2);
            Title_Text.Name = "Title_Text";
            Title_Text.Size = new Size(368, 23);
            Title_Text.TabIndex = 43;
            Title_Text.KeyDown += Title_keyDown;
            // 
            // Author_Text
            // 
            Author_Text.Location = new Point(383, 203);
            Author_Text.Margin = new Padding(3, 2, 3, 2);
            Author_Text.Name = "Author_Text";
            Author_Text.Size = new Size(368, 23);
            Author_Text.TabIndex = 42;
            Author_Text.KeyDown += Author_KeyDown;
            // 
            // Price_Text
            // 
            Price_Text.Location = new Point(383, 312);
            Price_Text.Margin = new Padding(3, 2, 3, 2);
            Price_Text.Name = "Price_Text";
            Price_Text.Size = new Size(368, 23);
            Price_Text.TabIndex = 41;
            Price_Text.KeyPress += Price_KeyPress;
            // 
            // File_Name
            // 
            File_Name.Location = new Point(383, 47);
            File_Name.Margin = new Padding(3, 2, 3, 2);
            File_Name.Name = "File_Name";
            File_Name.Size = new Size(368, 23);
            File_Name.TabIndex = 40;
            File_Name.KeyDown += File_Name_keyDown;
            File_Name.KeyPress += File_Name_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(383, 470);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(186, 462);
            label2.Name = "label2";
            label2.Size = new Size(181, 29);
            label2.TabIndex = 57;
            label2.Text = "Number of Index Record";
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(112, 98, 51);
            update.Cursor = Cursors.Hand;
            update.FlatStyle = FlatStyle.Popup;
            update.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            update.ForeColor = Color.FromArgb(250, 231, 201);
            update.Location = new Point(56, 269);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Size = new Size(154, 38);
            update.TabIndex = 9;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 146, 106);
            ClientSize = new Size(1206, 561);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Num_books);
            Controls.Add(Num_files);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Price);
            Controls.Add(Publisher_Date);
            Controls.Add(Author);
            Controls.Add(Title);
            Controls.Add(ISPN);
            Controls.Add(Publish_text);
            Controls.Add(ISPN_text);
            Controls.Add(Title_Text);
            Controls.Add(Author_Text);
            Controls.Add(Price_Text);
            Controls.Add(File_Name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Search";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Num_books;
        private TextBox Num_files;
        private Panel panel1;
        private Button Create_index_file;
        private Button Create_File;
        private Button add_into_index;
        private Button Exit_file_btn;
        private Button Add_btn;
        private Button Clear_btn;
        private Button Search_btn;
        private Button Delete_btn;
        private Label label7;
        private Label label6;
        private Label Price;
        private Label Publisher_Date;
        private Label Author;
        private Label Title;
        private Label ISPN;
        private TextBox Publish_text;
        private TextBox ISPN_text;
        private TextBox Title_Text;
        private TextBox Author_Text;
        private TextBox Price_Text;
        private TextBox File_Name;
        private TextBox textBox1;
        private Label label2;
        private Button update;
    }
}