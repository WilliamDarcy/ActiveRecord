using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent1_ActiveRecord
{
    public class Adherent
    {
        private int Id;
        private string Nom;
        private string Prenom;
        private string CodePostal;
        private string Ville;
        private DateTime AnneeNaissance;
        private int TypeAdhesion;
       

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="lId">id de l'adhérent</param>
        /// <param name="leNom">le nom</param>
        /// <param name="lePrenom">le prénom</param>
        /// <param name="leCodePostal">le code postal</param>
        /// <param name="laVille">la ville</param>
        /// <param name="lAnneeDeNaissance">la date de naissance</param>
        /// <param name="leType">le type de l'adhésion</param>
        public Adherent(string leNom, string lePrenom, string leCodePostal, string laVille, DateTime lAnneeDeNaisance, int leType )
        {
            Id = -1;
            Nom = leNom;
            Prenom = lePrenom;
            CodePostal = leCodePostal;
            Ville = laVille;
            AnneeNaissance = lAnneeDeNaisance;
            TypeAdhesion = leType;
        }

        /// <summary>
        /// Constructeur avec un id chainé avec le constructeur sans id.
        /// </summary>
        /// <param name="lId">id de l'adhérent</param>
        /// <param name="leNom">le nom</param>
        /// <param name="lePrenom">le prénom</param>
        /// <param name="leCodePostal">le code postal</param>
        /// <param name="laVille">la ville</param>
        /// <param name="lAnneeDeNaissance">la date de naissance</param>
        /// <param name="leType">le type de l'adhésion</param>
        public Adherent(int id, string leNom, string lePrenom, string leCodePostal, string laVille, DateTime lAnneeDeNaisance, int leType)
            : this(leNom, lePrenom, leCodePostal, laVille, lAnneeDeNaisance, leType)
        {
            Id = id;
        }

         /// <summary>
        /// Getter pour l'id
        /// </summary>
        /// <returns>l'id</returns>
        public int GetId()
        {
            return Id;
        }
      
        /// <summary>
        /// Getter pour le nom
        /// </summary>
        /// <returns>le nom</returns>
        public string GetNom()
        {
            return Nom;
        }

        /// <summary>
        /// Getter pour le prénom
        /// </summary>
        /// <returns>le nom</returns>
        public string GetPrenom()
        {
            return Prenom;
        }


        /// <summary>
        /// Getter pour  le code postal
        /// </summary>
        /// <returns>le CP de l'adhérent</returns>
        public string GetCodePostal()
        {
            return CodePostal;
        }
        
        /// <summary>
        /// Getter pour  la ville
        /// </summary>
        /// <returns>la ville de l'adhérent</returns>
        public string GetVille()
        {
            return Ville;
        }

        /// <summary>
        /// Getter pour  la date de naissance
        /// </summary>
        /// <returns>l'année de naissance</returns>
        public DateTime GetDateDeNaissance()
        {
            return AnneeNaissance;
        }

        /// <summary>
        /// Getter pour  le type d'adhesion
        /// </summary>
        /// <returns>le numero du type de l'adhésion</returns>
        public int GettypeAdherent()
        {
            return TypeAdhesion;
        }


        /// <summary>
        /// Setter pour l'id
        /// </summary>
        public void SetId(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Setter pour le nom
        /// </summary>
        public void SetNom(string nom)
        {
            Nom = nom;
        }

        /// <summary>
        /// Setter pour le prénom
        /// </summary>
        public void SetPrenom(string prenom)
        {
            Prenom = prenom;
        }


        /// <summary>
        /// Setter pour  le code postal
        /// </summary>
        public void SetCodePostal(string codePostal)
        {
            CodePostal = codePostal;
        }

        /// <summary>
        /// setter pour  la ville
        /// </summary>
        public void SetVille(string ville)
        {
            Ville = ville;
        }

        /// <summary>
        /// setter pour  la date de naissance
        /// </summary>
        public void GetDateDeNaissance(DateTime dateNaissance)
        {
            AnneeNaissance = dateNaissance;
        }



        /// <summary>
        /// La méthode GetAdherent retourne les informations sur un adherent. Elle est static.
        /// </summary>
        /// <param name="id">l'id de l'adhérent</param>
        /// <returns>un adhérent</returns>
        public static Adherent GetAdherent(int id)
        {
           string connectionString = Initialisation.InitialiserConnexion();
            Adherent lAdherent = null;
             using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT idAdherent, nom, prenom, codePostal, ville, dateNaissance, typeAdhesion from adherent WHERE idAdherent = @id; ";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@id", id);

                    //Crée un data reader et exécute la commande
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {

                        //Lit les données 
                        while (dataReader.Read())
                        {

                            int idAdherent = Convert.ToInt32(dataReader["idAdherent"]);
                            string nom = dataReader["nom"].ToString();
                            string prenom = dataReader["prenom"].ToString();
                            string cp = dataReader["codePostal"].ToString();
                            string ville = dataReader["ville"].ToString();
                            DateTime annee = Convert.ToDateTime(dataReader["dateNaissance"]);
                            int idType = Convert.ToInt32(dataReader["typeAdhesion"]);
                            lAdherent = new Adherent(id, nom, prenom, cp, ville, annee, idType);

                           
                        }
                    }
                }
            
           
            return lAdherent;
        }

         /// <summary>
        /// La méthode GetAllAdherent retourne les informations sur tous les adhérents de la base. Elle est static. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>la liste de tous les adhérents</returns>
        public static List<Adherent> GetAllAdherent()
        {
            string connectionString = Initialisation.InitialiserConnexion();
            List<Adherent> listeDeTousLesAdherents = new List<Adherent>();
                   using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT idAdherent from adherent";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

     

                    //Crée un data reader et exécute la commande
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {

                        //Lit les données 
                        while (dataReader.Read())
                        {
                            Adherent lAdherent = null;
                            int idAdherent = Convert.ToInt32(dataReader["idAdherent"]);
                            lAdherent = GetAdherent(idAdherent);
                            if (lAdherent != null)
                            {
                                listeDeTousLesAdherents.Add(lAdherent);
                            }

                           
                        }
                    }
                }
            
           
            return listeDeTousLesAdherents;
        }

         /// <summary>
        /// La méthode SaveAdherent crée un nouvel adhérent s'il n'existe pas et le modifie 
        /// s'il existe déjà dans la base. 
        /// </summary>
        public void Save()
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;
            if (Id == -1)
            {
                //Création d'un nouvel adhérent    
                query = "insert into adherent (nom, prenom, codePostal, ville, dateNaissance, typeAdhesion) values (@nom, @prenom, @codePostal, @ville, @dateNaissance, @typeAdhesion);";
            }
            else
            {
                //Modification d'un adhérent
                query = "update adherent set  idAdherent = @id, nom = @nom, prenom = @prenom, codePostal = @prenom, ville = @ville, dateNaissance = @dateNaissance, typeAdhesion = typeAdhesion where idAdherent = @id";

            }

               
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                  
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@nom", Nom);
                    cmd.Parameters.AddWithValue("@prenom", Prenom);
                    cmd.Parameters.AddWithValue("@codePostal", CodePostal);
                    cmd.Parameters.AddWithValue("@dateNaissance", AnneeNaissance.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ville", Ville);
                    cmd.Parameters.AddWithValue("@typeAdhesion", TypeAdhesion);


                    //exécution la commande
                    cmd.ExecuteNonQuery();

                } 
        }
     
        /// <summary>
        /// TODO.  Supprimer adherent
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            //TODO
        }
           
    }
}


