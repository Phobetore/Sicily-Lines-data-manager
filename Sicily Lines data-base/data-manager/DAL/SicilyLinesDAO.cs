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

                    //Instanciation d'un Emplye
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
                    string duree = (string)reader.GetValue(1);

                    //Instanciation d'un Emplye
                    l = new Liaison(id, duree, );

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



        public static List<Liaison> getLiaisons()
        {

            List<Liaison> liaisonList = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from Liaison");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string duree = (string)reader.GetValue(1);

                    //Instanciation d'un Emplye
                    l = new Liaison(id, duree, );

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

    }
}
