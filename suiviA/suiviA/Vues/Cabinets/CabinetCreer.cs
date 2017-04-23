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
    public partial class CabinetCreer : Form
    {
        public CabinetCreer()
        {
            InitializeComponent();
        }

        private List<Cabinet> uneListeDeCabinet;
        private List<Acteur> uneListeDeVisiteur;
        private List<Medecin> uneListeDeMedecin;
        private Cabinet cabinetATester;

        private void CabinetCreer_Load(object sender, EventArgs e)
        {
            // Initialise les listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
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
                    // Ajout du cabinet en base de données
                    PasserelleSuiviA.ajoutCabinet(cabinetATester);

                    MessageBox.Show("Le cabinet a été créé.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Veuillez saisir un code postal.");

            
            
        }
    }
}
