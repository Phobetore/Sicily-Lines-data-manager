using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_manager.Model
{
    internal class Secteur
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }


        public Secteur(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }


        public override string ToString()
        {
            return this.id.ToString() + " : " + this.libelle;
        }
    }
}
