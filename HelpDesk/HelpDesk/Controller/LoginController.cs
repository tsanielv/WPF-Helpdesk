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

        public bool cekLogin(string username, string password)
        {
            bool cek = false;
            var temp = db.Users.FirstOrDefault();
            try
            {
                if (temp.Username == username && temp.Password == password)
                {
                    cek = true;
                }
            }
            catch (Exception ex)
            {
                cek = false;
                ex.GetBaseException();
            }
            return cek;
        }
    }
}
