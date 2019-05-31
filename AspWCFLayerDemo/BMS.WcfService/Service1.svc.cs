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

namespace BMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        static string strcon = ConfigurationManager.
            ConnectionStrings["bookconn"].ConnectionString;
        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd;
        SqlDataReader dr;

        public bool AddBook(Book book)
        {
            bool bookAdded = false;

            try
            {
                cmd = new SqlCommand("usp_InsertBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", book.ID);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@desc", book.Description);
                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    bookAdded = true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return bookAdded;
        }

        public bool UpdateBook(Book book)
        {
            bool bookUpdated = false;
            try
            {
                cmd = new SqlCommand("usp_UpdateBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", book.ID);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@desc", book.Description);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    bookUpdated = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return bookUpdated;
        }

        public bool DeleteBook(int BookID)
        {
            bool bookDeleted = false;
            try
            {
                cmd = new SqlCommand("usp_DeleteBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", BookID);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    bookDeleted = true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return bookDeleted;
        }

        public Book SearchBook(int id)
        {
            Book book = null;

            try
            {
                cmd = new SqlCommand("usp_SearchBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    book = new Book();
                    book.ID = dr.GetInt32(0);
                    book.Name = dr.GetString(1);
                    book.Price = dr.GetDecimal(2);
                    book.Description = dr.GetString(3);
                }
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
            finally
            {
                dr.Close();
                conn.Close();
            }

            return book;
        }

        public List<Book> ShowBook()
        {
            List<Book> booklist = null;

            try
            {
                cmd = new SqlCommand("usp_ShowBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    booklist = new List<Book>();

                    while (dr.Read())
                    {
                        Book b = new Book();
                        b.ID = dr.GetInt32(0);
                        b.Name = dr.GetString(1).ToString();
                        b.Price = dr.GetDecimal(2);
                        b.Description = dr.GetString(3).ToString();

                        booklist.Add(b);
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                conn.Close();
            }

            return booklist;
        }
    }
}
