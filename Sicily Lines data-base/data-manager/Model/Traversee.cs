using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_manager.Model
{
    internal class Traversee
    {
        private int id;
        private string jour, mois, annee, heure;
        private Liaison liaisonLie;


        public Traversee(int id, string jour, string mois, string annee, Liaison liaisonLie, string heure)
        {
            this.id = id;
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
            this.liaisonLie = liaisonLie;
            this.heure = heure;
        }

        public int Id { get => id; set => id = value; }
        public string Jour { get => jour; set => jour = value; }
        public string Mois { get => mois; set => mois = value; }
        public string Annee { get => annee; set => annee = value; }
        internal Liaison LiaisonLie { get => liaisonLie; set => liaisonLie = value; }
        public string Heure { get => heure; set => heure = value; }

        public override string ToString()
        {
            return "Date: "+this.jour+"/"+this.mois+"/"+this.annee+" Heure: "+this.heure;
        }
    }
}
