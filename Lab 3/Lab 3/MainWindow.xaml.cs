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
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            mainFrame.Navigate(typeof(AffichageListeProjet));
        }

        private void btAjoutEmploye_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(AjouterEmploye));
        }

        private void btAjoutProjet_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(AjouterProjet));
        }

        private void btRechercheEmploye_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(RechercherEmploye));
        }

        private void btAfficherListeProjets_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(AffichageListeProjet));
        }
    }
}
