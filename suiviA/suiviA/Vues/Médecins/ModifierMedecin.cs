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
    public partial class ModifierMedecin : Form
    {
        public ModifierMedecin()
        {
            InitializeComponent();
        }

        private List<Cabinet> uneListeDeCabinet;
        private List<Acteur> uneListeDeVisiteur;
        private List<Medecin> uneListeDeMedecin;
        private Medecin medecinAModifier;

        private void ModifierMedecin_Load(object sender, EventArgs e)
        {
            // Initialise les listes et le médecin à modifier
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            medecinAModifier = PasserelleSuiviA.getMedecinAModifier();

            //Met le nom et prénom du médecin à modifier par défaut
            txtNom.Text = medecinAModifier.getNom();
            txtPrenom.Text = medecinAModifier.getPrenom();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // test pour vérifier si les données saisies sont valides
            if(txtNom.Text != "" && txtPrenom.Text != "")
            {
                //Met à jour le médecin en base de données
                medecinAModifier.setNom(txtNom.Text);
                medecinAModifier.setPrenom(txtPrenom.Text);
                PasserelleSuiviA.metAJourMedecin(medecinAModifier);

                //Ferme la vue de création de médecin
                MessageBox.Show("Le médecin a été correctement modifié.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Les données saisies sont invalides.");
            }

            
        }

        
    }
}
