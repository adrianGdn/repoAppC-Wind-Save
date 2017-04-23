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
    public partial class MedecinRU : Form
    {

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private String cpSelectionne;
        private String villeSelectionnee;

        public MedecinRU()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            PasserelleSuiviA.setMedecinAModifier((Medecin)dgvListeMedecin.SelectedRows[0].DataBoundItem);
            ModifierMedecin MM = new ModifierMedecin();
            MM.Show();

        }

        private void MedecinRU_Load(object sender, EventArgs e)
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

            //Ajout des éléments dans le combobox Cabinet
            foreach (Cabinet leCabinet in uneListeDeCabinet)
            {
                cboxCabinet.Items.Add(leCabinet);
            }

            //Rempli le DataGridView des visiteurs
            var bindingListVisiteurs = new BindingList<Acteur>(uneListeDeVisiteur);
            var sourceVisiteurs = new BindingSource(bindingListVisiteurs, null);
            dgvVisiteur.DataSource = sourceVisiteurs;

        }

        private void cboxCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des cabinets et des villes selon le code postal
            cpSelectionne = (String)cboxCP.SelectedItem;
            cboxCabinet.Items.Clear();
            cboxVille.Items.Clear();

            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                String codePostal = unCabinet.getNumDepartement();
                if (codePostal == cpSelectionne)
                    cboxCabinet.Items.Add(unCabinet);
            }

            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                String codePostal = unCabinet.getNumDepartement();
                if (codePostal == cpSelectionne)
                {
                    if (!cboxVille.Items.Contains(unCabinet.getVille()))
                    {
                        cboxVille.Items.Add(unCabinet.getVille());
                    }
                }
            }


        }

        private void cboxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des cabinets selon la ville
            villeSelectionnee = (String)cboxVille.SelectedItem;
            cboxCabinet.Items.Clear();

            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                String laVille = unCabinet.getVille();
                if (laVille == villeSelectionnee)
                    cboxCabinet.Items.Add(unCabinet);
            }

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Rempli le DataGridView des Médecins
            var bindingListMedecins = new BindingList<Medecin>(uneListeDeMedecin);
            var sourceMedecins = new BindingSource(bindingListMedecins, null);
            dgvListeMedecin.DataSource = sourceMedecins;
        }


    }
}
