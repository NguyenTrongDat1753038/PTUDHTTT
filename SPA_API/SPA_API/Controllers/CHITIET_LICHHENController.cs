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
    public class CHITIET_LICHHENController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/CHITIET_LICHHEN
        public IQueryable<CHITIET_LICHHEN> GetCHITIET_LICHHEN()
        {
            return db.CHITIET_LICHHEN;
        }

        // GET: api/CHITIET_LICHHEN/5
        [ResponseType(typeof(CHITIET_LICHHEN))]
        public async Task<IHttpActionResult> GetCHITIET_LICHHEN(int id)
        {
            CHITIET_LICHHEN cHITIET_LICHHEN = await db.CHITIET_LICHHEN.FindAsync(id);
            if (cHITIET_LICHHEN == null)
            {
                return NotFound();
            }

            return Ok(cHITIET_LICHHEN);
        }

        // PUT: api/CHITIET_LICHHEN/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCHITIET_LICHHEN(int id, CHITIET_LICHHEN cHITIET_LICHHEN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cHITIET_LICHHEN.ID_LH)
            {
                return BadRequest();
            }

            db.Entry(cHITIET_LICHHEN).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CHITIET_LICHHENExists(id))
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

        // POST: api/CHITIET_LICHHEN
        [ResponseType(typeof(CHITIET_LICHHEN))]
        public async Task<IHttpActionResult> PostCHITIET_LICHHEN(CHITIET_LICHHEN cHITIET_LICHHEN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CHITIET_LICHHEN.Add(cHITIET_LICHHEN);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CHITIET_LICHHENExists(cHITIET_LICHHEN.ID_LH))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cHITIET_LICHHEN.ID_LH }, cHITIET_LICHHEN);
        }

        // DELETE: api/CHITIET_LICHHEN/5
        [ResponseType(typeof(CHITIET_LICHHEN))]
        public async Task<IHttpActionResult> DeleteCHITIET_LICHHEN(int id)
        {
            CHITIET_LICHHEN cHITIET_LICHHEN = await db.CHITIET_LICHHEN.FindAsync(id);
            if (cHITIET_LICHHEN == null)
            {
                return NotFound();
            }

            db.CHITIET_LICHHEN.Remove(cHITIET_LICHHEN);
            await db.SaveChangesAsync();

            return Ok(cHITIET_LICHHEN);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CHITIET_LICHHENExists(int id)
        {
            return db.CHITIET_LICHHEN.Count(e => e.ID_LH == id) > 0;
        }
    }
}