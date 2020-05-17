﻿using System;
using System.Data.Entity.Core.Objects;
using PbxManagement.Models;

namespace PbxManagement.Helpers
{
    public static class AccountHelper
    {
        private static readonly string _responseSuccess = "User successfully logged in";
        private static readonly string _responseIncorrectLogin = "Invalid login";
        private static readonly string _responseIncorrectPassword = "Incorrect password";
        
        public static SignInResponseModel TrySignIn(string userName, string password)
        {
            string result = string.Empty;
            using (var context = new AccountEntities())
            {
                var responseMessage = new ObjectParameter("responseMessage", typeof(string));
                context.appSignIn(userName, password, responseMessage);

                result = Convert.ToString(responseMessage.Value);
            }

            var response = new SignInResponseModel();
            if (result.Equals(_responseSuccess))
            {
                response.isSuccess = true;
                response.Message = _responseSuccess;
            }
            if (result.Equals(_responseIncorrectLogin))
            {
                response.isSuccess = false;
                response.Message = _responseIncorrectLogin;
            }
            if (result.Equals(_responseIncorrectPassword))
            {
                response.isSuccess = false;
                response.Message = _responseIncorrectPassword;
            }

            return response;
        }
    }
}
