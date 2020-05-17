using PbxManagement.DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbxManagement.BLL.Controllers
{
    public class AccountsController
    {
        public string SignIn(string userName, string password)
        {
            return AccountHelper.TrySignIn(userName, password);
        }
    }
}
