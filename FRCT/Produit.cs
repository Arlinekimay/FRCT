using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCT
{
    class Produit
    {
        
        public int Quantite { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int Prix_unitaire { get; set; }
        public double Prix_total { get; set; }


        public Produit(string reference, string designation, int quantite, int prix_unitaire)
        {
            this.Quantite = quantite;
            this.Reference = reference;
            this.Designation = designation;
            this.Prix_unitaire = prix_unitaire;
            


        }
    }
}
