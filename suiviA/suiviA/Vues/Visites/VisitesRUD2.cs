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

namespace Vues.Visites
{
    public partial class VisitesRUD2 : Form
    {
        public VisitesRUD2()
        {
            InitializeComponent();
        }

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private static List<Visite> uneListeDeVisite;
        private Acteur leVisiteurConnecte;
        private static List<Visite> visitesFiltrees;
        private Cabinet cabinetSelectionne;
        private String cpSelectionne;
        private String villeSelectionnee;
        private Visite visiteSelectionnee;

        private void VisitesRUD2_Load(object sender, EventArgs e)
        {
            // Initialisation des listes et de l'utilisateur en cours
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            leVisiteurConnecte = PasserelleSuiviA.getActeurConnecte();
            uneListeDeVisite = PasserelleSuiviA.initListeVisite(leVisiteurConnecte.getIdActeur());
            visitesFiltrees = uneListeDeVisite;

            //Ajout des éléments dans le combobox Code Postal
            foreach (Cabinet unCabinet in uneListeDeCabinet)
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

            //Ajout des éléments dans le combobox Visites
            foreach (Visite laVisite in uneListeDeVisite)
            {
                cboxVisites.Items.Add(laVisite);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Sauvegarde la visite pour la passer à la page des modifications
            PasserelleSuiviA.setVisiteAModifier((Visite)cboxVisites.SelectedItem);

            // Ouvre la page des modifications
            ModifierVisite MV = new ModifierVisite();
            MV.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Suppression de la visite sélectionnée
            PasserelleSuiviA.supprimerVisite((Visite)cboxVisites.SelectedItem);
            MessageBox.Show("La visite à bien été supprimée.");
            this.Close();
        }

        private void cboxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {

            cabinetSelectionne = (Cabinet)cboxCabinet.SelectedItem;

            // Mise à jour des visites selon le cabinet sélectionné
            cboxVisites.Items.Clear();
            // Remplir le combobox avec les visites fitrées
            foreach(Visite uneVisite in uneListeDeVisite)
            {
                Cabinet cabinetDeLaVisite = uneVisite.getLeMedecin().getLeCabinet();
                if (cabinetDeLaVisite == cabinetSelectionne)
                    cboxVisites.Items.Add(uneVisite);
            }


        }

        private void cboxCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpSelectionne = (String)cboxCP.SelectedItem;


            // Mise à jour des visites selon le Code Postal sélectionné
            cboxVisites.Items.Clear();
            // Remplir le combobox avec les visites fitrées
            foreach (Visite uneVisite in uneListeDeVisite)
            {
                String codePostalDeLaVisite = uneVisite.getLeMedecin().getLeCabinet().getCP();
                if (codePostalDeLaVisite == cpSelectionne)
                    cboxVisites.Items.Add(uneVisite);
            }
        }

        private void cboxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            villeSelectionnee = (String)cboxVille.SelectedItem;

            // Mise à jour des cabinets selon la ville
            cboxCabinet.Items.Clear();

            //Mise à jour des visites selon la ville sélectionné
            cboxVisites.Items.Clear();
            foreach (Visite uneVisite in uneListeDeVisite)
            {
                String villeDeLaVisite = uneVisite.getLeMedecin().getLeCabinet().getVille();
                if (villeDeLaVisite == villeSelectionnee)
                    cboxVisites.Items.Add(uneVisite);
            }
        }

        private void cboxVisites_SelectedIndexChanged(object sender, EventArgs e)
        {
            visiteSelectionnee = (Visite)cboxVisites.SelectedItem;

            //Affichage des informations de la visite dans les combobox
            txtDateVisite.Text = visiteSelectionnee.getDateVisite().ToShortDateString();
            txtHeureArrivee.Text = visiteSelectionnee.getHeureArriveeCabinet();
            txtHeureDebut.Text = visiteSelectionnee.getHeureDebutEntretien();
            txtHeureDepart.Text = visiteSelectionnee.getHeureDepartCabinet();
            txtMedecin.Text = visiteSelectionnee.getLeMedecin().ToString();

            if (visiteSelectionnee.getEstVisiteProgramme())
                txtVisiteProgrammee.Text = "Oui";
            else
                txtVisiteProgrammee.Text = "Non";

        }

        private void cboxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des visites selon le médecin sélectionné
            cboxVisites.Items.Clear();
            Medecin medecinSelectionne = (Medecin)cboxMedecin.SelectedItem;
            foreach (Visite uneVisite in uneListeDeVisite)
            {
                Medecin medecinDeLaVisite = uneVisite.getLeMedecin();
                if (medecinDeLaVisite == medecinSelectionne)
                    cboxVisites.Items.Add(uneVisite);
            }
        }


    }
}
