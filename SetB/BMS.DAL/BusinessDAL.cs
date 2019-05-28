using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL;
using BMS.DAL.ServiceReference1;


namespace BMS.DAL
{
    public class BusinessDAL
    {
        public int GenerateBusinessIdDAL()
        {
            ServiceReference1.BusinessServiceClient client = new ServiceReference1.BusinessServiceClient();
            int businessId = client.GenerateBusinessID();
            return businessId;
        }

        public bool AddBusiness(Business business)
        {
            
            ServiceReference1.BusinessServiceClient client = new ServiceReference1.BusinessServiceClient();
            bool businessAdded = client.AddBusiness(business);
            return businessAdded;
        }
    }
}
