using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KatDatabaseInfo.Data
{
    class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password)
        {
            UsersDataClassesDataContext userDataContext = new UsersDataClassesDataContext();
            User[] queryResult = (from users in userDataContext.GetTable<User>()
                                  where (users.Username == username) &&
                                  (users.Password == password)
                                  select users).ToArray<User>();
            return _GetQueryResult(queryResult);
        }

        private static User _GetQueryResult(User[] queryResult)
        {
            if (queryResult.Count<User>() > 0)
            {
                return queryResult.ElementAt<User>(0);
            }
            return null;
        }

        public static Driver GetDriverByLicenseID(string licenseID)
        {
            DriversDataClassesDataContext driverDataContext = new DriversDataClassesDataContext();
            var queryResult = (from drivers in driverDataContext.GetTable<Driver>()
                               where (drivers.DrivingLicenseNumber == licenseID)
                               select drivers).ToArray<Driver>();
            if (queryResult.Count<Driver>() > 0)
            {
                return queryResult.ElementAt<Driver>(0);
            }
            return null;
        }

        public static Vehicle GetVehicleByRegNumber(string regNumber)
        {
            VehicleDataClassesDataContext vehicleDataContext = new VehicleDataClassesDataContext();
            var queryResult = (from vehicles in vehicleDataContext.GetTable<Vehicle>()
                               where (vehicles.RegistryNumber == regNumber)
                               select vehicles).ToArray<Vehicle>();
            if (queryResult.Count<Vehicle>() > 0)
            {
                return queryResult.ElementAt<Vehicle>(0);
            }
            return null;
        }

        public static Fine GetFineBySerialNumber(string serialNumber)
        {
            FinesDataClassesDataContext fineDataContext = new FinesDataClassesDataContext();
            var queryResult = (from fines in fineDataContext.GetTable<Fine>()
                               where (fines.SerialNumber == serialNumber)
                               select fines).ToArray<Fine>();
            if (queryResult.Count<Fine>() > 0)
            {
                return queryResult.ElementAt<Fine>(0);
            }
            return null;
        }

        public static short? GetUserRoleByLicenseID(string licenseID)
        {
            UsersDataClassesDataContext userDataContext = new UsersDataClassesDataContext();
            var queryResult = (from users in userDataContext.GetTable<User>()
                               where (users.DrivingLicenseNumber == licenseID)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
            {
                return queryResult.ElementAt<User>(0).Role_;
            }
            return null;
        }

        //ADDING 
        public static void addDriver(Driver driver)
        {
            DriversDataClassesDataContext dc = new DriversDataClassesDataContext();
            dc.AddNewDriver(driver.FirstName, driver.MiddleName, driver.LastName, driver.IdNumber, driver.BirthDate, driver.Gender, driver.Address, driver.Country, driver.City, driver.DrivingLicenseNumber, driver.DrivingCategories, driver.DrivingPointsLeft);
            dc.SubmitChanges();
        }

        public static void CreateUsernameAndPassword(User user)
        {
            UsersDataClassesDataContext dc = new UsersDataClassesDataContext();
            dc.CreateUsernameAndPassword(user.Username, user.Password, user.DrivingLicenseNumber, user.Role_);
            dc.SubmitChanges();
        }

        public static void AddNewFine(Fine fine)
        {
            FinesDataClassesDataContext dc = new FinesDataClassesDataContext();
            dc.AddNewFine(fine.Type, fine.SerialNumber, fine.Date, fine.Policeman, fine.DrivingLicenseNumber, fine.Paid, fine.Reason, fine.Amount);
            dc.SubmitChanges();
        }
        
        //DELETING
        public static void DeleteDriver(string drivingLicenseNumber)
        {
            DriversDataClassesDataContext dc = new DriversDataClassesDataContext();
            Driver driver = dc.Drivers.Where<Driver>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            dc.Drivers.DeleteOnSubmit(driver);
            dc.SubmitChanges();
        }

        public static void DeleteUser(string drivingLicenseNumber)
        {
            UsersDataClassesDataContext dc = new UsersDataClassesDataContext();
            User user = dc.Users.Where<User>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            dc.Users.DeleteOnSubmit(user);
            dc.SubmitChanges();
        }

        internal static void DeleteFine(string fineID)
        {
            FinesDataClassesDataContext dc = new FinesDataClassesDataContext();
            Fine fine = dc.Fines.Where<Fine>(anonymous => anonymous.SerialNumber == fineID).Single();
            dc.Fines.DeleteOnSubmit(fine);
            dc.SubmitChanges();
        }
    }
}
