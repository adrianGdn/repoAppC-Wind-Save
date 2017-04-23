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
    public partial class VisitesCreer : Form
    {
        public VisitesCreer()
        {
            InitializeComponent();
        }

        private bool rdv = false;
        private string heureArrivee;
        private string heureDebut;
        private string heureDepart;
        private List<Cabinet> uneListeDeCabinet;
        private List<Acteur> uneListeDeVisiteur;
        private List<Medecin> uneListeDeMedecin;
        private List<Visite> uneListeDeVisite;
        private Acteur leVisiteurConnecte;
        private Cabinet cabinetSelectionne;

        private void VisitesCreer_Load(object sender, EventArgs e)
        {
            //Initialisation des listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            leVisiteurConnecte = PasserelleSuiviA.getActeurConnecte();
            uneListeDeVisite = PasserelleSuiviA.initListeVisite(leVisiteurConnecte.getIdActeur());


            //Ajout des éléments dans le combobox Cabinet
            foreach(Cabinet leCabinet in uneListeDeCabinet)
            {
                cboxCabinet.Items.Add(leCabinet);
            }

            //Ajout des éléments dans le combobox Médecin
            foreach (Medecin leMedecin in uneListeDeMedecin)
            {
                cboxMedecin.Items.Add(leMedecin);
            }

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifie que les textbox des heures ne sont pas vides, les remplis avec 00 si c'est le cas
            if (txtHeureArrivee.Text == "")
                txtHeureArrivee.Text = "00";
            if (txtMinuteArrivee.Text == "")
                txtMinuteArrivee.Text = "";
            if (txtHeureDebut.Text == "")
                txtHeureDebut.Text = "00";
            if (txtMinuteDebut.Text == "")
                txtMinuteDebut.Text = "00";
            if (txtHeureDepart.Text == "")
                txtHeureDepart.Text = "00";
            if (txtMinuteDepart.Text == "")
                txtMinuteDepart.Text = "00";


            //Vérification que le médecin est bien sélectionné
            if (cboxMedecin.SelectedItem != null)
            {
                //Vérification que l'heure est bonne
                if (heureBonne(txtHeureArrivee.Text) && minuteBonne(txtMinuteArrivee.Text) && heureBonne(txtHeureDebut.Text) && minuteBonne(txtMinuteDebut.Text) && heureBonne(txtHeureDepart.Text) && minuteBonne(txtMinuteDepart.Text))
                {
                    //Boolean si la visite était sur rendez-vous
                    rdv = rdbtnOui.Checked;

                    //Mise en string de l'heure d'arrivée
                    heureArrivee = txtHeureArrivee.Text + "h" + txtMinuteArrivee.Text;

                    //Mise en string de l'heure de début
                    heureDebut = txtHeureDebut.Text + "h" + txtMinuteDebut.Text;

                    //Mise en string de l'heure de départ
                    heureDepart = txtHeureDepart.Text + "h" + txtMinuteDepart.Text;

                    //Création de l'objet visite et ajout en base de données 
                    // L'id de la visite est un int par défaut car il n'est jamais envoyé en base de données
                    Visite nouvelleVisite = new Visite(2342, calendrierDate.SelectionRange.Start, rdv, heureArrivee, heureDebut, heureDepart, (Medecin)cboxMedecin.SelectedItem, leVisiteurConnecte);
                    PasserelleSuiviA.ajoutVisiste(nouvelleVisite);

                    MessageBox.Show("La Visite a été correctement créée.");

                    this.Close();
                }
                else
                    MessageBox.Show("Les heures saisies sont incorrectes.");


            }

            else
                MessageBox.Show("Vous devez sélectionner un médecin.");


        }
        

        private void cboxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des Medecin selon le cabinet sélectionné
            cabinetSelectionne = (Cabinet)cboxCabinet.SelectedItem;

            //Vider le combobox des médecins
            cboxMedecin.Items.Clear();

            foreach (Medecin unMedecin in uneListeDeMedecin)
            {
                Cabinet cabinetDuMedecin = unMedecin.getLeCabinet();
                if (cabinetDuMedecin == cabinetSelectionne)
                    cboxMedecin.Items.Add(unMedecin);
            }
        }

        private void cboxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Empêcher l'utilisateur de mettre des caractères autres que 0-9 dans les heures et les minutes
        #region limitationCaractereHeure
        private void txtHeureArrivee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinuteArrivee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHeureDebut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinuteDebut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHeureDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinuteDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        /// <summary>
        /// Vérifie que l'heure saisie soit bien entre 0 et 23
        /// </summary>
        /// <param name="textboxTemps"></param>
        /// <returns>Boolean</returns>
        private bool heureBonne(string textboxTemps)
        {
            bool resultat = false;

            if (int.Parse(textboxTemps) >= 0 && int.Parse(textboxTemps) <= 23)
                resultat = true;

            return resultat;
        }

        /// <summary>
        /// Vérifie que la minute saisie soit bien entre 0 et 59
        /// </summary>
        /// <param name="textboxTemps"></param>
        /// <returns>Boolean</returns>
        private static bool minuteBonne(string textboxTemps)
        {
            bool resultat = false;

            if (int.Parse(textboxTemps) >= 0 && int.Parse(textboxTemps) <= 59)
                resultat = true;

            return resultat;
        }
    }
}
