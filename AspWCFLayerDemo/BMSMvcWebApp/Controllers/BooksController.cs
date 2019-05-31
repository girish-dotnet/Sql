using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMS.BLL;
using BMS.DAL.BookServiceReference;

namespace BMSMvcWebApp.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            List<Book> blist = BookBLL.GetBooksBLL();
            return View(blist);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            bool status = BookBLL.AddBookBLL(book);
            if (status)
            {
                return RedirectToAction("Index", "Books");
            }
            return View();
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            Book book = BookBLL.GetBookBLL(id);
            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            bool status = BookBLL.UpdateBookBLL(book);
            //bool status = client.UpdateBook(book);
            if (status)
            {
                return RedirectToAction("Index", "Books");
            }

            return View();
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            bool status = BookBLL.DeleteBookBLL(id);
        
            if (status)
            {
                return RedirectToAction("Index", "Books");
            }

            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
