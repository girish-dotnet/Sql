using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDonarService" in both code and config file together.
    [ServiceContract]
    public interface IDonarService
    {
        [OperationContract]
        int GenerateDonarID();
        [OperationContract]
        bool AddDonar(Donar donar);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Donar
    {
        [DataMember]
        public int DonarID { get; set; }
        [DataMember]
        public string DonarName { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string Organ { get; set; }
        [DataMember]
        public string City { get; set; }

    }
}
