using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Metiers
{
    /// <summary>
    /// Permet la création d'une classe Medecin
    /// </summary>
    public class Medecin
    {
        private int idMedecin;
        private string nom;
        private string prenom;
        private Cabinet leCabinet;
        private Acteur lActeur;


        #region Setters
        /// <summary>
        /// Permet de modifier l'identifiant du médecin
        /// </summary>
        /// <param name="id">Int</param>
        public void setIdMedecin(int id)
        {
            this.idMedecin = id;
        }

        /// <summary>
        /// Permet de modifier le nom du médecin
        /// </summary>
        /// <param name="nom">String</param>
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Permet de modifier le prénom du médecin
        /// </summary>
        /// <param name="prenom">String</param>
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        /// <summary>
        /// Permet de modifier le cabinet du médecin
        /// </summary>
        /// <param name="leCabinet">Objet Cabinet</param>
        public void setCabinet(Cabinet leCabinet)
        {
            this.leCabinet = leCabinet;
        }

        /// <summary>
        /// Permet de modifier l'acteur assigné au médecin
        /// </summary>
        /// <param name="lActeur">Objet Acteur</param>
        public void setActeur(Acteur lActeur)
        {
            this.lActeur = lActeur;
        }
        #endregion
        #region Getters
        /// <summary>
        /// Permet de récupérer l'identifiant du médecin
        /// </summary>
        /// <returns>Int</returns>
        public int getIdMedecin()
        {
            return this.idMedecin;
        }

        /// <summary>
        /// Permet de récupérer le nom du médecin
        /// </summary>
        /// <returns>String</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Permet de récupérer le prénom du médecin
        /// </summary>
        /// <returns>String</returns>
        public string getPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// Permet de récupérer le cabinet assigné au médecin
        /// </summary>
        /// <returns>Objet Cabinet</returns>
        public Cabinet getLeCabinet()
        {
            return this.leCabinet;
        }

        /// <summary>
        /// Permet de récupérer l'acteur assigné au médecin
        /// </summary>
        /// <returns>Ojet Acteur</returns>
        public Acteur getLActeur()
        {
            return this.lActeur;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Permet d'instancier un objet Médecin
        /// </summary>
        /// <param name="id">Int</param>
        /// <param name="nom">String</param>
        /// <param name="prenom">String</param>
        /// <param name="unCabinet">Objet Cabinet</param>
        /// <param name="unActeur">Objet Acteur</param>
        public Medecin(int id, string nom, string prenom, Cabinet unCabinet, Acteur unActeur)
        {
            this.setIdMedecin(id);
            this.setNom(nom);
            this.setPrenom(prenom);
            this.setCabinet(unCabinet);
            this.setActeur(unActeur);
        }

        /// <summary>
        /// Permet d'instancier un objet Médecin sans lui assigner un acteur
        /// </summary>
        /// <param name="id">Int</param>
        /// <param name="nom">String</param>
        /// <param name="prenom">String</param>
        /// <param name="unCabinet">Objet Cabinet</param>
        public Medecin(int id, string nom, string prenom, Cabinet unCabinet)
        {
            this.setIdMedecin(id);
            this.setNom(nom);
            this.setPrenom(prenom);
            this.setCabinet(unCabinet);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Renvoie les informations relatives au médecin
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            string msg = this.getNom() + " " + this.getPrenom();
            return msg;
        }
        #endregion
        #region Encapsulation
        /// <summary>
        /// Permet d'afficher le nom du médecin, sert dans la vue "Affectation"
        /// </summary>
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        /// <summary>
        /// Permet d'afficher le prénom du médecin, sert dans la vue "Affectation"
        /// </summary>
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        /// <summary>
        /// Permet d'afficher l'objet cabinet, sert dans la vue "Affectation"
        /// </summary>
        public Cabinet LeCabinet
        {
            get
            {
                return leCabinet;
            }

            set
            {
                leCabinet = value;
            }
        }

        /// <summary>
        /// Permet d'afficher l'objet acteur, sert dans la vue "Affectation"
        /// </summary>
        public Acteur LActeur
        {
            get
            {
                return lActeur;
            }

            set
            {
                lActeur = value;
            }
        }

        #endregion
    }
}
