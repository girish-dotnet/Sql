using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BusinessBLL;
using BMS.DAL;
using BMS.DAL.ServiceReference1;


namespace BMS.WebApplication
{
    public partial class AddBusiness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlActivityNature.Items.Add("Health");
                ddlActivityNature.Items.Add("Trade");
                ddlActivityNature.Items.Add("Water Tanker");
            }

            int businessID = BusinessBLL.BusinessBLL.GenerateDonarIdBLL();
            txtBusinessID.Text = businessID.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Business business = new Business();
            business.BusinessID = Convert.ToInt32(txtBusinessID.Text);
            business.FirmName = txtFirmName.Text;
            business.ActivityNature = ddlActivityNature.Text;
            business.FirmAddress = txtFirmAddress.Text;
            business.OwnerName = txtOwnerName.Text;
            business.MobileNo = txtMobileNo.Text;
            business.EmailID = txtEmailID.Text;
            bool result = BusinessBLL.BusinessBLL.AddBusiness(business);
            Response.Write(result);
        }
    }
}