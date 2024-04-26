using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_Fo_Project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        string Directory_Name = "C:\\FO";


        static LinkedList<string> StoreDataInLinkedList(string Directory_Name)
        {
            LinkedList<string> All_data = new LinkedList<string>();

            // Get the files in the directory
            string[] files = Directory.GetFiles(Directory_Name);

            foreach (string file in files)
            {
                // Read the contents of each file
                string[] lines = File.ReadAllLines(file);

                // Store each line in the linked list
                foreach (string line in lines)
                {
                    All_data.AddLast(line);
                }
            }

            return All_data;
        }



        private void Customer_Load(object sender, EventArgs e)
        {
            LinkedList<string> All_data = StoreDataInLinkedList(Directory_Name);

            string[] lines2 = All_data.ToArray();

            List<string> list_Data = new List<string>();
            foreach (string line in lines2)
            {
                string[] values = line.Split('|'); // Replace '|' with your actual delimiter
                if (values.Length > 1)
                {
                    list_Data.Add(values[1].Trim());
                }
            }

            // Optional: Convert the list to an array
            string[] secondValuesArray = list_Data.ToArray();

            // Output the second values
            comboBox1.Items.AddRange(secondValuesArray);
        }

        private void button1_Click(object sender, EventArgs e) // Search By Title 
        {
            LinkedList<string> All_data = StoreDataInLinkedList(Directory_Name);

            string[] lines = All_data.ToArray();

            List<string> list_Data = new List<string>();
            foreach (string line in lines)
            {
                string[] values = line.Split('|'); // Replace '|' with your actual delimiter
                if (values.Length > 1)
                {
                    list_Data.Add(values[1].Trim());
                }
            }

            // Optional: Convert the list to an array
            string[] secondValuesArray = list_Data.ToArray();



            foreach (string line in secondValuesArray)
            {
                if (line == textBox1.Text)
                {
                    label4.Text = textBox1.Text;
                    label5.Text = "\"Game of Thrones\" is renowned for its intricate plot\n, memorable characters, and unexpected twists and turns.\n It explores themes of power, morality, loyalty,\n and the consequences of actions, often challenging traditional fantasy tropes by subverting expectations \nand portraying a morally gray world where no character is safe from harm or death.";

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkedList<string> All_data = StoreDataInLinkedList(Directory_Name);

            string[] lines = All_data.ToArray();

            List<string> list_Data = new List<string>();
            foreach (string line in lines)
            {
                string[] values = line.Split('|'); // Replace '|' with your actual delimiter
                if (values.Length > 1)
                {
                    list_Data.Add(values[1].Trim());
                }
            }

            // Optional: Convert the list to an array
            string[] secondValuesArray = list_Data.ToArray();



            foreach (string line in secondValuesArray)
            {
                if (line == textBox2.Text)
                {
                    label4.Text = textBox1.Text;
                    //label5.Text = "\"Game of Thrones\" is renowned for its intricate plot, memorable characters, and unexpected twists and turns. It explores themes of power, morality, loyalty, and the consequences of actions, often challenging traditional fantasy tropes by subverting expectations and portraying a morally gray world where no character is safe from harm or death.";

                }
                else
                {
                    //label4.Text = "The Similer Books ";
                    //label5.Text = $"The Wheel of Time\nThe Stormlight Archive\nThe Kingkiller Chronicle\nA Song of Ice and Fire\nMalazan Book of the Fallen\nThe First Law";

                }

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        FileStream fs;
        StreamWriter sw;
        private void button3_Click(object sender, EventArgs e)// Add The Title Of Book and Author In The File 
        {
            fs = new FileStream("C:\\Suggesting Books\\Books Added Soon.txt ", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(fs);
            fs.Seek(0, SeekOrigin.End);
            sw.WriteLine($"{textBox3.Text}|{textBox4.Text}");
            sw.Flush();
            sw.Close();
            fs.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox4.Text = "";
        }


    }
}
