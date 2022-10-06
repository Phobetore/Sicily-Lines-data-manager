using data_manager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_manager.Model
{
    internal class Liaison
    {
        private int id;
        private string duree;
        private Secteur secteurLie;
        private Port portDepart;
        private Port portArrivee;

        public int Id { get => id; set => id = value; }
        public string Duree { get => duree; set => duree = value; }
        public Secteur SecteurLie { get => secteurLie; set => secteurLie = value; }
        public Port PortDepart { get => portDepart; set => portDepart = value; }
        public Port PortArrivee { get => portArrivee; set => portArrivee = value; }


        public Liaison(int id, string nom, int idSecteur, int idDepart, int idArrivee)
        {
            this.id = id;
            this.duree = nom;
            this.secteurLie = SicilyLinesDAO.getSecteursId(idSecteur);
            this.portDepart = SicilyLinesDAO.getPortId(idDepart);
            this.portArrivee = SicilyLinesDAO.getPortId(idArrivee);
        }

        public Liaison()
        {

        }

        public override string ToString()
        {
            return "Secteur : " + this.SecteurLie.Libelle + " -  Durée : " + this.duree + " - Depart : " + this.portDepart.Nom + " - Arrivee : " + this.portArrivee.Nom;
        }
    }
}
