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

namespace data_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!SicilyLinesDAO.getSecteurs().Any())
            {
                listBoxSecteur.Items.Clear();
                pasDeSecteur.Visible = true;
            }
            else
            {
                listBoxSecteur.DataSource = SicilyLinesDAO.getSecteurs();
                // listBoxSecteur.DisplayMember = ;
            }
            foreach (var item in SicilyLinesDAO.getPorts())
            {
                ArriveBox.Items.Add(item);
                DepartBox.Items.Add(item);
            }
        }


        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(listBoxSecteur.SelectedIndex + 1);

            // listBoxLiaison.DisplayMember = ;
        }
    }
}
