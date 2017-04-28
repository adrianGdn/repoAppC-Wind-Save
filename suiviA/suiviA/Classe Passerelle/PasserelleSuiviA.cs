using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using Classes_Metiers;
using System.Security.Cryptography;

namespace Classe_Passerelle
{
    /// <summary>
    /// Classe servant de lien entre la base de données et l'application
    /// </summary>
    public static class PasserelleSuiviA
    {
        private static string connectionString = "SERVER=localhost; DATABASE=gsbapplifrais; UID=root; PASSWORD=";
        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDActeur;
        private static List<Medecin> uneListeDeMedecin;
        private static List<Visite> uneListeDeVisite;
        private static Acteur acteurConnecte = null;
        private static Visite visiteAModifier = null;
        private static Medecin medecinAModifier = null;
        private static Cabinet cabinetAModifier = null;

        #region Methods
        #region Remplit Listes
        /// <summary>
        /// Permet de récupérer tous les cabinets présents en base de données
        /// </summary>
        private static void remplitListeCabinetViaBDD()
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                String uneRequete = "SELECT * FROM `cabinet`;";
                MySqlCommand maCommande = new MySqlCommand(uneRequete, maConnection);
                // Exécution de la requête
                MySqlDataReader reader = maCommande.ExecuteReader();


                // Initialisation d'un objet Cabinet, qui remplira la liste
                Cabinet unCabinet;
                // Permet de remplir la liste avec tout les cabinets présents en base de données
                while (reader.Read())
                {
                    // Création du cabinet et saisi de ses paramètres
                    unCabinet = new Cabinet(reader.GetInt32("id"), reader.GetString("rue"), reader.GetString("ville"), reader.GetString("cp"));

                    // On intègre le cabinet à la liste
                    uneListeDeCabinet.Add(unCabinet);
                }



                // Fermeture de la connection
                maConnection.Close();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de récupérer tous les acteurs présents en base de données
        /// </summary>
        private static void remplitListeActeurViaBDD()
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                String uneRequete = "SELECT * FROM `acteur`;";
                MySqlCommand maCommande = new MySqlCommand(uneRequete, maConnection);
                // Exécution de la requête
                MySqlDataReader reader = maCommande.ExecuteReader();


                // Initialisation d'un objet Acteur, qui remplira la liste
                Acteur unActeur;
                // Permet de remplir la liste avec tout les acteurs présents en base de données
                while (reader.Read())
                {
                    // Création de l'acteur et saisi de ses paramètres
                    unActeur = new Acteur(reader.GetString("id"), reader.GetString("nom"), reader.GetString("prenom"), reader.GetString("login"), reader.GetString("mdp"), reader.GetInt32("idTypeActeur"));

                    // On intègre l'acteur à la liste
                    uneListeDActeur.Add(unActeur);
                }


                // Fermeture de la connection
                maConnection.Close();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de récupérer tous les médecins présents en base de données
        /// </summary>
        private static void remplitListeMedecinViaBDD()
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                String uneRequete = "SELECT * FROM `medecin`;";
                MySqlCommand maCommande = new MySqlCommand(uneRequete, maConnection);
                // Exécution de la requête
                MySqlDataReader reader = maCommande.ExecuteReader();


                // Initialisation d'un objet Medecin, qui remplira la liste
                Medecin unMedecin;
                Cabinet leCabinetMedecin;
                string idActeur;
                int idCabinet;

                // Ces variables seront utilisées afin de récupérer un objet d'une liste
                int compteur;
                Boolean vraiFaux;
                Acteur lActeurPourTest;

                // Permet de remplir la liste avec tout les médecins présent en base de données
                while (reader.Read())
                {
                    // Remise à zéro ou instanciation des variables
                    compteur = 0;
                    vraiFaux = false;

                    // On essaye de récupérer l'identifiant de l'acteur associé au médecin, sinon, on indique que la variable est nulle
                    try
                    {
                        // Ces variables vont servir à retrouver l'objet (Acteur et Cabinet) qui sera associé au médecin
                        idActeur = reader.GetString("idActeur");
                    }
                    catch
                    {
                        idActeur = null;
                    }
                    idCabinet = reader.GetInt32("idCabinet");

                    // Objet sencé être forcément remplacer
                    leCabinetMedecin = null;

                    // On cherche ici à récupérer le cabinet associé au médecin
                    while (vraiFaux == false && compteur <= uneListeDeCabinet.Count())
                    {
                        if (uneListeDeCabinet[compteur].getIdCabinet() == idCabinet)
                        {
                            leCabinetMedecin = uneListeDeCabinet[compteur];
                            vraiFaux = true;
                        }
                        compteur++;
                    }

                    if (idActeur != null)
                    {
                        // Réinitialisation des variables
                        compteur = 0;
                        vraiFaux = false;

                        // Objet sencé être forcément remplacer
                        lActeurPourTest = null;
                        
                        // On cherche ici à récupérer l'acteur associé au médecin s'il y a un acteur d'associé
                        while (vraiFaux == false && compteur <= uneListeDActeur.Count())
                        {
                            if (uneListeDActeur[compteur].getIdActeur() == idActeur)
                            {
                                lActeurPourTest = uneListeDActeur[compteur];
                                vraiFaux = true;
                            }
                            compteur++;
                        }

                        // Cas où il y a un acteur associé au médecin
                        // Création du médecin et saisi de ses paramètres
                        unMedecin = new Medecin(reader.GetInt32("id"), reader.GetString("nom"), reader.GetString("prenom"), leCabinetMedecin, lActeurPourTest);

                        // On intègre le médecin à la liste
                        uneListeDeMedecin.Add(unMedecin);
                        
                    }
                    else
                    {
                        // Cas où il n'y a pas d'acteur associé au médecin
                        // Création du médecin et saisi de ses paramètres
                        unMedecin = new Medecin(reader.GetInt32("id"), reader.GetString("nom"), reader.GetString("prenom"), leCabinetMedecin);

                        // On intègre le médecin à la liste
                        uneListeDeMedecin.Add(unMedecin);
                    }
                }


                // Fermeture de la connection
                maConnection.Close();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de récupérer toutes les visites présentes en base de données
        /// </summary>
        private static void remplitListeVisiteViaBDD(string idActeur)
        { // on a besoin que des visites des visiteurs connecté
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                String uneRequete = "SELECT * FROM `visite` WHERE `idActeur`=@idActeur;";
                maCommande = new MySqlCommand(uneRequete, maConnection);
                maCommande.Parameters.AddWithValue("@idActeur", idActeur);
                // Exécution de la requête
                MySqlDataReader reader = maCommande.ExecuteReader();


                // Initialisation d'un objet Visite, qui remplira la liste
                Visite uneVisite;
                // Déclaration d'un objet "DateTime" pour pouvoir l'utiliser lors de la création d'un objet Visite
                DateTime laDateDeVisite;
                // Déclaration des variables nécessaire à l'association entre les médecins et les acteurs par rapport à la visite
                int compteur = 0;
                Boolean vraiFaux = false;
                Medecin leMedecinDeLaVisite = null;
                int idMedecin;
                Acteur lActeurDeLaVisiste = null;

                
                // On cherche ici à récupérer l'acteur associé à la visite selon la liste déjà présente dans l'application
                while (vraiFaux == false && compteur <= uneListeDActeur.Count())
                {
                    if (uneListeDActeur[compteur].getIdActeur() == idActeur)
                    {
                        lActeurDeLaVisiste = uneListeDActeur[compteur];
                        vraiFaux = true;
                    }
                    compteur++;
                }


                // Permet de remplir la liste avec toutes les visites présentes en base de données
                while (reader.Read())
                {
                    compteur = 0;
                    vraiFaux = false;

                    // On récupère les identifiants du médecin et du acteur associé à cet visite en base de données
                    idMedecin = reader.GetInt32("idMedecin");

                    // On cherche ici à récupérer le médecin associé à la visite selon la liste déjà présente dans l'application
                    while (vraiFaux == false && compteur <= uneListeDeMedecin.Count())
                    {
                        if (uneListeDeMedecin[compteur].getIdMedecin() == idMedecin)
                        {
                            leMedecinDeLaVisite = uneListeDeMedecin[compteur];
                            vraiFaux = true;
                        }
                        compteur++;
                    }



                    //  On récupère la date de la visite associé à cette visite
                    laDateDeVisite = (DateTime)reader.GetMySqlDateTime("dateVisite");
                    
                    // Création d'une visite et saisi de ses paramètres
                    uneVisite = new Visite(reader.GetInt32("id"), laDateDeVisite, reader.GetBoolean("estVisiteProgramme"), reader.GetString("heureArriveeCabinet"), reader.GetString("heureDebutEntretien"), reader.GetString("heureDepartCabinet"), leMedecinDeLaVisite, lActeurDeLaVisiste);

                    // On intègre le cabinet à la liste
                    uneListeDeVisite.Add(uneVisite);
                }


                // Fermeture de la connection
                maConnection.Close();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de récupérer toutes les visites présentes en base de données
        /// </summary>
        private static void remplitListeVisiteViaBDDSansActeur()
        { // on a besoin que des visites des visiteurs connecté
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                String uneRequete = "SELECT * FROM `visite`;";
                maCommande = new MySqlCommand(uneRequete, maConnection);
                // Exécution de la requête
                MySqlDataReader reader = maCommande.ExecuteReader();


                // Initialisation d'un objet Visite, qui remplira la liste
                Visite uneVisite;
                // Déclaration d'un objet "DateTime" pour pouvoir l'utiliser lors de la création d'un objet Visite
                DateTime laDateDeVisite;
                // Déclaration des variables nécessaire à l'association entre les médecins et les acteurs par rapport à la visite
                int compteur = 0;
                Boolean vraiFaux = false;
                Medecin leMedecinDeLaVisite = null;
                int idMedecin;
                Acteur lActeurDeLaVisiste = null;


                // Permet de remplir la liste avec toutes les visites présentes en base de données
                while (reader.Read())
                {
                    compteur = 0;
                    vraiFaux = false;

                    // On récupère les identifiants du médecin et du acteur associé à cet visite en base de données
                    idMedecin = reader.GetInt32("idMedecin");

                    // On cherche ici à récupérer le médecin associé à la visite selon la liste déjà présente dans l'application
                    while (vraiFaux == false && compteur <= uneListeDeMedecin.Count())
                    {
                        if (uneListeDeMedecin[compteur].getIdMedecin() == idMedecin)
                        {
                            leMedecinDeLaVisite = uneListeDeMedecin[compteur];
                            vraiFaux = true;
                        }
                        compteur++;
                    }



                    //  On récupère la date de la visite associé à cette visite
                    laDateDeVisite = (DateTime)reader.GetMySqlDateTime("dateVisite");

                    // Création d'une visite et saisi de ses paramètres
                    uneVisite = new Visite(reader.GetInt32("id"), laDateDeVisite, reader.GetBoolean("estVisiteProgramme"), reader.GetString("heureArriveeCabinet"), reader.GetString("heureDebutEntretien"), reader.GetString("heureDepartCabinet"), leMedecinDeLaVisite, lActeurDeLaVisiste);

                    // On intègre le cabinet à la liste
                    uneListeDeVisite.Add(uneVisite);
                }


                // Fermeture de la connection
                maConnection.Close();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }
        #endregion
        #region Read
        /// <summary>
        /// Permet de charger une liste contenant les cabinets présents en base de données
        /// </summary>
        /// <returns>Liste d'objets Cabinet</returns>
        public static List<Cabinet> initListeCabinet()
        {
            uneListeDeCabinet = new List<Cabinet>();

            remplitListeCabinetViaBDD();

            return uneListeDeCabinet;
        }

        /// <summary>
        /// Permet de charger une liste contenant les acteurs présents en base de données
        /// </summary>
        /// <returns>Liste d'objets Acteur</returns>
        public static List<Acteur> initListeActeur()
        {
            uneListeDActeur = new List<Acteur>();

            remplitListeActeurViaBDD();

            return uneListeDActeur;
        }

        /// <summary>
        /// Permet de charger une liste contenant les médecins présents en base de données
        /// </summary>
        /// <returns>Liste d'objets Medecin</returns>
        public static List<Medecin> initListeMedecin()
        {
            uneListeDeMedecin = new List<Medecin>();

            remplitListeMedecinViaBDD();

            return uneListeDeMedecin;
        }

        /// <summary>
        /// Permet de charger une liste contenant les visites présents en base de données
        /// </summary>
        /// <param name="idActeur">String</param>
        /// <returns>Liste d'objets Visite</returns>
        public static List<Visite> initListeVisite(string idActeur)
        {
            uneListeDeVisite = new List<Visite>();

            remplitListeVisiteViaBDD(idActeur);

            return uneListeDeVisite;
        }

        /// <summary>
        /// Permet de charger une liste contenant les visites présents en base de données
        /// </summary>
        /// <returns>Liste d'objets Visite</returns>
        public static List<Visite> initListeVisiteSansActeur()
        {
            uneListeDeVisite = new List<Visite>();

            remplitListeVisiteViaBDDSansActeur();

            return uneListeDeVisite;
        }
        #endregion
        #region Create
        /// <summary>
        /// Permet d'insérer un objet Cabinet en base de données
        /// </summary>
        /// <param name="unCabinet">Un objet Cabinet</param>
        public static void ajoutCabinet(Cabinet unCabinet)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                maCommande.CommandText = "INSERT INTO `cabinet`(`longitudeGPS`, `latitudeGPS`, `cp`, `ville`, `rue`) VALUES (@longitudeGPS, @latitudeGPS, @cp, @ville, @rue);";
                // On associe les attributs de l'objet passé en paramètre à ceux de la requête
                maCommande.Parameters.AddWithValue("@longitudeGPS", unCabinet.getLongitudeGPS());
                maCommande.Parameters.AddWithValue("@latitudeGPS", unCabinet.getLatitudeGPS());
                maCommande.Parameters.AddWithValue("@cp", unCabinet.getCP());
                maCommande.Parameters.AddWithValue("@ville", unCabinet.getVille());
                maCommande.Parameters.AddWithValue("@rue", unCabinet.getRue());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                maCommande.Clone();


                // On se synchronise avec la BDD
                PasserelleSuiviA.initListeCabinet();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet d'insérer un objet Medecin en base de données
        /// </summary>
        /// <param name="unMedecin">Un objet Medecin</param>
        public static void ajoutMedecin(Medecin unMedecin)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                maCommande.CommandText = "INSERT INTO `medecin`(`nom`, `prenom`, `idCabinet`, `idActeur`) VALUES (@nom, @prenom, @idCabinet, @idActeur);";
                // On associe les attributs de l'objet passé en paramètre à ceux de la requête
                maCommande.Parameters.AddWithValue("@nom", unMedecin.getNom());
                maCommande.Parameters.AddWithValue("@prenom", unMedecin.getPrenom());
                maCommande.Parameters.AddWithValue("@idCabinet", unMedecin.getLeCabinet().getIdCabinet());
                maCommande.Parameters.AddWithValue("@idActeur", unMedecin.getLActeur().getIdActeur());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                maCommande.Clone();


                // On se synchronise avec la BDD
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet d'insérer un objet Medecin sans visiteur en base de données
        /// </summary>
        /// <param name="unMedecin">Un objet Medecin</param>
        public static void ajoutMedecinSansVisiteur(Medecin unMedecin)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                maCommande.CommandText = "INSERT INTO `medecin`(`nom`, `prenom`, `idCabinet`) VALUES (@nom, @prenom, @idCabinet);";
                // On associe les attributs de l'objet passé en paramètre à ceux de la requête
                maCommande.Parameters.AddWithValue("@nom", unMedecin.getNom());
                maCommande.Parameters.AddWithValue("@prenom", unMedecin.getPrenom());
                maCommande.Parameters.AddWithValue("@idCabinet", unMedecin.getLeCabinet().getIdCabinet());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                maCommande.Clone();


                // On se synchronise avec la BDD
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet d'insérer un objet Visite en base de données
        /// </summary>
        /// <param name="uneVisite">Un objet Visite</param>
        public static void ajoutVisiste(Visite uneVisite)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                maCommande.CommandText = "INSERT INTO `visite`(`dateVisite`, `estVisiteProgramme`, `heureArriveeCabinet`, `heureDebutEntretien`, `heureDepartCabinet`, `idMedecin`, `idActeur`) VALUES (@dateVisite, @estVisiteProgramme, @heureArriveeCabinet, @heureDebutEntretien, @heureDepartCabinet, @idMedecin, @idActeur);";
                // On associe les attributs de l'objet passé en paramètre à ceux de la requête
                maCommande.Parameters.AddWithValue("@dateVisite", uneVisite.getDateVisite());
                maCommande.Parameters.AddWithValue("@estVisiteProgramme", uneVisite.getEstVisiteProgramme());
                maCommande.Parameters.AddWithValue("@heureArriveeCabinet", uneVisite.getHeureArriveeCabinet());
                maCommande.Parameters.AddWithValue("@heureDebutEntretien", uneVisite.getHeureDebutEntretien());
                maCommande.Parameters.AddWithValue("@heureDepartCabinet", uneVisite.getHeureDepartCabinet());
                maCommande.Parameters.AddWithValue("@idMedecin", uneVisite.getLeMedecin().getIdMedecin());
                maCommande.Parameters.AddWithValue("@idActeur", uneVisite.getLActeur().getIdActeur());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                maCommande.Clone();


                // On se synchronise avec la BDD
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
                PasserelleSuiviA.initListeVisite(uneVisite.getLActeur().getIdActeur());
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }
        #endregion
        #region Delete
        /// <summary>
        /// Permet de supprimer une visite de la base de données
        /// </summary>
        /// <param name="uneVisite">Un objet Visite</param>
        public static void supprimerVisite(Visite uneVisite)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();


                // On se sert de l'objet passé en paramètre pour supprimer le bon champs
                maCommande.CommandText = "DELETE FROM `visite` WHERE `id` = @idVisite;";
                maCommande.Parameters.AddWithValue("@idVisite", uneVisite.getIdVisite());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();


                // On ve se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
                PasserelleSuiviA.initListeVisite(uneVisite.getLActeur().getIdActeur());
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de supprimer une visite de la base de données
        /// Méthode utilisé seulement dans les tests pour éviter de se retrouver avec des médecins factice
        /// </summary>
        /// <param name="unMedecin">Un objet Medecin</param>
        public static void supprimerMedecin(Medecin unMedecin)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();


                // On se sert de l'objet passé en paramètre pour supprimer le bon champs
                maCommande.CommandText = "DELETE FROM `medecin` WHERE `id` = @idMedecin;";
                maCommande.Parameters.AddWithValue("@idMedecin", unMedecin.getIdMedecin());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();


                // On ve se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de supprimer un cabinet de la base de données
        /// Méthode utilisé seulement dans les tests pour éviter de se retrouver avec des cabinets factice
        /// </summary>
        /// <param name="unCabinet">Un objet Cabinet</param>
        public static void supprimerCabinet(Cabinet unCabinet)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();


                // On se sert de l'objet passé en paramètre pour supprimer le bon champs
                maCommande.CommandText = "DELETE FROM `cabinet` WHERE `id` = @idCabinet;";
                maCommande.Parameters.AddWithValue("@idCabinet", unCabinet.getIdCabinet());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();


                // On ve se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }
        #endregion
        #region Update
        /// <summary>
        /// Permet de mettre à jour un cabinet présent en base de données
        /// </summary>
        /// <param name="unCabinet">Un objet Cabinet</param>
        public static void metAJourCabinet(Cabinet unCabinet)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();


                // On se sert de l'objet passé en paramètre pour modifier plusieurs champs
                maCommande.CommandText = "UPDATE `cabinet` SET `cp`=@cp,`ville`=@ville,`rue`=@rue WHERE `id` = @idCabinet;";
                maCommande.Parameters.AddWithValue("@idCabinet", unCabinet.getIdCabinet());
                maCommande.Parameters.AddWithValue("@cp", unCabinet.getCP());
                maCommande.Parameters.AddWithValue("@ville", unCabinet.getVille());
                maCommande.Parameters.AddWithValue("@rue", unCabinet.getRue());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();

                                
                // On va se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de mettre à jour un médecin présent en base de données
        /// </summary>
        /// <param name="unMedecin">Un objet Medecin</param>
        public static void metAJourMedecin(Medecin unMedecin)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();


                // On se sert de l'objet passé en paramètre pour modifier plusieurs champs
                maCommande.CommandText = "UPDATE `medecin` SET `nom`=@nom,`prenom`=@prenom WHERE `id` = @idMedecin;";
                maCommande.Parameters.AddWithValue("@idMedecin", unMedecin.getIdMedecin());
                maCommande.Parameters.AddWithValue("@nom", unMedecin.getNom());
                maCommande.Parameters.AddWithValue("@prenom", unMedecin.getPrenom());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();


                // On va se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de mettre à jour un médecin et son visiteur présent en base de données
        /// </summary>
        /// <param name="unMedecin">Un objet Medecin</param>
        public static void metAJourMedecinEtActeur(Medecin unMedecin)
        {
            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();


                // On se sert de l'objet passé en paramètre pour modifier plusieurs champs
                maCommande.CommandText = "UPDATE `medecin` SET `nom`=@nom,`prenom`=@prenom, `idActeur`=@idActeur WHERE `id` = @idMedecin;";
                maCommande.Parameters.AddWithValue("@idMedecin", unMedecin.getIdMedecin());
                maCommande.Parameters.AddWithValue("@nom", unMedecin.getNom());
                maCommande.Parameters.AddWithValue("@prenom", unMedecin.getPrenom());
                maCommande.Parameters.AddWithValue("@idActeur", unMedecin.getLActeur().getIdActeur());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();


                // On va se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }

        /// <summary>
        /// Permet de mettre à jour une visite présente en base de données
        /// </summary>
        /// <param name="uneVisite">Un objet Visite</param>
        public static void metAJourVisite(Visite uneVisite)
        {

            try
            {
                // Ouverture de la connection
                MySqlConnection maConnection = new MySqlConnection(connectionString);
                maConnection.Open();


                // Création de la requête
                MySqlCommand maCommande = maConnection.CreateCommand();
                

                // On se sert de l'objet passé en paramètre pour modifier plusieurs champs
                maCommande.CommandText = "UPDATE `visite` SET `dateVisite`=@dateVisite,`estVisiteProgramme`=@estVisiteProgramme,`heureArriveeCabinet`=@heureArriveeCabinet,`heureDebutEntretien`=@heureDebutEntretien,`heureDepartCabinet`=@heureDepartCabinet WHERE `id` = @idVisite;";
                maCommande.Parameters.AddWithValue("@idVisite", uneVisite.getIdVisite());
                maCommande.Parameters.AddWithValue("@dateVisite", uneVisite.getDateVisite());
                maCommande.Parameters.AddWithValue("@estVisiteProgramme", uneVisite.getEstVisiteProgramme());
                maCommande.Parameters.AddWithValue("@heureArriveeCabinet", uneVisite.getHeureArriveeCabinet());
                maCommande.Parameters.AddWithValue("@heureDebutEntretien", uneVisite.getHeureDebutEntretien());
                maCommande.Parameters.AddWithValue("@heureDepartCabinet", uneVisite.getHeureDepartCabinet());


                // Exécution de la requête
                maCommande.ExecuteNonQuery();
                // Fermeture de la connection
                maConnection.Close();

                

                // On va se synchroniser avec la base de données
                PasserelleSuiviA.initListeCabinet();
                PasserelleSuiviA.initListeActeur();
                PasserelleSuiviA.initListeMedecin();
                PasserelleSuiviA.initListeVisite(uneVisite.getLActeur().getIdActeur());
            }
            catch (Exception erreur)
            {
                // Permet la gestion des erreurs
                throw erreur;
            }
        }
        #endregion
        #region Others Methods
        /// <summary>
        /// Permet de s'authentifier
        /// </summary>
        /// <param name="login">String</param>
        /// <param name="MDP">String</param>
        /// <param name="connexionViaActiveDirectory">Boolean</param>
        /// <returns>String</returns>
        public static string seConnecter(string login, string MDP, Boolean connexionViaActiveDirectory)
        {
            #region Cas sans Active Directory
            if (connexionViaActiveDirectory == false)
            {
                // Initialisation des variables nécessaires à la fonction et à la boucle tant que
                string typeUtilisateur = null;
                Boolean trouveOuPas = false;
                int compteur = 0;

                // On encode le mot de passe saisi par l'utilisateur et on le stocke dans un tableau
                byte[] unTab = Encoding.ASCII.GetBytes(MDP);
                // Création d'une classe permettant de crypter en SHA1
                SHA1CryptoServiceProvider classeDeCryptage = new SHA1CryptoServiceProvider();
                // On crypte en SHA1
                string MDPCrypte = BitConverter.ToString(classeDeCryptage.ComputeHash(unTab)).Replace("-", "");

                // Permet de parcourir la liste des acteurs pour savoir si le login et mot de passe sont bon
                while (trouveOuPas == false && compteur < uneListeDActeur.Count)
                {
                    // On regarde si le login de l'acteur est celui entré par l'utilisateur
                    if (uneListeDActeur[compteur].getLogin() == login)
                    {
                        // On regarde si le mot de passe de l'acteur est celui entré par l'utilisateur
                        if (uneListeDActeur[compteur].getMDP().ToUpper() == MDPCrypte)
                        {
                            // On renvoit le type d'acteur
                            // Cas où le login et le mot de passe sont correct
                            if (uneListeDActeur[compteur].getTypeActeur() == 2)
                            {
                                // L'utilisateur est un "visiteur"
                                typeUtilisateur = "Visiteur";
                                trouveOuPas = true;
                                // On stocke l'acteur connecté dans un variable de la classe
                                PasserelleSuiviA.setActeurConnecte(uneListeDActeur[compteur]);
                            }
                            else
                            {
                                // L'utilisateur est un "administrateur" ou un "comptable" ou autre
                                typeUtilisateur = "Autre";
                                trouveOuPas = true;
                                // On stocke l'acteur connecté dans un variable de la classe
                                PasserelleSuiviA.setActeurConnecte(uneListeDActeur[compteur]);
                            }
                        }
                        else
                        {
                            // Cas où le login saisi existe mais que le mot de passe correspondant est incorrect
                            typeUtilisateur = "Incorrect";
                            // Mot de passe incorrect, on sort de la boucle
                            trouveOuPas = true;
                        }
                    }
                    else
                    {
                        // Cas où ce n'est pas le bon login
                        typeUtilisateur = "Incorrect";
                    }
                    compteur++;
                }
                // On retourne le type d'utilisateur
                return typeUtilisateur;
            }
            #endregion
            #region Cas avec Active Directory
            else
            {
                // Initialisation des variables nécessaires à la fonction et à la boucle tant que
                string typeUtilisateur = null;
                Boolean trouveOuPas = false;
                int compteur = 0;

                // Permet de parcourir la liste des acteurs pour obtenir l'acteur qui a tenté de se connecter
                while (trouveOuPas == false && compteur < uneListeDActeur.Count)
                {
                    // On regarde si le login de l'acteur est celui entré par l'utilisateur
                    if (uneListeDActeur[compteur].getLogin() == login)
                    {
                        // On renvoit le type d'acteur
                        // Cas où le login et le mot de passe sont correct
                        if (uneListeDActeur[compteur].getTypeActeur() == 2)
                        {
                            // L'utilisateur est un "visiteur"
                            typeUtilisateur = "Visiteur";
                            trouveOuPas = true;
                            // On stocke l'acteur connecté dans un variable de la classe
                            PasserelleSuiviA.setActeurConnecte(uneListeDActeur[compteur]);
                            // On retourne le type d'utilisateur
                            return typeUtilisateur;
                        }
                        else
                        {
                            // L'utilisateur est un "administrateur" ou un "comptable" ou autre
                            typeUtilisateur = "Autre";
                            trouveOuPas = true;
                            // On stocke l'acteur connecté dans un variable de la classe
                            PasserelleSuiviA.setActeurConnecte(uneListeDActeur[compteur]);
                            // On retourne le type d'utilisateur
                            return typeUtilisateur;
                        }
                    }
                    compteur++;
                }
            }
            #endregion
            return "Erreur de connexion";
        }
        #region Setters SVG
        /// <summary>
        /// Permet de sauvegarder l'acteur actuellement connecté à l'application
        /// Procédure utilisée afin de passer un objet Acteur d'une vue à une autre
        /// </summary>
        /// <param name="lActeurConnecte">Un objet Acteur</param>
        public static void setActeurConnecte(Acteur lActeurConnecte)
        {
            PasserelleSuiviA.acteurConnecte = lActeurConnecte;
        }

        /// <summary>
        /// Permet de sauvegarder la visite qui doit être modifiée
        /// Procédure utilisée afin de passer un objet Visite d'une vue à une autre
        /// </summary>
        /// <param name="laVisiteSelectionnee">Un objet Visite</param>
        public static void setVisiteAModifier(Visite laVisiteSelectionnee)
        {
            PasserelleSuiviA.visiteAModifier = laVisiteSelectionnee;
        }

        /// <summary>
        /// Permet de sauvegarder le médecin qui doit être modifiée
        /// Procédure utilisée afin de passer un objet Medecin d'une vue à une autre
        /// </summary>
        /// <param name="leMedecinSelectionnee">Un objet Medecin</param>
        public static void setMedecinAModifier(Medecin leMedecinSelectionnee)
        {
            PasserelleSuiviA.medecinAModifier = leMedecinSelectionnee;
        }

        /// <summary>
        /// Permet de sauvegarder le cabinet qui doit être modifiée
        /// Procédure utilisée afin de passer un objet Cabinet d'une vue à une autre
        /// </summary>
        /// <param name="leCabinetSelectionnee">Un objet Cabinet</param>
        public static void setCabinetAModifier(Cabinet leCabinetSelectionnee)
        {
            PasserelleSuiviA.cabinetAModifier = leCabinetSelectionnee;
        }
        #endregion
        #region Getters SVG
        /// <summary>
        /// Permet de récupérer l'acteur actuellement connecté à l'application
        /// Fonction utilisée afin de passer un objet Acteur d'une vue à une autre
        /// </summary>
        /// <returns>Un objet Acteur</returns>
        public static Acteur getActeurConnecte()
        {
            return PasserelleSuiviA.acteurConnecte;
        }
        
        /// <summary>
        /// Permet de récupérer la visite qui doit être modifiée
        /// Fonction utilisée afin de passer un objet Visite d'une vue à une autre
        /// </summary>
        /// <returns>Un objet Visite</returns>
        public static Visite getVisiteAModifier()
        {
            return PasserelleSuiviA.visiteAModifier;
        }

        /// <summary>
        /// Permet de récupérer le médecin qui doit être modifiée
        /// Fonction utilisée afin de passer un objet Medecin d'une vue à une autre
        /// </summary>
        /// <returns>Un objet Medecin</returns>
        public static Medecin getMedecinAModifier()
        {
            return PasserelleSuiviA.medecinAModifier;
        }

        /// <summary>
        /// Permet de récupérer le cabinet qui doit être modifiée
        /// Fonction utilisée afin de passer un objet Cabinet d'une vue à une autre
        /// </summary>
        /// <returns>Un objet Cabinet</returns>
        public static Cabinet getCabinetAModifier()
        {
            return PasserelleSuiviA.cabinetAModifier;
        }
        #endregion
        #endregion
        #endregion
    }
}
