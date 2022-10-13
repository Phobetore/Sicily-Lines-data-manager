using data_manager.DAL;
using data_manager.Model;
using data_manager.Vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace data_manager.Vue
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            
        }

        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            string login= LoginBox.Text;
            string mdp = MdpBox.Text;
            
      
    
                if ( SecureLoging.checkcredentials(login,mdp))
                {
                var page = new PageAdmin();
                page.Show();
                }
                else
                {
                   erreur.Text = "Login ou mot de passe invalide"; 
 
                    }  
                
           

         


        }
    }
}
