using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes_Metiers;
using Classe_Passerelle;

namespace Vues
{
    public partial class Affectation : Form
    {
        public Affectation()
        {
            InitializeComponent();
        }

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private Medecin medecinAModifier;
        private Acteur visiteurAAffecter;

        private void Affectation_Load(object sender, EventArgs e)
        {
            // Initialise les listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();


            //Rempli le DataGridView des visiteurs
            var bindingListVisiteurs = new BindingList<Acteur>(uneListeDeVisiteur);
            var sourceVisiteurs = new BindingSource(bindingListVisiteurs, null);
            dgvVisiteur.DataSource = sourceVisiteurs;

            //Rempli le DataGridView des Médecins
            var bindingListMedecins = new BindingList<Medecin>(uneListeDeMedecin);
            var sourceMedecins = new BindingSource(bindingListMedecins, null);
            dgvMedecin.DataSource = sourceMedecins;
        }


        private void btnAffecter_Click(object sender, EventArgs e)
        {
            medecinAModifier = (Medecin)dgvMedecin.SelectedRows[0].DataBoundItem;
            visiteurAAffecter = (Acteur)dgvVisiteur.SelectedRows[0].DataBoundItem;
            medecinAModifier.setActeur(visiteurAAffecter);

            PasserelleSuiviA.metAJourMedecinEtActeur(medecinAModifier);

            MessageBox.Show("Le médecin a bien été associé au visiteur.");
            this.Close();
        }
    }
}
