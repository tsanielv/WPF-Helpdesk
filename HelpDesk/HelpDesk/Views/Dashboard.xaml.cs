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
        /*
        Function Bawaan
        */
        public Dashboard()
        {
            InitializeComponent();
        }

        /*1. Nama entitas model saat membuat koneksi database (helpdeskEntitasNew)
          2. _context => objek bebas*/
        helpdeskEntitiesNew _context = new helpdeskEntitiesNew();


        /*Function untuk menghapus text input setelah input berhasil dilakukan. (Hapus data di textbox) */
        private void clearTextInputDepartment()
        {
            tB_id.Clear();
            tB_depatment_name.Clear();
        }

        /*Function untuk menghapus text input setelah input berhasil dilakukan. (Hapus data di textbox) */
        private void clearTextInputRole()
        {
            tB_roleid.Clear();
            tB_Namerole.Clear();
        }

        private void clearTextInputUser()
        {
            tB_idUser.Clear();
            tB_username.Clear();
            tB_password.Clear();
            tB_firstName.Clear();
            tB_lastName.Clear();
            tB_address.Clear();
            tB_city.Clear();
            tB_phone.Clear();
            tB_email.Clear();
            tB_departmentid.Clear();
            tB_roleid.Clear();
        }

        /*Function aksi ketika klik tombol save */
        private void button_save_department(object sender, RoutedEventArgs e)
        {
            /*Department merupakan nama table entitas di database */
            Department depart = new Department()
            {
                /*Id dan Department_Name merupakan field dari table Department. */
                Id = Convert.ToInt32(tB_id.Text),
                Department_Name = tB_depatment_name.Text
            };

            try
            {
                _context.Departments.Add(depart);
                var result = _context.SaveChanges(); /* Kondisi setelah save berhasil */
                clearTextInputDepartment();/* Fungsi clear dipanggil */
                viewDepartment(dgDepartment); /* fungsi untuk me load data table secara otomatis setelah input berhasil */
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
                clearTextInputRole();
                viewRole(dgRole);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Role", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_save_user(object sender, RoutedEventArgs e)
        {
        User us = new User()
            {
                Id = Convert.ToInt32(tB_idUser.Text),
                Username = tB_username.Text,
                Password = tB_password.Text,
                First_Name = tB_firstName.Text,
                Last_Name = tB_lastName.Text,
                Address = tB_address.Text,
                City = tB_city.Text,
                Phone = tB_phone.Text,
                Email = tB_email.Text
            };

            try
            {
                _context.Users.Add(us);
                _context.SaveChanges();
                
                viewUser(dgUser);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "User", MessageBoxButton.OK, MessageBoxImage.Information);
            clearTextInputUser();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewDepartment(dgDepartment);
            viewRole(dgRole);
            viewUser(dgUser);
        }

        private void viewDepartment(DataGrid DG)
        {
            DG.ItemsSource = _context.Departments.ToList();
        }

        private void viewRole (DataGrid DG)
        {
            DG.ItemsSource = _context.Roles.ToList();
        }

        private void viewUser (DataGrid DG)
        {
            DG.ItemsSource = _context.Users.ToList();
        }

        private void dgRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
