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
    public class DICHVUsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/DICHVUs
        public IQueryable<DICHVU> GetDICHVUs()
        {
            return db.DICHVUs;
        }

        // GET: api/DICHVUs/5
        [ResponseType(typeof(DICHVU))]
        public async Task<IHttpActionResult> GetDICHVU(int id)
        {
            DICHVU dICHVU = await db.DICHVUs.FindAsync(id);
            if (dICHVU == null)
            {
                return NotFound();
            }

            return Ok(dICHVU);
        }

        // PUT: api/DICHVUs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDICHVU(int id, DICHVU dICHVU)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dICHVU.ID_DICHVU)
            {
                return BadRequest();
            }

            db.Entry(dICHVU).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DICHVUExists(id))
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

        // POST: api/DICHVUs
        [ResponseType(typeof(DICHVU))]
        public async Task<IHttpActionResult> PostDICHVU(DICHVU dICHVU)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DICHVUs.Add(dICHVU);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = dICHVU.ID_DICHVU }, dICHVU);
        }

        // DELETE: api/DICHVUs/5
        [ResponseType(typeof(DICHVU))]
        public async Task<IHttpActionResult> DeleteDICHVU(int id)
        {
            DICHVU dICHVU = await db.DICHVUs.FindAsync(id);
            if (dICHVU == null)
            {
                return NotFound();
            }

            db.DICHVUs.Remove(dICHVU);
            await db.SaveChangesAsync();

            return Ok(dICHVU);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DICHVUExists(int id)
        {
            return db.DICHVUs.Count(e => e.ID_DICHVU == id) > 0;
        }
    }
}