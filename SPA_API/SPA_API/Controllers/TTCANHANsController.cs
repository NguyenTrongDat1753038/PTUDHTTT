﻿using System;
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
    public class TTCANHANsController : ApiController
    {
        private SPAEntities db = new SPAEntities();

        // GET: api/TTCANHANs
        public IQueryable<TTCANHAN> GetTTCANHANs()
        {
            return db.TTCANHANs;
        }

        // GET: api/TTCANHANs/5
        [ResponseType(typeof(TTCANHAN))]
        public async Task<IHttpActionResult> GetTTCANHAN(int id)
        {
            TTCANHAN tTCANHAN = await db.TTCANHANs.FindAsync(id);
            if (tTCANHAN == null)
            {
                return NotFound();
            }

            return Ok(tTCANHAN);
        }

        // PUT: api/TTCANHANs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTTCANHAN(int id, TTCANHAN tTCANHAN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tTCANHAN.ID_USER)
            {
                return BadRequest();
            }

            db.Entry(tTCANHAN).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TTCANHANExists(id))
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

        // POST: api/TTCANHANs
        [ResponseType(typeof(TTCANHAN))]
        public async Task<IHttpActionResult> PostTTCANHAN(TTCANHAN tTCANHAN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TTCANHANs.Add(tTCANHAN);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TTCANHANExists(tTCANHAN.ID_USER))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tTCANHAN.ID_USER }, tTCANHAN);
        }

        // DELETE: api/TTCANHANs/5
        [ResponseType(typeof(TTCANHAN))]
        public async Task<IHttpActionResult> DeleteTTCANHAN(int id)
        {
            TTCANHAN tTCANHAN = await db.TTCANHANs.FindAsync(id);
            if (tTCANHAN == null)
            {
                return NotFound();
            }

            db.TTCANHANs.Remove(tTCANHAN);
            await db.SaveChangesAsync();

            return Ok(tTCANHAN);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TTCANHANExists(int id)
        {
            return db.TTCANHANs.Count(e => e.ID_USER == id) > 0;
        }
    }
}