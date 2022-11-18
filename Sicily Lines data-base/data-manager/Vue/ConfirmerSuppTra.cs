using data_manager.DAL;
using data_manager.Model;
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
     internal partial class ConfirmerSuppTra : Form
    {

        private Traversee supp_traversee;
        private ListBox listBoxTraversee;
        private int liaisonId;

        public ConfirmerSuppTra(Traversee supp_traversee, ListBox listBoxTraversee, int liaisonId)
        {
            InitializeComponent();

            // Initialisation des variables depuis les parametres
            this.supp_traversee = supp_traversee;
            this.listBoxTraversee = listBoxTraversee;
            this.liaisonId = liaisonId;

        }

        private void OuiBtn_Click(object sender, EventArgs e)
        {
            // Suppression de la Liaison selon une id donnée
            SicilyLinesDAO.suppTraversee(supp_traversee.Id);

            // Actualisation de la listBoxLiaison
            listBoxTraversee.DataSource = null;
            listBoxTraversee.DataSource = SicilyLinesDAO.getTraversee(liaisonId);

            // Fermeture de la fenetre
            this.Close();
        }

        private void NonBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
