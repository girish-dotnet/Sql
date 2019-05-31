using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;
using BMS.DAL.BookServiceReference;

namespace BMSWebApp
{
    public partial class SearchBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg1", "alert('Please enter id')", true);
            }
            else
            {
                try
                {
                    int searchId = Convert.ToInt32(txtID.Text);

                    Book book = BookBLL.GetBookBLL(searchId);

                    if (book != null)
                    {
                        List<Book> blist = new List<Book>();
                        blist.Add(book);
                        DetailsView1.DataSource = blist.ToList();
                        DetailsView1.DataBind();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "error4", "alert('Book Not Available')", true);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}