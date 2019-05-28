using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Q2.Models;

namespace Q2.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            IEnumerable<Donar> list = null;
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new
                    Uri("http://localhost:64478/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Donars");  // PersonDetails is the WebApi controller name
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.
                        ReadAsAsync<IList<Donar>>();
                    readTask.Wait();
                    // fill the list vairable created above with the returned result
                    list = readTask.Result;
                }
                else //web api sent error response 
                {
                    list = Enumerable.Empty<Donar>();
                    ModelState.AddModelError(string.Empty,
                        "Server error. Please contact administrator.");
                }
            }
            return View(list);
        }

        // GET: App/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
