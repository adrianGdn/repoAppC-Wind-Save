using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vues.Cabinets;
using Vues.Médecins;

namespace Vues
{
    public partial class AccueilUtilisateur : Form
    {
        public AccueilUtilisateur()
        {
            InitializeComponent();
        }


        private void creerUnMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedecinCreer uneFeuille = new MedecinCreer();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void voirOuModifierUnMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedecinRU2 uneFeuille = new MedecinRU2();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void creerUnCabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabinetCreer uneFeuille = new CabinetCreer();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void voirOuModifierUnCabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabinetRU2 uneFeuille = new CabinetRU2();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void affecterUnVisiteurÀUnMédecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affectation uneFeuille = new Affectation();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistiques uneFeuille = new Statistiques();
            FonctionsEtProcedures.OUVRE_UNE_MDI_FILLE(uneFeuille, this);
        }

        private void AccueilUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
