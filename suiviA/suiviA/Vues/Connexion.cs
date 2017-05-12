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
using ActiveDirectory;

namespace Vues
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private List<Cabinet> uneListeDeCabinet;
        private List<Acteur> uneListeDActeur;
        private List<Medecin> uneListeDeMedecin;

        private void Connexion_Load(object sender, EventArgs e)
        {
            // Instanciation des listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDActeur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // On passe cette variable à faux (false) lorsqu'on ne souhaite pas utiliser l'Active Directory (si on n'y a pas accès)
            Boolean utiliseAD = true;

            if (utiliseAD == false)
            {
                //////////////////////////////////////////////////
                //// TEST DE CONNEXION AVEC LA BDD //////////////
                ////////////////////////////////////////////////
                //Instanciation du résultat du test dans la BDD
                string resultatConnexion = PasserelleSuiviA.seConnecter(txtLogin.Text, txtMotDePasse.Text, false);
                // Test pour la connexion et la redirection vers la vue d'accueil correspondante
                if (resultatConnexion == "Visiteur")
                {
                    AccueilVisiteur AV = new AccueilVisiteur();
                    AV.Show();
                    this.Hide();
                }
                else
                {
                    if (resultatConnexion == "Autre")
                    {
                        AccueilUtilisateur AU = new AccueilUtilisateur();
                        AU.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMessageErreur.Text = "Le login ou le mot de passe est incorrect";
                        txtLogin.Text = "";
                        txtMotDePasse.Text = "";
                    }

                }

            }
            else
            {
                ///////////////////////////////////////////////
                ////   TEST DE CONNEXION AVEC L'AD     ///////
                /////////////////////////////////////////////
                string authentificationAD = ActiveDirectory.ConnexionActiveDirectory.authentification(txtLogin.Text, txtMotDePasse.Text);
                // Test pour la connexion et la redirection vers la vue d'accueil correspondante
                if (authentificationAD == "Visiteur")
                {
                    AccueilVisiteur AV = new AccueilVisiteur();
                    AV.Show();
                    this.Hide();
                }
                else
                {
                    if (authentificationAD == "Autre")
                    {
                        AccueilUtilisateur AU = new AccueilUtilisateur();
                        AU.Show();
                        this.Hide();
                    }

                    else
                    {
                        lblMessageErreur.Text = "Le login ou le mot de passe est incorrect";
                        txtLogin.Text = "";
                        txtMotDePasse.Text = "";
                    }
                }
            }
        }

        private void Connexion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(sender, e);
            }
        }
    }
}
