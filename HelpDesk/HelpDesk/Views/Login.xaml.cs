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
using HelpDesk.Controller;
using HelpDesk.Views;


namespace HelpDesk.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        LoginController l = new LoginController();
        Dashboard vd = new Dashboard();
        public Login()
        {
            InitializeComponent();
        }

        private void Login1_Click(object sender, RoutedEventArgs e)
        {
            if ((l.cekLogin(txtUsername.Text, txtPassword.Text)) != 0)
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                if (l.cekLogin(txtUsername.Text, txtPassword.Text) == 1)
                {
                    
                    vd.ShowDialog();
                }
                else if (l.cekLogin(txtUsername.Text, txtPassword.Text) == 2)
                {
                    
                    vd.ShowDialog();
                }
                else
                {
                    
                    vd.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Username and Password wrong", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
