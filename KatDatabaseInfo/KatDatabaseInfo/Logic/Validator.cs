using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Logic
{
    abstract class Validator
    {
        public static string errText { get; private set; }

        public Validator()
        {
            errText = string.Empty;
        }

        public bool Validate()
        {
            bool isValid = ValidateStatic();
            if (isValid)
            {
                return ValidateDynamic();
            }
            return isValid;
        }

        public abstract bool ValidateStatic();
        protected abstract bool ValidateDynamic();

        protected bool isDataValid(string date, string message)
        {
            DateTime dt;
            bool isValid = DateTime.TryParse(date, out dt);
            setErrMessage(message, isValid);
            return isValid;
        }

        public static bool isNullOrEmpty(string value, string valuePlace)
        {
            if (value == null || "".Equals(value))
            {
                setErrMessage("Стойността '" + valuePlace + "' е празна", false); ;
                return true;
            }

            return false;
        }

        protected bool IsLettersOnly(string value, string valueForValidation) //City, Country, FirstName, MiddleName, LastName @"^[a-zA-Z]+$"
        {
            Regex regex = new Regex(@"^[А-Я][а-яА-Я\s]{1,250}$");
            bool isValid = true;
            isValid &= regex.IsMatch(value);

            setErrMessage("Стойността на полето '" + valueForValidation + "' трябва да започва с главна буква и може да съдържа само букви на кирилица.", isValid); ;

            return isValid;
        }

        protected bool isDigitsOnly(int count, string forValidation) // DrivingLicenseNumber, IdNumber
        {
            Regex regex = new Regex(@"^\d{"+count+"}$");
            bool isValid = true;
            isValid &= regex.IsMatch(forValidation);
            return isValid;

        }

        protected bool isLengthValid(int length, string forValidation, string value)
        {
            bool isValid = forValidation.Length == length;
            setErrMessage("Дължината на '" + value + "' трябва да е " + length + ".", isValid);
            return isValid;
        }

        protected static void setErrMessage(string message, bool isValid)
        {
            if (!isValid)
            {
                errText += ("\n" + message);
            }
        }
    }
}
