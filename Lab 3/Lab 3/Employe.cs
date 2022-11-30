using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Employe
    {
        string matricule;
        string nomEmploye;
        string prenomEmploye;

        public string Matricule { get => matricule; set => matricule = value; }
        public string NomEmploye { get => nomEmploye; set => nomEmploye = value; }
        public string PrenomEmploye { get => prenomEmploye; set => prenomEmploye = value; }

        public override string ToString()
        {
            return matricule + " " + nomEmploye + " " + prenomEmploye;
        }

    }
}
