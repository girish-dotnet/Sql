using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BMS.WcfBusiness
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BusinessService" in both code and config file together.
    public class BusinessService : IBusinessService
    {
        SqlCommand command;
        static string strcon = Configurat.ConnectionStrings["donarconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(strcon);

        public int GenerateBusinessID()
        {
            connection.Open();
            command = new SqlCommand("prcBusinessIdAutoGenerate", connection);
            command.CommandType = CommandType.StoredProcedure;
            int businessId = Convert.ToInt32(command.ExecuteScalar());
            return businessId;
        }

        public bool AddBusiness(Business business)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("PrcBusinessInsert", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BusinessID", business.BusinessID);
                command.Parameters.AddWithValue("@FirmName", business.FirmAddress);
                command.Parameters.AddWithValue("@ActivityNature", business.ActivityNature);
                command.Parameters.AddWithValue("@FirmAddress", business.FirmAddress);
                command.Parameters.AddWithValue("@OwnerName", business.OwnerName);
                command.Parameters.AddWithValue("@MobileNo", business.MobileNo);
                command.Parameters.AddWithValue("@EmailID", business.EmailID);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
}
