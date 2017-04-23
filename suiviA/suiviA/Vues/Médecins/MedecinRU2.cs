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

namespace Vues.Médecins
{
    public partial class MedecinRU2 : Form
    {
        public MedecinRU2()
        {
            InitializeComponent();
        }

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private String cpSelectionne;
        private String villeSelectionnee;
        private Cabinet cabinetSelectionne;
        private Acteur visiteurSelectionne;

        private void MedecinRU2_Load(object sender, EventArgs e)
        {
            // Initialise les listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();

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

            //Ajout des éléments dans le combobox Visiteur
            foreach (Acteur leVisiteur in uneListeDeVisiteur)
            {
                cboxVisiteur.Items.Add(leVisiteur);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            PasserelleSuiviA.setMedecinAModifier((Medecin)cboxMedecin.SelectedItem);
            ModifierMedecin MM = new ModifierMedecin();
            MM.Show();
        }

        private void cboxCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpSelectionne = (String)cboxCP.SelectedItem;

            //Filtre des médecins selon le code postal sélectionné
            cboxMedecin.Items.Clear();
            // Remplir le combobox avec les médecins filtrés
            foreach(Medecin unMedecin in uneListeDeMedecin)
            {
                String cpDuMedecin = unMedecin.getLeCabinet().getCP();
                if (cpDuMedecin == cpSelectionne)
                    cboxMedecin.Items.Add(unMedecin);
            }
        }

        private void cboxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            villeSelectionnee = (String)cboxVille.SelectedItem;
            //Filtre des médecins selon la ville sélectionnée
            cboxMedecin.Items.Clear();
            // Remplir le combobox avec les médecins filtrés
            foreach (Medecin unMedecin in uneListeDeMedecin)
            {
                String villeDuMedecin = unMedecin.getLeCabinet().getVille();
                if (villeDuMedecin == villeSelectionnee)
                    cboxMedecin.Items.Add(unMedecin);
            }

        }

        private void cboxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cabinetSelectionne = (Cabinet)cboxCabinet.SelectedItem;
            //Filtre des médecins selon le cabinet sélectionnée
            cboxMedecin.Items.Clear();
            // Remplir le combobox avec les médecins filtrés
            foreach (Medecin unMedecin in uneListeDeMedecin)
            {
                Cabinet cabinetDuMedecin = unMedecin.getLeCabinet();
                if (cabinetDuMedecin == cabinetSelectionne)
                    cboxMedecin.Items.Add(unMedecin);
            }
        }

        private void cboxVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            visiteurSelectionne = (Acteur)cboxVisiteur.SelectedItem;
            //Filtre des médecins selon le cabinet sélectionnée
            cboxMedecin.Items.Clear();
            // Remplir le combobox avec les médecins filtrés
            foreach (Medecin unMedecin in uneListeDeMedecin)
            {
                Acteur visiteurDuMedecin = unMedecin.getLActeur();
                if (visiteurDuMedecin == visiteurSelectionne)
                    cboxMedecin.Items.Add(unMedecin);
            }
        }

        private void cboxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medecin medecinSelectionne = (Medecin)cboxMedecin.SelectedItem;
            txtCabinet.Text = medecinSelectionne.getLeCabinet().ToString();
            txtVisiteur.Text = medecinSelectionne.getLActeur().ToString();
            txtNom.Text = medecinSelectionne.getNom();
            txtPrenom.Text = medecinSelectionne.getPrenom();
        }
    }
}
