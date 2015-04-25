namespace dictionaryConsole
{
    partial class EditWord
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
            this.button_edit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_wordEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_edit
            // 
            this.button_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_edit.Location = new System.Drawing.Point(12, 43);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(158, 52);
            this.button_edit.TabIndex = 0;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancel.Location = new System.Drawing.Point(178, 43);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 52);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_wordEdit
            // 
            this.textBox_wordEdit.Location = new System.Drawing.Point(12, 12);
            this.textBox_wordEdit.Name = "textBox_wordEdit";
            this.textBox_wordEdit.Size = new System.Drawing.Size(324, 20);
            this.textBox_wordEdit.TabIndex = 2;
            this.textBox_wordEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_wordEdit_KeyPress);
            // 
            // EditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 107);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_wordEdit);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWord";
            this.Text = "EditWord";
            this.Load += new System.EventHandler(this.EditWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.TextBox textBox_wordEdit;
    }
}