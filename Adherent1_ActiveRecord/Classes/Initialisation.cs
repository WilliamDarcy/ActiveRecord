using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent1_ActiveRecord
{
    public class Initialisation
    {
        /// <summary>
        /// Retourne la chaine de connexion. On predra soin de ne pas utiliser l'utilisateur root avec un password vide comme ici!
        /// </summary>
        public static string InitialiserConnexion()
        {

            string server = "localhost";
            string port = "3306";
            string database = "association";
            string uid = "root";
            string password = "";
            return "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }
    }
}
