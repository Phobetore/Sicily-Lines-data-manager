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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

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
    }
}
