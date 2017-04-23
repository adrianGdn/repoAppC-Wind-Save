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
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private static List<Visite> uneListeDeVisites;
        private Acteur leVisiteurConnecte;

        private void Statistiques_Load(object sender, EventArgs e)
        {
            // Initialise les listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();
            leVisiteurConnecte = PasserelleSuiviA.getActeurConnecte();

            if(leVisiteurConnecte.getTypeActeur() != 2)
                uneListeDeVisites = PasserelleSuiviA.initListeVisiteSansActeur();
            else
                uneListeDeVisites = PasserelleSuiviA.initListeVisite(leVisiteurConnecte.getIdActeur());

            // rempli le combobox du Médecin
            foreach (Medecin leMedecin in uneListeDeMedecin)
            {
                cboxMedecin.Items.Add(leMedecin);
            }

            // Renvoie le nombre total de visites
            txtNbrVisitesTotal.Text = uneListeDeVisites.Count.ToString();

           
        }

        private void cboxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Renvoie le nombre de visites pour le médecin sélectionné
            int nbrVisiteMedecin = 0;
            foreach(Visite uneVisite in uneListeDeVisites)
            {
                if ((Medecin)cboxMedecin.SelectedItem == uneVisite.getLeMedecin())
                    nbrVisiteMedecin++;
            }
            txtNbrVisitesMedecin.Text = nbrVisiteMedecin.ToString();
        }

        private void calendrierTempsVisite_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Affiche le nombre de visites qui ont eu lieu lors du jour sélectionné
            int nbrVisiteJour = 0;
            foreach (Visite uneVisite in uneListeDeVisites)
            {
                if (calendrierTempsVisite.SelectionRange.Start == uneVisite.getDateVisite())
                    nbrVisiteJour++;

            }
            txtNbrVisiteJour.Text = nbrVisiteJour.ToString();

            // Affiche le temps passé en visite lors du jour sélectionné
            int jour = calendrierTempsVisite.SelectionRange.Start.Day;
            int mois = calendrierTempsVisite.SelectionRange.Start.Month;
            int annee = calendrierTempsVisite.SelectionRange.Start.Year;
            DateTime heureDebut;
            DateTime heureFin;
            TimeSpan tempsTotal = new TimeSpan();

            foreach (Visite uneVisite in uneListeDeVisites)
            {
                if (calendrierTempsVisite.SelectionRange.Start == uneVisite.getDateVisite())
                {
                    heureDebut = new DateTime(annee,mois,jour,int.Parse(uneVisite.getHeureArriveeCabinet().Substring(0,2)), int.Parse(uneVisite.getHeureArriveeCabinet().Substring(3, 2)), 0);
                    heureFin = new DateTime(annee, mois, jour, int.Parse(uneVisite.getHeureDepartCabinet().Substring(0, 2)), int.Parse(uneVisite.getHeureDepartCabinet().Substring(3, 2)), 0);
                    tempsTotal += heureFin.Subtract(heureDebut);
                }

            }
            txtTempsParJour.Text = tempsTotal.ToString();


        }
    }
}
