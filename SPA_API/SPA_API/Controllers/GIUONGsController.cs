using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SPA_API.Models;

namespace SPA_API.Controllers
{
    public class GIUONGsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/GIUONGs
        public IQueryable<GIUONG> GetGIUONGs()
        {
            return db.GIUONGs;
        }

        // GET: api/GIUONGs/5
        [ResponseType(typeof(GIUONG))]
        public async Task<IHttpActionResult> GetGIUONG(int id)
        {
            GIUONG gIUONG = await db.GIUONGs.FindAsync(id);
            if (gIUONG == null)
            {
                return NotFound();
            }

            return Ok(gIUONG);
        }

        // PUT: api/GIUONGs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGIUONG(int id, GIUONG gIUONG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gIUONG.ID_GIUONG)
            {
                return BadRequest();
            }

            db.Entry(gIUONG).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GIUONGExists(id))
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

        // POST: api/GIUONGs
        [ResponseType(typeof(GIUONG))]
        public async Task<IHttpActionResult> PostGIUONG(GIUONG gIUONG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GIUONGs.Add(gIUONG);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = gIUONG.ID_GIUONG }, gIUONG);
        }

        // DELETE: api/GIUONGs/5
        [ResponseType(typeof(GIUONG))]
        public async Task<IHttpActionResult> DeleteGIUONG(int id)
        {
            GIUONG gIUONG = await db.GIUONGs.FindAsync(id);
            if (gIUONG == null)
            {
                return NotFound();
            }

            db.GIUONGs.Remove(gIUONG);
            await db.SaveChangesAsync();

            return Ok(gIUONG);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GIUONGExists(int id)
        {
            return db.GIUONGs.Count(e => e.ID_GIUONG == id) > 0;
        }
    }
}