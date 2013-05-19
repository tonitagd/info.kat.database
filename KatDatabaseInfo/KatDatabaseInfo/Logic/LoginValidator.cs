using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatDatabaseInfo.Data;

namespace KatDatabaseInfo.Logic
{
    class LoginValidator
    {
        private string _username;
        private string _password;
        public string errText { get; private set; } //поле за запаметяване на възникналите грешки.

        public LoginValidator(string username, string password)
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
                errText = "Невалидно потребителско име! Полето не може да е празно.";
                return false;
            }

            if (isEmpty(_password))
            {
                errText = "Невалидна парола! Полето не може да е празно.";
                return false;
            }

            if (isShorterThan(_password, 6))
            {
                errText = "Невалидна парола! Паролата трябва да е поне 6 символа дълга.";
                return false;
            }
            
            User queryResult = UserData.IsUserPassCorrect(_username, _password);

            if (queryResult == null)
            {
                errText += "Грешно потребителско име или парола! Опитайте пак.";
                return false;
            }
            user = queryResult;
            return true;
        }
    }
}
