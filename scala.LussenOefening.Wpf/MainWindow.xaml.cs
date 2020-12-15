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

namespace scala.LussenOefening.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulCombos();
            lblFout.Visibility = Visibility.Hidden;
        }
        private void VulCombos()
        {
            for (int r = 1; r <= 100; r++)
            {
                cmbBasisgetal.Items.Add(r);
            }
            for(int r = 1; r <= 50; r++)
            {
                cmbVan.Items.Add(r);
                cmbTot.Items.Add(r);
            }
            cmbVan.SelectedItem = 1;
            cmbTot.SelectedItem = 10;
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            lblFout.Visibility = Visibility.Hidden;
            lstTafel.Items.Clear();

            if(cmbBasisgetal.SelectedItem == null)
            {
                lblFout.Content = "Selecteer een basisgetal !";
                lblFout.Visibility = Visibility.Visible;
                return;
            }
            int basis = int.Parse(cmbBasisgetal.SelectedItem.ToString());
            int van = int.Parse(cmbVan.SelectedItem.ToString());
            int tot = int.Parse(cmbTot.SelectedItem.ToString());
            if(tot < van)
            {
                lblFout.Content = "Tot moet groter zijn dan van !";
                lblFout.Visibility = Visibility.Visible;
                return;
            }
            for(int r = van; r <= tot; r++)
            {
                lstTafel.Items.Add($"{basis} * {r} = {basis * r}");
            }
        }

        private void cmbBasisgetal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblFout.Visibility = Visibility.Hidden;
            lstTafel.Items.Clear();

        }

        private void cmbVan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblFout.Visibility = Visibility.Hidden;
            lstTafel.Items.Clear();

        }

        private void cmbTot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblFout.Visibility = Visibility.Hidden;
            lstTafel.Items.Clear();

        }
    }
}
