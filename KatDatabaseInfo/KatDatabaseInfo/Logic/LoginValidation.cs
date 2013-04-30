using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private bool isEmtpy(string inputText)
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

    }
}
