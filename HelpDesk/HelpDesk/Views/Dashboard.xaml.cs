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
using HelpDesk.Views;
using HelpDesk.Models;

namespace HelpDesk.Views
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        helpdeskEntitiesNew _context = new helpdeskEntitiesNew();

        

        private void dgRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void button_save_department(object sender, RoutedEventArgs e)
        {
            Department depart = new Department()
            {
                Id = Convert.ToInt32(tB_id.Text),
                Department_Name = tB_depatment_name.Text
            };

            try
            {
                _context.Departments.Add(depart);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Department", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_save_role(object sender, RoutedEventArgs e)
        {
            Role role = new Role()
            {
                Id = Convert.ToInt32(tB_roleid.Text),
                Role1 = tB_Namerole.Text
            };

            try
            {
                _context.Roles.Add(role);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Role", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
