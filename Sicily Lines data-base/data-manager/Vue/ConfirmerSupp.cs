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
    internal partial class ConfirmerSupp : Form
    {

        private Liaison supp_liaison;
        private ListBox listBoxLiaison;
        private int secteurId;

        public ConfirmerSupp(Liaison supp_liaison, ListBox listBoxLiaison, int secteurId)
        {
            InitializeComponent();

            this.supp_liaison = supp_liaison;
            this.listBoxLiaison = listBoxLiaison;
            this.secteurId = secteurId;

        }

        private void OuiBtn_Click(object sender, EventArgs e)
        {
            SicilyLinesDAO.suppLiaison(supp_liaison.Id);
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteurId);
            this.Close();
        }

        private void NonBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
