﻿using data_manager.DAL;
using data_manager.Model;
<<<<<<< HEAD
=======
using data_manager.Vue;
>>>>>>> 1ec5e476745b36197ee43e926e53bb91468c8591
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
            }
            else
            {
                // Suppression du message "pas de liaisons"
                pasDeLiaisons.Visible = false;

                // Affichage des Liaisons dans la listBox
                listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);
            }

        }

        private void InsererBtn_Click(object sender, EventArgs e)
        {
            // Initialisation des valeurs pour la creation de l'objet
            int add_id = SicilyLinesDAO.getAllLiaisons(listBoxSecteur.SelectedIndex).Count+1;
            string add_duree = dureeBox.Text;
            Secteur add_secteur = SicilyLinesDAO.getSecteurs()[listBoxSecteur.SelectedIndex];
            Port add_depart = SicilyLinesDAO.getPorts()[DepartBox.SelectedIndex];
            Port add_arrivee = SicilyLinesDAO.getPorts()[ArriveeBox.SelectedIndex];

            // Creation de la Liaison avec en parametre le nouvelle objet de celle-ci
            SicilyLinesDAO.addLiaison(new Liaison(add_id, add_duree, add_secteur, add_depart, add_arrivee));

            // Actualisation de la listBoxLiaison
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);

            // Suppression du message "pas de liaisons"
            pasDeLiaisons.Visible = false;

        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            // Extraction du secteur et de la liaison selectionnés
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            Liaison supp_liaison = listBoxLiaison.SelectedItem as Liaison;

            // Envoie de l'id du secteur et de la listBoxLiaison pour actualiser, de la liaison à supp.
            var suppConfirmation = new ConfirmerSupp(supp_liaison, listBoxLiaison, secteur.Id);
            suppConfirmation.Show();

        }

<<<<<<< HEAD
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Secteur> listsecteurs = SicilyLinesDAO.getSecteurs();
            foreach (Secteur sect in listsecteurs)
            {
                Secteur.Items.Add(sect.Libelle);
            }
        }
=======
        private void majBtn_Click(object sender, EventArgs e)
        {
            // Initialisation des valeurs pour la creation de l'objet
            int maj_id = SicilyLinesDAO.getAllLiaisons(listBoxSecteur.SelectedIndex)[listBoxSecteur.SelectedIndex-1].Id;
            string maj_duree = majBox.Text;
            Secteur maj_secteur = SicilyLinesDAO.getSecteurs()[listBoxSecteur.SelectedIndex];
            Port maj_depart = SicilyLinesDAO.getPorts()[DepartBox.SelectedIndex];
            Port maj_arrivee = SicilyLinesDAO.getPorts()[ArriveeBox.SelectedIndex];

            // Modification de la Liaison avec en parametre le nouvelle objet (modifié) de celle-ci
            SicilyLinesDAO.modifLiaison(new Liaison(maj_id, maj_duree, maj_secteur, maj_depart, maj_arrivee));

            // Actualisation de listBoxLiaison
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = SicilyLinesDAO.getLiaisons(secteur.Id);
        }

>>>>>>> 1ec5e476745b36197ee43e926e53bb91468c8591
    }
}
