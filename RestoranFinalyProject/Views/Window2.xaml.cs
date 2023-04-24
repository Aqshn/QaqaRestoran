using RestoranFinalyProject.Commands;
using RestoranFinalyProject.Models;
using RestoranFinalyProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window, INotifyPropertyChanged
    {
        public string _name;
        private string _surname;
        private string _password;
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
        public Window2()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string _Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (_surname != value)
                {
                    _surname = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null)
            {
                Window2 viewModel = DataContext as Window2;
                if (viewModel != null)
                {
                    viewModel.Password = passwordBox.Password;
                }
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return _loginCommand = new PasswordCommand(param => this.Login(param), param => this.CanLogin());
            }
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(_Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(Password);
        }

        private void Login(object parameter)
        {
            MessageBox.Show("Welcome To Menu!");
            MenuWindow Window = new MenuWindow();
            if (bTn1 != null)
            {
                BTn1.GetInstance().garson = new Garson(_Name, Surname, Password);
                Window.B1(BTn1.GetInstance());
            }
            else if (bTn2 != null)
            {
                BTn2.GetInstance().garson = new Garson(_Name, Surname, Password);
                Window.B2(BTn2.GetInstance());
            }
            else if (bTn3 != null)
            {
                BTn3.GetInstance().garson = new Garson(_Name, Surname, Password);
                Window.B3(BTn3.GetInstance());
            }
            else if (bTn4 != null)
            {
                BTn4.GetInstance().garson = new Garson(_Name, Surname, Password);
                Window.B4(BTn4.GetInstance());
            }
            else if (bTn5 != null)
            {
                BTn5.GetInstance().garson = new Garson(_Name, Surname, Password);
                Window.B5(BTn5.GetInstance());
            }
            else if (bTn6 != null)
            {
                BTn6.GetInstance().garson = new Garson(_Name, Surname, Password);
                Window.B6(BTn6.GetInstance());
            }
            Window.Show();
            Close();
            return;

        }



        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
