using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vues
{
    class FonctionsEtProcedures
    {
        /// <summary>
        /// ferme la feuille ouverte précdemment et ouvre la nouvelle feuille
        /// </summary>
        /// <param name="uneForm">la feuille à ouvrir</param>
        /// <param name="laFeuilleMDI">la feuille mdi dans laquelle doit être ouverte la feuille</param>

        //Pour créer une feuille MDI basculer à "true" dans les composants
        public static void OUVRE_UNE_MDI_FILLE(Form uneForm, Form laFeuilleMDI)
        {

            foreach (Form uneFeuille in laFeuilleMDI.MdiChildren)
                uneFeuille.Close(); // Ferme toute les autres feuilles


            uneForm.MdiParent = laFeuilleMDI; // Indique le parent
            uneForm.WindowState = FormWindowState.Maximized; // Pour ouvrir en plein écran
            uneForm.Show(); // Pour afficher la feuille
        }

        
    }
}
