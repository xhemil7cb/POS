using System;
using System.Collections.Generic;
using System.Text;

namespace POS
{

    // Creating a class with login credential to keep code clean
     class LoginCredentials
    {

        public string Username;
        public string Password;

        public LoginCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

}
