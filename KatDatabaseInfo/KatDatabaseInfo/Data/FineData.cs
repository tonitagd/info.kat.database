using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatDatabaseInfo.Data
{
    class FineData
    {
        private static FinesDataClassesDataContext fineDataContext = new FinesDataClassesDataContext();

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

        public static void AddNewFine(Fine fine)
        {
            fineDataContext.AddNewFine(fine.Type, fine.SerialNumber, fine.Date, fine.Policeman, fine.DrivingLicenseNumber, fine.Paid, fine.Reason, fine.Amount, fine.Location, fine.Hour);
            fineDataContext.SubmitChanges();
        }

        public static void DeleteFine(string fineID)
        {
            Fine fine = fineDataContext.Fines.Where<Fine>(anonymous => anonymous.SerialNumber == fineID).Single();
            fineDataContext.Fines.DeleteOnSubmit(fine);
            fineDataContext.SubmitChanges();
        }

        public static void UpdateFine(string fineId, byte paid, decimal? amount)
        {
            Fine fine = fineDataContext.Fines.Where<Fine>(anonymous => anonymous.SerialNumber == fineId).Single();

            fine.Paid = paid;
            fine.Amount = amount;

            fineDataContext.SubmitChanges();
        }
    }
}
