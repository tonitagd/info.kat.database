using KatDatabaseInfo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Logic
{
    class FineValidator:Validator
    {
        private Fine _fine;

        public FineValidator(Fine fine)
        {
            this._fine = fine;
        }

        public override bool ValidateStatic()
        {
            bool isValid = true;

            isValid &= isTypeValid();
            isValid &= isPaidValid();
            isValid &= isAmountValid();
            isValid &= isDigitsOnly(); 
            isValid &= isDataValid(_fine.Date, "Датата не е въведена коректно");
            isValid &= isDataValid(_fine.Hour, "Часа не е въведен коректно");
            isValid &= IsLettersOnly(_fine.Location, "място");
            isValid &= IsLettersOnly(_fine.Policeman, "съставител");
            isValid &= !isNullOrEmpty(_fine.Reason, "Причина");

            return isValid;
        }

        private bool isAmountValid()
        {
            if (_fine.Paid == 0)
            {
                return !isNullOrEmpty(_fine.Amount.ToString(), "Стойност");
            }
            return true;
        }

        private bool isTypeValid()
        {
            bool isValid = ("Act" == _fine.Type || "Ticket" == _fine.Type);
            setErrMessage("Вида на глобата не е въведен коректно.", isValid);
            return isValid;
        }

        private bool isPaidValid()
        {
            bool isValid = (0 == _fine.Paid || 1 == _fine.Paid);
            setErrMessage("Полето 'платен' не е въведен коректно.", isValid);
            return isValid;
        }

        private bool isDigitsOnly()
        {
            bool isValid = isDigitsOnly(7, _fine.SerialNumber);
            setErrMessage("Номера на глобата трябва да съдържа точно 7 цифри", isValid);
            bool isLicenseValid = isDigitsOnly(9, _fine.DrivingLicenseNumber);
            setErrMessage("Номера на шофьорската книжка трябва да съдържа точно 9 цифри", isLicenseValid);
            return isValid && isLicenseValid;
        }

        protected override bool ValidateDynamic()
        {
            bool isSerialValid = (UserData.GetFineBySerialNumber(_fine.SerialNumber) == null);
            setErrMessage("Съществува глоба със сериен номер: " + _fine.SerialNumber + ".", isSerialValid);
            bool isDriverValid = (UserData.GetDriverByLicenseID(_fine.DrivingLicenseNumber) != null);
            setErrMessage("Не съществува шофьор с номер на книжка: " + _fine.DrivingLicenseNumber + ".", isDriverValid);
            return isDriverValid && isSerialValid;
        }
    }
}
