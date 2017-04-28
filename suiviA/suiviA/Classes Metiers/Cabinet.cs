using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMaps.LocationServices;

namespace Classes_Metiers
{
    /// <summary>
    /// Permet la création d'une classe Cabinet
    /// </summary>
    public class Cabinet
    {
        private int idCabinet;
        private string longitudeGPS;
        private string latitudeGPS;
        private string rue;
        private string ville;
        private string cp;



        #region Setters
        /// <summary>
        /// Permet de modifier l'identifiant du cabinet
        /// </summary>
        /// <param name="id">Int</param>
        public void setIdCabinet(int id)
        {
            this.idCabinet = id;
        }

        /// <summary>
        /// Permet de modifier l'emplacement du cabinet (sa longitude)
        /// </summary>
        /// <param name="longitudeGPS">String</param>
        public void setLongitute(string longitudeGPS)
        {
            this.longitudeGPS = longitudeGPS;
        }

        /// <summary>
        /// Permet de modifier l'emplacement du cabinet (sa latitude)
        /// </summary>
        /// <param name="latitudeGPS">String</param>
        public void setLatitude(string latitudeGPS)
        {
            this.latitudeGPS = latitudeGPS;
        }

        /// <summary>
        /// Permet de modifier la rue cabinet
        /// </summary>
        /// <param name="rue">String</param>
        public void setRue(string rue)
        {
            this.rue = rue;
        }

        /// <summary>
        /// Permet de modifier la ville cabinet
        /// </summary>
        /// <param name="ville">String</param>
        public void setVille(string ville)
        {
            this.ville = ville;
        }

        /// <summary>
        /// Permet de modifier le code postal cabinet
        /// </summary>
        /// <param name="cp">String</param>
        public void setCP(string cp)
        {
            this.cp = cp;
        }
        #endregion
        #region Getters
        /// <summary>
        /// Permet d'obtenir l'identifiant du cabinet
        /// </summary>
        /// <returns>Int</returns>
        public int getIdCabinet()
        {
            return this.idCabinet;
        }

        /// <summary>
        /// Permet d'obtenir les coordonnées GPS du cabinet (sa longitude)
        /// </summary>
        /// <returns>String</returns>
        public string getLongitudeGPS()
        {
            return this.longitudeGPS;
        }

        /// <summary>
        /// Permet d'obtenir les coordonnées GPS du cabinet (sa latitude)
        /// </summary>
        /// <returns>String</returns>
        public string getLatitudeGPS()
        {
            return this.latitudeGPS;
        }

        /// <summary>
        /// Permet d'obtenir la rue du cabinet
        /// </summary>
        /// <returns>String</returns>
        public string getRue()
        {
            return this.rue;
        }

        /// <summary>
        /// Permet d'obtenir le code postal du cabinet
        /// </summary>
        /// <returns>String</returns>
        public string getCP()
        {
            return this.cp;
        }

        /// <summary>
        /// Permet d'obtenir la ville du cabinet
        /// </summary>
        /// <returns>String</returns>
        public string getVille()
        {
            return this.ville;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Permet d'instancier un objet Cabinet
        /// </summary>
        /// <param name="id">Int</param>
        /// <param name="rue">String</param>
        /// <param name="ville">String</param>
        /// <param name="cp">String</param>
        public Cabinet(int id, string rue, string ville, string cp)
        {
            this.setIdCabinet(id);
            this.setLatitude(this.getLatitudeViaAPI(ville, rue));
            this.setLongitute(this.getLongitudeViaAPI(ville, rue));
            this.setRue(rue);
            this.setVille(ville);
            this.setCP(cp);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Permet de récupérer le numéro du département où se trouve le cabinet
        /// </summary>
        /// <returns>String</returns>
        public string getNumDepartement()
        {
            string numDepartement = null;

            numDepartement = this.getCP().Substring(0, 2);

            return numDepartement;
        }

        /// <summary>
        /// Renvoie les informations relatives au cabinet
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            string msg = "Adresse : " + this.getRue() + " " + this.getVille() + ", " + this.getCP() + ".";
            return msg;
        }

        /// <summary>
        /// Permet d'obtenir la latitude du cabinet
        /// </summary>
        /// <param name="laVilleDuCabinet">String</param>
        /// <param name="laRueDuCabinet">String</param>
        /// <returns>La latitude du cabinet (String) ou "erreur"</returns>
        public string getLatitudeViaAPI(string laVilleDuCabinet, string laRueDuCabinet)
        {
            try
            {
                // On déclare et initialise la variable qui nous permettra d'obtenir la latitude et la longitude
                var serviceDeLocalisation = new GoogleLocationService();
                // On créée la variable qui va contenir les coordonnées GPS du cabinet
                var lesPointsDeCoordonnees = serviceDeLocalisation.GetLatLongFromAddress(laRueDuCabinet + ", " + laVilleDuCabinet);

                // On récupère la latitude contenu dans la variable
                var laLatitude = lesPointsDeCoordonnees.Latitude;

                return laLatitude.ToString();
            }
            catch
            {
                return "Erreur";
            }
        }

        /// <summary>
        /// Permet d'obtenir la longitude du cabinet
        /// </summary>
        /// <param name="laVilleDuCabinet">String</param>
        /// <param name="laRueDuCabinet">String</param>
        /// <returns>La longitude du cabinet (String) ou "erreur"</returns>
        public string getLongitudeViaAPI(string laVilleDuCabinet, string laRueDuCabinet)
        {
            try
            {
                // On déclare et initialise la variable qui nous permettra d'obtenir la latitude et la longitude
                var serviceDeLocalisation = new GoogleLocationService();
                // On créée la variable qui va contenir les coordonnées GPS du cabinet
                var lesPointsDeCoordonnees = serviceDeLocalisation.GetLatLongFromAddress(laRueDuCabinet + ", " + laVilleDuCabinet);

                // On récupère la longitude contenu dans la variable
                var laLongitude = lesPointsDeCoordonnees.Longitude;

                return laLongitude.ToString();
            }
            catch
            {
                return "Erreur";
            }
        }
        #endregion
    }
}
