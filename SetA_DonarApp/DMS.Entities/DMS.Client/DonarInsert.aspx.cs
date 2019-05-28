using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMS.BLL;
using DMS.DALL;
using DMS.DALL.ServiceReference1;

namespace DMS.Client
{
    public partial class DonarInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int donarId = DonarBLL.GenerateDonarIdBLL();
            txtDonarID.Text = donarId.ToString();
            ddlOrgan.Items.Add("Eyes");
            ddlOrgan.Items.Add("Heart");
            ddlOrgan.Items.Add("Liver");

            ddlCity.Items.Add("Bangalore");
            ddlCity.Items.Add("Chennai");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Donar donar = new Donar();
            donar.DonarID = Convert.ToInt32(txtDonarID.Text);
            donar.DonarName = txtDonarName.Text;
            if(rbnMale.Checked==true)
            {
                donar.Gender = "M";
            }
            if(rbnFemale.Checked==true)
            {
                donar.Gender = "F";
            }
            donar.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            donar.City = ddlCity.Text;
            donar.MobileNo = txtMobileNo.Text;
            donar.Organ = ddlOrgan.Text;
            bool result = DonarBLL.AddDonar(donar);
            Response.Write(result);
        }
    }
}