using PbxManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbxManagement.DAL.Helpers
{
    public static class AccountHelper
    {
        public static string TrySignIn(string userName, string password)
        {
            using (var context = new PbxManagementEntities())
            {
                var responseMessage = new ObjectParameter("responseMessage", typeof(string));

                context.appSignIn(userName, password, responseMessage);

                return Convert.ToString(responseMessage.Value);
            }
        }
    }
}
