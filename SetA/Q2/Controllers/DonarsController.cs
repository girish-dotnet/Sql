using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Q2.Models;

namespace Q2.Controllers
{
    public class DonarsController : ApiController
    {
        private sqlpracticeEntities db = new sqlpracticeEntities();

        // GET: api/Donars
        public IQueryable<Donar> GetDonars()
        {
            return db.Donars.Where(x => x.City.Equals("Mumbai"));
        }

        // GET: api/Donars/5
        [ResponseType(typeof(Donar))]
        public IHttpActionResult GetDonar(int id)
        {
            Donar donar = db.Donars.Find(id);
            if (donar == null)
            {
                return NotFound();
            }

            return Ok(donar);
        }

        // PUT: api/Donars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDonar(int id, Donar donar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donar.DonorId)
            {
                return BadRequest();
            }

            db.Entry(donar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Donars
        [ResponseType(typeof(Donar))]
        public IHttpActionResult PostDonar(Donar donar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Donars.Add(donar);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (DonarExists(donar.DonorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = donar.DonorId }, donar);
        }

        // DELETE: api/Donars/5
        [ResponseType(typeof(Donar))]
        public IHttpActionResult DeleteDonar(int id)
        {
            Donar donar = db.Donars.Find(id);
            if (donar == null)
            {
                return NotFound();
            }

            db.Donars.Remove(donar);
            db.SaveChanges();

            return Ok(donar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DonarExists(int id)
        {
            return db.Donars.Count(e => e.DonorId == id) > 0;
        }
    }
}