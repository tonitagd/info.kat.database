using KatDatabaseInfo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Logic
{
    class DriverValidator : Validator
    {
        private Driver _driver;
        int role;

        public DriverValidator(Driver driver, int role)
        {
            this._driver = driver;
            this.role = role;
        }

        public override bool ValidateStatic()
        {
            bool isValid = true;

            isValid &= !areParametersEmpty();
            isValid &= IsLettersOnly(_driver.FirstName, "име");
            isValid &= IsLettersOnly(_driver.MiddleName, "презиме");
            isValid &= IsLettersOnly(_driver.LastName, "фамилия");
            isValid &= StartsWithCapital(_driver.FirstName, "име");
            isValid &= StartsWithCapital(_driver.MiddleName, "презиме");
            isValid &= StartsWithCapital(_driver.LastName, "фамилия");
            isValid &= IsDataValid(_driver.BirthDate, "Датата  на раждане не е въведена коректно. Формата трябва да е Месец.Ден.Година.");
            isValid &= isDigitsOnly();
            isValid &= isGenderValid();
            isValid &= IsLettersOnly(_driver.City, "град");
            isValid &= IsLettersOnly(_driver.Country, "държава");
            isValid &= StartsWithCapital(_driver.City, "град");
            isValid &= StartsWithCapital(_driver.Country, "държава");
            isValid &= arePointsLeftValid();
            isValid &= isRoleValid();

            return isValid;
        }

        private bool areParametersEmpty()
        {
            bool isValid = true;
            isValid &= isNullOrEmpty(_driver.DrivingCategories, "категории");
            isValid &= isNullOrEmpty(_driver.Address, "адрес");
            isValid &= isNullOrEmpty(_driver.PictureLocation, "местоположение на снимка");
            return isValid;
        }

        private bool isDigitsOnly()
        {
            bool isValid = isDigitsOnly(10, _driver.IdNumber);
            setErrMessage("Номера на личната карта трябва да съдържа само 10 цифри.", isValid); ;
            bool isLicenseValid = isDigitsOnly(9, _driver.DrivingLicenseNumber);
            setErrMessage("Номера на шофьорската книжка трябва да съдържа само 9 цифри.", isLicenseValid); ;
            return isValid & isLicenseValid;

        }

        private bool isGenderValid()
        {
            bool isValid = 0 == _driver.Gender || 1 == _driver.Gender;
            setErrMessage("Пола не е въведен коректно.", isValid);
            return isValid;
        }

        private bool arePointsLeftValid()
        {
            bool isValid = -1 < _driver.DrivingPointsLeft && _driver.DrivingPointsLeft < 40;
            setErrMessage("Точките не са въведени коректно.", isValid);
            return isValid;
        }

        private bool isRoleValid()
        {
            if (role == 0 || role == 1)
            {
                return true;  
            }
            setErrMessage("Ролята на потребителя не е зададена", false);
            return false;
        }

        protected override bool ValidateDynamic()
        {
            bool isValid = true;
            isValid &= (DriverData.GetDriverByLicenseID(_driver.DrivingLicenseNumber) == null);
            setErrMessage("Съществува шофьор с шофьорска книжка номер: " + _driver.DrivingLicenseNumber + ".", isValid);
            isValid &= (DriverData.GetDriverByIdNumber(_driver.IdNumber) == null);
            setErrMessage("Съществува шофьор с ЕГН: " + _driver.IdNumber + ".",isValid);
            return isValid;
        }
    }
}
