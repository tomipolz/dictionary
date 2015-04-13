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
        // had to use this again sorry guys...this allows me to access this form from child forms or objects...
        public static Dictionary dictionaryForm;

        public WordListClass wordListClass = new WordListClass();
        WordList wordListForm = new WordList();

        // stored inside wordListClass object
        //public List<String> words = new List<string> { "Hello", "Welcome", "Goodbye" };

        public Dictionary()
        {
            InitializeComponent();

            //...and this.
            dictionaryForm = this;
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
            checkList();
        }

        private void textBox_type_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusReset();
            if (e.KeyChar == 13)
            {
                checkList();
            }
            else if (e.KeyChar == 27)
            {
                textBox_type_in.Clear();
            }
        }

        private void button_all_words_Click(object sender, EventArgs e)
        {
            if (!wordListForm.Visible)
            {
                //wordListForm.listBox_word_list.DataSource = wordListClass.words;
                wordListForm.Show();
            }
            else
            {
                wordListForm.BringToFront();
            }
        }

        private void textBox_type_in_TextChanged(object sender, EventArgs e)
        {
            statusReset();
        }

        private void statusReset()
        {
            if (label_check_status.ForeColor != System.Drawing.Color.Black || label_check_status.Text != "Pending...")
            {
                label_check_status.ForeColor = System.Drawing.Color.Black;
                label_check_status.Text = "Pending...";
            }
        }

        private bool isWordEmpty(string newWord)
        {
            if (newWord == "" || newWord[0] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkList()
        {
            bool found = false;
            string word = textBox_type_in.Text;

            if (isWordEmpty(word))
            {
                MessageBox.Show("Please input a word to the text box and make sure it does not start with a space");
            }
            else
            {
                // case sensitive
                if (checkBox_case_sensitive.Checked)
                {
                    for (int i = 0; i < wordListClass.words.Count(); i++)
                    {
                        if (wordListClass.words[i] == word)
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
                    for (int i = 0; i < wordListClass.words.Count(); i++)
                    {
                        if (wordListClass.words[i].ToLower() == word.ToLower())
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
        }
    }
}