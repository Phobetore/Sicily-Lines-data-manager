using data_manager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_manager.DAL
{
    internal class SicilyLinesDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "bd-sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;


        // Récupération de la liste des Secteurs
        public static List<Secteur> getSecteurs()
        {

            List<Secteur> secList = new List<Secteur>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from secteur");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Secteur s;

                while (reader.Read())
                {
                    int ID = (int)reader.GetValue(0);
                    string LIBELLE = (string)reader.GetValue(1);

                    //Instanciation d'un secteur
                    s = new Secteur(ID, LIBELLE);

                    // Ajout de cet Secteur à la liste 
                    secList.Add(s);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste des secteurs
                return (secList);
            }

            catch (Exception error)
            {
                throw (error);
            }

        }


        // Récupération de la liste des Liaisons selon un Secteur donné
        public static List<Liaison> getLiaisons(int idSecteur)
        {

            List<Liaison> liaisonList = new List<Liaison>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from liaison where ID_REGROUPER = "+ idSecteur);
                MySqlDataReader reader = Ocom.ExecuteReader();
                Liaison l;

                while (reader.Read())
                {
                    int ID = (int)reader.GetValue(0);
                    int ID_REGROUPER = (int)reader.GetValue(1);
                    int ID_DEPART = (int)reader.GetValue(2);
                    int ID_ARRIVEE = (int)reader.GetValue(3);
                    string DUREE = (string)reader.GetValue(4);

                    //Instanciation d'une liaison
                    l = new Liaison(ID, DUREE, ID_REGROUPER, ID_DEPART, ID_ARRIVEE);

                    // Ajout de cet Liaison à la liste 
                    liaisonList.Add(l);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste des liaisons
                return (liaisonList);
            }

            catch (Exception error)
            {

                throw (error);

            }

        }


        // Récupération d'un Secteur selon un id donnée
        public static Secteur getSecteursId(int idSecteur)
        {

            Secteur unSecteur = new Secteur();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from secteur where ID = " + idSecteur);
                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader.GetValue(0);
                    string LIBELLE = (string)reader.GetValue(1);

                    //Instanciation d'un secteur
                    unSecteur = new Secteur(ID, LIBELLE);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi du secteur
                return (unSecteur);
            }

            catch (Exception error)
            {
                throw (error);
            }

        }


        // Récupération d'un Port selon un id donnée
        public static Port getPortId(int idPort)
        {

            Port unPort = new Port();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from port where ID = " + idPort);
                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader.GetValue(0);
                    string NOM = (string)reader.GetValue(1);

                    //Instanciation du port
                    unPort = new Port(ID, NOM);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi du port
                return (unPort);
            }

            catch (Exception error)
            {
                throw (error);
            }

        }


        // Modification de la durrée d'une liaison
        public static void modifLiaison(Liaison updatedLiaison)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("update liaison set DUREE= '" + updatedLiaison.Duree + "' where ID = " + updatedLiaison.Id);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception error)
            {
                throw (error);
            }
        }


        // Modification de la durrée d'une liaison
        public static void addLiaison(Liaison addedLiaison)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("INSERT INTO `liaison`(`ID_REGROUPER`, `ID_DEPART`, `ID_ARRIVEE`, `DUREE`) VALUES (" + addedLiaison.SecteurLie.Id + "," + addedLiaison.PortDepart.Id + "," + addedLiaison.PortDepart.Id + "," + addedLiaison.Duree + ")");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception error)
            {
                throw (error);
            }
        }


        // Suppression d'une liaison
        public static void suppLiaison(int liaisonId)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("DELETE FROM liaison WHERE ID = " + liaisonId);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception error)
            {
                throw (error);
            }
        }


    }
}
