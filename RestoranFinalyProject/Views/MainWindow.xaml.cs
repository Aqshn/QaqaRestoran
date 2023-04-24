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
using System.Windows.Threading;

namespace RestoranFinalyProject.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            saatTextBlock.Text = DateTime.UtcNow.AddHours(4).AddSeconds(5).ToString("dd/MM/yyyy HH:mm:ss");
        }

        public void Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (button == btn1)
            {
                if ((bool)BTn1.GetInstance().status == true)
                {
                    Window2 Window = new Window2();
                    Window.B1(BTn1.GetInstance());
                    Window.Show();
                    Close();
                }
                else
                {
                    Hesab hesab = new Hesab();
                    hesab.B1(BTn1.GetInstance());
                    hesab.Show();
                    Close();
                }
            }
            else if (button == btn2)
            {
                if (BTn2.GetInstance().status == true)
                {
                    Window2 Window = new Window2();
                    Window.B2(BTn2.GetInstance());
                    Window.Show();
                    Close();
                }
                else
                {
                    Hesab hesab = new Hesab();
                    hesab.B2(BTn2.GetInstance());
                    hesab.Show();
                    Close();
                }
            }
            else if (button == btn3)
            {
                if (BTn3.GetInstance().status == true)
                {
                    Window2 Window = new Window2();
                    Window.B3(BTn3.GetInstance());
                    Window.Show();
                    Close();
                }
                else
                {
                    Hesab hesab = new Hesab();
                    hesab.B3(BTn3.GetInstance());
                    hesab.Show();
                    Close();
                }
            }
            else if (button == btn4)
            {
                if (BTn4.GetInstance().status == true)
                {
                    Window2 Window = new Window2();
                    Window.B4(BTn4.GetInstance());
                    Window.Show();
                    Close();
                }
                else
                {
                    Hesab hesab = new Hesab();
                    hesab.B4(BTn4.GetInstance());
                    hesab.Show();
                    Close();
                }
            }
            else if (button == btn5)
            {
                if (BTn5.GetInstance().status == true)
                {
                    Window2 Window = new Window2();
                    Window.B5(BTn5.GetInstance());
                    Window.Show();
                    Close();
                }
                else
                {
                    Hesab hesab = new Hesab();
                    hesab.B5(BTn5.GetInstance());
                    hesab.Show();
                    Close();
                }
            }
            else if (button == btn6)
            {
                if (BTn6.GetInstance().status == true)
                {
                    Window2 Window = new Window2();
                    Window.B6(BTn6.GetInstance());
                    Window.Show();
                    Close();
                }
                else
                {
                    Hesab hesab = new Hesab();
                    hesab.B6(BTn6.GetInstance());
                    hesab.Show();
                    Close();
                }
            }
        }
    }
}
