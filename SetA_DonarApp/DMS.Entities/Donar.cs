using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Entities
{
    public class Donar
    {
        public int DonarID { get; set; }
        public string DonarName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNo { get; set; }

        public string Organ { get; set; }
        public string City { get; set; }

    }
}
