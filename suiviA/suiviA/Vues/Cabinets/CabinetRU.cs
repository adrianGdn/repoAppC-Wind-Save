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

namespace Vues.Cabinets
{
    public partial class CabinetRU : Form
    {
        public CabinetRU()
        {
            InitializeComponent();
        }

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;

        private void btnModifier_Click(object sender, EventArgs e)
        {
            PasserelleSuiviA.setCabinetAModifier((Cabinet)dgvCabinet.SelectedRows[0].DataBoundItem);
            ModifierCabinet MC = new ModifierCabinet();
            MC.Show();
        }

        private void CabinetRU_Load(object sender, EventArgs e)
        {
            // Initialise les listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();

            // Met les éléments dans le cbox Ville
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                if (!cboxVille.Items.Contains(unCabinet.getVille()))
                {
                    cboxVille.Items.Add(unCabinet.getVille());
                }
            }

            //Ajout des éléments dans le combobox Code Postal
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                if (!cboxCP.Items.Contains(unCabinet.getNumDepartement()))
                {
                    cboxCP.Items.Add(unCabinet.getNumDepartement());
                }
            }

            //Rempli le DataGridView des Visiteurs associés
            var bindingListVisiteurs = new BindingList<Acteur>(uneListeDeVisiteur);
            var sourceVisiteurs = new BindingSource(bindingListVisiteurs, null);
            dgvVisiteur.DataSource = sourceVisiteurs;

            //Rempli le DataGridView des Médecins associés
            var bindingListMedecins = new BindingList<Medecin>(uneListeDeMedecin);
            var sourceMedecins = new BindingSource(bindingListMedecins, null);
            dgvMedecin.DataSource = sourceMedecins;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Rempli le DataGridView des Cabinets
            var bindingListCabinet = new BindingList<Cabinet>(uneListeDeCabinet);
            var sourceCabinet = new BindingSource(bindingListCabinet, null);
            dgvCabinet.DataSource = sourceCabinet;
        }
    }
}
