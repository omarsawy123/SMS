using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS.Models;

namespace SMS.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DEV_SMS_ver2Context _context;

        public StudentsController(DEV_SMS_ver2Context context)
        {
            _context = context;
        }

        // GET: api/Students
        [EnableCors("Policy1")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblStudents>>> GetTblStudents()
        {
            return await _context.TblStudents.ToListAsync();
        }

        // GET: api/Students/5
        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public async Task<ActionResult<TblStudents>> GetTblStudents(int id)
        {
            var tblStudents = await _context.TblStudents.FindAsync(id);

            if (tblStudents == null)
            {
                return NotFound();
            }

            return tblStudents;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [EnableCors("Policy1")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblStudents(int id, TblStudents tblStudents)
        {
            if (id != tblStudents.StudentId)
            {
                return BadRequest();
            }

            _context.Entry(tblStudents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblStudentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Students
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [EnableCors("Policy1")]
        [HttpPost]
        public async Task<ActionResult<TblStudents>> PostTblStudents(TblStudents tblStudents)
        {
            _context.TblStudents.Add(tblStudents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblStudents", new { id = tblStudents.StudentId }, tblStudents);
        }

        // DELETE: api/Students/5
        [EnableCors("Policy1")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblStudents>> DeleteTblStudents(int id)
        {
            var tblStudents = await _context.TblStudents.FindAsync(id);
            if (tblStudents == null)
            {
                return NotFound();
            }

            _context.TblStudents.Remove(tblStudents);
            await _context.SaveChangesAsync();

            return tblStudents;
        }

        private bool TblStudentsExists(int id)
        {
            return _context.TblStudents.Any(e => e.StudentId == id);
        }
    }
}
