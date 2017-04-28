using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using Classe_Passerelle;

namespace ActiveDirectory
{
    /// <summary>
    /// Classe permettant de faire la liaison avec l'Active Directory
    /// </summary>
    public static class ConnexionActiveDirectory
    {
        /// <summary>
        /// Permet de vérifier si les identifiants précisé en paramètre existe au sein
        /// de l'active l'Active Directory. Dans le cas contraire, délenche une exception
        /// </summary>
        /// <param name="login">Le login de l'utilisateur</param>
        /// <param name="mdp">Le mot de passe de l'utilisateur</param>
        /// <returns>L'état de la connexion</returns>
        public static string authentification(string login, string mdp)
        {
            try
            {
                // Il est possible que la connexion se fasse mal ci l'adresse ci-dessous est incorrect.
                // Les adresses entre la salle 8 et 9 sont différentes.
                DirectoryEntry entree = new DirectoryEntry("LDAP://172.16.8.10", login, mdp);
                object objetNatif = entree.NativeObject;

                return PasserelleSuiviA.seConnecter(login, mdp, true);
            }
            catch
            {
                return "Erreur de connexion";
            }
        }
    }
}
