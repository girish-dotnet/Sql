using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;
using WebApiBooksDemo.Models;

namespace WebApiBooksDemo.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            // Variable to store the list returned by WebApi GetC:\WebApiDemo\WebApiBooksDemo\Scripts\PersonDetails method
            IEnumerable<Book> list = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:61803/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Books1");  // PersonDetails is the WebApi controller name
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<IList<Book>>();
                    readTask.Wait();
                    // fill the list vairable created above with the returned result
                    list = readTask.Result;
                }
                else //web api sent error response 
                {
                    list = Enumerable.Empty<Book>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(list);
        }

        // GET: App/Details/5
        public ActionResult Details(int id)
        {
            // variable to hold the person details retrieved from WebApi
            Book book = null;
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:63253/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Books?ID=" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<Book>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                    book = readTask.Result;
                }
            }
            return View(book);
        }

        // GET: App/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: App/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: App/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: App/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: App/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: App/Delete/5
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
