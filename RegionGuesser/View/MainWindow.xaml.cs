using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RegionGuesser.Model;
using RegionGuesser.Control;

namespace RegionGuesser
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controler controler;
        public MainWindow()
        {
            InitializeComponent();
            controler = new Controler();
            cboSearch.ItemsSource = controler.GetRegions();
            
        }

        private void cboSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Region selectedRegion = ((Region)cboSearch.SelectedItem);
            this.Resources["selectedRegion"] = selectedRegion.Departments[0].ToString();
            updateMap(selectedRegion);
            updateRegionInfos(selectedRegion);    
        }

        /// <summary>
        /// Met à jour l'image de la carte de France en fonction de la région choisie.
        /// </summary>
        /// <param name="region">Région à afficher.</param>
        private void updateMap(Region region)
        {
            BitmapImage biRegion = new BitmapImage();
            biRegion.BeginInit();
            biRegion.UriSource = new Uri(controler.GetImagePath(region), UriKind.Relative);
            biRegion.EndInit();
            mapOfFrance.Stretch = Stretch.Uniform;
            mapOfFrance.Source = biRegion;
        }

        /// <summary>
        /// Met à jour l'affichage des informations du département. 
        /// Chaque département est listé au format : 
        /// 59 : Nord
        /// Chef lieu : Lille
        /// </summary>
        /// <param name="region">Région à afficher.</param>
        private void updateRegionInfos(Region region)
        {
            panelInfos.Children.Clear();
            foreach (Department department in region.Departments)
            {
                TextBlock txtBlock = new TextBlock();
                txtBlock.Inlines.Add(new Bold(new Run($"{department.Code} - ")));
                txtBlock.Inlines.Add(new Run($"{department.Name }\n"));
                txtBlock.Inlines.Add(new Run($"Chef lieu : "));
                txtBlock.Inlines.Add(new Bold(new Run($"{department.Capital }\n\n")));
                panelInfos.Children.Add(txtBlock);
            }
        }


    }
}
