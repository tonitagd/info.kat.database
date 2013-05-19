using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Data
{
    class VehicleData
    {
        private static VehicleDataClassesDataContext vehicleDataContext = new VehicleDataClassesDataContext();

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

        public static Vehicle GetVehicleByEngineNumber(string engineNumber)
        {
            var queryResult = (from vehicles in vehicleDataContext.GetTable<Vehicle>()
                               where (vehicles.EngineNumber == engineNumber)
                               select vehicles).ToArray<Vehicle>();
            if (queryResult.Count<Vehicle>() > 0)
            {
                return queryResult.ElementAt<Vehicle>(0);
            }
            return null;
        }

        public static Vehicle GetVehicleByFrameNumber(string frameNumber)
        {
            var queryResult = (from vehicles in vehicleDataContext.GetTable<Vehicle>()
                               where (vehicles.FrameNumber == frameNumber)
                               select vehicles).ToArray<Vehicle>();
            if (queryResult.Count<Vehicle>() > 0)
            {
                return queryResult.ElementAt<Vehicle>(0);
            }
            return null;
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

        public static void AddNewVehicle(Vehicle vehicle)
        {
            vehicleDataContext.AddNewVehicle(vehicle.RegistryNumber, vehicle.FrameNumber, vehicle.EngineNumber, vehicle.Brand, vehicle.Model, vehicle.Type, vehicle.Seats, vehicle.Weight, vehicle.Color, vehicle.RegistryDate, vehicle.DrivingLicenseNumber);
            vehicleDataContext.SubmitChanges();
        }

        public static void DeleteVehicle(string regNumber)
        {
            Vehicle vehicle = vehicleDataContext.Vehicles.Where<Vehicle>(anonymous => anonymous.RegistryNumber == regNumber).Single();
            vehicleDataContext.Vehicles.DeleteOnSubmit(vehicle);
            vehicleDataContext.SubmitChanges();
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
