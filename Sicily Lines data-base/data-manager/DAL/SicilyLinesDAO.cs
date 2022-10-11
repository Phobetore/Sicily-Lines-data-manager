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
        private static string provider = "127.0.0.1";
        private static string dataBase = "bd-sicilylines";
        private static string uid = "root";
        private static string mdp = "";
        



        // Récupération de la liste des Secteurs
        public static List<Secteur> getSecteurs()
        {

            List<Secteur> secList = new List<Secteur>();

            try
            {

                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from secteur";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getLeTrucChiant());
                MySqlDataReader readerS = Ocom.ExecuteReader();
                Secteur s;

                while (readerS.Read())
                {
                    int ID = (int)readerS["id"];
                    string NOM = (string)readerS["nom"];
                   
                    s = new Secteur(ID, NOM);

                    // Ajout de cet Liaison à la liste 
                    secList.Add(s);
                }

                readerS.Close();
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
                List<Secteur> listSecteursDeLiaison= getSecteurs();
                List<Port> listPortsDeLiaison= getPorts();
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from liaison where id = ?idSecteur ";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getLeTrucChiant());
                Ocom.Parameters.Add(new MySqlParameter("idSecteur", idSecteur));

                MySqlDataReader readerL = Ocom.ExecuteReader();
                Liaison l;


                while (readerL.Read())
                {
                    int ID = (int) readerL["id"];
                    string DUREE = (string) readerL["duree"];
                    Port PORT_DEPART = (Port) listPortsDeLiaison[Convert.ToInt32(readerL["port-depart"])];
                    Port PORT_ARRIVEE = (Port) listPortsDeLiaison[Convert.ToInt32(readerL["port-arrivee"])];
                    Secteur ID_SECTEUR = (Secteur)listSecteursDeLiaison[Convert.ToInt32(readerL["id-secteur"])];

                    l = new Liaison(ID, DUREE, ID_SECTEUR, PORT_DEPART, PORT_ARRIVEE);

                    // Ajout de cet Liaison à la liste 
                    liaisonList.Add(l);
                }

                readerL.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste des liaisons
                return (liaisonList);
            }

            catch (Exception error)
            {

                throw (error);

            }

        }


        // Récupération de la list des ports

        public static List<Port> getPorts()
        {

            List<Port> portList = new List<Port>();

            try
            {
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from port";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getLeTrucChiant());
                MySqlDataReader readerP = Ocom.ExecuteReader();
                Port p;

                while (readerP.Read())
                {
                    int ID = (int)readerP["id"];
                    string NOM = (string)readerP["nom"];

                    p = new Port(ID, NOM);

                    // Ajout de cet Liaison à la liste 
                    portList.Add(p);
                }

                readerP.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste des ports
                return (portList);
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

                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("update liaison set DUREE= '" + updatedLiaison.Duree + "' where ID = " + updatedLiaison.Id);
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

                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("INSERT INTO `liaison`(`ID_REGROUPER`, `ID_DEPART`, `ID_ARRIVEE`, `DUREE`) VALUES (" + addedLiaison.SecteurLie.Id + "," + addedLiaison.PortDepart.Id + "," + addedLiaison.PortDepart.Id + "," + addedLiaison.Duree + ")");
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

                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("DELETE FROM liaison WHERE ID = " + liaisonId);
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
