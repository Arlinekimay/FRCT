using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCT.BO
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }


        public Client(string nom, string prenom, string email,int telephone)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Telephone = telephone;
        }
    }
}