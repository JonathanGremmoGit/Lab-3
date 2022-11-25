using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
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
    public sealed partial class AjouterEmploye : Page
    {
        public AjouterEmploye()
        {
            this.InitializeComponent();
        }

        private void btAjouterEmploye_Click(object sender, RoutedEventArgs e)
        {
            if (matricule.Text == "")
            {
                matriculeErreur.Text = "Entrez un matricule";
            }
            else matriculeErreur.Text = "";

            if (nom.Text == "")
            {
                nomErreur.Text = "Entrez le nom de l'employé";
            }
            else nomErreur.Text = "";

            if (prenom.Text == "")
            {
                prenomErreur.Text = "Entrez le prénom de l'employé";
            }
            else prenomErreur.Text = "";

            if (matricule.Text != "" && nom.Text != "" && prenom.Text != "")
            {
                this.Frame.Navigate(typeof(AffichageListeProjet));
            }


        }
    }
}
