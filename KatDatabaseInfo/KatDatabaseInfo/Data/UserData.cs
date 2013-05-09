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

        public static bool addDriver(Driver driver)
        {
           /* SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=Database.mdf;Integrated Security=True; User Instance=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddNewStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@fName",
                obj.FirstName));
                cmd.Parameters.Add(new SqlParameter("@sName",
                obj.SecondName));
                cmd.Parameters.Add(new SqlParameter("@lName",
                obj.LastName));
                cmd.Parameters.Add(new SqlParameter("@faculty",
                obj.Faculty));
                cmd.Parameters.Add(new SqlParameter("@specialty", "sdf"));
                cmd.Parameters.Add(new SqlParameter("@fak",
                obj.FakNumber));
                cmd.Parameters.Add(new SqlParameter("@OKS", obj.OKS));
                cmd.Parameters.Add(new SqlParameter("@StudentStat",
                obj.StudentStatus));
                cmd.Parameters.Add(new SqlParameter("@Course",
                obj.Course));
                cmd.Parameters.Add(new SqlParameter("@Porok", obj.Stream));
                cmd.Parameters.Add(new SqlParameter("@Group", obj.Group));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }*/
            return true;
        }
    }
}
