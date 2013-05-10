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

       /* public static bool addDriver(Driver driver)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Personal data\TU\III Kurs\II semestyr\PS\repository\info.kat.database\KatDatabaseInfo\KatDatabaseInfo\Data\Database.mdf;Integrated Security=True; User Instance=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddNewDriver", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FirstName",
                driver.FirstName));
                cmd.Parameters.Add(new SqlParameter("@MiddleName",
                driver.MiddleName));
                cmd.Parameters.Add(new SqlParameter("@LastName",
                driver.LastName));
                cmd.Parameters.Add(new SqlParameter("@IdNumber",
                driver.IdNumber));
                cmd.Parameters.Add(new SqlParameter("@BirthDate", driver.BirthDate));
                cmd.Parameters.Add(new SqlParameter("@Gender",
                driver.Gender));
                cmd.Parameters.Add(new SqlParameter("@Address", driver.Address));
                cmd.Parameters.Add(new SqlParameter("@Country",
                driver.Country));
                cmd.Parameters.Add(new SqlParameter("@City",
                driver.City));
                cmd.Parameters.Add(new SqlParameter("@DrivingLicenseNumber", driver.DrivingLicenseNumber));
                cmd.Parameters.Add(new SqlParameter("@DrivingCategories", driver.DrivingCategories));
                cmd.Parameters.Add(new SqlParameter("@DrivingPointsLeft", driver.DrivingPointsLeft));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }*/
        public static void addDriver(Driver driver)
        {

                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Personal data\TU\III Kurs\II semestyr\PS\repository\info.kat.database\KatDatabaseInfo\KatDatabaseInfo\Data\Database.mdf;Integrated Security=True; User Instance=True");
                string insertCommand = "INSERT INTO dbo.Drivers(FirstName, MiddleName, LastName, IdNumber, BirthDate, Gender, Address, Country, City, DrivingLicenseNumber, DrivingCategories, DrivingPointsLeft) VALUES(@FirstName, @MiddleName, @LastName, @IdNumber, @BirthDate, @Gender, @Address, @Country, @City, @DrivingLicenseNumber, @DrivingCategories, @DrivingPointsLeft)";

                SqlCommand cmd = new SqlCommand(insertCommand, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@FirstName", driver.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName",
                driver.MiddleName);
                cmd.Parameters.AddWithValue("@LastName",
                driver.LastName);
                cmd.Parameters.AddWithValue("@IdNumber",
                driver.IdNumber);
                cmd.Parameters.AddWithValue("@BirthDate", driver.BirthDate);
                cmd.Parameters.AddWithValue("@Gender",
                driver.Gender);
                cmd.Parameters.AddWithValue("@Address", driver.Address);
                cmd.Parameters.AddWithValue("@Country",
                driver.Country);
                cmd.Parameters.AddWithValue("@City",
                driver.City);
                cmd.Parameters.AddWithValue("@DrivingLicenseNumber", driver.DrivingLicenseNumber);
                cmd.Parameters.AddWithValue("@DrivingCategories", driver.DrivingCategories);
                cmd.Parameters.AddWithValue("@DrivingPointsLeft", driver.DrivingPointsLeft);
   
                cmd.ExecuteNonQuery();
            
        }
    }
}
