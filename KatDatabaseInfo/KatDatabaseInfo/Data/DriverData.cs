using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Data
{
    class DriverData
    {
        private static DriversDataClassesDataContext driverDataContext = new DriversDataClassesDataContext();

        //Get Fillind Data queries

        public static Driver GetDriverByLicenseID(string licenseID)
        {
            var queryResult = (from drivers in driverDataContext.GetTable<Driver>()
                               where (drivers.DrivingLicenseNumber == licenseID)
                               select drivers).ToArray<Driver>();
            if (queryResult.Count<Driver>() > 0)
            {
                return queryResult.ElementAt<Driver>(0);
            }
            return null;
        }

        public static Driver GetDriverByIdNumber(string idNumber)
        {
            var queryResult = (from drivers in driverDataContext.GetTable<Driver>()
                               where (drivers.IdNumber == idNumber)
                               select drivers).ToArray<Driver>();
            if (queryResult.Count<Driver>() > 0)
            {
                return queryResult.ElementAt<Driver>(0);
            }
            return null;
        }

        public static void addDriver(Driver driver)
        {
            driverDataContext.AddNewDriver(driver.FirstName, driver.MiddleName, driver.LastName, driver.IdNumber, driver.BirthDate, driver.Gender, driver.Address, driver.Country, driver.City, driver.DrivingLicenseNumber, driver.DrivingCategories, driver.DrivingPointsLeft, driver.PictureLocation);
            driverDataContext.SubmitChanges();
        }

        public static void DeleteDriver(string drivingLicenseNumber)
        {
            Driver driver = driverDataContext.Drivers.Where<Driver>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            driverDataContext.Drivers.DeleteOnSubmit(driver);
            driverDataContext.SubmitChanges();
        }

        public static void UpdateDriver(string drivingLicenseNumber, string country, string city, string address, short pointsLeft, string drivingCategories, short? role)
        {
            UsersDataClassesDataContext userDataContext = new UsersDataClassesDataContext();
            Driver driver = driverDataContext.Drivers.Where<Driver>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            User user = userDataContext.Users.Where<User>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();

            driver.Country = country;
            driver.City = city;
            driver.Address = address;
            driver.DrivingPointsLeft = pointsLeft;
            driver.DrivingCategories = drivingCategories;
            user.Role_ = role;

            driverDataContext.SubmitChanges();
            userDataContext.SubmitChanges();
        }
    }
}
