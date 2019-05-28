using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.DALL.ServiceReference1;

namespace DMS.DALL
{
    public class DonarDAL
    {
        public int GenerateDonarIdDAL()
        {
            ServiceReference1.DonarServiceClient client = new ServiceReference1.DonarServiceClient();
            int donarId = client.GenerateDonarID();
            return donarId;
        }

        public bool AddDonar(Donar donar)
        {
            ServiceReference1.DonarServiceClient client = new ServiceReference1.DonarServiceClient();
            bool donarAdded = client.AddDonar(donar);
            return donarAdded;
        }
    }
}
