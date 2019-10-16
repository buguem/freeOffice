using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using em = freeOffice.FreeOfficeGenerale.MessErreurs;

namespace freeOffice
{
    class FreeOfficeGenerale
    {

        
        public enum MessErreurs
        {
            EmDocument,
            EmSauvegarde,
            EmInattendu
            
        }
        public static string[] MessagesErreurs = new string[3];
        private static void InitMessages()
        {
            MessagesErreurs[(int)em.EmDocument] = "impossible de creer un document.";
            MessagesErreurs[(int)em.EmSauvegarde] = "impossible de sauvegarder la note.";
            MessagesErreurs[(int)em.EmInattendu] = "Erreur inattendu.";

        }

        public static void RemoveChecks(ToolStripMenuItem menu)
        {
            if(menu != null )
            {
                //for(int i = 0; i < 4; i++)
                //{
                //    (menu.DropDownItems[i] as ToolStripMenuItem).Checked = false;
                //}
                foreach (ToolStripItem item in menu.DropDownItems)
                {
                    if (item is ToolStripMenuItem)
                        (item as ToolStripMenuItem).Checked = false;
                }

            }
        }
    }
}
