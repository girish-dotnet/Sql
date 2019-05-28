using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBusinessService" in both code and config file together.
    [ServiceContract]
    public interface IBusinessService
    {

        [OperationContract]
        int GenerateBusinessID();
        [OperationContract]
        bool AddBusiness(Business business);

    }

    [DataContract]
    public class Business
    {
        [DataMember]
        public int BusinessID { get; set; }
        [DataMember]
        public string FirmName { get; set; }
        [DataMember]
        public string ActivityNature { get; set; }
        [DataMember]
        public string FirmAddress { get; set; }
        [DataMember]
        public string OwnerName { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string EmailID { get; set; }
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
