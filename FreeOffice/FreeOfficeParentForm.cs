/*
    Programmeur:            Cesaire Aurelien Ngaleu, Raoul Buguem, Ola Zegai
    Date:                   Septembre 2019
    Solution:               FreeOffice.sln
    Projet:                 FreeOffice.csproj
    Classe:                 BlocNoteParentForm.cs

    But:                   Creation du d'un bloc note
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using em = freeOffice.FreeOfficeGenerale.MessErreurs;
using gen = freeOffice.FreeOfficeGenerale;

namespace freeOffice
{
    public partial class freeOfficeParentForm : Form
    {
        #region :Variables
        public static int nbNotes;
        #endregion

        #region :initialisation
        public freeOfficeParentForm()
        {
            InitializeComponent();
            InitImages();
        }

        private void InitImages()
        {
            fichierNouveauToolStripMenuItem.Image = nouveauToolStripButton.Image;
            ouvrirToolStripMenuItem.Image = ouvrirToolStripButton.Image;
            enregistrerSousToolStripMenuItem.Image = enregistrerToolStripButton.Image;
            imprimerToolStripMenuItem.Image = imprimerToolStripButton.Image;
            couperToolStripMenuItem.Image = couperToolStripButton.Image;
            copierToolStripMenuItem.Image = copierToolStripButton.Image;
            collerToolStripMenuItem.Image = collerToolStripButton.Image;
        }
        #endregion

        #region :Nouvelle Fenetre
        private void nouveauToolStripButton_Click(object sender, EventArgs e)
        {
            FreeOfficeEnfantForm note;
            nbNotes++;
            try
            {
                note = new FreeOfficeEnfantForm();
                note.MdiParent = this;
                note.Show();
                note.Text += nbNotes;

            }
            catch (Exception)
            {
                MessageBox.Show(em.EmInattendu.ToString());
            }
        }
        #endregion

        #region :Fermeture du formulaire
        private void FenetreMDILayout_Click(object sender, EventArgs e)
        {
            gen.RemoveChecks(fenetreToolStripMenuItem);
            ToolStripMenuItem oFormat;
            oFormat = sender as ToolStripMenuItem;
            oFormat.Checked = true;

            int positionInt = fenetreToolStripMenuItem.DropDownItems.IndexOf((ToolStripMenuItem)sender);
            this.LayoutMdi((MdiLayout)positionInt);
        }
        #endregion

        #region :Alligment Panneaux
        private void ToolStrip_ControlAdded(object sender, ControlEventArgs e)
        {
            if (sender == TopToolStripPanel || sender == BottomToolStripPanel)
            {
                if (e.Control == freeOfficeMenuStrip)
                {
                    toolStripPoliceComboBox.Visible = true;
                    freeOfficeMenuStrip.TextDirection = ToolStripTextDirection.Horizontal;
                    freeOfficeMenuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
                }
                else//barre d'outils
                {
                    freeOfficeMenuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                    toolStripPoliceComboBox.Visible = true;
                    toolStripTailleComboBox.Visible = true;
                }
            }
            else
            {
                if (e.Control == freeOfficeMenuStrip)
                {
                    toolStripPoliceComboBox.Visible = false;
                    freeOfficeMenuStrip.TextDirection = ToolStripTextDirection.Vertical270;
                    freeOfficeMenuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                }
                else
                {
                    freeOfficeMenuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                    toolStripPoliceComboBox.Visible = false;
                    toolStripTailleComboBox.Visible = false;
                }
            }
        }
        #endregion

        #region :Variables
        #endregion

        //private Boolean enregistrer;
                     
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void freeOfficeParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //au changement demander sauvegarde
        }

       

       

        private void style_Click(object sender, EventArgs e)
        {
            //Not
        }

        private void alignment_Click(object sender, EventArgs e)
        {

        }

        private void freeOfficeParentForm_MdiChildActivate(object sender, EventArgs e)
        {

        }
    }
}
