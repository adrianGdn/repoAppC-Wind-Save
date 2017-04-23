using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vues
{
    public partial class AccueilVisiteur : Form
    {
        public AccueilVisiteur()
        {
            InitializeComponent();
        }

        private void AccueilVisiteur_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitesCreer uneFeuille = new VisitesCreer();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void modifierLesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visites.VisitesRUD2 uneFeuille = new Visites.VisitesRUD2();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistiques uneFeuille = new Statistiques();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }
    }
}
