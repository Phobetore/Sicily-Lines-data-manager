using data_manager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace data_manager.DAL
{
    internal class SecureLoging
    {

        private static string provider = "127.0.0.1";
        private static string dataBase = "bd-sicilylines";
        private static string uid = "dbmanager";
        private static string mdp = "ceciEstUnGrosMotDePasse";


       private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool checkcredentials(string login, string passwd)
        {
            string hashedPasswd = ComputeSha256Hash(passwd);

            ConnexionSql maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
            maConnexionSql.openConnection();
            string req = "Select Count(*) as nbReturn from admin where login = ?loginstr and passwd = ?passwdstr";
            MySqlCommand Ocom = new MySqlCommand(req, maConnexionSql.getmysalCn());
            Ocom.Parameters.Add(new MySqlParameter("loginstr", login));
            Ocom.Parameters.Add(new MySqlParameter("passwdstr", hashedPasswd));

            // execution de la requete
            MySqlDataReader reader = Ocom.ExecuteReader();
<<<<<<< HEAD
            reader.Read();
=======

>>>>>>> 9d9e190668da9d8f2d8b7f07715108d19a76dfb2
            if (Convert.ToInt32(reader["nbReturn"]) == 1)
            {
                maConnexionSql.closeConnection();
                return true;
            }
            maConnexionSql.closeConnection();
            return false;
        }


    }
}
