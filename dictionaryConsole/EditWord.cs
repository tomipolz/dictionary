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
    public partial class EditWord : Form
    {
        WordList wordListForm;
        Dictionary dictionaryForm;

        int selectedIndex;
        string orginalText;

        public EditWord(WordList wordListForm, Dictionary dictionaryForm, int incomingSselectedIndex)
        {
            InitializeComponent();
            this.wordListForm = wordListForm;
            this.dictionaryForm = dictionaryForm;
            selectedIndex = incomingSselectedIndex;
        }

        private void textBox_wordEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                editCurrentItem(textBox_wordEdit.Text);
            }
            else if (e.KeyChar == 27)
            {
                textBox_wordEdit.Text = orginalText;
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(08) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            editCurrentItem(textBox_wordEdit.Text);
        }

        private void editCurrentItem(string text)
        {
            if (!dictionaryForm.isWordEmpty(text))
            {
                dictionaryForm.wordListClass.words[selectedIndex] = text;
                wordListForm.refresh_word_list();
                Console.WriteLine("Word \"" + orginalText + "\" has beed changed to \"" + text + "\"");
                this.Close();
            }
        }

        private void EditWord_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Word editor opened");
            orginalText = wordListForm.listBox_word_list.Items[selectedIndex].ToString();
            textBox_wordEdit.Text = orginalText;
        }
    }
}
