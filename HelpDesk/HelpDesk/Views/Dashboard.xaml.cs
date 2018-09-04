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
using System.Data.Entity.Validation;

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

        /*Class untuk memanggil data view, sehingga data dari database bisa ditampilkan kedalam grid view */
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewDepartment(dgDepartment);
            viewRole(dgRole);
            viewUser(dgUser);
            viewCategory(dgCategory);
            viewSubCategory(dgSubCategory);
            viewType(dgType);
            LoadIdComboBox();
        }

        /*1. Nama entitas model saat membuat koneksi database (helpdeskEntitasNew)
          2. _context => objek bebas*/
        helpdeskEntitiesNew _context = new helpdeskEntitiesNew();

        public object RoleId { get; private set; }

        /*================================================= R O L E   S T A R T ============================================= */

        /*Function untuk menghapus text input setelah input berhasil dilakukan. (Hapus data di textbox) */
        private void clearTextInputRole()
        {
            tb_r_id.Clear();
            tb_r_namerole.Clear();
        }

        //Function Save
        private void button_save_role(object sender, RoutedEventArgs e)
        {
            Role role = new Role()
            {
                //Id = Convert.ToInt32(tb_r_id.Text), (AUTO INCREAMENT)
                Role1 = tb_r_namerole.Text
            };

            try
            {
                _context.Roles.Add(role);
                var result = _context.SaveChanges();
                clearTextInputRole(); //Memanggil Fungsi, supaya setelah pengisian data di textbox terhapus
                viewRole(dgRole); //Memanggil Fungsi, supaya setelah insert data, data langsung update menuju datagrid
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            cb_u_roleid.ItemsSource = _context.Roles.ToList(); //supaya data terbaru muncul pada combo box.
            MessageBox.Show("Data Role Berhasil Ditambahkan!", "Role", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //Function View
        private void viewRole(DataGrid DG)
        {
            DG.ItemsSource = _context.Roles.ToList(); //Menampilkan data (select biasa)
        }

        //FUnction Search (Integrasi dengan Update)
        private Role SearchIdRole(int id)
        {
            var role = _context.Roles.Find(id);
            if (role == null)
            {
                MessageBox.Show("ID Role" + id + "Tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            return role;
        }


        //Function Update
        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgRole.SelectedItem;
            string temp_id = (dgRole.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            Role role = SearchIdRole(id);
            role.Role1 = tb_r_namerole.Text;

            _context.Entry(role).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            clearTextInputRole();
            this.viewRole(dgRole);
            MessageBox.Show("Data Role Berhasil Diubah !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        //Function Grid (Tampil Data)
        private void dgRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgRole.SelectedItem;
                string id = (dgRole.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                tb_r_id.Text = id;
                string role1 = (dgRole.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_r_namerole.Text = role1;
            }
            catch (Exception ex)
            {

            }
        }

        //Function Delete
        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            object item = dgRole.SelectedItem;
            string temp_id = (dgRole.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);
            Role role = SearchIdRole(id);
            _context.Entry(role).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            clearTextInputRole();
            this.viewRole(dgRole);
            MessageBox.Show("Data Role Berhasil di hapus !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        /*================================================= R O L E   E N D ============================================= */




        /*======================================= D E P A R T M E N T   S T A R T ======================================== */

        /*Function untuk menghapus text input setelah input berhasil dilakukan. (Hapus data di textbox) */
        private void clearTextInputDepartment()
        {
            tb_d_id.Clear();
            tb_d_namedepartment.Clear();
        }

        /*Function aksi ketika klik tombol save */
        private void button_save_department(object sender, RoutedEventArgs e)
        {
            /*Department merupakan nama table entitas di database */
            Department depart = new Department()
            {
                /*Id dan Department_Name merupakan field dari table Department. */
                //Id = Convert.ToInt32(tb_d_id .Text),
                Department_Name = tb_d_namedepartment.Text
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
            cb_u_departmentid.ItemsSource = _context.Departments.ToList();
            MessageBox.Show("Data Department Berhasil Ditambahkan!", "Department", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void viewDepartment(DataGrid DG)
        {
            DG.ItemsSource = _context.Departments.ToList();
        }


        private Department SearchByIdDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            if (department == null)
            {
                MessageBox.Show("ID Department" + id + "Tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return department;
        }


        private void button_edit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgDepartment.SelectedItem;
            string temp_id = (dgDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            Department depart = SearchByIdDepartment(id);
            depart.Department_Name = tb_d_namedepartment.Text;

            _context.Entry(depart).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            clearTextInputDepartment();
            this.viewDepartment(dgDepartment);
            MessageBox.Show("Data Department Berhasil Diubah !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void dgDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgDepartment.SelectedItem;
                string id = (dgDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                tb_d_id.Text = id;
                string department_name = (dgDepartment.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_d_namedepartment.Text = department_name;
            }
            catch (Exception ex)
            {

            }
        }


        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            object item = dgDepartment.SelectedItem;
            string temp_id = (dgDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;


            int id = Convert.ToInt32(temp_id);

            Department depart = SearchByIdDepartment(id);
            _context.Entry(depart).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            clearTextInputDepartment();
            this.viewDepartment(dgDepartment);

            MessageBox.Show("Data Department Berhasil Dihapus !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /*======================================= D E P A R T M E N T   E N D ============================================ */




        /*============================================ U S E R   S T A R T =============================================== */
        private void clearTextInputUser()
        {
            tb_u_id.Clear();
            tb_u_username.Clear();
            tb_u_password.Clear();
            tb_u_firstName.Clear();
            tb_u_lastName.Clear();
            tb_u_address.Clear();
            tb_u_city.Clear();
            tb_u_phone.Clear();
            tb_u_email.Clear();
        }


        private void button_save_user(object sender, RoutedEventArgs e)
        {
            User us = new User()
            {
                //Id = Convert.ToInt32(tb_u_id.Text),
                Username = tb_u_username.Text,
                Password = tb_u_password.Text,
                First_Name = tb_u_firstName.Text,
                Last_Name = tb_u_lastName.Text,
                Address = tb_u_address.Text,
                City = tb_u_city.Text,
                Phone = tb_u_phone.Text,
                Email = tb_u_email.Text,
                Departmentid = Convert.ToInt32(cb_u_departmentid.SelectedValue),
                Roleid = Convert.ToInt32(cb_u_roleid.SelectedValue)
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
            MessageBox.Show("Data User Berhasil Ditambahkan!", "User", MessageBoxButton.OK, MessageBoxImage.Information);
            clearTextInputUser();
        }


         private void viewUser (DataGrid DG)
        {
            var user = from d in _context.Departments.ToList() join u in _context.Users.ToList()
                       on d.Id equals u.Departmentid join r in _context.Roles.ToList()
                       on u.Roleid equals r.Id
                       select u;

            DG.ItemsSource = user.ToList();
        }


        private User SearchIduser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                MessageBox.Show("ID User" + id + "Tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return user;

        }

        //Edit User
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgUser.SelectedItem;
            string temp_id = (dgUser.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            User user = SearchIduser(id);
            user.Username = tb_u_username.Text;
            user.Password = tb_u_password.Text;
            user.First_Name = tb_u_firstName.Text;
            user.Last_Name = tb_u_lastName.Text;
            user.Address = tb_u_address.Text;
            user.City = tb_u_city.Text;
            user.Phone = tb_u_phone.Text;
            user.Email = tb_u_email.Text;
            user.Departmentid = Convert.ToInt32(cb_u_departmentid.SelectedValue);
            user.Roleid = Convert.ToInt32(cb_u_roleid.SelectedValue);


            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            clearTextInputUser();
            this.viewUser(dgUser);
            MessageBox.Show("Data User Berhasil Diubah !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void dgUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgUser.SelectedItem;
                string id = (dgUser.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                tb_d_id.Text = id;
                string firstname = (dgUser.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_firstName.Text = firstname;
                string lastname = (dgUser.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_lastName.Text = lastname;
                string username = (dgUser.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_username.Text = username;
                string password = (dgUser.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_password.Text = password;
                string address = (dgUser.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_address.Text = address;
                string city = (dgUser.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_city.Text = city;
                string phone = (dgUser.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_phone.Text = phone;
                string email = (dgUser.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
                tb_u_email.Text = email;
                string departmentid = (dgUser.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text;
                cb_u_departmentid.Text = departmentid;
                string roleid = (dgUser.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text;
                cb_u_roleid.Text = roleid;
            }
            catch (Exception ex)
            {

            }
        }


        //delete user
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            object item = dgUser.SelectedItem;
            string temp_id = (dgUser.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);
            User user = SearchIduser(id);
            _context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            clearTextInputUser();
            this.viewUser(dgUser);
            MessageBox.Show("Data User Berhasil Dihapus !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /*============================================ U S E R   E N D =================================================== */




        /*============================================ C A T E G O R Y   S T A R T ======================================== */
        private void clearTextInputCategory()
        {
            tb_c_id.Clear();
            tb_c_categoryname.Clear();
        }

        private void viewCategory(DataGrid DG)
        {
            DG.ItemsSource = _context.Categories.ToList();
        }


        //save category
        private void btn_c_save_Click(object sender, RoutedEventArgs e)
        {
            Category cat = new Category()
            {
                //Id = Convert.ToInt32(tb_r_id.Text),
                Category_Name = tb_c_categoryname.Text
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
            
            cb_sc_categoriid.ItemsSource = _context.Categories.ToList();
            MessageBox.Show("Data Category Berhasil Ditambahkan!", "Category", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private Category SearchIdCategory(int id)
        {
            var cat = _context.Categories.Find(id);
            if (cat == null)
            {
                MessageBox.Show("ID Category" + id + "Tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return cat;

        }
        

        private void btn_c_edit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgCategory.SelectedItem;
            string temp_id = (dgCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            Category cat = SearchIdCategory(id);
            cat.Category_Name = tb_c_categoryname.Text;

            _context.Entry(cat).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            clearTextInputCategory();
            this.viewCategory(dgCategory);
            MessageBox.Show("Data Category Berhasil Diubah!", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void dgCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgCategory.SelectedItem;
                string id = (dgCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                tb_c_id.Text = id;
                string category_name = (dgCategory.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_c_categoryname.Text = category_name;
            }
            catch (Exception ex)
            {

            }
        }


        private void btn_c_delete_Click(object sender, RoutedEventArgs e)
        {
            object item = dgCategory.SelectedItem;
            string temp_id = (dgCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);
            Category cat = SearchIdCategory(id);
            _context.Entry(cat).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            clearTextInputCategory();
            this.viewCategory(dgCategory);
            MessageBox.Show("Data Category Berhasil Dihapus !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /*============================================ C A T E G O R Y   E N D =========================================== */



        /*======================================== S U B   C A T E G O R Y   S T A R T ===================================*/

        private void clearTextInputSubCategory()
        {
            tb_sc_id.Clear();
            tb_sc_subcategoryname.Clear();
            
        }

        private void viewSubCategory(DataGrid DG)
        {
            var sub = from c in _context.Categories.ToList() join sc in _context.SubCategories.ToList()
                       on c.Id equals sc.CategoryId select sc;
            DG.ItemsSource = sub.ToList();
        }

        private void btn_sc_save_Click(object sender, RoutedEventArgs e)
        {
            SubCategory subcat = new SubCategory()
            {
                //Id = Convert.ToInt32(tb_r_id.Text),
                SubCategory_Name = tb_sc_subcategoryname.Text,
                CategoryId = Convert.ToInt32(cb_sc_categoriid.SelectedValue)
            };

            try
            {
                _context.SubCategories.Add(subcat);
                var result = _context.SaveChanges();
                clearTextInputSubCategory();
                viewSubCategory(dgSubCategory);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            cb_tk_admin.ItemsSource = _context.Users.Where(admin => admin.Roleid == 11).ToList();
            cb_tk_technician.ItemsSource = _context.Users.Where(admin => admin.Roleid == 12).ToList();
            cb_tk_user.ItemsSource = _context.Users.Where(admin => admin.Roleid == 13).ToList();
            MessageBox.Show("Data Sub Kategori Berhasil Dihapus !", "Sub Kategori", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private SubCategory SearchIdSubCategory(int id)
        {
            var subcat = _context.SubCategories.Find(id);
            if (subcat == null)
            {
                MessageBox.Show("ID Sub Kayegori" + id + "Tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return subcat;

        }

        private void dgSubCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgSubCategory.SelectedItem;
                string id = (dgSubCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                tb_sc_id.Text = id;
                string subcategory_name = (dgSubCategory.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_sc_subcategoryname.Text = subcategory_name;
                string categoryid = (dgSubCategory.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                cb_sc_categoriid.Text = categoryid;
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_sc_edit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgSubCategory.SelectedItem;
            string temp_id = (dgSubCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(temp_id);

            SubCategory subcat = SearchIdSubCategory(id);
            subcat.SubCategory_Name = tb_sc_subcategoryname.Text;
            subcat.CategoryId = Convert.ToInt32(cb_sc_categoriid.SelectedValue);

            _context.Entry(subcat).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            clearTextInputSubCategory();
            this.viewSubCategory(dgSubCategory);
            MessageBox.Show("Data Sub Kategori Berhasil Diubah !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn_sc_delete_Click(object sender, RoutedEventArgs e)
        {
            object item = dgType.SelectedItem;
            string temp_type = (dgType.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;


            string type = temp_type;

            DueDate due = SearchIdType(type);
            _context.Entry(due).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            clearTextInputType();
            this.viewType(dgType);

            MessageBox.Show("Data Type Berhasil Dihapus !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        /*======================================== S U B  C A T E G O R Y  E N D ==========================================*/



        /*============================================  T Y P E   S T A R T ================================================*/

        private void clearTextInputType()
        {
            tb_t_interval.Clear();

        }

        private void viewType(DataGrid DG)
        {
            
            DG.ItemsSource = _context.DueDates.ToList();
        }


        private void btn_t_save_Click(object sender, RoutedEventArgs e)
        {
            DueDate type = new DueDate()
            {
                Type = cb_t_type.Text,
                Interval = Convert.ToInt32(tb_t_interval.Text)
            };

            try
            {
                _context.DueDates.Add(type);
                var result = _context.SaveChanges();
                clearTextInputType(); //Memanggil Fungsi, supaya setelah pengisian data di textbox terhapus
                viewType(dgType); //Memanggil Fungsi, supaya setelah insert data, data langsung update menuju datagrid
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            MessageBox.Show("Data Type Berhasil Ditambahkan!", "Role", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void dgType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgType.SelectedItem;
                string type = (dgType.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                cb_t_type.Text = type;
                string interval = (dgType.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_t_interval.Text = interval;

            }
            catch (Exception ex)
            {

            }
        }

        private DueDate SearchIdType(string type )
        {
            var type1 = _context.DueDates.Find(type);
            if (type1 == null)
            {
                MessageBox.Show( type + "Tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            return type1;
        }

        private void btn_t_edit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgType.SelectedItem;
            string temp_type = (dgType.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            string type = temp_type;

            DueDate due = SearchIdType(type);
            due.Interval = Convert.ToInt32(tb_t_interval.Text);

            _context.Entry(due).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            clearTextInputType();
            this.viewType(dgType);
            MessageBox.Show("Data Type Berhasil Diubah!", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn_t_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        /*============================================ T Y P E   E N D =====================================================*/



        /*================================================ T I C K E T   S T A R T ===========================================*/
        private void clearTextInputTicket()
        {
            

        }

        private void viewTicket(DataGrid DG)
        {

            DG.ItemsSource = _context.Tickets.ToList();
        }



        /*================================================ T I C K E T   E N D ==============================================*/


















        public void LoadIdComboBox()
        {
            //Supaya tampil di combo box user, field departmentid
            cb_u_departmentid.DisplayMemberPath = "Department_Name";
            cb_u_departmentid.SelectedValuePath = "Id";
            cb_u_departmentid.ItemsSource = _context.Departments.ToList();

            //Supaya tampil di combo box user, field roleid
            cb_u_roleid.DisplayMemberPath = "Role1";
            cb_u_roleid.SelectedValuePath = "Id";
            cb_u_roleid.ItemsSource = _context.Roles.ToList();

            //Supaya tampil di combo box sub category, field categoriid
            cb_sc_categoriid.DisplayMemberPath = "Category_Name";
            cb_sc_categoriid.SelectedValuePath = "Id";
            cb_sc_categoriid.ItemsSource = _context.Categories.ToList();

            //Supaya tampil di combo box ticket, field admin
            cb_tk_admin.DisplayMemberPath = "Username";
            cb_tk_admin.SelectedValuePath = "Id";
            cb_tk_admin.ItemsSource = _context.Users.Where(admin => admin.Roleid == 11).ToList();

            cb_tk_technician.DisplayMemberPath = "Username";
            cb_tk_technician.SelectedValuePath = "Id";
            cb_tk_technician.ItemsSource = _context.Users.Where(admin => admin.Roleid == 12).ToList();

            cb_tk_user.DisplayMemberPath = "Username";
            cb_tk_user.SelectedValuePath = "Id";
            cb_tk_user.ItemsSource = _context.Users.Where(admin => admin.Roleid == 13).ToList();

            cb_tk_category.DisplayMemberPath = "Category_Name";
            cb_tk_category.SelectedValuePath = "Id";
            cb_tk_category.ItemsSource = _context.Categories.ToList();

            cb_tk_subcategory.DisplayMemberPath = "SubCategory_Name";
            cb_tk_subcategory.SelectedValuePath = "Id";
            cb_tk_subcategory.ItemsSource = _context.SubCategories.ToList();
        }

        private void btn_tk_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_tk_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_tk_delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
