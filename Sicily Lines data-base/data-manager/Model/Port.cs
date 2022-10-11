using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_manager.Model
{
    internal class Port
    {
        private int id;
        private string nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }


        public Port(int id, string libelle)
        {
            this.id = id;
            this.nom = libelle;
        }

        public Port()
        {

        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
