using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class GestionBD
    {
        MySqlConnection con;
        ObservableCollection<Projet> liste1;
        ObservableCollection<Employe> liste2;

        static GestionBD gestionBD = null;

        public GestionBD()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=2003317-jonathan-gremmo;Uid=2003317;Pwd=2003317;");
            liste1 = new ObservableCollection<Projet>();
            liste2 = new ObservableCollection<Employe>();
        }

        public static GestionBD getInstance()
        {
            if (gestionBD == null)
                gestionBD = new GestionBD();

            return gestionBD;
        }

        public ObservableCollection<Projet> GetProjets()
        {
            return liste1;
        }

        public ObservableCollection<Employe> GetEmployes()
        {
            return liste2;
        }

    }
}
