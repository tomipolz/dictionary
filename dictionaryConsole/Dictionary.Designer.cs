namespace dictionaryConsole
{
    partial class Dictionary
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
            this.button_allWords = new System.Windows.Forms.Button();
            this.textBox_type_in = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_type_in_info = new System.Windows.Forms.Label();
            this.label_check_status = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.checkBox_case_sensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_allWords
            // 
            this.button_allWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_allWords.Location = new System.Drawing.Point(12, 320);
            this.button_allWords.Name = "button_allWords";
            this.button_allWords.Size = new System.Drawing.Size(105, 23);
            this.button_allWords.TabIndex = 6;
            this.button_allWords.Text = "Show all words";
            this.button_allWords.UseVisualStyleBackColor = true;
            this.button_allWords.Click += new System.EventHandler(this.button_all_words_Click);
            // 
            // textBox_type_in
            // 
            this.textBox_type_in.Location = new System.Drawing.Point(55, 60);
            this.textBox_type_in.Name = "textBox_type_in";
            this.textBox_type_in.Size = new System.Drawing.Size(323, 20);
            this.textBox_type_in.TabIndex = 2;
            this.textBox_type_in.TextChanged += new System.EventHandler(this.textBox_type_in_TextChanged);
            this.textBox_type_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_type_in_KeyPress);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(55, 87);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label_type_in_info
            // 
            this.label_type_in_info.AutoSize = true;
            this.label_type_in_info.Location = new System.Drawing.Point(55, 41);
            this.label_type_in_info.Name = "label_type_in_info";
            this.label_type_in_info.Size = new System.Drawing.Size(235, 13);
            this.label_type_in_info.TabIndex = 1;
            this.label_type_in_info.Text = "Please enter in a word and click \"Check\" button";
            // 
            // label_check_status
            // 
            this.label_check_status.AutoSize = true;
            this.label_check_status.Location = new System.Drawing.Point(136, 92);
            this.label_check_status.Name = "label_check_status";
            this.label_check_status.Size = new System.Drawing.Size(55, 13);
            this.label_check_status.TabIndex = 4;
            this.label_check_status.Text = "Pending...";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(359, 320);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // checkBox_case_sensitive
            // 
            this.checkBox_case_sensitive.AutoSize = true;
            this.checkBox_case_sensitive.Location = new System.Drawing.Point(298, 86);
            this.checkBox_case_sensitive.Name = "checkBox_case_sensitive";
            this.checkBox_case_sensitive.Size = new System.Drawing.Size(94, 17);
            this.checkBox_case_sensitive.TabIndex = 5;
            this.checkBox_case_sensitive.Text = "Case sensitive";
            this.checkBox_case_sensitive.UseVisualStyleBackColor = true;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 355);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_case_sensitive);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_check_status);
            this.Controls.Add(this.label_type_in_info);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.textBox_type_in);
            this.Controls.Add(this.button_allWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_allWords;
        private System.Windows.Forms.TextBox textBox_type_in;
        private System.Windows.Forms.Button button_check;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_type_in_info;
        private System.Windows.Forms.Label label_check_status;
        private System.Windows.Forms.CheckBox checkBox_case_sensitive;
        public System.Windows.Forms.Button button_close;
    }
}