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

                // preparation de la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from secteur";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());
                
                // execution de la requete
                MySqlDataReader readerS = Ocom.ExecuteReader();
                Secteur s;

                // pour chaque resultat de la requete:
                while (readerS.Read())
                {
                    int ID = (int)readerS["id"];
                    string NOM = (string)readerS["nom"];
                   
                    // Creation de l'objet de ce seceur.
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


        // Recuperation de toutes les liaisons peut importe le secteur.
        public static List<Liaison> getAllLiaisons(int idSecteur)
        {

            List<Liaison> liaisonList = new List<Liaison>();

            try
            {
                // Creation de lists contenant tout les secteurs et les ports
                List<Secteur> listSecteursDeLiaison = getSecteurs();
                List<Port> listPortsDeLiaison = getPorts();

                // Preparation de la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from liaison";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());

                // Execution de la requete
                MySqlDataReader readerL = Ocom.ExecuteReader();


                // Pour chaque resultat de la requete:
                while (readerL.Read())
                {
                    int ID = (int)readerL["id"];
                    string DUREE = (string)readerL["duree"];
                    
                    // Utilisation des list de ports et de secteurs pour attribuer les port et
                    // le secteur adequat à la liaison
                    Port PORT_DEPART = (Port)listPortsDeLiaison[Convert.ToInt32(readerL["port-depart"]) - 1];
                    Port PORT_ARRIVEE = (Port)listPortsDeLiaison[Convert.ToInt32(readerL["port-arrivee"]) - 1];
                    Secteur ID_SECTEUR = (Secteur)listSecteursDeLiaison[Convert.ToInt32(readerL["id-secteur"]) - 1];

                    // Creation de l'objet de cette liaison
                    Liaison l = new Liaison(ID, DUREE, ID_SECTEUR, PORT_DEPART, PORT_ARRIVEE);

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


        // Récupération de la liste des Liaisons selon un Secteur donné
        public static List<Liaison> getLiaisons(int idSecteur)
        {

            List<Liaison> liaisonList = new List<Liaison>();

            try
            {
                // Creation de lists contenant tout les secteurs et les ports
                List<Secteur> listSecteursDeLiaison= getSecteurs();
                List<Port> listPortsDeLiaison= getPorts();

                // Preparation de la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from liaison where `id-secteur` = ?idSecteur ";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());
                Ocom.Parameters.Add(new MySqlParameter("idSecteur", idSecteur));

                // Execution de la requete
                MySqlDataReader readerL = Ocom.ExecuteReader();

                // Pour chaque resultat de la requete:
                while (readerL.Read())
                {
                    int ID = (int) readerL["id"];
                    string DUREE = (string) readerL["duree"];
                    Port PORT_DEPART = (Port) listPortsDeLiaison[Convert.ToInt32(readerL["port-depart"])-1];
                    Port PORT_ARRIVEE = (Port) listPortsDeLiaison[Convert.ToInt32(readerL["port-arrivee"])-1];
                    Secteur ID_SECTEUR = (Secteur)listSecteursDeLiaison[Convert.ToInt32(readerL["id-secteur"])-1];

                    // Creation de l'objet de cette liaison
                    Liaison l = new Liaison(ID, DUREE, ID_SECTEUR, PORT_DEPART, PORT_ARRIVEE);

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
                // Preparation de la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "Select * from port";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());

                // Execution de la requete
                MySqlDataReader readerP = Ocom.ExecuteReader();
                
                Port p;

                // Pour chaque resultat de la requete:
                while (readerP.Read())
                {
                    int ID = (int)readerP["id"];
                    string NOM = (string)readerP["nom"];

                    // Creation de l'objet de ce port
                    p = new Port(ID, NOM);

                    // Ajout de ce port à la liste 
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
                // Preparationde la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "update liaison set duree = '?updatedDuree' where id = ?idToUpdate";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());
                Ocom.Parameters.Add(new MySqlParameter("updatedDuree", updatedLiaison.Duree));
                Ocom.Parameters.Add(new MySqlParameter("idToUpdate", updatedLiaison.Id));

                // Execution de la requte
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
                // Preparationde la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "INSERT INTO `liaison`(`id`, `id-secteur`, `port-depart`, `port-arrivee`, `duree`) VALUES (?newId, ?newSecteurId, ?newDepartId, ?newArriveeId, ?newDuree )";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());
                Ocom.Parameters.Add(new MySqlParameter("newId", addedLiaison.Id));
                Ocom.Parameters.Add(new MySqlParameter("newSecteurId", addedLiaison.SecteurLie.Id));
                Ocom.Parameters.Add(new MySqlParameter("newDepartId", addedLiaison.PortDepart.Id));
                Ocom.Parameters.Add(new MySqlParameter("newArriveeId", addedLiaison.PortArrivee.Id));
                Ocom.Parameters.Add(new MySqlParameter("newDuree", addedLiaison.Duree));

                // Execution de la requte
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
                // Preparationde la requete
                ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string req = "DELETE FROM liaison WHERE id = ?liaisonId";
                MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());
                Ocom.Parameters.Add(new MySqlParameter("liaisonId", liaisonId));

                // Execution de la requte
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
