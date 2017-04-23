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
    public partial class ModifierCabinet : Form
    {
        public ModifierCabinet()
        {
            InitializeComponent();
        }

        private List<Cabinet> uneListeDeCabinet;
        private List<Acteur> uneListeDeVisiteur;
        private List<Medecin> uneListeDeMedecin;
        private Cabinet leCabinetAModifier;
        private Cabinet cabinetATester;

        private void ModifierCabinet_Load(object sender, EventArgs e)
        {
            // Initialise les listes et le cabinet
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            leCabinetAModifier = PasserelleSuiviA.getCabinetAModifier();

            // Met l'adresse du cabinet par défaut
            txtAdresse.Text = leCabinetAModifier.getRue();

            // Met le code postal par défaut
            txtCodePostal.Text = leCabinetAModifier.getCP();

            // Met la ville par défaut
            txtVille.Text = leCabinetAModifier.getVille();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Test si le code postal a été saisit
            if (txtCodePostal.Text != "")
            {
                //Test de l'adresse du cabinet, vérification que la longitude et lattitude sont bonnes
                cabinetATester = new Cabinet(1, txtAdresse.Text, txtVille.Text, txtCodePostal.Text);
                if (cabinetATester.getLatitudeGPS() == "Erreur" || cabinetATester.getLongitudeGPS() == "Erreur")
                {
                    MessageBox.Show("L'adresse saisie est incorrecte, veuillez saisir une adresse valide.");
                }
                else
                {
                    // Modification des attributs avant d'envoyer en bdd
                    leCabinetAModifier.setCP(txtCodePostal.Text);
                    leCabinetAModifier.setRue(txtAdresse.Text);
                    leCabinetAModifier.setVille(txtVille.Text);

                    // Envoie du cabinet modifié en bdd
                    PasserelleSuiviA.metAJourCabinet(leCabinetAModifier);

                    MessageBox.Show("Le cabinet à été modifié.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Veuillez saisir un code postal.");

        }
    }
}
