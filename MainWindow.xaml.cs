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

namespace SeptemberExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bike> allBikes;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BikeData db = new BikeData();

            var query = from b in db.Bikes
                        orderby b.Name
                        select b;


            allBikes = query.ToList();
            lbxBikes.ItemsSource = allBikes;
        }
        private void lbxBikes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selected
            Bike selected = lbxBikes.SelectedItem as Bike;

            //not null
            if (selected != null)
            {
                tblkBikeDetails.Text = selected.GetDescription();

            }

            //update display
        }
    }
}
