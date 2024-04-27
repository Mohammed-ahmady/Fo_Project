namespace Cs_Fo_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string User_name = "Admin";
        string Pass = "8080";
        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();


            if (User_name == textBox1.Text && Pass == textBox2.Text)
            {
                a.Show();
            }
            else if (User_name == textBox1.Text && Pass != textBox2.Text)
            {
                MessageBox.Show("The Password Is Wrong ");
            }
            else if (User_name != textBox1.Text && Pass == textBox2.Text)
            {
                MessageBox.Show("The User Name Is Wrong ");
            }
            else
            {
                MessageBox.Show("Please Sure From Your User Name And Password ");
            }
        }

        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void Pass_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (User_name == textBox1.Text && Pass == textBox2.Text)
                {
                    button1.PerformClick();
                }
                else if (User_name_Customer == textBox1.Text && Pass_Customer == textBox2.Text)
                {
                    button2.PerformClick();
                }
            }
        }
        string User_name_Customer = "User";
        string Pass_Customer = "100";
        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();


            if (User_name_Customer == textBox1.Text && Pass_Customer == textBox2.Text)
            {
                c.Show();
            }
            else if (User_name_Customer == textBox1.Text && Pass_Customer != textBox2.Text)
            {
                MessageBox.Show("The Password Is Wrong ");
            }
            else if (User_name_Customer != textBox1.Text && Pass_Customer == textBox2.Text)
            {
                MessageBox.Show("The User Name Is Wrong ");
            }
            else
            {
                MessageBox.Show("Please Sure From Your User Name And Password ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}