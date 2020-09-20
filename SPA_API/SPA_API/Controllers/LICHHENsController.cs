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
    public class LICHHENsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/LICHHENs
        public IQueryable<LICHHEN> GetLICHHENs()
        {
            return db.LICHHENs;
        }

        // GET: api/LICHHENs/5
        [ResponseType(typeof(LICHHEN))]
        public async Task<IHttpActionResult> GetLICHHEN(int id)
        {
            LICHHEN lICHHEN = await db.LICHHENs.FindAsync(id);
            if (lICHHEN == null)
            {
                return NotFound();
            }

            return Ok(lICHHEN);
        }

        // PUT: api/LICHHENs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLICHHEN(int id, LICHHEN lICHHEN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lICHHEN.ID_LH)
            {
                return BadRequest();
            }

            db.Entry(lICHHEN).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LICHHENExists(id))
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

        // POST: api/LICHHENs
        [ResponseType(typeof(LICHHEN))]
        public async Task<IHttpActionResult> PostLICHHEN(LICHHEN lICHHEN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LICHHENs.Add(lICHHEN);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = lICHHEN.ID_LH }, lICHHEN);
        }

        // DELETE: api/LICHHENs/5
        [ResponseType(typeof(LICHHEN))]
        public async Task<IHttpActionResult> DeleteLICHHEN(int id)
        {
            LICHHEN lICHHEN = await db.LICHHENs.FindAsync(id);
            if (lICHHEN == null)
            {
                return NotFound();
            }

            db.LICHHENs.Remove(lICHHEN);
            await db.SaveChangesAsync();

            return Ok(lICHHEN);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LICHHENExists(int id)
        {
            return db.LICHHENs.Count(e => e.ID_LH == id) > 0;
        }
    }
}