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
    public class CHINHANHsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/CHINHANHs
        public IQueryable<CHINHANH> GetCHINHANHs()
        {
            return db.CHINHANHs;
        }

        // GET: api/CHINHANHs/5
        [ResponseType(typeof(CHINHANH))]
        public async Task<IHttpActionResult> GetCHINHANH(int id)
        {
            CHINHANH cHINHANH = await db.CHINHANHs.FindAsync(id);
            if (cHINHANH == null)
            {
                return NotFound();
            }

            return Ok(cHINHANH);
        }

        // PUT: api/CHINHANHs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCHINHANH(int id, CHINHANH cHINHANH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cHINHANH.ID_CHINHANH)
            {
                return BadRequest();
            }

            db.Entry(cHINHANH).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CHINHANHExists(id))
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

        // POST: api/CHINHANHs
        [ResponseType(typeof(CHINHANH))]
        public async Task<IHttpActionResult> PostCHINHANH(CHINHANH cHINHANH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CHINHANHs.Add(cHINHANH);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cHINHANH.ID_CHINHANH }, cHINHANH);
        }

        // DELETE: api/CHINHANHs/5
        [ResponseType(typeof(CHINHANH))]
        public async Task<IHttpActionResult> DeleteCHINHANH(int id)
        {
            CHINHANH cHINHANH = await db.CHINHANHs.FindAsync(id);
            if (cHINHANH == null)
            {
                return NotFound();
            }

            db.CHINHANHs.Remove(cHINHANH);
            await db.SaveChangesAsync();

            return Ok(cHINHANH);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CHINHANHExists(int id)
        {
            return db.CHINHANHs.Count(e => e.ID_CHINHANH == id) > 0;
        }
    }
}