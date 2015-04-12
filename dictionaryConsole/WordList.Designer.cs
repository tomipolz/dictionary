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
            this.button_hide = new System.Windows.Forms.Button();
            this.textBox_new_word = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_word_list
            // 
            this.listBox_word_list.FormattingEnabled = true;
            this.listBox_word_list.Location = new System.Drawing.Point(12, 12);
            this.listBox_word_list.Name = "listBox_word_list";
            this.listBox_word_list.Size = new System.Drawing.Size(299, 472);
            this.listBox_word_list.TabIndex = 0;
            // 
            // button_hide
            // 
            this.button_hide.Location = new System.Drawing.Point(236, 516);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(75, 52);
            this.button_hide.TabIndex = 1;
            this.button_hide.Text = "Hide";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // textBox_new_word
            // 
            this.textBox_new_word.Location = new System.Drawing.Point(12, 490);
            this.textBox_new_word.Name = "textBox_new_word";
            this.textBox_new_word.Size = new System.Drawing.Size(299, 20);
            this.textBox_new_word.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 516);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(12, 545);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // WordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 576);
            this.ControlBox = false;
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_new_word);
            this.Controls.Add(this.button_hide);
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
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.TextBox textBox_new_word;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;

    }
}