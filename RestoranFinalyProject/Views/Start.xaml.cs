using RestoranFinalyProject.ViewModels;
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
using System.Windows.Shapes;

namespace RestoranFinalyProject.Views
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        BTn1 bTn1 = BTn1.GetInstance();
        BTn2 bTn2 = BTn2.GetInstance();
        BTn3 bTn3 = BTn3.GetInstance();
        BTn4 bTn4 = BTn4.GetInstance();
        BTn5 bTn5 = BTn5.GetInstance();
        BTn6 bTn6 = BTn6.GetInstance();
        public Start()
        {
            InitializeComponent();
        }
        public void Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Getdiy!");
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
