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
    public class PHONGsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/PHONGs
        public IQueryable<PHONG> GetPHONGs()
        {
            return db.PHONGs;
        }

        // GET: api/PHONGs/5
        [ResponseType(typeof(PHONG))]
        public async Task<IHttpActionResult> GetPHONG(int id)
        {
            PHONG pHONG = await db.PHONGs.FindAsync(id);
            if (pHONG == null)
            {
                return NotFound();
            }

            return Ok(pHONG);
        }

        // PUT: api/PHONGs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPHONG(int id, PHONG pHONG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pHONG.ID_PHONG)
            {
                return BadRequest();
            }

            db.Entry(pHONG).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PHONGExists(id))
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

        // POST: api/PHONGs
        [ResponseType(typeof(PHONG))]
        public async Task<IHttpActionResult> PostPHONG(PHONG pHONG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PHONGs.Add(pHONG);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pHONG.ID_PHONG }, pHONG);
        }

        // DELETE: api/PHONGs/5
        [ResponseType(typeof(PHONG))]
        public async Task<IHttpActionResult> DeletePHONG(int id)
        {
            PHONG pHONG = await db.PHONGs.FindAsync(id);
            if (pHONG == null)
            {
                return NotFound();
            }

            db.PHONGs.Remove(pHONG);
            await db.SaveChangesAsync();

            return Ok(pHONG);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PHONGExists(int id)
        {
            return db.PHONGs.Count(e => e.ID_PHONG == id) > 0;
        }
    }
}