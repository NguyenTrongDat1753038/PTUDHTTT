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
    public class GIOHANGsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/GIOHANGs
        public IQueryable<GIOHANG> GetGIOHANGs()
        {
            return db.GIOHANGs;
        }

        // GET: api/GIOHANGs/5
        [ResponseType(typeof(GIOHANG))]
        public async Task<IHttpActionResult> GetGIOHANG(int id)
        {
            GIOHANG gIOHANG = await db.GIOHANGs.FindAsync(id);
            if (gIOHANG == null)
            {
                return NotFound();
            }

            return Ok(gIOHANG);
        }

        // PUT: api/GIOHANGs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGIOHANG(int id, GIOHANG gIOHANG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gIOHANG.ID_GIOHANG)
            {
                return BadRequest();
            }

            db.Entry(gIOHANG).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GIOHANGExists(id))
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

        // POST: api/GIOHANGs
        [ResponseType(typeof(GIOHANG))]
        public async Task<IHttpActionResult> PostGIOHANG(GIOHANG gIOHANG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GIOHANGs.Add(gIOHANG);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = gIOHANG.ID_GIOHANG }, gIOHANG);
        }

        // DELETE: api/GIOHANGs/5
        [ResponseType(typeof(GIOHANG))]
        public async Task<IHttpActionResult> DeleteGIOHANG(int id)
        {
            GIOHANG gIOHANG = await db.GIOHANGs.FindAsync(id);
            if (gIOHANG == null)
            {
                return NotFound();
            }

            db.GIOHANGs.Remove(gIOHANG);
            await db.SaveChangesAsync();

            return Ok(gIOHANG);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GIOHANGExists(int id)
        {
            return db.GIOHANGs.Count(e => e.ID_GIOHANG == id) > 0;
        }
    }
}