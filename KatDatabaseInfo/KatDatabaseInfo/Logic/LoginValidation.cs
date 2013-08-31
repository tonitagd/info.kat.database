using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatDatabaseInfo.Data;

namespace KatDatabaseInfo.Logic
{
    class LoginValidation
    {
        private string _username;
        private string _password;
        public string errText { get; private set; } //поле за запаметяване на възникналите грешки.

        public LoginValidation(string username, string password)
        {
            _username = username;
            _password = password;  
            errText = string.Empty;
        }

        private bool isEmpty(string inputText)
        {
            if (inputText == string.Empty)
            {
                return true;
            }
            return false;
        }

        private bool isShorterThan(string inputText, int length)
        {
            if (inputText.Length < length)
            {
                return true;
            }
            return false;
        }

        public bool ValidateUserInput(out User user)
        {
            user = null;
            if (isEmpty(_username))
            {
                errText = "Invalid username! It cannot be an empty value.";
                return false;
            }

            if (isEmpty(_password))
            {
                errText = "Invalid password! It cannot be an empty value.";
                return false;
            }

            if (isShorterThan(_password, 6))
            {
                errText = "Invalid password! It must be longer than 6 symbols";
                return false;
            }
            
            User queryResult = UserData.IsUserPassCorrect(_username, _password);

            if (queryResult == null)
            {
                errText += "Wrong username or password! Try again";
                return false;
            }
            user = queryResult;
            return true;
        }
    }
}
