using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDesk.Models;

namespace HelpDesk.ViewModel
{
    class LoginVM
    {
        helpdeskEntitiesNew db = new helpdeskEntitiesNew();

        public bool cekLogin(string username, string password)
        {
            bool cek = false;
            var temp = db.Users.FirstOrDefault(db => db.Username == username && db.Password == password);

            try
            {
                if (temp.Username == username && temp.Password == password)
                {
                    cek = true;
                }
            }
            catch (Exception ex)
            {
                cek = true;
                ex.GetBaseException();
            }
            return cek;
        }


    }
}
