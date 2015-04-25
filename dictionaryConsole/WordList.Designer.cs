namespace dictionaryConsole
{
    partial class WordList
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
            this.listBox_word_list = new System.Windows.Forms.ListBox();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_new_word = new System.Windows.Forms.TextBox();
            this.button_addWord = new System.Windows.Forms.Button();
            this.button_removeWord = new System.Windows.Forms.Button();
            this.button_openFromFile = new System.Windows.Forms.Button();
            this.button_saveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_word_list
            // 
            this.listBox_word_list.FormattingEnabled = true;
            this.listBox_word_list.Location = new System.Drawing.Point(12, 12);
            this.listBox_word_list.Name = "listBox_word_list";
            this.listBox_word_list.Size = new System.Drawing.Size(299, 472);
            this.listBox_word_list.TabIndex = 0;
            this.listBox_word_list.DoubleClick += new System.EventHandler(this.listBox_word_list_DoubleClick);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(236, 516);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 52);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.close_button_Click);
            // 
            // textBox_new_word
            // 
            this.textBox_new_word.Location = new System.Drawing.Point(12, 490);
            this.textBox_new_word.Name = "textBox_new_word";
            this.textBox_new_word.Size = new System.Drawing.Size(299, 20);
            this.textBox_new_word.TabIndex = 2;
            this.textBox_new_word.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_new_word_KeyPress);
            // 
            // button_addWord
            // 
            this.button_addWord.Location = new System.Drawing.Point(12, 516);
            this.button_addWord.Name = "button_addWord";
            this.button_addWord.Size = new System.Drawing.Size(106, 23);
            this.button_addWord.TabIndex = 3;
            this.button_addWord.Text = "Add word";
            this.button_addWord.UseVisualStyleBackColor = true;
            this.button_addWord.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_removeWord
            // 
            this.button_removeWord.Location = new System.Drawing.Point(12, 545);
            this.button_removeWord.Name = "button_removeWord";
            this.button_removeWord.Size = new System.Drawing.Size(106, 23);
            this.button_removeWord.TabIndex = 4;
            this.button_removeWord.Text = "Remove word";
            this.button_removeWord.UseVisualStyleBackColor = true;
            this.button_removeWord.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_openFromFile
            // 
            this.button_openFromFile.Location = new System.Drawing.Point(124, 516);
            this.button_openFromFile.Name = "button_openFromFile";
            this.button_openFromFile.Size = new System.Drawing.Size(106, 23);
            this.button_openFromFile.TabIndex = 5;
            this.button_openFromFile.Text = "Open from file";
            this.button_openFromFile.UseVisualStyleBackColor = true;
            this.button_openFromFile.Click += new System.EventHandler(this.button_openFromFile_Click);
            // 
            // button_saveToFile
            // 
            this.button_saveToFile.Location = new System.Drawing.Point(124, 545);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(106, 23);
            this.button_saveToFile.TabIndex = 6;
            this.button_saveToFile.Text = "Save to file";
            this.button_saveToFile.UseVisualStyleBackColor = true;
            this.button_saveToFile.Click += new System.EventHandler(this.button_saveToFile_Click);
            // 
            // WordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 576);
            this.ControlBox = false;
            this.Controls.Add(this.button_saveToFile);
            this.Controls.Add(this.button_openFromFile);
            this.Controls.Add(this.button_removeWord);
            this.Controls.Add(this.button_addWord);
            this.Controls.Add(this.textBox_new_word);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.listBox_word_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordList";
            this.Text = "WordList";
            this.Load += new System.EventHandler(this.WordList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_word_list;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_new_word;
        private System.Windows.Forms.Button button_addWord;
        private System.Windows.Forms.Button button_removeWord;
        private System.Windows.Forms.Button button_openFromFile;
        private System.Windows.Forms.Button button_saveToFile;

    }
}