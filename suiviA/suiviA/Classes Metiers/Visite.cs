using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Contient les classes Cabinet, Médecin, Visite et Acteur
/// </summary>
namespace Classes_Metiers
{
    /// <summary>
    /// Permet la création d'une classe Visite
    /// </summary>
    public class Visite
    {
        private int idVisite;
        private DateTime dateVisite;
        private Boolean estVisiteProgramme;
        private string heureArriveeCabinet;
        private string heureDebutEntretien;
        private string heureDepartCabinet;
        private Medecin leMedecin;
        private Acteur lActeur;

        
        #region Encapsulation
        public DateTime DateVisite
        {
            get
            {
                return dateVisite;
            }

            set
            {
                dateVisite = value;
            }
        }

        public bool EstVisiteProgramme
        {
            get
            {
                return estVisiteProgramme;
            }

            set
            {
                estVisiteProgramme = value;
            }
        }

        public string HeureArriveeCabinet
        {
            get
            {
                return heureArriveeCabinet;
            }

            set
            {
                heureArriveeCabinet = value;
            }
        }

        public string HeureDebutEntretien
        {
            get
            {
                return heureDebutEntretien;
            }

            set
            {
                heureDebutEntretien = value;
            }
        }

        public string HeureDepartCabinet
        {
            get
            {
                return heureDepartCabinet;
            }

            set
            {
                heureDepartCabinet = value;
            }
        }

        public Medecin LeMedecin
        {
            get
            {
                return leMedecin;
            }

            set
            {
                leMedecin = value;
            }
        }
        #endregion
        #region Setters
        /// <summary>
        /// Permet de modifier l'identifiant d'une visite
        /// </summary>
        /// <param name="id">Int</param>
        public void setIdVisite(int id)
        {
            this.idVisite = id;
        }

        /// <summary>
        /// Permet de modifier la date d'une visite
        /// </summary>
        /// <param name="dateVisite">DateTime</param>
        public void setDateVisite(DateTime dateVisite)
        {
            this.dateVisite = dateVisite;
        }

        /// <summary>
        /// Permet de modifier le fait que la visite est été ou non programmé
        /// </summary>
        /// <param name="estVisiteProgramme">Boolean</param>
        public void setEstVisiteProgramme(Boolean estVisiteProgramme)
        {
            this.estVisiteProgramme = estVisiteProgramme;
        }

        /// <summary>
        /// Permet de modifier l'heure d'arrivée de la visite
        /// </summary>
        /// <param name="heureArriveCabinet">String</param>
        public void setHeureArriveeCabinet(string heureArriveCabinet)
        {
            this.heureArriveeCabinet = heureArriveCabinet;
        }

        /// <summary>
        /// Permet de modifier l'heure de début d'entretient de la visite
        /// </summary>
        /// <param name="heureDebutEntretien">String</param>
        public void setHeureDebutEntretien(string heureDebutEntretien)
        {
            this.heureDebutEntretien = heureDebutEntretien;
        }

        /// <summary>
        /// Permet de modifier l'heure de départ de l'acteur du cabinet
        /// </summary>
        /// <param name="heureDepartCabinet">String</param>
        public void setHeureDepartCabinet(string heureDepartCabinet)
        {
            this.heureDepartCabinet = heureDepartCabinet;
        }

        /// <summary>
        /// Permet de modifier le médecin associé à une visite
        /// </summary>
        /// <param name="unMedecin">Objet Medecin</param>
        public void setMedecin(Medecin unMedecin)
        {
            this.leMedecin = unMedecin;
        }

        /// <summary>
        /// Permet de modifier de l'acteur associé à une visite
        /// </summary>
        /// <param name="unActeur">Objet Acteur</param>
        public void setActeur(Acteur unActeur)
        {
            this.lActeur = unActeur;
        }
        #endregion
        #region Getters
        /// <summary>
        /// Permet d'obtenir l'identifiant de la visite
        /// </summary>
        /// <returns>Int</returns>
        public int getIdVisite()
        {
            return this.idVisite;
        }

        /// <summary>
        /// Permet d'obtenir la date de visite
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime getDateVisite()
        {
            return this.dateVisite;
        }

        /// <summary>
        /// Permet de savoir si la visite était programmé ou non
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean getEstVisiteProgramme()
        {
            return this.estVisiteProgramme;
        }

        /// <summary>
        /// Permet d'obtenir l'heure d'arrivée de l'acteur dans le cabinet
        /// </summary>
        /// <returns>String</returns>
        public string getHeureArriveeCabinet()
        {
            return this.heureArriveeCabinet;
        }

        /// <summary>
        /// Permet d'obtenir l'heure de début d'entretien de l'acteur avec le médecin
        /// </summary>
        /// <returns>String</returns>
        public string getHeureDebutEntretien()
        {
            return this.heureDebutEntretien;
        }

        /// <summary>
        /// Permet d'obtenir l'heure de départ de l'acteur du cabinet
        /// </summary>
        /// <returns>String</returns>
        public string getHeureDepartCabinet()
        {
            return this.heureDepartCabinet;
        }

        /// <summary>
        /// Permet de récupérer le médecin associé à la visite
        /// </summary>
        /// <returns>Objet Medecin</returns>
        public Medecin getLeMedecin()
        {
            return this.leMedecin;
        }

        /// <summary>
        /// Permet de récupérer l'acteur associé à la visite
        /// </summary>
        /// <returns>Objet Acteur</returns>
        public Acteur getLActeur()
        {
            return this.lActeur;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Permet d'instanticier un objet Visite
        /// </summary>
        /// <param name="idVisite">Int</param>
        /// <param name="dateVisite">DateTime</param>
        /// <param name="estVisiteProgramme">Boolean</param>
        /// <param name="heureArriveeCabinet">String</param>
        /// <param name="heureDebutEntretien">String</param>
        /// <param name="heureDepartCabinet">String</param>
        /// <param name="unMedecin">Objet Medecin</param>
        /// <param name="unActeur">Objet Acteur</param>
        public Visite(int idVisite, DateTime dateVisite, Boolean estVisiteProgramme, string heureArriveeCabinet, string heureDebutEntretien, string heureDepartCabinet, Medecin unMedecin, Acteur unActeur)
        {
            this.setIdVisite(idVisite);
            this.setDateVisite(dateVisite);
            this.setEstVisiteProgramme(estVisiteProgramme);
            this.setHeureArriveeCabinet(heureArriveeCabinet);
            this.setHeureDebutEntretien(heureDebutEntretien);
            this.setHeureDepartCabinet(heureDepartCabinet);
            this.setMedecin(unMedecin);
            this.setActeur(unActeur);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Renvoie les informations relatives à la visite
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            string msg = this.getIdVisite().ToString() + " - " + "Médecin : " + this.getLeMedecin().getNom() + ", Visiteur : " + this.getLActeur().getNom() + ", Date : " + this.getDateVisite().ToShortDateString();
            return msg;
        }
        #endregion
    }
}
