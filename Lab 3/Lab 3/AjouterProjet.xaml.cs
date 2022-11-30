using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Lab_3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AjouterProjet : Page
    {
        public AjouterProjet()
        {
            this.InitializeComponent();
        }

        private void btAjouterProjet_Click(object sender, RoutedEventArgs e)
        {

            int budgetInt = 0;
            string laDate;
            try
            {
                budgetErreur.Text = "";
                budgetInt = Convert.ToInt32(budget.Text);

                if (budgetInt < 10000 || budgetInt > 100000)
                {
                    budgetErreur.Text = "Entrez un budget entre 10 000$ et 100 000$";
                }
            }
            catch(Exception ex)
            {
                budgetErreur.Text = "Entrez un budget entre 10 000$ et 100 000$";
            }

            if (numero.Text == "")
            {
                numeroErreur.Text = "Entrez un numéro";
            }
            else numeroErreur.Text = "";

            if (dateDebut.SelectedDate == null)
            {
                dateDebutErreur.Text = "Entrez une date";
            }
            else
            {
                dateDebutErreur.Text = "";
                laDate = dateDebut.Date.Date.ToString("yyyy/MM/dd");
            }

            if (description.Text == "")
            {
                descriptionErreur.Text = "Entrez une description";
            }
            else descriptionErreur.Text = "";

            if (employe.Text == "")
            {
                employeErreur.Text = "Entrez le matricule de l'employé que vous voulez assigner au projet";
            }
            else employeErreur.Text = "";

            if (numero.Text != "" && dateDebut.SelectedDate != null && budgetInt >= 10000 && budgetInt <= 100000 && description.Text != "" && employe.Text != "")
            {
                this.Frame.Navigate(typeof(AffichageListeProjet));
            }
        }
    }
}
