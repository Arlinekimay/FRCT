using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCT
{
    class facture
    {
        public string Archive;
        public int prix;
        public int Numero_facture;


        public void Facture(string archive, int prix, int numero_facture, string client)
        {
            this.Archive = archive;
            this.prix = prix;
            this.Numero_facture = numero_facture;
           

        }
    }
}
