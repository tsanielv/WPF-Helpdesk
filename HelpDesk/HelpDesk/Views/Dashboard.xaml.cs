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
using HelpDesk.Model;
using System.Text.RegularExpressions;

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

        /*1. Nama entitas model saat membuat koneksi database (helpdeskEntities1)
          2. _context => objek bebas*/
        helpdeskEntities1 _context = new helpdeskEntities1();

        /*Function untuk menghapus text input setelah input berhasil dilakukan. (Hapus data di textbox) */
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

        private void clearText()
        {
            tB_department_id.Clear();
            tB_department_name.Clear();
        }

        private void clearTextInputRole()
        {
            tB_roleid1.Clear();
            tB_Namerole.Clear();
        }

        private void clearTextInputCategory()
        {
            tB_categoryid.Clear();
            tB_categoryname.Clear();
        }

        private void clearTextInputType()
        {
            tB_type.Clear();
            tB_interval.Clear();
        }

        private void clearTextInputSubCategory()
        {
            tB_categoryid.Clear();
            tB_categoryname.Clear();
        }

        private void clearTextInputTicket()
        {
            tB_tid.Clear();
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
                Email = tB_email.Text,
                Departmentid = Convert.ToInt32(tB_departmentid.Text),
                RoleId = Convert.ToInt32(tB_roleid.Text)
            };

            try
            {
                _context.Users.Add(us);
                var result = _context.SaveChanges();
                clearText();
                viewUser(dgUser);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "User", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_save_department(object sender, RoutedEventArgs e)
        {
            Department depart = new Department()
            {
                Id = Convert.ToInt32(tB_department_id.Text),
                Department_Name = tB_department_name.Text
            };

            try
            {
                _context.Departments.Add(depart);
                var result = _context.SaveChanges();
                clearText();
                //viewDepartment(dgDepartment);
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
                Id = Convert.ToInt32(tB_roleid1.Text),
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

        private void button_save_category(object sender, RoutedEventArgs e)
        {
            Category cat = new Category()
            {
                //Id = Convert.ToInt32(tB_categoryid.Text),
                Category_Name = tB_categoryname.Text
            };

            try
            {
                _context.Categories.Add(cat);
                var result = _context.SaveChanges();
                clearTextInputCategory();
                viewCategory(dgCategory);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Category", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_save_type(object sender, RoutedEventArgs e)
        {
            DueDate type = new DueDate()
            {
                Type = tB_type.Text,
                Interval = Convert.ToInt32(tB_interval.Text)
            };

            try
            {
                _context.DueDates.Add(type);
                var result = _context.SaveChanges();
                clearTextInputType();
                viewType(dgType);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Type", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_save_subcategory(object sender, RoutedEventArgs e)
        {
            SubCategory sc = new SubCategory()
            {
                Id = Convert.ToInt32(tB_idscategory.Text),
                SubCategory_Name = tB_scategoryname.Text,
                CategoryId = Convert.ToInt32(tB_scategoryid.Text)
            };

            try
            {
                _context.SubCategories.Add(sc);
                var result = _context.SaveChanges();
                clearTextInputSubCategory();
                viewSubCategory(dgSubCategory);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Category", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_save_ticket(object sender, RoutedEventArgs e)
        {
            Ticket ticket = new Ticket()
            {
                Id = Convert.ToInt32(tB_tid.Text),
                Type = tB_ttype.Text,
                Description = tB_tdescription.Text,
                Dtm_Crt = Convert.ToDateTime(tB_tdtm.Text),
                L1 = tB_tl1.Text,
                DueDate = Convert.ToDateTime(tB_tdue.Text),
                Last_Update = Convert.ToDateTime(tB_tlast.Text),
                OnProgressDate = Convert.ToDateTime(tB_tonprog.Text),
                OnWaitingDate = Convert.ToDateTime(tB_tonwait.Text),
                OnHoldDate = Convert.ToDateTime(tB_tonhold.Text),
                ResolvedTime = Convert.ToDateTime(tB_tresolved.Text),
                ClosedTime = Convert.ToDateTime(tB_tclosed.Text),
                Technician = tB_ttechnician.Text,
                Status = tB_tstatus.Text,
                UsersId = Convert.ToInt32(tB_tuserid.Text),
                CategoryId = Convert.ToInt32(tB_tcategoryid.Text),
                SubCategoryId = Convert.ToInt32(tB_tsubcategoryid.Text)
            };

            try
            {
                _context.Tickets.Add(ticket);
                var result = _context.SaveChanges();
                clearText();
                viewTicket(dgTicket);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Input Success!", "Ticket", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Loaded_User(object sender, RoutedEventArgs e)
        {
            viewUser(dgUser);
        }

        private void Window_Loaded_Dept(object sender, RoutedEventArgs e)
        {
            //viewDepartment(dgDepartment);
        }

        private void Window_Loaded_Role(object sender, RoutedEventArgs e)
        {
            viewRole(dgRole);
        }

        private void Window_Loaded_Category(object sender, RoutedEventArgs e)
        {
            viewCategory(dgCategory);
        }
        private void Window_Loaded_Type(object sender, RoutedEventArgs e)
        {
            viewType(dgType);
        }

        private void Window_Loaded_SubCategory(object sender, RoutedEventArgs e)
        {
            viewSubCategory(dgSubCategory);
        }

        private void Window_Loaded_Ticket(object sender, RoutedEventArgs e)
        {
            viewTicket(dgTicket);
        }


        private void viewUser(DataGrid DG)
        {
            DG.ItemsSource = _context.Users.ToList();
        }

        private void viewDepartment(DataGrid DG)
        {
            DG.ItemsSource = _context.Departments.ToList();
        }

        private void viewTicket(DataGrid DG)
        {
            DG.ItemsSource = _context.Tickets.ToList();
        }


        private void viewRole(DataGrid DG)
        {
            DG.ItemsSource = _context.Roles.ToList();
        }

        private void viewCategory(DataGrid DG)
        {
            DG.ItemsSource = _context.Categories.ToList();
        }

        private void viewType(DataGrid DG)
        {
            DG.ItemsSource = _context.DueDates.ToList();
        }

        private void viewSubCategory(DataGrid DG)
        {
            DG.ItemsSource = _context.Categories.ToList();
        }

        private void dgRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgSubCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void LetterValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}