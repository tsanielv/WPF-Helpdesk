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
using HelpDesk.ViewModel;
using HelpDesk.Views;


namespace HelpDesk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LoginVM l = new LoginVM();
        Dashboard vd = new Dashboard();
        //DashboardClient dc = new DashboardClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login1_Click(object sender, RoutedEventArgs e)
        {
            if ((l.cekLogin(txtUsername.Text, txtPassword.Password)) == true)
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                vd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and Password wrong", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
