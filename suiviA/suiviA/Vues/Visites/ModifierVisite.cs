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
    public partial class ModifierVisite : Form
    {
        public ModifierVisite()
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
        private Visite laVisiteAModifier;


        private void ModifierVisite_Load(object sender, EventArgs e)
        {
            //Initialisation des listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            leVisiteurConnecte = PasserelleSuiviA.getActeurConnecte();
            uneListeDeVisite = PasserelleSuiviA.initListeVisite(leVisiteurConnecte.getIdActeur());
            laVisiteAModifier = PasserelleSuiviA.getVisiteAModifier();


            //Ajout des éléments dans le combobox Cabinet
            var bindingListCabinet = new BindingList<Cabinet>(uneListeDeCabinet);
            var sourceCabinet = new BindingSource(bindingListCabinet, null);
            cboxCabinet.DataSource = sourceCabinet;


            //Ajout des éléments dans le combobox Médecin
            var bindingListMedecin = new BindingList<Medecin>(uneListeDeMedecin);
            var sourceMedecin = new BindingSource(bindingListMedecin, null);
            cboxMedecin.DataSource = sourceMedecin;


            // Valeur par défaut du combobox correspondant au Cabinet de la Visite à modifier
            int positionCabinet = donnePositionCabinet(laVisiteAModifier.getLeMedecin().getLeCabinet());
            sourceCabinet.Position = positionCabinet;

            // Valeur par défaut du combobox correspondant au Médecin de la Visite à modifier
            int positionMedecin = donnePositionMedecin(laVisiteAModifier.getLeMedecin());
            sourceMedecin.Position = positionMedecin;


            // Valeur par défaut du choix du rendez-vous
            if (laVisiteAModifier.getEstVisiteProgramme())
                rdbtnOui.Checked = true;
            else
                rdbtnNon.Checked = true;

            // Valeur par défaut de l'heure d'arrivée
            txtHeureArrivee.Text = laVisiteAModifier.getHeureArriveeCabinet().Substring(0, 2);
            txtMinuteArrivee.Text = laVisiteAModifier.getHeureArriveeCabinet().Substring(3, 2);

            // Valeur par défaut de l'heure de début
            txtHeureDebut.Text = laVisiteAModifier.getHeureDebutEntretien().Substring(0, 2);
            txtMinuteDebut.Text = laVisiteAModifier.getHeureDebutEntretien().Substring(3, 2);

            // Valeur par défaut de l'heure de départ
            txtHeureDepart.Text = laVisiteAModifier.getHeureDepartCabinet().Substring(0, 2);
            txtMinuteDepart.Text = laVisiteAModifier.getHeureDepartCabinet().Substring(3, 2);

            // Valeur par défaut du calendrier
            calendrierDate.SetDate(laVisiteAModifier.getDateVisite());
        }

        /// <summary>
        /// Parcours les cabinets et retourne l'index du cabinet de la visite à modifier
        /// </summary>
        /// <param name="leCabinet"></param>
        /// <returns></returns>
        public int donnePositionCabinet(Cabinet leCabinet)
        {
            int position = -1;
            int i = 0;
            Boolean trouver = false;
            while(i < uneListeDeCabinet.Count && !trouver)
            {
                if (leCabinet.getIdCabinet() == uneListeDeCabinet[i].getIdCabinet())
                {
                    position = i;
                    trouver = true;
                }
                else
                    i++;
            }
            return position;
        }

        /// <summary>
        /// Parcours les médecin et retourne l'index du médecin de la visite à modifier
        /// </summary>
        /// <param name="leMedecin"></param>
        /// <returns></returns>
        public int donnePositionMedecin(Medecin leMedecin)
        {
            int position = -1;
            int i = 0;
            Boolean trouver = false;
            while (i < uneListeDeMedecin.Count && !trouver)
            {
                if (leMedecin.getIdMedecin() == uneListeDeMedecin[i].getIdMedecin())
                {
                    position = i;
                    trouver = true;
                }
                else
                    i++;
            }
            return position;
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

                //Mise à jour de l'objet visite et ajout en base de données 
                laVisiteAModifier.setDateVisite(calendrierDate.SelectionRange.Start);
                laVisiteAModifier.setEstVisiteProgramme(rdv);
                laVisiteAModifier.setHeureArriveeCabinet(heureArrivee);
                laVisiteAModifier.setHeureDebutEntretien(heureDebut);
                laVisiteAModifier.setHeureDepartCabinet(heureDepart);
                laVisiteAModifier.setMedecin((Medecin)cboxMedecin.SelectedItem);
                laVisiteAModifier.setActeur(leVisiteurConnecte);

                PasserelleSuiviA.metAJourVisite(laVisiteAModifier);

                MessageBox.Show("La Visite a été correctement modifiée.");

                this.Close();
            }
            else
                MessageBox.Show("Les heures saisies sont incorrectes.");
            
            
        }


        private void cboxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour des Medecin selon le cabinet sélectionné
            cabinetSelectionne = (Cabinet)cboxCabinet.SelectedItem;
            List<Medecin> uneListeDeMedecinsFiltres = new List<Medecin>();

            foreach (Medecin unMedecin in uneListeDeMedecin)
            {
                Cabinet cabinetDuMedecin = unMedecin.getLeCabinet();
                if (cabinetDuMedecin == cabinetSelectionne)
                    uneListeDeMedecinsFiltres.Add(unMedecin);
            }

            var bindingListMedecinFiltre = new BindingList<Medecin>(uneListeDeMedecinsFiltres);
            var sourceMedecinFiltre = new BindingSource(bindingListMedecinFiltre, null);
            cboxMedecin.DataSource = sourceMedecinFiltre;
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
