using PbxManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbxManagement.BLL
{
    public class AccountController
    {
        public string SignIn (string username, string password)
        {
            using (var context = new PbxManagementEntities())
            {
                var responseMessage = new ObjectParameter("responseMessage", typeof(string));

                context.appSignIn(username, password, responseMessage);

                return Convert.ToString(responseMessage.Value);
            }
        }
    }
}
