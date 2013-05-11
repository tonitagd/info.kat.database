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

      /*public static void addDriver(Driver driver)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\repository\info.kat.database\KatDatabaseInfo\KatDatabaseInfo\Database.mdf;Integrated Security=True; User Instance=True");

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

        }*/
     public static void addDriver(Driver driver)
       {
           DriversDataClassesDataContext dc = new DriversDataClassesDataContext();
           dc.AddNewDriver(driver.FirstName,driver.MiddleName,driver.LastName,driver.IdNumber,driver.BirthDate,driver.Gender,driver.Address,driver.Country,driver.City,driver.DrivingLicenseNumber,driver.DrivingCategories,driver.DrivingPointsLeft);
           dc.SubmitChanges();
        }

     public static void CreateUsernameAndPassword(Driver driver)
        {
         
        }
    }
}
