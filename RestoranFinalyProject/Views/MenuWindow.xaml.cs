using RestoranFinalyProject.Models;
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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public List<Food> _foodItems;
        public BTn1 bTn1;
        public BTn2 bTn2;
        public BTn3 bTn3;
        public BTn4 bTn4;
        public BTn5 bTn5;
        public BTn6 bTn6;

        public void B1(BTn1 button)
        {
            bTn1 = button;
        }
        public void B2(BTn2 button)
        {
            bTn2 = button;
        }
        public void B3(BTn3 button)
        {
            bTn3 = button;
        }
        public void B4(BTn4 button)
        {
            bTn4 = button;
        }
        public void B5(BTn5 button)
        {
            bTn5 = button;
        }
        public void B6(BTn6 button)
        {
            bTn6 = button;
        }
        public MenuWindow()
        {
            InitializeComponent();
            this.DataContext = this;


            _foodItems = new List<Food>
            {
                new Food { Name = "Pive", Price = 12,Count = 0 },
                new Food { Name = "Kofe", Price = 7.4,Count = 0 },
                new Food { Name = "Dolma", Price = 11.2,Count = 0 },
                new Food { Name = "Merci", Price = 11.2,Count = 0 },
                new Food { Name = "Dovga", Price = 12,Count = 0 }
            };
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;


            if (button == _btn1)
            {
                if (_foodItems[0].Count == 1)
                {
                    _foodItems[0].Count -= 1;
                    _btn1.Content = "Burada sizin  reklam ola bilerdi";
                }
                else if (_foodItems[0].Count > 1)
                {
                    _foodItems[0].Count -= 1;
                    _btn1.Content = _foodItems[0].ToString();
                }
            }
            if (button == _btn2)
            {
                if (_foodItems[5].Count == 1)
                {
                    _foodItems[5].Count -= 1;
                    _btn2.Content = "Burada sizin  reklam ola bilerdi";
                }
                else if (_foodItems[5].Count > 1)
                {
                    _foodItems[5].Count -= 1;
                    _btn2.Content = _foodItems[5].ToString();
                }
            }
            if (button == _btn3)
            {
                if (_foodItems[2].Count == 1)
                {
                    _foodItems[2].Count -= 1;
                    _btn3.Content = "Burada sizin  reklam ola bilerdi";
                }
                else if (_foodItems[2].Count > 1)
                {
                    _foodItems[2].Count -= 1;
                    _btn3.Content = _foodItems[2].ToString();
                }
            }
            if (button == _btn4)
            {
                if (_foodItems[3].Count == 1)
                {
                    _foodItems[3].Count -= 1;
                    _btn4.Content = "Burada sizin  reklam ola bilerdi";
                }
                else if (_foodItems[3].Count > 1)
                {
                    _foodItems[3].Count -= 1;
                    _btn4.Content = _foodItems[3].ToString();
                }
            }
            if (button == _btn5)
            {
                if (_foodItems[4].Count == 1)
                {
                    _foodItems[4].Count -= 1;
                    _btn5.Content = "Burada sizin  reklam ola bilerdi";
                }
                else if (_foodItems[4].Count > 1)
                {
                    _foodItems[4].Count -= 1;
                    _btn5.Content = _foodItems[4].ToString();
                }
            }

            calc();
        }

        public void Btn1(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            if (button == btn1)
            {
                _foodItems[0].Count += 1;
                _btn1.Content = _foodItems[0].ToString();

            }
            else if (button == btn2)
            {
                _foodItems[1].Count += 1;
                _btn2.Content = _foodItems[1].ToString();
            }
            else if (button == btn3)
            {
                _foodItems[2].Count += 1;
                _btn3.Content = _foodItems[2].ToString();
            }
            else if (button == btn4)
            {
                _foodItems[3].Count += 1;
                _btn4.Content = _foodItems[3].ToString();
            }
            else if (button == btn5)
            {
                _foodItems[4].Count += 1;
                _btn5.Content = _foodItems[4].ToString();
            }
            calc();
        }
        public float calc()
        {
            float calculate = 0;
            foreach (var item in _foodItems)
            {
                calculate += (float)(item.Price * item.Count);
            }
            hesabBtn.Content = Convert.ToString(calculate);
            return calculate;
        }
        public void HesabClick(object sender, RoutedEventArgs e)
        {
            if (_foodItems != null)
            {
                MessageBox.Show("Nus olsun qaqam!");
                if (bTn1 != null)
                {
                    BTn1.GetInstance().hesab = calc();
                    BTn1.GetInstance().status = false;
                }
                else if (bTn2 != null)
                {
                    BTn2.GetInstance().hesab = calc();
                    BTn2.GetInstance().status = false;
                }
                else if (bTn3 != null)
                {
                    BTn3.GetInstance().hesab = calc();
                    BTn3.GetInstance().status = false;
                }
                else if (bTn4 != null)
                {
                    BTn4.GetInstance().hesab = calc();
                    BTn4.GetInstance().status = false;
                }
                else if (bTn5 != null)
                {
                    BTn5.GetInstance().hesab = calc();
                    BTn5.GetInstance().status = false;
                }
                else if (bTn6 != null)
                {
                    BTn6.GetInstance().hesab = calc();
                    BTn6.GetInstance().status = false;
                }
                MainWindow window = new MainWindow();
                window.Show();
                Close();
            }
        }
    }
}
