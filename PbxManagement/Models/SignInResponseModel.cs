using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbxManagement.Models
{
    public class SignInResponseModel
    {
        public bool isSuccess { get; set; }
        public string Message { get; set; }

        public SignInResponseModel() { }

        public SignInResponseModel(bool success, string message)
        {
            isSuccess = success;
            Message = message;
        }
    }
}
