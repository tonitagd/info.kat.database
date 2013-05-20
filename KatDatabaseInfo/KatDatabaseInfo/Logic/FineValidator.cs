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

            isValid &= IsTypeValid();
            isValid &= IsPaidValid();
            isValid &= IsAmountValid();
            isValid &= IsDigitsOnly();
            isValid &= IsDataValid(_fine.Date, "Датата не е въведена коректно.Формата трябва да е Месец.Ден.Година.");
            isValid &= IsDataValid(_fine.Hour, "Часа не е въведен коректно.");
            isValid &= IsLettersOnly(_fine.Location, "място");
            isValid &= IsLettersOnly(_fine.Policeman, "съставител");
            isValid &= StartsWithCapital(_fine.Policeman, "съставител");
            isValid &= !isNullOrEmpty(_fine.Reason, "Причина");

            return isValid;
        }

        private bool IsAmountValid()
        {
            if (_fine.Paid == 0)
            {
                return !isNullOrEmpty(_fine.Amount.ToString(), "дължима сума");
            }
            return true;
        }

        private bool IsTypeValid()
        {
            bool isValid = ("Act" == _fine.Type || "Ticket" == _fine.Type);
            setErrMessage("Вида на глобата не е въведен коректно.", isValid);
            return isValid;
        }

        private bool IsPaidValid()
        {
            bool isValid = (0 == _fine.Paid || 1 == _fine.Paid);
            setErrMessage("Полето 'платен' не е въведен коректно.", isValid);
            return isValid;
        }

        private bool IsDigitsOnly()
        {
            bool isValid = isDigitsOnly(7, _fine.SerialNumber);
            setErrMessage("Номера на глобата трябва да съдържа точно 7 цифри", isValid);
            bool isLicenseValid = isDigitsOnly(9, _fine.DrivingLicenseNumber);
            setErrMessage("Номера на шофьорската книжка трябва да съдържа точно 9 цифри", isLicenseValid);
            return isValid && isLicenseValid;
        }

        protected override bool ValidateDynamic()
        {
            bool isSerialValid = (FineData.GetFineBySerialNumber(_fine.SerialNumber) == null);
            setErrMessage("Съществува глоба със сериен номер: " + _fine.SerialNumber + ".", isSerialValid);
            bool isDriverValid = (DriverData.GetDriverByLicenseID(_fine.DrivingLicenseNumber) != null);
            setErrMessage("Не съществува шофьор с номер на книжка: " + _fine.DrivingLicenseNumber + ".", isDriverValid);
            return isDriverValid && isSerialValid;
        }
    }
}
