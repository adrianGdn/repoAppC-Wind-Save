using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes_Metiers;
using Classe_Passerelle;
using System.Data;
using GoogleMaps.LocationServices;

namespace Lot_de_tests
{
    [TestClass]
    public class TestsUnitairesClassePasserelleSuiviA
    {
        private TestContext m_testContext;
        /// <summary>
        /// Méthode permettant de récupérer du contenu stocké dans un fichier XML
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return m_testContext;
            }

            set
            {
                m_testContext = value;
            }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseCabinet.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseCabinet.xml")]
        public void testCRUDCabinet()
        {
            #region Création du cabinet localement
            // Récupération des valeurs
            int idCabinet = int.Parse(TestContext.DataRow["idCabinet"].ToString());
            string longitudeGPS = TestContext.DataRow["longitudeGPS"].ToString();
            string latitudeGPS = TestContext.DataRow["latitudeGPS"].ToString();
            string ville = TestContext.DataRow["ville"].ToString();
            string rue = TestContext.DataRow["rue"].ToString();
            string cp = TestContext.DataRow["cp"].ToString();
            // Création de l'objet Cabinet
            Cabinet unCabinet = new Cabinet(idCabinet, rue, ville, cp);
            #endregion
            #region Ajout du cabinet créé localement en BDD
            // On ajoute en BDD le cabinet créée
            PasserelleSuiviA.ajoutCabinet(unCabinet);
            // On récupère la nouvelle liste des cabinets
            List<Cabinet> laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            #endregion
            #region Vérification de l'existance du cabinet en BDD
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            int compteur = 0;
            Boolean cabinetTrouveOuPas = false;
            Cabinet leCabinetQuOnCherche = null;

            while (cabinetTrouveOuPas == false && compteur < laListeDeCabinetATester_AjoutViaMethode.Count())
            {
                leCabinetQuOnCherche = laListeDeCabinetATester_AjoutViaMethode[compteur];
                if (leCabinetQuOnCherche.getRue() == unCabinet.getRue() && leCabinetQuOnCherche.getVille() == unCabinet.getVille() && leCabinetQuOnCherche.getCP() == unCabinet.getCP())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unCabinet.setIdCabinet(leCabinetQuOnCherche.getIdCabinet());
                    cabinetTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(unCabinet.ToString(), leCabinetQuOnCherche.ToString());
            #endregion
            #region Modification du cabinet en BDD
            // On modifie les attributs du cabinet (actuellement présent en local)
            unCabinet.setRue("11 rue de la résistance");
            unCabinet.setVille("La Madeleine");
            unCabinet.setCP("59110");
            // On modifie le cabinet en BDD
            PasserelleSuiviA.metAJourCabinet(unCabinet);
            // On récupère la nouvelle liste des cabinets
            laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été modifié en BDD
            compteur = 0;
            cabinetTrouveOuPas = false;
            leCabinetQuOnCherche = null;
            Boolean valeurDuCabinetModifieOuPas = false;

            while (cabinetTrouveOuPas == false && compteur < laListeDeCabinetATester_AjoutViaMethode.Count())
            {
                leCabinetQuOnCherche = laListeDeCabinetATester_AjoutViaMethode[compteur];
                if (leCabinetQuOnCherche.getRue() == unCabinet.getRue() && leCabinetQuOnCherche.getVille() == unCabinet.getVille() && leCabinetQuOnCherche.getCP() == unCabinet.getCP())
                {
                    cabinetTrouveOuPas = true;
                    valeurDuCabinetModifieOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(true, valeurDuCabinetModifieOuPas);
            #endregion
            #region Suppression du cabinet en BDD et vérification de sa suppression
            // Suppression du cabinet en BDD
            PasserelleSuiviA.supprimerCabinet(unCabinet);
            // On récupère la nouvelle liste des cabinets
            laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été supprimer
            compteur = 0;
            cabinetTrouveOuPas = false;
            leCabinetQuOnCherche = null;

            // On vérifie que l'objet à bien été surrpimé de la BDD
            // Il est possible qu'on ne passe jamais dans cet boucle (notamment si la liste est vide)
            while (cabinetTrouveOuPas == false && compteur < laListeDeCabinetATester_AjoutViaMethode.Count())
            {
                leCabinetQuOnCherche = laListeDeCabinetATester_AjoutViaMethode[compteur];
                if (leCabinetQuOnCherche.getIdCabinet() == unCabinet.getIdCabinet())
                {
                    cabinetTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(false, cabinetTrouveOuPas);
            #endregion
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseMedecin.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseMedecin.xml")]
        public void testCRUDMedecin()
        {
            #region Création du médecin localement
            // Récupération des valeurs
            string idActeur = TestContext.DataRow["idActeur"].ToString();
            string nomActeur = TestContext.DataRow["nomActeur"].ToString();
            string prenomActeur = TestContext.DataRow["prenomActeur"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string MDP = TestContext.DataRow["MDP"].ToString();
            int typeActeur = int.Parse(TestContext.DataRow["typeActeur"].ToString());
            // Création de l'objet Acteur
            Acteur unActeur = new Acteur(idActeur, nomActeur, prenomActeur, login, MDP, typeActeur);


            int idCabinet = int.Parse(TestContext.DataRow["idCabinet"].ToString());
            string longitudeGPS = TestContext.DataRow["longitudeGPS"].ToString();
            string latitudeGPS = TestContext.DataRow["latitudeGPS"].ToString();
            string ville = TestContext.DataRow["ville"].ToString();
            string rue = TestContext.DataRow["rue"].ToString();
            string cp = TestContext.DataRow["cp"].ToString();
            // Création de l'objet Cabinet
            Cabinet unCabinet = new Cabinet(idCabinet, rue, ville, cp);


            int idMedecin = int.Parse(TestContext.DataRow["idMedecin"].ToString());
            string nomMedecin = TestContext.DataRow["nomMedecin"].ToString();
            string prenomMedecin = TestContext.DataRow["prenomMedecin"].ToString();
            // Création de l'objet Medecin
            Medecin unMedecin = new Medecin(idMedecin, nomMedecin, prenomMedecin, unCabinet, unActeur);
            #endregion
            #region Ajout du médecin créé localement en BDD
            // On ajoute en BDD le médecin et le cabinet créé
            PasserelleSuiviA.ajoutCabinet(unCabinet);
            #region On cherche a obtenir le bon ID du cabinet
            // On récupère la nouvelle liste des cabinets
            List<Cabinet> laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            int compteur = 0;
            Boolean cabinetTrouveOuPas = false;
            Cabinet leCabinetQuOnCherche = null;

            while (cabinetTrouveOuPas == false && compteur < laListeDeCabinetATester_AjoutViaMethode.Count())
            {
                leCabinetQuOnCherche = laListeDeCabinetATester_AjoutViaMethode[compteur];
                if (leCabinetQuOnCherche.getRue() == unCabinet.getRue() && leCabinetQuOnCherche.getVille() == unCabinet.getVille() && leCabinetQuOnCherche.getCP() == unCabinet.getCP())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unCabinet.setIdCabinet(leCabinetQuOnCherche.getIdCabinet());
                    cabinetTrouveOuPas = true;
                }
                compteur++;
            }
            unMedecin.setCabinet(unCabinet);
            #endregion
            PasserelleSuiviA.ajoutMedecin(unMedecin);
            // On récupère la nouvelle liste des médecins
            PasserelleSuiviA.initListeActeur();
            PasserelleSuiviA.initListeCabinet();
            List<Medecin> laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            #endregion
            #region Vérification de l'existance du médecin en BDD
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            compteur = 0;
            Boolean medecinTrouveOuPas = false;
            Medecin leMedecinQuOnCherche = null;

            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getNom() == unMedecin.getNom() && leMedecinQuOnCherche.getPrenom() == unMedecin.getPrenom())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unMedecin.setIdMedecin(leMedecinQuOnCherche.getIdMedecin());
                    medecinTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(leMedecinQuOnCherche.ToString(), unMedecin.ToString());
            #endregion
            #region Modification du médecin en BDD
            // On modifie les attributs du médecin (actuellement présent en local)
            unMedecin.setNom("Testeur");
            unMedecin.setPrenom("Le");
            // On modifie le médecin en BDD
            PasserelleSuiviA.metAJourMedecin(unMedecin);
            // On récupère la nouvelle liste des médecins
            laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été modifié en BDD
            compteur = 0;
            medecinTrouveOuPas = false;
            leMedecinQuOnCherche = null;
            Boolean valeurDuMedecinModifieOuPas = false;

            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getNom() == unMedecin.getNom() && leMedecinQuOnCherche.getPrenom() == unMedecin.getPrenom())
                {
                    medecinTrouveOuPas = true;
                    valeurDuMedecinModifieOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(true, valeurDuMedecinModifieOuPas);
            #endregion
            #region Suppression du médecin en BDD et vérification de sa suppression
            // Suppression du médecin et du cabinet en BDD
            PasserelleSuiviA.supprimerMedecin(unMedecin);
            PasserelleSuiviA.supprimerCabinet(unCabinet);
            // On récupère la nouvelle liste des médecins et des cabinets
            laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été supprimer
            compteur = 0;
            medecinTrouveOuPas = false;
            leMedecinQuOnCherche = null;

            // On vérifie que l'objet à bien été surrpimé de la BDD
            // Il est possible qu'on ne passe jamais dans cet boucle (notamment si la liste est vide)
            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getIdMedecin() == unMedecin.getIdMedecin())
                {
                    medecinTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(false, medecinTrouveOuPas);
            #endregion
        }
        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseMedecin.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseMedecin.xml")]
        public void testCRUDMedecinSansActeurAuDebut()
        {
            #region Création du médecin localement
            // Récupération des valeurs
            string idActeur = TestContext.DataRow["idActeur"].ToString();
            string nomActeur = TestContext.DataRow["nomActeur"].ToString();
            string prenomActeur = TestContext.DataRow["prenomActeur"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string MDP = TestContext.DataRow["MDP"].ToString();
            int typeActeur = int.Parse(TestContext.DataRow["typeActeur"].ToString());
            // Création de l'objet Acteur
            Acteur unActeur = new Acteur(idActeur, nomActeur, prenomActeur, login, MDP, typeActeur);


            int idCabinet = int.Parse(TestContext.DataRow["idCabinet"].ToString());
            string longitudeGPS = TestContext.DataRow["longitudeGPS"].ToString();
            string latitudeGPS = TestContext.DataRow["latitudeGPS"].ToString();
            string ville = TestContext.DataRow["ville"].ToString();
            string rue = TestContext.DataRow["rue"].ToString();
            string cp = TestContext.DataRow["cp"].ToString();
            // Création de l'objet Cabinet
            Cabinet unCabinet = new Cabinet(idCabinet, rue, ville, cp);


            int idMedecin = int.Parse(TestContext.DataRow["idMedecin"].ToString());
            string nomMedecin = TestContext.DataRow["nomMedecin"].ToString();
            string prenomMedecin = TestContext.DataRow["prenomMedecin"].ToString();
            // Création de l'objet Medecin
            Medecin unMedecin = new Medecin(idMedecin, nomMedecin, prenomMedecin, unCabinet);
            #endregion
            #region Ajout du médecin créé localement en BDD
            // On ajoute en BDD le médecin et le cabinet créé
            PasserelleSuiviA.ajoutCabinet(unCabinet);
            #region On cherche a obtenir le bon ID du cabinet
            // On récupère la nouvelle liste des cabinets
            List<Cabinet> laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            int compteur = 0;
            Boolean cabinetTrouveOuPas = false;
            Cabinet leCabinetQuOnCherche = null;

            while (cabinetTrouveOuPas == false && compteur < laListeDeCabinetATester_AjoutViaMethode.Count())
            {
                leCabinetQuOnCherche = laListeDeCabinetATester_AjoutViaMethode[compteur];
                if (leCabinetQuOnCherche.getRue() == unCabinet.getRue() && leCabinetQuOnCherche.getVille() == unCabinet.getVille() && leCabinetQuOnCherche.getCP() == unCabinet.getCP())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unCabinet.setIdCabinet(leCabinetQuOnCherche.getIdCabinet());
                    cabinetTrouveOuPas = true;
                }
                compteur++;
            }
            unMedecin.setCabinet(unCabinet);
            #endregion
            PasserelleSuiviA.ajoutMedecinSansVisiteur(unMedecin);
            // On récupère la nouvelle liste des médecins
            PasserelleSuiviA.initListeActeur();
            PasserelleSuiviA.initListeCabinet();
            List<Medecin> laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            #endregion
            #region Vérification de l'existance du médecin en BDD
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            compteur = 0;
            Boolean medecinTrouveOuPas = false;
            Medecin leMedecinQuOnCherche = null;

            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getNom() == unMedecin.getNom() && leMedecinQuOnCherche.getPrenom() == unMedecin.getPrenom())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unMedecin.setIdMedecin(leMedecinQuOnCherche.getIdMedecin());
                    medecinTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(leMedecinQuOnCherche.ToString(), unMedecin.ToString());
            #endregion
            #region Modification du médecin en BDD
            // On modifie les attributs du médecin (actuellement présent en local)
            unMedecin.setNom("Testeur");
            unMedecin.setPrenom("Le");
            unMedecin.setActeur(unActeur);
            // On modifie le médecin en BDD
            PasserelleSuiviA.metAJourMedecinEtActeur(unMedecin);
            // On récupère la nouvelle liste des médecins
            laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été modifié en BDD
            compteur = 0;
            medecinTrouveOuPas = false;
            leMedecinQuOnCherche = null;
            Boolean valeurDuMedecinModifieOuPas = false;

            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getNom() == unMedecin.getNom() && leMedecinQuOnCherche.getPrenom() == unMedecin.getPrenom())
                {
                    medecinTrouveOuPas = true;
                    valeurDuMedecinModifieOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(true, valeurDuMedecinModifieOuPas);
            #endregion
            #region Suppression du médecin en BDD et vérification de sa suppression
            // Suppression du médecin et du cabinet en BDD
            PasserelleSuiviA.supprimerMedecin(unMedecin);
            PasserelleSuiviA.supprimerCabinet(unCabinet);
            // On récupère la nouvelle liste des médecins et des cabinets
            laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été supprimer
            compteur = 0;
            medecinTrouveOuPas = false;
            leMedecinQuOnCherche = null;

            // On vérifie que l'objet à bien été surrpimé de la BDD
            // Il est possible qu'on ne passe jamais dans cet boucle (notamment si la liste est vide)
            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getIdMedecin() == unMedecin.getIdMedecin())
                {
                    medecinTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(false, medecinTrouveOuPas);
            #endregion
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseVisite.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseVisite.xml")]
        public void testCRUDVisite()
        {
            #region Création de la visite localement
            // Récupération des valeurs
            string idActeur = TestContext.DataRow["idActeur"].ToString();
            string nomActeur = TestContext.DataRow["nomActeur"].ToString();
            string prenomActeur = TestContext.DataRow["prenomActeur"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string MDP = TestContext.DataRow["MDP"].ToString();
            int typeActeur = int.Parse(TestContext.DataRow["typeActeur"].ToString());
            // Création de l'objet Acteur
            Acteur unActeur = new Acteur(idActeur, nomActeur, prenomActeur, login, MDP, typeActeur);


            int idCabinet = int.Parse(TestContext.DataRow["idCabinet"].ToString());
            string longitudeGPS = TestContext.DataRow["longitudeGPS"].ToString();
            string latitudeGPS = TestContext.DataRow["latitudeGPS"].ToString();
            string ville = TestContext.DataRow["ville"].ToString();
            string rue = TestContext.DataRow["rue"].ToString();
            string cp = TestContext.DataRow["cp"].ToString();
            // Création de l'objet Cabinet
            Cabinet unCabinet = new Cabinet(idCabinet, rue, ville, cp);


            int idMedecin = int.Parse(TestContext.DataRow["idMedecin"].ToString());
            string nomMedecin = TestContext.DataRow["nomMedecin"].ToString();
            string prenomMedecin = TestContext.DataRow["prenomMedecin"].ToString();
            // Création de l'objet Medecin
            Medecin unMedecin = new Medecin(idMedecin, nomMedecin, prenomMedecin, unCabinet, unActeur);


            int idVisite = int.Parse(TestContext.DataRow["idVisite"].ToString());
            int dateVisiteJour = int.Parse(TestContext.DataRow["dateVisiteJour"].ToString());
            int dateVisiteMois = int.Parse(TestContext.DataRow["dateVisiteMois"].ToString());
            int dateVisiteAnnee = int.Parse(TestContext.DataRow["dateVisiteAnnee"].ToString());
            DateTime dateVisite = new DateTime(dateVisiteAnnee, dateVisiteMois, dateVisiteJour);
            string heureArriveeCabinet = TestContext.DataRow["heureArriveeCabinet"].ToString();
            string heureDebutEntretien = TestContext.DataRow["heureDebutEntretien"].ToString();
            string heureDepartCabinet = TestContext.DataRow["heureDepartCabinet"].ToString();
            Boolean estVisiteProgramme = Boolean.Parse(TestContext.DataRow["estVisiteProgramme"].ToString());
            // Création de l'objet Visite
            Visite uneVisite = new Visite(idVisite, dateVisite, estVisiteProgramme, heureArriveeCabinet, heureDebutEntretien, heureDepartCabinet, unMedecin, unActeur);
            #endregion
            #region Ajout de la visite créé localement en BDD
            // On ajoute en BDD le médecin, la visite et le cabinet créé
            PasserelleSuiviA.ajoutCabinet(unCabinet);
            #region On cherche à obtenir le bon ID du cabinet
            // On récupère la nouvelle liste des cabinets
            List<Cabinet> laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            int compteur = 0;
            Boolean cabinetTrouveOuPas = false;
            Cabinet leCabinetQuOnCherche = null;

            while (cabinetTrouveOuPas == false && compteur < laListeDeCabinetATester_AjoutViaMethode.Count())
            {
                leCabinetQuOnCherche = laListeDeCabinetATester_AjoutViaMethode[compteur];
                if (leCabinetQuOnCherche.getRue() == unCabinet.getRue() && leCabinetQuOnCherche.getVille() == unCabinet.getVille() && leCabinetQuOnCherche.getCP() == unCabinet.getCP())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unCabinet.setIdCabinet(leCabinetQuOnCherche.getIdCabinet());
                    cabinetTrouveOuPas = true;
                }
                compteur++;
            }
            // On change le cabinet associé au médecin (afin qu'il est le bon ID)
            unMedecin.setCabinet(unCabinet);
            #endregion
            PasserelleSuiviA.ajoutMedecin(unMedecin);
            #region On cherche à obtenir le bon ID du médecin
            // On récupère la nouvelle liste des médecins
            PasserelleSuiviA.initListeActeur();
            PasserelleSuiviA.initListeCabinet();
            List<Medecin> laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            compteur = 0;
            Boolean medecinTrouveOuPas = false;
            Medecin leMedecinQuOnCherche = null;

            while (medecinTrouveOuPas == false && compteur < laListeDeMedecinATester_AjoutViaMethode.Count())
            {
                leMedecinQuOnCherche = laListeDeMedecinATester_AjoutViaMethode[compteur];
                if (leMedecinQuOnCherche.getNom() == unMedecin.getNom() && leMedecinQuOnCherche.getPrenom() == unMedecin.getPrenom())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    unMedecin.setIdMedecin(leMedecinQuOnCherche.getIdMedecin());
                    medecinTrouveOuPas = true;
                }
                compteur++;
            }
            // On change le médecin associé à la visite (afin qu'il est le bon ID)
            uneVisite.setMedecin(unMedecin);
            #endregion
            PasserelleSuiviA.ajoutVisiste(uneVisite);
            // On récupère la nouvelle liste des visites
            List<Visite> laListeDeVisiteATester_AjoutViaMethode = PasserelleSuiviA.initListeVisite(uneVisite.getLActeur().getIdActeur());
            #endregion
            #region Vérification de l'existance de la visite en BDD
            // On déclare et initialise des variables qui nous serviront à récupérer un objet spécifique dans une liste
            compteur = 0;
            Boolean visiteTrouveOuPas = false;
            Visite laVisiteQuOnCherche = null;

            while (visiteTrouveOuPas == false && compteur < laListeDeVisiteATester_AjoutViaMethode.Count())
            {
                laVisiteQuOnCherche = laListeDeVisiteATester_AjoutViaMethode[compteur];
                if (laVisiteQuOnCherche.getHeureArriveeCabinet() == uneVisite.getHeureArriveeCabinet() && laVisiteQuOnCherche.getHeureDebutEntretien() == uneVisite.getHeureDebutEntretien() && laVisiteQuOnCherche.getHeureDepartCabinet() == uneVisite.getHeureDepartCabinet() && laVisiteQuOnCherche.getEstVisiteProgramme() == uneVisite.getEstVisiteProgramme() && laVisiteQuOnCherche.getDateVisite() == uneVisite.getDateVisite())
                {
                    // Permet d'avoir le même identifiant que l'objet en base
                    // En BDD, comme l'ID est auto incrémenté, on ne peut pas le connaître à l'avance, d'où la nécessité de le retrouver.
                    uneVisite.setIdVisite(laVisiteQuOnCherche.getIdVisite());
                    visiteTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(laVisiteQuOnCherche.ToString(), uneVisite.ToString());
            #endregion
            #region Modification de la visite en BDD
            // On modifie les attributs de la visite (actuellement présent en local)
            uneVisite.setDateVisite(new DateTime(1997, 03, 17));
            uneVisite.setEstVisiteProgramme(false);
            uneVisite.setHeureArriveeCabinet("14h00");
            uneVisite.setHeureDebutEntretien("14h30");
            uneVisite.setHeureDepartCabinet("15h00");
            // On modifie la visite en BDD
            PasserelleSuiviA.metAJourVisite(uneVisite);
            // On récupère la nouvelle liste des visites
            laListeDeVisiteATester_AjoutViaMethode = PasserelleSuiviA.initListeVisite(uneVisite.getLActeur().getIdActeur());
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été modifié en BDD
            compteur = 0;
            visiteTrouveOuPas = false;
            laVisiteQuOnCherche = null;
            Boolean valeurDeVisiteModifieOuPas = false;

            while (visiteTrouveOuPas == false && compteur < laListeDeVisiteATester_AjoutViaMethode.Count())
            {
                laVisiteQuOnCherche = laListeDeVisiteATester_AjoutViaMethode[compteur];
                if (laVisiteQuOnCherche.getHeureArriveeCabinet() == uneVisite.getHeureArriveeCabinet() && laVisiteQuOnCherche.getHeureDebutEntretien() == uneVisite.getHeureDebutEntretien() && laVisiteQuOnCherche.getHeureDepartCabinet() == uneVisite.getHeureDepartCabinet() && laVisiteQuOnCherche.getEstVisiteProgramme() == uneVisite.getEstVisiteProgramme() && laVisiteQuOnCherche.getDateVisite() == uneVisite.getDateVisite())
                {
                    visiteTrouveOuPas = true;
                    valeurDeVisiteModifieOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(true, valeurDeVisiteModifieOuPas);
            #endregion
            #region Suppression de la visite en BDD et vérification de sa suppression
            // Suppression du médecin, de la visite et du cabinet en BDD
            PasserelleSuiviA.supprimerVisite(uneVisite);
            PasserelleSuiviA.supprimerMedecin(unMedecin);
            PasserelleSuiviA.supprimerCabinet(unCabinet);
            // On récupère la nouvelle liste des visites, des cabinets et des médecins
            laListeDeCabinetATester_AjoutViaMethode = PasserelleSuiviA.initListeCabinet();
            laListeDeMedecinATester_AjoutViaMethode = PasserelleSuiviA.initListeMedecin();
            laListeDeVisiteATester_AjoutViaMethode = PasserelleSuiviA.initListeVisite(uneVisite.getLActeur().getIdActeur());
            // On déclare et initialise des variables qui nous serviront à vérifier que l'objet à bien été supprimer
            compteur = 0;
            visiteTrouveOuPas = false;
            laVisiteQuOnCherche = null;

            // On vérifie que l'objet à bien été surrpimé de la BDD
            // Il est possible qu'on ne passe jamais dans cet boucle (notamment si la liste est vide)
            while (visiteTrouveOuPas == false && compteur < laListeDeVisiteATester_AjoutViaMethode.Count())
            {
                laVisiteQuOnCherche = laListeDeVisiteATester_AjoutViaMethode[compteur];
                if (laVisiteQuOnCherche.getIdVisite() == uneVisite.getIdVisite())
                {
                    visiteTrouveOuPas = true;
                }
                compteur++;
            }
            Assert.AreEqual(false, visiteTrouveOuPas);
            #endregion
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseActeur.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseActeur.xml")]
        public void testSeConnecter()
        {
            PasserelleSuiviA.initListeActeur();

            string idActeur = TestContext.DataRow["idActeur"].ToString();
            string nom = TestContext.DataRow["nom"].ToString();
            string prenom = TestContext.DataRow["prenom"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string MDP = TestContext.DataRow["MDP"].ToString();
            string MDPClair = TestContext.DataRow["MDPClair"].ToString();
            int typeActeur = int.Parse(TestContext.DataRow["typeActeur"].ToString());
            // Création d'un objet Acteur
            Acteur unActeur = new Acteur(idActeur, nom, prenom, login, MDP, typeActeur);

            // On récupère le type d'état de connection
            string etatCo = PasserelleSuiviA.seConnecter(unActeur.getLogin(), MDPClair, false);
            // On vérifie le message en fonction du type d'acteur qu'est l'utilisateur
            if (unActeur.getTypeActeur() == 2)
            {
                Assert.AreEqual("Visiteur", etatCo);
            }
            else
                Assert.AreEqual("Autre", etatCo);

            // On vérifie que si le mot de passe entré est incorrect, le message change
            etatCo = PasserelleSuiviA.seConnecter(unActeur.getLogin(), "mauvaisMDP", false);
            Assert.AreEqual("Incorrect", etatCo);

            // On vérifie que si le login est incorrect, le message change
            unActeur.setLogin("mauvaisLogin");
            etatCo = PasserelleSuiviA.seConnecter(unActeur.getLogin(), MDPClair, false);
            Assert.AreEqual("Incorrect", etatCo);

            // On vérifie que si le mot de passe et le login entré est incorrect, le message change
            etatCo = PasserelleSuiviA.seConnecter(unActeur.getLogin(), "mauvaisMDP", false);
            Assert.AreEqual("Incorrect", etatCo);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseVisite.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseVisite.xml")]
        public void testGettersEtSettersClassePasserelle()
        {
            #region Création acteur
            string idActeur = TestContext.DataRow["idActeur"].ToString();
            string nomActeur = TestContext.DataRow["nomActeur"].ToString();
            string prenomActeur = TestContext.DataRow["prenomActeur"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string MDP = TestContext.DataRow["MDP"].ToString();
            int typeActeur = int.Parse(TestContext.DataRow["typeActeur"].ToString());
            Acteur unActeur = new Acteur(idActeur, nomActeur, prenomActeur, login, MDP, typeActeur);
            #endregion
            #region Créations cabinet
            int idCabinet = int.Parse(TestContext.DataRow["idCabinet"].ToString());
            string longitudeGPS = TestContext.DataRow["longitudeGPS"].ToString();
            string latitudeGPS = TestContext.DataRow["latitudeGPS"].ToString();
            string ville = TestContext.DataRow["ville"].ToString();
            string rue = TestContext.DataRow["rue"].ToString();
            string cp = TestContext.DataRow["cp"].ToString();
            Cabinet unCabinet = new Cabinet(idCabinet, rue, ville, cp);
            #endregion
            #region Création médecin
            int idMedecin = int.Parse(TestContext.DataRow["idMedecin"].ToString());
            string nomMedecin = TestContext.DataRow["nomMedecin"].ToString();
            string prenomMedecin = TestContext.DataRow["prenomMedecin"].ToString();
            Medecin unMedecin = new Medecin(idMedecin, nomMedecin, prenomMedecin, unCabinet, unActeur);
            #endregion
            #region Création visite
            int idVisite = int.Parse(TestContext.DataRow["idVisite"].ToString());
            int dateVisiteJour = int.Parse(TestContext.DataRow["dateVisiteJour"].ToString());
            int dateVisiteMois = int.Parse(TestContext.DataRow["dateVisiteMois"].ToString());
            int dateVisiteAnnee = int.Parse(TestContext.DataRow["dateVisiteAnnee"].ToString());
            DateTime dateVisite = new DateTime(dateVisiteAnnee, dateVisiteMois, dateVisiteJour);
            string heureArriveeCabinet = TestContext.DataRow["heureArriveeCabinet"].ToString();
            string heureDebutEntretien = TestContext.DataRow["heureDebutEntretien"].ToString();
            string heureDepartCabinet = TestContext.DataRow["heureDepartCabinet"].ToString();
            Boolean estVisiteProgramme = Boolean.Parse(TestContext.DataRow["estVisiteProgramme"].ToString());
            Visite uneVisite = new Visite(idVisite, dateVisite, estVisiteProgramme, heureArriveeCabinet, heureDebutEntretien, heureDepartCabinet, unMedecin, unActeur);
            #endregion

            // On ajoute l'acteur, le cabinet, le médecin et la visite en classe passerelle
            PasserelleSuiviA.setActeurConnecte(unActeur);
            PasserelleSuiviA.setCabinetAModifier(unCabinet);
            PasserelleSuiviA.setMedecinAModifier(unMedecin);
            PasserelleSuiviA.setVisiteAModifier(uneVisite);

            // On vérifie que l'objet passé à la classe passerelle est toujours le même
            Assert.AreEqual(unActeur, PasserelleSuiviA.getActeurConnecte());
            Assert.AreEqual(unCabinet, PasserelleSuiviA.getCabinetAModifier());
            Assert.AreEqual(unMedecin, PasserelleSuiviA.getMedecinAModifier());
            Assert.AreEqual(uneVisite, PasserelleSuiviA.getVisiteAModifier());
        }
    }
}
