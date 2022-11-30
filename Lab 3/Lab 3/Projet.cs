using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Projet
    {
        string numero;
        string dateDebut;
        int budget;
        string description;
        string matriculeEmploye;

        public Projet()
        {
            this.numero = "1";
            this.dateDebut = "a";
            this.budget = 50001;
            this.description = "d";
            this.matriculeEmploye = "m";
        }

        public Projet(string numero, string dateDebut, int budget, string description, string matriculeEmploye)
        {
            this.numero = numero;
            this.dateDebut = dateDebut;
            this.budget = budget;
            this.description = description;
            this.matriculeEmploye = matriculeEmploye;
        }

        public string Numero { get => numero; set => numero = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public int Budget { get => budget; set => budget = value; }
        public string Description { get => description; set => description = value; }
        public string MatriculeEmploye { get => matriculeEmploye; set => matriculeEmploye = value; }

        public override string ToString()
        {
            return numero + " " + dateDebut + " Budget : " + budget + "$ " + description + " " + matriculeEmploye;
        }
    }
}
