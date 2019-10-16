using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace freeOffice
{
    public partial class FreeOfficeEnfantForm : Form
    {
        public FreeOfficeEnfantForm()
        {
            InitializeComponent();
        }

        private void FreeOfficeEnfantForm_Load(object sender, EventArgs e)
        {

        }

        private void noteRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            freeOfficeParentForm parent = this.MdiParent as freeOfficeParentForm;
            if(this.noteRichTextBox.SelectionFont != null) 
            {                     
                parent.boldToolStripButton.Checked = noteRichTextBox.SelectionFont.Bold;
                parent.italicToolStripButton.Checked = noteRichTextBox.SelectionFont.Italic;
                parent.underlineToolStripButton.Checked = noteRichTextBox.SelectionFont.Underline;                
            }
        }
    }
}
