using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL;
using BMS.DAL.ServiceReference1;


namespace BMS.BusinessBLL
{
    public class BusinessBLL
    {
        public bool Validate(Business business)
        {
            bool valid = true;
            StringBuilder sb = new StringBuilder();
            if (business.OwnerName.Length == 0)
            {
                valid = false;
                sb.Append("Owner Name mandetory...");
            }
            return valid;
        }

        public static int GenerateDonarIdBLL()
        {
            return new BusinessDAL().GenerateBusinessIdDAL();
        }

        public static bool AddBusiness(Business business)
        {
            return new BusinessDAL().AddBusiness(business);
        }
    }
}
