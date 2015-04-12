using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionaryConsole
{
    public partial class Dictionary : Form
    {
        WordList wordListForm = new WordList();
        public List<String> words = new List<string> { "Hello", "Welcome", "Goodbye" };

        public Dictionary()
        {
            InitializeComponent();
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Dictionary Form Launched");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            check_list();
        }

        private void textBox_type_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            status_reset();
            if (e.KeyChar == 13)
            {
                check_list();
            }
            else if (e.KeyChar == 27)
            {
                textBox_type_in.Clear();
            }
        }

        private void check_list()
        {
            bool found = false;
            string word = textBox_type_in.Text;

            // case sensitive
            if (checkBox_case_sensitive.Checked) 
            {
                for (int i = 0; i < words.Count(); i++)
                {
                    if (words[i] == word)
                    {
                        Console.WriteLine("Word found (case insensitive)");
                        label_check_status.Text = "Found!";
                        label_check_status.ForeColor = System.Drawing.Color.Green;
                        found = true;
                    }
                }
            }
            
            // case insensitive
            else
            {
                for (int i = 0; i < words.Count(); i++)
                {
                    if (words[i].ToLower() == word.ToLower())
                    {
                        Console.WriteLine("Word found (case insensitive)");
                        label_check_status.Text = "Found!";
                        label_check_status.ForeColor = System.Drawing.Color.Green;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Word not found");
                label_check_status.Text = "Not Found";
                label_check_status.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button_all_words_Click(object sender, EventArgs e)
        {
            if (!wordListForm.Visible)
            {
                wordListForm.listBox_word_list.DataSource = words;
                wordListForm.Show();
            }
            else
            {
                wordListForm.BringToFront();
            }
        }

        private void textBox_type_in_TextChanged(object sender, EventArgs e)
        {
            status_reset();
        }

        private void status_reset()
        {
            if (label_check_status.ForeColor != System.Drawing.Color.Black || label_check_status.Text != "Pending...")
            {
                label_check_status.ForeColor = System.Drawing.Color.Black;
                label_check_status.Text = "Pending...";
            }
        }
    }
}