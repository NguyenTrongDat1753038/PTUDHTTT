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
    public class CHITIET_GIUONGController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/CHITIET_GIUONG
        public IQueryable<CHITIET_GIUONG> GetCHITIET_GIUONG()
        {
            return db.CHITIET_GIUONG;
        }

        // GET: api/CHITIET_GIUONG/5
        [ResponseType(typeof(CHITIET_GIUONG))]
        public async Task<IHttpActionResult> GetCHITIET_GIUONG(int id)
        {
            CHITIET_GIUONG cHITIET_GIUONG = await db.CHITIET_GIUONG.FindAsync(id);
            if (cHITIET_GIUONG == null)
            {
                return NotFound();
            }

            return Ok(cHITIET_GIUONG);
        }

        // PUT: api/CHITIET_GIUONG/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCHITIET_GIUONG(int id, CHITIET_GIUONG cHITIET_GIUONG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cHITIET_GIUONG.ID_GIUONG)
            {
                return BadRequest();
            }

            db.Entry(cHITIET_GIUONG).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CHITIET_GIUONGExists(id))
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

        // POST: api/CHITIET_GIUONG
        [ResponseType(typeof(CHITIET_GIUONG))]
        public async Task<IHttpActionResult> PostCHITIET_GIUONG(CHITIET_GIUONG cHITIET_GIUONG)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CHITIET_GIUONG.Add(cHITIET_GIUONG);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CHITIET_GIUONGExists(cHITIET_GIUONG.ID_GIUONG))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cHITIET_GIUONG.ID_GIUONG }, cHITIET_GIUONG);
        }

        // DELETE: api/CHITIET_GIUONG/5
        [ResponseType(typeof(CHITIET_GIUONG))]
        public async Task<IHttpActionResult> DeleteCHITIET_GIUONG(int id)
        {
            CHITIET_GIUONG cHITIET_GIUONG = await db.CHITIET_GIUONG.FindAsync(id);
            if (cHITIET_GIUONG == null)
            {
                return NotFound();
            }

            db.CHITIET_GIUONG.Remove(cHITIET_GIUONG);
            await db.SaveChangesAsync();

            return Ok(cHITIET_GIUONG);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CHITIET_GIUONGExists(int id)
        {
            return db.CHITIET_GIUONG.Count(e => e.ID_GIUONG == id) > 0;
        }
    }
}