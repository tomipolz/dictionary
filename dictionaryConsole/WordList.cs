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
    public partial class WordList : Form
    {
        Dictionary dictionaryForm;

        public WordList(Dictionary dictionaryForm)
        {
            InitializeComponent();
            this.dictionaryForm = dictionaryForm;
        }

        private void WordList_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Word list form launched");
            listBox_word_list.DataSource = dictionaryForm.wordListClass.words;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //I want to add a word to a list at Dictionary.cs
            if (!isWordEmpty(textBox_new_word.Text))
            {
                addWordToList(textBox_new_word.Text);
            }
            else
            {
                MessageBox.Show("Please input a word to add and make sure it does not start with a space");
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

        private void addWordToList(string newWord)
        {
            Console.WriteLine("Adding word : " +newWord);
            bool sameWordFound = false;

            for (int j = 0; j < listBox_word_list.Items.Count; j++)
            {
                Console.WriteLine("Checking word index " + j.ToString());
                if (dictionaryForm.wordListClass.words[j] == newWord)
                {
                    listBox_word_list.SetSelected(j, true);
                    sameWordFound = true;
                    break;
                }
            }

            if (!sameWordFound)
            {
                dictionaryForm.wordListClass.words.Add(newWord);
                refresh_word_list();
                listBox_word_list.SetSelected(listBox_word_list.Items.IndexOf(newWord), true);
                Console.WriteLine("Word \"" + newWord + "\" has been added");
            }
            else
            {
                Console.WriteLine("Word \"" + newWord + "\" already exists");
                MessageBox.Show("Word: \"" + newWord + "\" already exists");
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            //I want to remove a selected word from a list at Dictionary.cs
            if (listBox_word_list.Items.Count != 0 && listBox_word_list.SelectedIndex != -1)
            {
                Console.WriteLine("Removing word \"" + dictionaryForm.wordListClass.words[listBox_word_list.SelectedIndex] + "\"");
                dictionaryForm.wordListClass.words.RemoveAt(listBox_word_list.SelectedIndex);
                refresh_word_list();
            }
        }

        private void refresh_word_list()
        {
            listBox_word_list.DataSource = null;
            listBox_word_list.DataSource = dictionaryForm.wordListClass.words;
            textBox_new_word.Clear();
        }

        private void textBox_new_word_KeyPress(object sender, KeyPressEventArgs e)
        {
            string word = textBox_new_word.Text;

            if (e.KeyChar == 13 && !isWordEmpty(word))
            {
                addWordToList(word);
            }
            else if (e.KeyChar == 27)
            {
                textBox_new_word.Clear();
            }
        }
    }
}
