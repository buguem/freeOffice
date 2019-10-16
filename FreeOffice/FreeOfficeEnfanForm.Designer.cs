namespace freeOffice
{
    partial class FreeOfficeEnfantForm
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
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(489, 367);
            this.noteRichTextBox.TabIndex = 0;
            this.noteRichTextBox.Text = "";
            this.noteRichTextBox.SelectionChanged += new System.EventHandler(this.noteRichTextBox_SelectionChanged);
            // 
            // FreeOfficeEnfantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 367);
            this.Controls.Add(this.noteRichTextBox);
            this.Name = "FreeOfficeEnfantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "note";
            this.Load += new System.EventHandler(this.FreeOfficeEnfantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteRichTextBox;
    }
}