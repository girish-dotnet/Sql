using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.DALL.ServiceReference1;
using DMS.DALL;
using DMS.Exceptoins;

namespace DMS.BLL
{
    public class DonarBLL
    {
        public bool Validate(Donar donar)
        {
            bool valid = true;
            StringBuilder sb = new StringBuilder();
            if(donar.DonarName.Length==0)
            {
                valid = false;
                sb.Append("Donar Name mandetory...");
            }
            return valid;
        }

        public static int GenerateDonarIdBLL()
        {
            return new DonarDAL().GenerateDonarIdDAL();
        }

        public static bool AddDonar(Donar donar)
        {
            DonarDAL dal = new DonarDAL();
            return dal.AddDonar(donar);
        }
    }
}
