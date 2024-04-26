using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cs_Fo_Project
{
    public partial class Admin : Form 
    {
        FileStream fs;
        StreamReader sr;
        StreamReader isr;
        StreamWriter sw;
        StreamWriter isw;
        SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
        public Admin()
        {
            InitializeComponent();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ISPN_text.Clear();
            Title_Text.Clear();
            Author_Text.Clear();
            Publish_text.Clear();
            Price_Text.Clear();


        }
        String Folder = "C:\\Fo";
        private void Create_File_Click(object sender, EventArgs e)
        {
            string Path = File_Name.Text;
            fs = new FileStream($"C:\\FO\\{Path}", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sr = new StreamReader(fs);
            sw = new StreamWriter(fs);

            if (Directory.Exists(Folder))
            {
                string[] Files = Directory.GetFiles(Folder);
                int Counter_File = Files.Length;
                Num_files.Text = Counter_File.ToString();
            }
            else
            {
                MessageBox.Show("The Folder Not Found ");
            }

        }

        private void Create_index_file_Click(object sender, EventArgs e)
        {
            dic.Clear();
            textBox1.Clear();

            if (File.Exists("C:\\FO\\index1.txt"))
            {
                isr = new StreamReader("C:\\FO\\index1.txt");
                string line = isr.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    textBox1.Text = field[0] + field[1] + Environment.NewLine;
                    dic.Add(int.Parse(field[0]), int.Parse(field[1]));
                    isr.Close();
                    MessageBox.Show("The Index file is Loaded ");
                }
            }
        }

        int Num_index_Record = 0;
        private void add_into_index_Click(object sender, EventArgs e)
        {
            isw = new StreamWriter("C:\\FO\\index1.txt");
            foreach (KeyValuePair<int, int> item in dic)
            {
                isw.WriteLine($"{item.Key}|{item.Value}");
                Num_index_Record++;
                textBox1.Text = Num_index_Record.ToString();
            }
            isw.Close();
        }
        int Id_Counter = 0;
        private void Add_btn_Click(object sender, EventArgs e)
        {
            fs.Seek(0, SeekOrigin.End);
            int locate = Convert.ToInt32(fs.Position);
            sw.WriteLine($"{ISPN_text.Text}|{Title_Text.Text}|{Author_Text.Text}|{Publish_text.Text}|{Price_Text.Text}");
            sw.Flush();
            dic.Add(int.Parse(ISPN_text.Text), locate);
            Id_Counter++;
            Num_books.Text = Id_Counter.ToString();
        }


        public bool BS(int[] arr, int k) // Binary Search 
        {
            int F = 0;
            int l = arr.Length - 1;
            int mid = (F + l) / 2;

            while (F <= l)
            {
                mid = (F + l) / 2;

                if (k < arr[mid])
                {
                    l = mid - 1;
                }

                else if (k > arr[mid])
                {
                    F = mid + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }


        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (BS(dic.Keys.ToArray(), int.Parse(ISPN_text.Text)))
            {
                fs.Seek(dic[int.Parse(ISPN_text.Text)], SeekOrigin.Begin);
                string line = sr.ReadLine();
                string[] arr = line.Split('|');
                Title_Text.Text = arr[1];
                Author_Text.Text = arr[2];
                Publish_text.Text = arr[3];
                Price_Text.Text = arr[4];
                return;
            }
            else
            {
                Title_Text.Text = Author_Text.Text = Publish_text.Text = Price_Text.Text = "Not Found";
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (dic.ContainsKey(int.Parse(ISPN_text.Text)))
            {
                fs.Seek(dic[int.Parse(ISPN_text.Text)], SeekOrigin.Begin);
                sw.Write("*");
                sw.Close();
                fs.Flush();
                dic.Remove(int.Parse(ISPN_text.Text));
                return;

            }
            else
            {
                Title_Text.Text = Author_Text.Text = Publish_text.Text = Price_Text.Text = "Not Found";
            }
        }

        private void Exit_file_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new  Form1();

            f.Close();
            this.Close();
  

        }

        private void File_Name_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ISPN_text.Focus();
            }
        }

        private void ISPN_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Title_Text.Focus();
            }
        }

        private void Title_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Author_Text.Focus();
            }
        }

        private void Author_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Publish_text.Focus();
            }
        }

        private void Publish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Price_Text.Focus();
            }
        }

        private void File_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Create_File.PerformClick();
            }
        }

      

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               
                add_into_index.PerformClick();
            }
        }
    }
}
