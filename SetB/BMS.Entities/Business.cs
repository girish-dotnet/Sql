using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Entities
{
    public class Business
    {
        public int BusinessID { get; set; }
        public string FirmName { get; set; }
        public string ActivityNature { get; set; }
        public string FirmAddress { get; set; }
        public string OwnerName { get; set; }
        public string MobileNo { get; set; } 
        public string EmailID { get; set; }
    }
}
