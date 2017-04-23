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
    public partial class MedecinCreer : Form
    {
        public MedecinCreer()
        {
            InitializeComponent();
        }

        private List<Cabinet> uneListeDeCabinet;
        private List<Acteur> uneListeDeVisiteur;
        private List<Medecin> uneListeDeMedecin;

        private void MedecinCreer_Load(object sender, EventArgs e)
        {
            // Initialise les listes et le visiteur
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();

            //Ajout des éléments dans le combobox Cabinet
            foreach (Cabinet leCabinet in uneListeDeCabinet)
            {
                cboxCabinet.Items.Add(leCabinet);
            }

            //Rempli le DataGridView des visiteurs
            var bindingListVisiteurs = new BindingList<Acteur>(uneListeDeVisiteur);
            var sourceVisiteurs = new BindingSource(bindingListVisiteurs, null);
            dgvVisiteur.DataSource = sourceVisiteurs;

            //Desactive le Datagridview de base
            dgvVisiteur.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // test pour voir si un cabinet a bien été sélectionné
            if (cboxCabinet.SelectedItem != null)
            {
                // Test pour voir si le nom a bien été saisis
                if(txtNom.Text != "")
                {
                    // test pour voir si le prénom a bien été saisis
                    if(txtPrenom.Text != "")
                    {
                        //Ajoute le médecin en base de données
                        PasserelleSuiviA.ajoutMedecinSansVisiteur(new Medecin(23, txtNom.Text, txtPrenom.Text, (Cabinet)cboxCabinet.SelectedItem));

                        //Ferme la vue de création de médecin
                        MessageBox.Show("Le médecin a été correctement créé.");
                        this.Close();
                    }

                }

            }
            else
            {
                // Message d'erreur si au moins une donnée est incorrecte
                MessageBox.Show("Les données saisies sont incorrectes.");
            }

                

        }

        private void btnAssocier_Click(object sender, EventArgs e)
        {
            // Active le datagridview pour associer un visiteur
            dgvVisiteur.Visible = true;
            lblVisiteur.Visible = true;

            //Change le bouton de validation
            btnValiderVisiteur.Visible = true;
            btnValider.Visible = false;
        }

        private void btnValiderVisiteur_Click(object sender, EventArgs e)
        {

            // test pour voir si un cabinet a bien été sélectionné
            if (cboxCabinet.SelectedItem != null)
            {
                // Test pour voir si le nom a bien été saisis
                if (txtNom.Text != "")
                {
                    // test pour voir si le prénom a bien été saisis
                    if (txtPrenom.Text != "")
                    {
                        //Ajoute le médecin en base de données
                        PasserelleSuiviA.ajoutMedecin(new Medecin(23, txtNom.Text, txtPrenom.Text, (Cabinet)cboxCabinet.SelectedItem, (Acteur)dgvVisiteur.SelectedRows[0].DataBoundItem));

                        //Ferme la vue de création de médecin
                        MessageBox.Show("Le médecin a été correctement créé.");
                        this.Close();
                    }

                }

            }
            else
            {
                MessageBox.Show("Les données saisies sont incorrectes.");
            }
                
        }
    }
}
