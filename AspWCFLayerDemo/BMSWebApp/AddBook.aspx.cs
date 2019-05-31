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
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.ID = Convert.ToInt32(txtID.Text);
                book.Name = txtName.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.Description = txtDescription.Text;
                bool status = BookBLL.AddBookBLL(book);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "m1", "alert('Book Details Added')", true);

                    txtID.Text = "";
                    txtName.Text = "";
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "error5", "alert('" + ex.Message + "')", true);
            }
        }
    }
}