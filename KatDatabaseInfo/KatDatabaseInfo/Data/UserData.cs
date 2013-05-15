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
        private static DriversDataClassesDataContext driverDataContext = new DriversDataClassesDataContext();
        private static UsersDataClassesDataContext userDataContext = new UsersDataClassesDataContext();
        private static FinesDataClassesDataContext fineDataContext = new FinesDataClassesDataContext();
        private static VehicleDataClassesDataContext vehicleDataContext = new VehicleDataClassesDataContext();

        // Log in queries

        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password)
        {
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

        public static Vehicle GetVehicleByRegNumber(string regNumber)
        {
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
            var queryResult = (from users in userDataContext.GetTable<User>()
                               where (users.DrivingLicenseNumber == licenseID)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
            {
                return queryResult.ElementAt<User>(0).Role_;
            }
            return null;
        }

        // Get Data Sources for fines

        public static List<Fine> GetFineById(string id)
        {
            List<Fine> fineList = new List<Fine>();
            var queryResult = (from fines in fineDataContext.GetTable<Fine>()
                               where (fines.DrivingLicenseNumber == id)
                               select fines).ToArray<Fine>();

            for (int i = 0; i < queryResult.Count<Fine>(); i++)
            {
                fineList.Add(queryResult.ElementAt<Fine>(i));
            }

            return fineList;
        }

        public static List<Fine> GetAllFines()
        {
            List<Fine> fineList = new List<Fine>();
            var queryResult = (from fines in fineDataContext.GetTable<Fine>()
                               select fines).ToArray<Fine>();

            for (int i = 0; i < queryResult.Count<Fine>(); i++)
            {
                fineList.Add(queryResult.ElementAt<Fine>(i));
            }

            return fineList;
        }

        // Get Data Sources for fines

        public static List<Vehicle> GetVehicleById(string id)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            var queryResult = (from vehicles in vehicleDataContext.GetTable<Vehicle>()
                               where (vehicles.DrivingLicenseNumber == id)
                               select vehicles).ToArray<Vehicle>();

            for (int i = 0; i < queryResult.Count<Vehicle>(); i++)
            {
                vehicleList.Add(queryResult.ElementAt<Vehicle>(i));
            }

            return vehicleList;
        }

        public static List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vechiclesList = new List<Vehicle>();
            var queryResult = (from vechicles in vehicleDataContext.GetTable<Vehicle>()
                               select vechicles).ToArray<Vehicle>();

            for (int i = 0; i < queryResult.Count<Vehicle>(); i++)
            {
                vechiclesList.Add(queryResult.ElementAt<Vehicle>(i));
            }

            return vechiclesList;
        }

        //ADDING 

        public static void addDriver(Driver driver)
        {
            driverDataContext.AddNewDriver(driver.FirstName, driver.MiddleName, driver.LastName, driver.IdNumber, driver.BirthDate, driver.Gender, driver.Address, driver.Country, driver.City, driver.DrivingLicenseNumber, driver.DrivingCategories, driver.DrivingPointsLeft);
            driverDataContext.SubmitChanges();
        }

        public static void CreateUsernameAndPassword(User user)
        {
            userDataContext.CreateUsernameAndPassword(user.Username, user.Password, user.DrivingLicenseNumber, user.Role_);
            userDataContext.SubmitChanges();
        }

        public static void AddNewFine(Fine fine)
        {
            fineDataContext.AddNewFine(fine.Type, fine.SerialNumber, fine.Date, fine.Policeman, fine.DrivingLicenseNumber, fine.Paid, fine.Reason, fine.Amount);
            fineDataContext.SubmitChanges();
        }

        public static void AddNewVehicle(Vehicle vehicle)
        {
            vehicleDataContext.AddNewVehicle(vehicle.RegistryNumber, vehicle.FrameNumber, vehicle.EngineNumber, vehicle.Brand, vehicle.Model, vehicle.Type, vehicle.Seats, vehicle.Weight, vehicle.Color, vehicle.RegistryDate, vehicle.DrivingLicenseNumber);
            vehicleDataContext.SubmitChanges();
        }
        
        //DELETING
        public static void DeleteDriver(string drivingLicenseNumber)
        {
            Driver driver = driverDataContext.Drivers.Where<Driver>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            driverDataContext.Drivers.DeleteOnSubmit(driver);
            driverDataContext.SubmitChanges();
        }

        public static void DeleteUser(string drivingLicenseNumber)
        {
            User user = userDataContext.Users.Where<User>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            userDataContext.Users.DeleteOnSubmit(user);
            userDataContext.SubmitChanges();
        }

        public static void DeleteFine(string fineID)
        {
            Fine fine = fineDataContext.Fines.Where<Fine>(anonymous => anonymous.SerialNumber == fineID).Single();
            fineDataContext.Fines.DeleteOnSubmit(fine);
            fineDataContext.SubmitChanges();
        }

        public static void DeleteVehicle(string regNumber)
        {
            Vehicle vehicle = vehicleDataContext.Vehicles.Where<Vehicle>(anonymous => anonymous.RegistryNumber == regNumber).Single();
            vehicleDataContext.Vehicles.DeleteOnSubmit(vehicle);
            vehicleDataContext.SubmitChanges();
        }

        //UPDATING
        public static void UpdateDriver(string drivingLicenseNumber, string country, string city, string address, short pointsLeft, string drivingCategories, short? role)
        {
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

        public static void UpdateFine(string fineId, byte paid, decimal? amount)
        {
            Fine fine = fineDataContext.Fines.Where<Fine>(anonymous => anonymous.SerialNumber == fineId).Single();

            fine.Paid = paid;
            fine.Amount = amount;

            fineDataContext.SubmitChanges();
        }

        public static void UpdateVehicle(string frameNumber, string regNumber, string color, string drivingLicenseNumber)
        {
            Vehicle vehicle = vehicleDataContext.Vehicles.Where<Vehicle>(anonymous => anonymous.FrameNumber == frameNumber).Single();

            vehicle.RegistryNumber = regNumber;
            vehicle.Color = color;
            vehicle.DrivingLicenseNumber = drivingLicenseNumber;

            vehicleDataContext.SubmitChanges();
        }

       
    }
}
