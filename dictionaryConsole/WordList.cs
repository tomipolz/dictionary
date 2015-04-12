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
        public WordList()
        {
            InitializeComponent();
        }

        private void WordList_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Word list form launched");
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //I want to add a word to a list at Dictionary.cs
            //listBox_word_list.Items.Add(textBox_new_word.Text);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            //I want to remove a selected word from a list at Dictionary.cs
            //listBox_word_list.Items.Remove(listBox_word_list.SelectedIndex);
        }
    }
}
