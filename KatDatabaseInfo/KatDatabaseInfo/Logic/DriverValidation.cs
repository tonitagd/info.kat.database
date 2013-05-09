using KatDatabaseInfo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Logic
{
    class DriverValidation
    {

        public static Driver IsThereDriver(User usr)
        {
            return UserData.GetDriverByLicenseID(usr.DrivingLicenseN);
        }

    }
}
