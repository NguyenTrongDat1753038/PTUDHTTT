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
    public class USERsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/USERs
        public IQueryable<USER> GetUSERS()
        {
            return db.USERS;
        }

        // GET: api/USERs/5
        [ResponseType(typeof(USER))]
        public async Task<IHttpActionResult> GetUSER(int id)
        {
            USER uSER = await db.USERS.FindAsync(id);
            if (uSER == null)
            {
                return NotFound();
            }

            return Ok(uSER);
        }

        // PUT: api/USERs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUSER(int id, USER uSER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uSER.ID)
            {
                return BadRequest();
            }

            db.Entry(uSER).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!USERExists(id))
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

        // POST: api/USERs
        [ResponseType(typeof(USER))]
        public async Task<IHttpActionResult> PostUSER(USER uSER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.USERS.Add(uSER);
            //await db.Database.ExecuteSqlCommandAsync("Exec dbo.insert_user @name @pass", uSER.USERNAME, uSER.PASSWORDS);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = uSER.ID }, uSER);
        }

        // DELETE: api/USERs/5
        [ResponseType(typeof(USER))]
        public async Task<IHttpActionResult> DeleteUSER(int id)
        {
            USER uSER = await db.USERS.FindAsync(id);
            if (uSER == null)
            {
                return NotFound();
            }

            db.USERS.Remove(uSER);
            await db.SaveChangesAsync();

            return Ok(uSER);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool USERExists(int id)
        {
            return db.USERS.Count(e => e.ID == id) > 0;
        }
    }
}