using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDesk.Model;

namespace HelpDesk.Controller
{
    class LoginController
    {
        helpdeskEntities1 db = new helpdeskEntities1();

        public int cekLogin(string username, string password)
        {
            int cek = 0;
            var temp = db.Users.FirstOrDefault(db => db.Username == username && db.Password == password);
            try
            {
                if (temp.Username == username && temp.Password == password)
                {
                    cek = temp.RoleId;
                }
            }
            catch (Exception ex)
            {
                cek = 0;
                ex.GetBaseException();
            }
            return cek;
        }
    }
}
