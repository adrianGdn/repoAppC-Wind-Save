using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes_Metiers;
using Classe_Passerelle;
using System.Data;

namespace Lot_de_tests
{
    [TestClass]
    public class TestsUnitairesClassesMetiers
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
        public void testGettersCabinet()
        {
            #region Création cabinet
            int idCabinet = int.Parse(TestContext.DataRow["idCabinet"].ToString());
            string longitudeGPS = TestContext.DataRow["longitudeGPS"].ToString();
            string latitudeGPS = TestContext.DataRow["latitudeGPS"].ToString();
            string ville = TestContext.DataRow["ville"].ToString();
            string rue = TestContext.DataRow["rue"].ToString();
            string cp = TestContext.DataRow["cp"].ToString();
            Cabinet unCabinet = new Cabinet(idCabinet, rue, ville, cp);
            #endregion

            string resultatAttendu = longitudeGPS;
            string resultatObtenu = unCabinet.getLongitudeGPS();
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            string resultatAttendu2 = latitudeGPS;
            string resultatObtenu2 = unCabinet.getLatitudeGPS();
            Assert.AreEqual(resultatAttendu2, resultatObtenu2);

            string resultatAttendu3 = ville;
            string resultatObtenu3 = unCabinet.getVille();
            Assert.AreEqual(resultatAttendu3, resultatObtenu3);

            string resultatAttendu4 = rue;
            string resultatObtenu4 = unCabinet.getRue();
            Assert.AreEqual(resultatAttendu4, resultatObtenu4);

            string resultatAttendu5 = cp;
            string resultatObtenu5 = unCabinet.getCP();
            Assert.AreEqual(resultatAttendu5, resultatObtenu5);
            
            int resultatAttendu6 = idCabinet;
            int resultatObtenu6 = unCabinet.getIdCabinet();
            Assert.AreEqual(resultatAttendu6, resultatObtenu6);

            string resultatAttendu7 = cp.Substring(0, 2);
            string resultatObtenu7 = unCabinet.getNumDepartement();
            Assert.AreEqual(resultatAttendu7, resultatObtenu7);

            string resultatAttendu8 = "Adresse : " + unCabinet.getRue() + " " + unCabinet.getVille() + ", " + unCabinet.getCP() + ".";
            string resultatObtenu8 = unCabinet.ToString();
            Assert.AreEqual(resultatAttendu8, resultatObtenu8);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseActeur.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseActeur.xml")]
        public void testGettersActeur()
        {
            #region Création Acteur
            string idActeur = TestContext.DataRow["idActeur"].ToString();
            string nom = TestContext.DataRow["nom"].ToString();
            string prenom = TestContext.DataRow["prenom"].ToString();
            string login = TestContext.DataRow["login"].ToString();
            string MDP = TestContext.DataRow["MDP"].ToString();
            int typeActeur = int.Parse(TestContext.DataRow["typeActeur"].ToString());
            Acteur unActeur = new Acteur(idActeur, nom, prenom, login, MDP, typeActeur);
            #endregion

            string resultatAttendu = idActeur;
            string resultatObtenu = unActeur.getIdActeur();
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            string resultatAttendu2 = nom;
            string resultatObtenu2 = unActeur.getNom();
            Assert.AreEqual(resultatAttendu2, resultatObtenu2);

            string resultatAttendu3 = prenom;
            string resultatObtenu3 = unActeur.getPrenom();
            Assert.AreEqual(resultatAttendu3, resultatObtenu3);

            string resultatAttendu4 = login;
            string resultatObtenu4 = unActeur.getLogin();
            Assert.AreEqual(resultatAttendu4, resultatObtenu4);

            string resultatAttendu5 = MDP;
            string resultatObtenu5 = unActeur.getMDP();
            Assert.AreEqual(resultatAttendu5, resultatObtenu5);

            int resultatAttendu6 = typeActeur;
            int resultatObtenu6 = unActeur.getTypeActeur();
            Assert.AreEqual(resultatAttendu6, resultatObtenu6);

            string resultatAttendu8 = unActeur.getNom() + " " + unActeur.getPrenom() + " (login : " + unActeur.getLogin() + ").";
            string resultatObtenu8 = unActeur.ToString();
            Assert.AreEqual(resultatAttendu8, resultatObtenu8);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseMedecin.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseMedecin.xml")]
        public void testGettersMedecin()
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
            #region Création cabinet
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
            Medecin unMedecinV2 = new Medecin(idMedecin, nomMedecin, prenomMedecin, unCabinet);
            #endregion

            #region Avec constructeur 1
            string resultatAttendu = nomMedecin;
            string resultatObtenu = unMedecin.getNom();
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            string resultatAttendu2 = prenomMedecin;
            string resultatObtenu2 = unMedecin.getPrenom();
            Assert.AreEqual(resultatAttendu2, resultatObtenu2);
            
            Acteur resultatAttendu3 = unActeur;
            Acteur resultatObtenu3 = unMedecin.getLActeur();
            Assert.AreEqual(resultatAttendu3, resultatObtenu3);

            Cabinet resultatAttendu4 = unCabinet;
            Cabinet resultatObtenu4 = unMedecin.getLeCabinet();
            Assert.AreEqual(resultatAttendu4, resultatObtenu4);

            string resultatAttendu5 = unMedecin.getNom() + " " + unMedecin.getPrenom();
            string resultatObtenu5 = unMedecin.ToString();
            Assert.AreEqual(resultatAttendu5, resultatObtenu5);

            int resultatAttendu6 = idMedecin;
            int resultatObtenu6 = unMedecin.getIdMedecin();
            Assert.AreEqual(resultatAttendu6, resultatObtenu6);
            #endregion
            #region Avec constructeur 2
            string resultatAttenduV2 = nomMedecin;
            string resultatObtenuV2 = unMedecinV2.getNom();
            Assert.AreEqual(resultatAttenduV2, resultatObtenuV2);

            string resultatAttendu2V2 = prenomMedecin;
            string resultatObtenu2V2 = unMedecinV2.getPrenom();
            Assert.AreEqual(resultatAttendu2V2, resultatObtenu2V2);

            Acteur resultatAttendu3V2 = null;
            Acteur resultatObtenu3V2 = unMedecinV2.getLActeur();
            Assert.AreEqual(resultatAttendu3V2, resultatObtenu3V2);

            Cabinet resultatAttendu4V2 = unCabinet;
            Cabinet resultatObtenu4V2 = unMedecinV2.getLeCabinet();
            Assert.AreEqual(resultatAttendu4V2, resultatObtenu4V2);

            string resultatAttendu5V2 = unMedecinV2.getNom() + " " + unMedecinV2.getPrenom();
            string resultatObtenu5V2 = unMedecinV2.ToString();
            Assert.AreEqual(resultatAttendu5V2, resultatObtenu5V2);

            int resultatAttendu6V2 = idMedecin;
            int resultatObtenu6V2 = unMedecinV2.getIdMedecin();
            Assert.AreEqual(resultatAttendu6V2, resultatObtenu6V2);
            #endregion
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\testClasseVisite.xml", "uneValeur", DataAccessMethod.Sequential), DeploymentItem("TestsUnitairesClassesMetiers\\testClasseVisite.xml")]
        public void testGettersVisite()
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

            DateTime resultatAttendu = dateVisite;
            DateTime resultatObtenu = uneVisite.getDateVisite();
            Assert.AreEqual(resultatAttendu, resultatObtenu);
            
            int resultatAttendu2 = idVisite;
            int resultatObtenu2 = uneVisite.getIdVisite();
            Assert.AreEqual(resultatAttendu2, resultatObtenu2);

            string resultatAttendu3 = heureArriveeCabinet;
            string resultatObtenu3 = uneVisite.getHeureArriveeCabinet();
            Assert.AreEqual(resultatAttendu3, resultatObtenu3);

            string resultatAttendu4 = heureDebutEntretien;
            string resultatObtenu4 = uneVisite.getHeureDebutEntretien();
            Assert.AreEqual(resultatAttendu4, resultatObtenu4);

            string resultatAttendu5 = heureDepartCabinet;
            string resultatObtenu5 = uneVisite.getHeureDepartCabinet();
            Assert.AreEqual(resultatAttendu5, resultatObtenu5);

            Medecin resultatAttendu6 = unMedecin;
            Medecin resultatObtenu6 = uneVisite.getLeMedecin();
            Assert.AreEqual(resultatAttendu6, resultatObtenu6);

            Acteur resultatAttendu7 = unActeur;
            Acteur resultatObtenu7 = uneVisite.getLActeur();
            Assert.AreEqual(resultatAttendu7, resultatObtenu7);

            string resultatAttendu8 = "Nom du médecin : " + uneVisite.getLeMedecin().getNom() + ", nom du visiteur " + uneVisite.getLActeur().getNom(); ;
            string resultatObtenu8 = uneVisite.ToString();
            Assert.AreEqual(resultatAttendu8, resultatObtenu8);

            Boolean resultatAttendu9 = estVisiteProgramme;
            Boolean resultatObtenu9 = uneVisite.getEstVisiteProgramme();
            Assert.AreEqual(resultatAttendu9, resultatObtenu9);
        }
    }
}
