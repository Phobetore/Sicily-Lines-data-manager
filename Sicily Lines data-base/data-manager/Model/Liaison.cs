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
        //private int port-depart;
        //private int port-arrivee;

        public int Id { get => id; set => id = value; }
        public string Nom { get => duree; set => duree = value; }
        public Secteur SecteurLie { get => secteurLie; set => secteurLie = value; }


        public Liaison(int id, string nom, Secteur secteurLie)
        {
            this.id = id;
            this.duree = nom;
            this.secteurLie = SecteurLie;
        }

        public Liaison()
        {

        }

        public override string ToString()
        {
            return "Depart : " + this.SecteurLie.Nom + " -  durée : " + this.duree + " - destination : ";
        }
    }
}
