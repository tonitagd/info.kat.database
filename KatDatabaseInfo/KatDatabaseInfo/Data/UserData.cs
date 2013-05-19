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
        private static UsersDataClassesDataContext userDataContext = new UsersDataClassesDataContext();
        

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


       

        

        //ADDING 

        

        public static void CreateUsernameAndPassword(User user)
        {
            userDataContext.CreateUsernameAndPassword(user.Username, user.Password, user.DrivingLicenseNumber, user.Role_);
            userDataContext.SubmitChanges();
        }

        

        

        //DELETING
        

        public static void DeleteUser(string drivingLicenseNumber)
        {
            User user = userDataContext.Users.Where<User>(anonymous => anonymous.DrivingLicenseNumber == drivingLicenseNumber).Single();
            userDataContext.Users.DeleteOnSubmit(user);
            userDataContext.SubmitChanges();
        }

        

        

        //UPDATING
        

       

        

        public static void UpdatePass(string licenseNumber, string newPass)
        {
            User user = userDataContext.Users.Where<User>(anonymous => anonymous.DrivingLicenseNumber == licenseNumber).Single();

            user.Password = newPass;

            userDataContext.SubmitChanges();
        }
    }
}
