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

            ArriveeBox.DataSource = SicilyLinesDAO.getPorts();
            DepartBox.DataSource = SicilyLinesDAO.getPorts();
        }


        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);

            listBoxLiaison.DataSource = null;
            listBoxLiaison.Items.Clear();

            if (!SicilyLinesDAO.getLiaisons(secteur.Id).Any())
            {
                pasDeLiaisons.Visible = true;
            }
            else
            {
                pasDeLiaisons.Visible = false;
                listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);
                // listBoxLiaison.DisplayMember = ;
            }

        }

        private void InsererBtn_Click(object sender, EventArgs e)
        {
            int add_id = SicilyLinesDAO.getAllLiaisons(listBoxSecteur.SelectedIndex).Count+1;
            string add_duree = dureeBox.Text;
            Secteur add_secteur = SicilyLinesDAO.getSecteurs()[listBoxSecteur.SelectedIndex];
            Port add_depart = SicilyLinesDAO.getPorts()[DepartBox.SelectedIndex];
            Port add_arrivee = SicilyLinesDAO.getPorts()[ArriveeBox.SelectedIndex];

            SicilyLinesDAO.addLiaison(new Liaison(add_id, add_duree, add_secteur, add_depart, add_arrivee));


            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);

        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            int indexMiaison = listBoxLiaison.SelectedIndex;

            Liaison supp_liaison = SicilyLinesDAO.getLiaisons(secteur.Id)[indexMiaison];
            var suppConfirmation = new ConfirmerSupp(supp_liaison, listBoxLiaison, secteur.Id);
            suppConfirmation.Show();

        }

        private void majBtn_Click(object sender, EventArgs e)
        {
            int maj_id = SicilyLinesDAO.getAllLiaisons(listBoxSecteur.SelectedIndex)[listBoxSecteur.SelectedIndex-1].Id;
            string maj_duree = majBox.Text;
            Secteur maj_secteur = SicilyLinesDAO.getSecteurs()[listBoxSecteur.SelectedIndex];
            Port maj_depart = SicilyLinesDAO.getPorts()[DepartBox.SelectedIndex];
            Port maj_arrivee = SicilyLinesDAO.getPorts()[ArriveeBox.SelectedIndex];

            SicilyLinesDAO.modifLiaison(new Liaison(maj_id, maj_duree, maj_secteur, maj_depart, maj_arrivee));

            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);
        }
    }
}
