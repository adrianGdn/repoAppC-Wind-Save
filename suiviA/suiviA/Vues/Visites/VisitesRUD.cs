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
    public partial class VisitesRUD : Form
    {
        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private static List<Visite> uneListeDeVisite;
        private Acteur leVisiteurConnecte;
        private static List<Visite> visitesFiltrees;
        private Cabinet cabinetSelectionne;
        private String cpSelectionne;
        private String villeSelectionnee;


        public VisitesRUD()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Sauvegarde la visite pour la passer à la page des modifications
            PasserelleSuiviA.setVisiteAModifier((Visite)dgvListeVisites.SelectedRows[0].DataBoundItem);

            // Ouvre la page des modifications
            ModifierVisite MV = new ModifierVisite();
            MV.Show();
        }

        private void VisitesRUD_Load(object sender, EventArgs e)
        {
            // Initialisation des listes et de l'utilisateur en cours
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            leVisiteurConnecte = PasserelleSuiviA.getActeurConnecte();
            uneListeDeVisite = PasserelleSuiviA.initListeVisite(leVisiteurConnecte.getIdActeur());
            visitesFiltrees = uneListeDeVisite;


            //Ajout des éléments dans le combobox Code Postal
            foreach(Cabinet unCabinet in uneListeDeCabinet)
            {
                if (!cboxCP.Items.Contains(unCabinet.getNumDepartement()))
                {
                    cboxCP.Items.Add(unCabinet.getNumDepartement());
                }
            }


            //Ajout des éléments dans le combobox Ville
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                if (!cboxVille.Items.Contains(unCabinet.getVille()))
                {
                    cboxVille.Items.Add(unCabinet.getVille());
                }
            }

            //Ajout des éléments dans le combobox Cabinet
            foreach (Cabinet leCabinet in uneListeDeCabinet)
            {
                cboxCabinet.Items.Add(leCabinet);
            }

            //Ajout des éléments dans le combobox Médecin
            foreach (Medecin leMedecin in uneListeDeMedecin)
            {
                cboxMedecin.Items.Add(leMedecin);
            }



            ////Rempli le DataGridView
            //var bindingList = new BindingList<Visite>(visitesFiltrees);
            //var source = new BindingSource(bindingList, null);
            //dgvListeVisites.DataSource = source;

            //Rempli le DataGridView
            BindingSource sourceVisite = new BindingSource();
            sourceVisite.DataSource = visitesFiltrees;
            dgvListeVisites.DataSource = sourceVisite;

        }

        private void lblRegion_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Suppression de la visite sélectionnée
            PasserelleSuiviA.supprimerVisite((Visite)dgvListeVisites.SelectedRows[0].DataBoundItem);
            MessageBox.Show("La visite à bien été supprimée.");
            this.Close();
        }

        private void cboxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des Medecin selon le cabinet sélectionné
            cabinetSelectionne = (Cabinet)cboxCabinet.SelectedItem;

            //Vider le combobox des médecins
            cboxMedecin.Items.Clear();

            //Remplir le combobox avec les médecins filtrés
            foreach (Medecin unMedecin in uneListeDeMedecin)
            {
                Cabinet cabinetDuMedecin = unMedecin.getLeCabinet();
                if (cabinetDuMedecin == cabinetSelectionne)
                    cboxMedecin.Items.Add(unMedecin);
            }
        }

        private void cboxCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des cabinets selon le code postal
            cpSelectionne = (String)cboxCP.SelectedItem;
            cboxCabinet.Items.Clear();

            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                String codePostal = unCabinet.getNumDepartement();
                if (codePostal == cpSelectionne)
                    cboxCabinet.Items.Add(unCabinet);
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

        private void cboxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource sourceVisite = new BindingSource();
            sourceVisite.DataSource = visitesFiltrees;
            sourceVisite.Filter = dgvListeVisites.Columns[5].HeaderText.ToString() + " LIKE '%" + cboxMedecin.SelectedItem.ToString() + "%'";
            dgvListeVisites.DataSource = sourceVisite;
        }
    }
 }

