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
    public class DATTRUOCsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/DATTRUOCs
        public IQueryable<DATTRUOC> GetDATTRUOCs()
        {
            return db.DATTRUOCs;
        }

        // GET: api/DATTRUOCs/5
        [ResponseType(typeof(DATTRUOC))]
        public async Task<IHttpActionResult> GetDATTRUOC(int id)
        {
            DATTRUOC dATTRUOC = await db.DATTRUOCs.FindAsync(id);
            if (dATTRUOC == null)
            {
                return NotFound();
            }

            return Ok(dATTRUOC);
        }

        // PUT: api/DATTRUOCs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDATTRUOC(int id, DATTRUOC dATTRUOC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dATTRUOC.ID_DATTRUOC)
            {
                return BadRequest();
            }

            db.Entry(dATTRUOC).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DATTRUOCExists(id))
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

        // POST: api/DATTRUOCs
        [ResponseType(typeof(DATTRUOC))]
        public async Task<IHttpActionResult> PostDATTRUOC(DATTRUOC dATTRUOC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DATTRUOCs.Add(dATTRUOC);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = dATTRUOC.ID_DATTRUOC }, dATTRUOC);
        }

        // DELETE: api/DATTRUOCs/5
        [ResponseType(typeof(DATTRUOC))]
        public async Task<IHttpActionResult> DeleteDATTRUOC(int id)
        {
            DATTRUOC dATTRUOC = await db.DATTRUOCs.FindAsync(id);
            if (dATTRUOC == null)
            {
                return NotFound();
            }

            db.DATTRUOCs.Remove(dATTRUOC);
            await db.SaveChangesAsync();

            return Ok(dATTRUOC);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DATTRUOCExists(int id)
        {
            return db.DATTRUOCs.Count(e => e.ID_DATTRUOC == id) > 0;
        }
    }
}