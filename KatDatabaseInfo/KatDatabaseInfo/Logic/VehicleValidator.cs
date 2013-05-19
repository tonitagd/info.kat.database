using KatDatabaseInfo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Logic
{
    class VehicleValidator:Validator
    {
        private Vehicle _vehicle;

        public VehicleValidator(Vehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        public override bool ValidateStatic()
        {
            bool isValid = true;
            isValid &= isLengthValid(17, _vehicle.FrameNumber, "номер на рамата");
            isValid &= isLengthValid(9, _vehicle.EngineNumber, "номер на двигателя");
            isValid &= IsLettersOnly(_vehicle.Brand, "марка");
            isValid &= !isNullOrEmpty(_vehicle.Model, "модел");
            isValid &= isTypeValid(_vehicle.Type);
            isValid &= isSeatsValid();
            isValid &= isWeightValid();
            isValid &= IsLettersOnly(_vehicle.Color, "цвят");
            isValid &= isDataValid(_vehicle.RegistryDate, "Невалидна дата на регистрация.");
            isValid &= !isNullOrEmpty(_vehicle.RegistryNumber, "регистрационен номер");

            return isValid;
        }

        private bool isTypeValid(string value)
        {
            bool isValid = "лек".Equals(value) || "леко-товарен".Equals(value) || "тежко-товарен".Equals(value);
            string message = "Невалиден вид на МПС. Вида на МПС-то може да бъде лек, леко-товарен и тежко-товарен.";
            setErrMessage(message, isValid);
            return isValid;
        }

        private bool isSeatsValid()
        {
            bool isValid = _vehicle.Seats<53;
            isValid &= 0 < _vehicle.Seats;
            string message = "МПС-то не може да притежава повече от 52 места за сядане.";
            setErrMessage(message, isValid);
            return isValid;
        }

        private bool isWeightValid()
        {
            bool isValid = _vehicle.Weight < 10001;
            isValid &= _vehicle.Weight > 0;
            string message = "Собственото тегло на МПС-то не може да надвишава 10 тона(10000).";
            setErrMessage(message, isValid);
            return isValid;
        }

        protected override bool ValidateDynamic()
        {
            bool isRegValid = (VehicleData.GetVehicleByRegNumber(_vehicle.RegistryNumber) == null);
            setErrMessage("Съществува МПС с регистрационен номер: " + _vehicle.RegistryNumber + ".", isRegValid);
            bool isFrameValid = (VehicleData.GetVehicleByFrameNumber(_vehicle.FrameNumber) == null);
            setErrMessage("Съществува МПС с номер на рамата: " + _vehicle.FrameNumber + ".", isFrameValid);
            bool isEngValid = (VehicleData.GetVehicleByEngineNumber(_vehicle.EngineNumber) == null);
            setErrMessage("Съществува МПС с номер на двигателя: " + _vehicle.EngineNumber + ".", isEngValid);
            bool isDriverValid = (DriverData.GetDriverByLicenseID(_vehicle.DrivingLicenseNumber) != null);
            setErrMessage("Не съществува шофьор с номер на книжка: " + _vehicle.DrivingLicenseNumber + ".", isDriverValid);
            return isRegValid && isFrameValid && isEngValid && isDriverValid;
        }
    }
}
