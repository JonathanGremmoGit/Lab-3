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
            ObservableCollection<Projet> liste1 = new ObservableCollection<Projet>();

            MySqlCommand commande1 = new MySqlCommand();
            commande1.Connection = con;
            commande1.CommandText = "SELECT * from projet";

            con.Open();
            MySqlDataReader r = commande1.ExecuteReader();

            while (r.Read())
            {
                liste1.Add(new Projet());
            }
            r.Close();
            con.Close();

            return liste1;
        }

        public ObservableCollection<Employe> GetEmployes()
        {
            ObservableCollection<Employe> liste2 = new ObservableCollection<Employe>();

            MySqlCommand commande2 = new MySqlCommand();
            commande2.Connection = con;
            commande2.CommandText = "SELECT * from employe";

            con.Open();
            MySqlDataReader r = commande2.ExecuteReader();

            while (r.Read())
            {
                liste2.Add(new Employe());
            }
            r.Close();
            con.Close();

            return liste2;
        }

        public int ajouterProjet(Projet p) 
        {
            int retour = 0;

            MySqlCommand commande3 = new MySqlCommand();
            commande3.Connection = con;
            commande3.CommandText = "INSERT INTO projet VALUES(@numero, @debut, @budget, @description, @employe) ";

            commande3.Parameters.AddWithValue("@numero", p.Numero);
            commande3.Parameters.AddWithValue("@debut", p.DateDebut);
            commande3.Parameters.AddWithValue("@budget", p.Budget);
            commande3.Parameters.AddWithValue("@description", p.Description);
            commande3.Parameters.AddWithValue("@employe", p.MatriculeEmploye);

            con.Open();
            commande3.Prepare();
            retour = commande3.ExecuteNonQuery();

            con.Close();
            return retour;
        }

        public int ajouterEmploye(Employe e)
        {
            int retour = 0;

            MySqlCommand commande4 = new MySqlCommand();
            commande4.Connection = con;
            commande4.CommandText = "INSERT INTO projet VALUES(@matricule, @nom, @prenom) ";

            commande4.Parameters.AddWithValue("@numero", e.Matricule);
            commande4.Parameters.AddWithValue("@debut", e.NomEmploye);
            commande4.Parameters.AddWithValue("@budget", e.PrenomEmploye);

            con.Open();
            commande4.Prepare();
            retour = commande4.ExecuteNonQuery();

            con.Close();
            return retour;
        }

    }
}
