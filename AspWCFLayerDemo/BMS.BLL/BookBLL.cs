using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;
using BMS.DAL;

namespace BMS.BLL
{
    public class BookBLL
    {
        public static bool DeleteBookBLL(int id)
        {
            bool bookdelete = false;

            try
            {
                if (id > 0)
                {
                    BookDAL bmsdal = new BookDAL();
                    bookdelete = bmsdal.DeleteBookDAL(id);
                }
                else
                {
                    throw new BookException.BookException("Invalid Book ID");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bookdelete;
        }
        public static bool UpdateBookBLL(Book book)
        {
            bool bookupdate = false;
            try
            {
                if (ValidateBook(book))
                {
                    BookDAL bmsdal = new BookDAL();
                    bookupdate = bmsdal.UpdateBookDAL(book);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bookupdate;
        }
        public static bool ValidateBook(Book book)
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (book.ID <= 0 || book.ID == null)
            {
                result = false;
                sb.Append("ID cannot be blank or negative");
            }

            if (book.Name == string.Empty)
            {
                result = false;
                sb.Append("Book Name cannot be blank");
            }

            if (book.Description == string.Empty)
            {
                result = false;
                sb.Append("Description cannot be blank");
            }
            if (book.Price <= 0 || book.Price == null)
            {
                result = false;
                sb.Append("Price cannot be negative or zero");
            }

            if (result == false)
            {
                throw new BookException.BookException(sb.ToString());
            }
            return result;
        }

        public static bool AddBookBLL(Book book)
        {
            bool bookaddded = false;
            try
            {
                if (ValidateBook(book))
                {
                    BookDAL obj = new BookDAL();
                    bookaddded = obj.AddBookDAL(book);
                }
            }
            catch (Exception ex)
            {
                throw new BookException.BookException(ex.Message);
            }
            return bookaddded;
        }
        public static Book GetBookBLL(int bookid)
        {
            Book book = null;
            try
            {
                BookDAL bmsdal = new BookDAL();
                book = bmsdal.GetBookDAL(bookid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return book;
        }

        public static List<Book> GetBooksBLL()
        {
            List<Book> bookllist = null;
            try
            {
                BookDAL bmsdal = new BookDAL();
                bookllist = bmsdal.GetBooksDAL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bookllist;
        }
    }
}
