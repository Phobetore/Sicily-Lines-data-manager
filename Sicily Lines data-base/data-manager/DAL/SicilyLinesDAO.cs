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


        // Récupération de la liste des Secteur
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

                // Envoi de la liste au Manager
                return (secList);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }



        public static List<Liaison> getLiaisons()
        {

            List<Liaison> liaisonList = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison");


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

                // Envoi de la liste au Manager
                return (liaisonList);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static Secteur getSecteursId(int idSecteur)
        {

            Secteur unSecteur = new Secteur();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from secteur where ID = " + idSecteur);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur s;




                while (reader.Read())
                {

                    int ID = (int)reader.GetValue(0);
                    string LIBELLE = (string)reader.GetValue(1);

                    //Instanciation d'un secteur
                    unSecteur = new Secteur(ID, LIBELLE);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (unSecteur);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static Port getPortId(int idPort)
        {

            Port unPort = new Port();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from port where ID = " + idPort);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Port s;




                while (reader.Read())
                {

                    int ID = (int)reader.GetValue(0);
                    string NOM = (string)reader.GetValue(1);

                    //Instanciation d'un secteur
                    unPort = new Port(ID, NOM);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (unPort);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


    }
}
