using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Metiers
{
    /// <summary>
    /// Permet la création d'une classe Acteur
    /// </summary>
    public class Acteur
    {
        private string idActeur;
        private string nom;
        private string prenom;
        private string login;
        private string MDP;
        private int typeActeur;


        #region Setters
        /// <summary>
        /// Permet de modifier l'identifiant de l'acteur
        /// </summary>
        /// <param name="id">Int</param>
        private void setIdActeur(string id)
        {
            this.idActeur = id;
        }

        /// <summary>
        /// Permet de modifier le nom de l'acteur
        /// </summary>
        /// <param name="nom">String</param>
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Permet de modifier le prenom de l'acteur
        /// </summary>
        /// <param name="prenom">String</param>
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        /// <summary>
        /// Permet de modifier le login de l'acteur
        /// </summary>
        /// <param name="login">String</param>
        public void setLogin(string login)
        {
            this.login = login;
        }

        /// <summary>
        /// Permet de modifier le mot de passe de l'acteur
        /// </summary>
        /// <param name="MDP">string</param>
        public void setMDP(string MDP)
        {
            this.MDP = MDP;
        }

        /// <summary>
        /// Permet de modifier le type d'acteur qu'est cet acteur
        /// </summary>
        /// <param name="unTypeActeur">Int</param>
        private void setTypeActeur(int unTypeActeur)
        {
            this.typeActeur = unTypeActeur;
        }
        #endregion
        #region Getters
        /// <summary>
        /// Permet de récupérer l'identifiant de l'acteur
        /// </summary>
        /// <returns>String</returns>
        public string getIdActeur()
        {
            return this.idActeur;
        }
        /// <summary>
        /// Permet de récupérer le nom de l'acteur
        /// </summary>
        /// <returns>String</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Permet de récupérer le prenom de l'acteur
        /// </summary>
        /// <returns>String</returns>
        public string getPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// Permet de récupérer le login de l'acteur
        /// </summary>
        /// <returns>String</returns>
        public string getLogin()
        {
            return this.login;
        }

        /// <summary>
        /// Permet de récupérer le mot de passe de l'acteur
        /// </summary>
        /// <returns>String</returns>
        public string getMDP()
        {
            return this.MDP;
        }

        /// <summary>
        /// Permet de récupérer le type d'acteur qu'est l'acteur
        /// </summary>
        /// <returns>Int</returns>
        public int getTypeActeur()
        {
            return this.typeActeur;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Permet d'instancier un objet Acteur
        /// </summary>
        /// <param name="id">String</param>
        /// <param name="nom">String</param>
        /// <param name="prenom">String</param>
        /// <param name="login">String</param>
        /// <param name="MDP">String</param>
        /// <param name="typeActeur">Int</param>
        public Acteur(string id, string nom, string prenom, string login, string MDP, int typeActeur)
        {
            this.setIdActeur(id);
            this.setLogin(login);
            this.setNom(nom);
            this.setPrenom(prenom);
            this.setMDP(MDP);
            this.setTypeActeur(typeActeur);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Renvoie les informations relatives à l'acteur
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            string msg = this.getNom() + " " + this.getPrenom() + " (login : " + this.getLogin() + ").";
            return msg;
        }
        #endregion
        #region Encapsulation
        /// <summary>
        /// Permet d'afficher le nom de l'acteur, sert dans la vue "Affectation"
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
        /// Permet d'afficher le prénom de l'acteur, sert dans la vue "Affectation"
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
        /// Permet d'afficher le login de l'acteur, sert dans la vue "Affectation"
        /// </summary>
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        #endregion

    }
}
