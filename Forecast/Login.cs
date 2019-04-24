using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Forecast
{
    class Login
    {
        public string Username { get; set; }
        public string UserPassword { get; set; }

        public Login(string username, string userPassword)
        {
            Username = username;
            UserPassword = userPassword;
        }

        private bool isString(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern)) return true;
            else return false;
        }
        private void Reset(string username, string password)
        {
            username = String.Empty;
            password = String.Empty;
        }
        internal bool isLoggedIn(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter your username");
                return false;
            }
            else if (isString(username) == true) //This part doesnt make sense
            {
                MessageBox.Show("Enter valid text only");
                Reset(username, password);
                return false;
            }
            else //Test if password is null
            {
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Enter your password!");
                    return false;
                }
                else if (UserPassword != password)
                {
                    MessageBox.Show("Password is incorrect");
                    return false;
                }
                else { return true; }
            }

        }
    }
}
