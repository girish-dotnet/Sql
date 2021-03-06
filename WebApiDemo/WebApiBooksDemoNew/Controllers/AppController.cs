﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebApiBooksDemoNew.Models;

namespace WebApiBooksDemoNew.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            IEnumerable<Book> list = null;
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new 
                    Uri("http://localhost:63253/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Books");  // PersonDetails is the WebApi controller name
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.
                        ReadAsAsync<IList<Book>>();
                    readTask.Wait();
                    // fill the list vairable created above with the returned result
                    list = readTask.Result;
                }
                else //web api sent error response 
                {
                    list = Enumerable.Empty<Book>();
                    ModelState.AddModelError(string.Empty,
                        "Server error. Please contact administrator.");
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
        public ActionResult Create(Book book)
        {
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:63253/api/");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<Book>("Books",
                    book);
                // wait for task to complete
                postTask.Wait();
                // retrieve the result
                var result = postTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            // Add model error
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error
            return View(book);
        }

        // GET: App/Edit/5
        public ActionResult Edit(int id)
        {
            // variable to hold the person details retrieved from WebApi
            Book book = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:63253/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Books/" + id.ToString());
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

        // POST: App/Edit/5
        [HttpPost]
        public ActionResult Edit(Book obj)
        {
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress =
                    new Uri("http://localhost:63253/api/");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<Book>("Books", obj);
                // wait for task to complete
                putTask.Wait();
                // retrieve the result
                var result = putTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // Return to Index
                    return RedirectToAction("Index");
                }
            }
            // Add model error
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error 
            return View(obj);
        }

        // GET: App/Delete/5
        public ActionResult Delete(int id)
        {
            // variable to hold the person details retrieved from WebApi
            Book book = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:63253/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Books/" + id.ToString());
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
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                // send the view back with model error 
                return View(book);
            }

        // POST: App/Delete/5
        [HttpPost]
        public ActionResult Delete(Book book)
        {
            // variable to hold the person details retrieved from WebApi
            int ID = book.ID;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:63253/api/");
                //HTTP Delete
                var responseTask = client.DeleteAsync("Books/" + ID.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var deleteTask = responseTask.Result;
                // check the status code for success
                if (deleteTask.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
