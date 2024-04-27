using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net.Http;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

namespace Cs_Fo_Project
{

    public partial class Customer : Form
    {

        private const string GoogleBooksApiBaseUrl = "https://www.googleapis.com/books/v1/volumes";
       // private readonly HttpClient httpClient;
        HttpClient httpClient = new HttpClient();
        public Customer()
        {
            InitializeComponent();
           
        }

        string Directory_Name = "E:\\Fo Project\\Fo_Project";


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

        public async void description(HttpClient httpClient, string name)
        {
            if (httpClient == null)
            {
                // Handle the case when httpClient is null
                textBox5.Text = "HTTP client is not initialized.";
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                // Handle the case when name is null or empty
                textBox5.Text = "Invalid name.";
                return;
            }

            string bookTitle = name;

            // Call the Google Books API to search for the book
            string searchUrl = $"{GoogleBooksApiBaseUrl}?q={Uri.EscapeDataString(bookTitle)}&key=AIzaSyDVPJsh1wm7hXcFqLJKzG7azW9UryVYJzo";
            HttpResponseMessage response = await httpClient.GetAsync(searchUrl);

            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                JObject json = JObject.Parse(responseContent);
                JArray items = (JArray)json["items"];

                if (items.Count > 0)
                {
                    // Extract the book description from the response
                    JObject firstItem = (JObject)items[0];
                    JObject volumeInfo = (JObject)firstItem["volumeInfo"];
                    string description = volumeInfo.Value<string>("description");

                    // Display the description in the console
                    textBox5.Text =  description ?? "No description found.";
                }
                else
                {
                    // No books found
                    textBox5.Text = "No books found.";
                }
            }
            else
            {
                // Request failed
                textBox5.Text = "Request failed.";
            }

            
        }
    


        private  void button1_Click(object sender, EventArgs e) // Search By Title 
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
                    description(httpClient, line);

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}

