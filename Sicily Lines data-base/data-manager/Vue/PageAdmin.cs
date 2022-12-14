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
    public partial class PageAdmin : Form
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Verification de la presence de Secteur
            if (!SicilyLinesDAO.getSecteurs().Any())
            {
                // Affichage du message indiquant qu'il n'y a pas de secteurs
                listBoxSecteur.Items.Clear();
                pasDeSecteur.Visible = true;
            }
            else
            {
                // Affichage des secteur dans la listBox
                listBoxSecteur.DataSource = SicilyLinesDAO.getSecteurs();
            }

            // Affichage des ports dans les comboBox de l'insertion
            ArriveeBox.DataSource = SicilyLinesDAO.getPorts();
            DepartBox.DataSource = SicilyLinesDAO.getPorts();
        }


        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Extraction du secteur selectionnné
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;

            // Actualisation de la listBox
            listBoxLiaison.DataSource = null;

            if (!SicilyLinesDAO.getLiaisons(secteur.Id).Any())
            {
                // Affichage du message "pas de liaisons"
                pasDeLiaisons.Visible = true;
                pasdetraversee.Visible = true;
            }
            else
            {
                // Suppression du message "pas de liaisons"
                pasDeLiaisons.Visible = false;
                pasdetraversee.Visible = false;

                // Affichage des Liaisons dans la listBox
                listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);
                listBoxLiaison.SelectedIndex = 0;
            }

        }

        private void InsererBtn_Click(object sender, EventArgs e)
        {
            if (SicilyLinesDAO.checkDuree(dureeBox.Text))
            {
                Secteur secteur = listBoxSecteur.SelectedItem as Secteur;

                // Initialisation des valeurs pour la creation de l'objet
                int add_id = SicilyLinesDAO.getAllLiaisons().Count + 1;
                string add_duree = dureeBox.Text;
                Secteur add_secteur = secteur;
                Port add_depart = DepartBox.SelectedItem as Port;
                Port add_arrivee = ArriveeBox.SelectedItem as Port;

                // Creation de la Liaison avec en parametre le nouvelle objet de celle-ci
                SicilyLinesDAO.addLiaison(new Liaison(add_id, add_duree, add_secteur, add_depart, add_arrivee));

                // Actualisation de la listBoxLiaison
                listBoxLiaison.DataSource = null;
                listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);

                // Suppression du message "pas de liaisons"
                pasDeLiaisons.Visible = false;
            }
            else
            {
                var alert = new DureeErreur();
                alert.Show();
            }
            dureeBox.Text = "";

        }

        private void suppBtnLi_Click(object sender, EventArgs e)
        {
            // Extraction du secteur et de la liaison selectionnés
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            Liaison supp_liaison = listBoxLiaison.SelectedItem as Liaison;

            // Envoie de l'id du secteur et de la listBoxLiaison pour actualiser, de la liaison à supp.
            var suppConfirmation = new ConfirmerSupp(supp_liaison, listBoxLiaison, secteur.Id);
            suppConfirmation.Show();

        }

        private void majBtn_Click(object sender, EventArgs e)
        {
            if (SicilyLinesDAO.checkDuree(majBox.Text))
            {
                Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
                Liaison maj_liaison = listBoxLiaison.SelectedItem as Liaison;

                // Initialisation des valeurs pour la creation de l'objet
                int maj_id = maj_liaison.Id;
                string maj_duree = majBox.Text;
                Secteur maj_secteur = listBoxSecteur.SelectedItem as Secteur;
                Port maj_depart = maj_liaison.PortDepart;
                Port maj_arrivee = maj_liaison.PortArrivee;

                // Modification de la Liaison avec en parametre le nouvelle objet (modifié) de celle-ci
                SicilyLinesDAO.modifLiaison(new Liaison(maj_id, maj_duree, maj_secteur, maj_depart, maj_arrivee));

                // Actualisation de listBoxLiaison
                listBoxLiaison.DataSource = null;
                listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);
            }
            else
            {
                var alert = new DureeErreur();
                alert.Show();
            }
            majBox.Text = "";
        }


        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liaison liaison = listBoxLiaison.SelectedItem as Liaison;

            // Actualisation de la listBox
            listBoxTraversee.DataSource = null;

            if (liaison == null || !SicilyLinesDAO.getTraversee(liaison.Id).Any())
            {
                // Affichage du message "pas de liaisons"
                pasdetraversee.Visible = true;
            }
            else
            {
                // Suppression du message "pase liaisons"
                pasdetraversee.Visible = false;

                // Affichage des Liaisons dans la listBox
                listBoxTraversee.DataSource = SicilyLinesDAO.getTraversee(liaison.Id);
            }
        }


        private void PageAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void suppBtnTra_Click(object sender, EventArgs e)
        {
            // Extraction de la liaison et de la traversée selectionnées
            Liaison liaison = listBoxLiaison.SelectedItem as Liaison;
            Traversee supp_treaversee = listBoxTraversee.SelectedItem as Traversee;

            // Envoie de l'id du secteur et de la listBoxLiaison pour actualiser, de la liaison à supp.
            var suppConfirmation = new ConfirmerSuppTra(supp_treaversee, listBoxTraversee, liaison.Id);
            suppConfirmation.Show();
        }

        private void insertTra_Click(object sender, EventArgs e)
        {
            if (SicilyLinesDAO.checkDuree(heureBox.Text))
            {
                Liaison liaison = listBoxLiaison.SelectedItem as Liaison;

                // Initialisation des valeurs pour la creation de l'objet
                int add_id = SicilyLinesDAO.getAllLiaisons().Count + 1;
                string add_heure = heureBox.Text;
                Liaison add_liaison = liaison;
                string jour = textBoxJour.Text;
                string mois = textBoxMois.Text;
                string annee = textBoxAnnee.Text;

                // Creation de la Liaison avec en parametre le nouvelle objet de celle-ci
                SicilyLinesDAO.addTraversee(new Traversee(add_id, jour, mois, annee, add_liaison, add_heure));

                // Actualisation de la listBoxLiaison
                listBoxTraversee.DataSource = null;
                listBoxTraversee.DataSource = SicilyLinesDAO.getTraversee(liaison.Id);

                // Suppression du message "pas de liaisons"
                pasdetraversee.Visible = false;
            }
            else
            {
                var alert = new DureeErreur();
                alert.Show();
            }
            heureBox.Text = "";
            textBoxAnnee.Text = "";
            textBoxJour.Text = "";
            textBoxMois.Text = "";
        }
    }
}
