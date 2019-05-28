using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DonarService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DonarService.svc or DonarService.svc.cs at the Solution Explorer and start debugging.
    public class DonarService : IDonarService
    {
        
        SqlCommand command;
        static string strcon = ConfigurationManager.ConnectionStrings["donarconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(strcon);
        public int GenerateDonarID()
        {
            connection.Open();
            command = new SqlCommand("prcDonarIdAutoGenerate", connection);
            command.CommandType = CommandType.StoredProcedure;
            int donarid = Convert.ToInt32(command.ExecuteScalar());
            return donarid;
        }

        public bool AddDonar(Donar donar)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("PrcDonarInsert", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DonarID", donar.DonarID);
                command.Parameters.AddWithValue("@DonarName", donar.DonarName);
                command.Parameters.AddWithValue("@Gender", donar.Gender);
                command.Parameters.AddWithValue("@DateOfBirth", donar.DateOfBirth);
                command.Parameters.AddWithValue("@MobileNo", donar.MobileNo);
                command.Parameters.AddWithValue("@Organ", donar.Organ);
                command.Parameters.AddWithValue("@City", donar.City);
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
