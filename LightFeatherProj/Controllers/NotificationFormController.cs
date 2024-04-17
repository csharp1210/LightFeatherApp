using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using LightFeatherProj.Models;
using System.Text.Encodings.Web;

namespace LightFeatherProj.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class NotificationFormController : ControllerBase
    {
        private readonly NotificationFormContext _context;
        private readonly SupervisorContext _supervisorcontext;

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public NotificationFormController(NotificationFormContext context, SupervisorContext supervisorcontext)
        {
            _context = context;
            _supervisorcontext = supervisorcontext;
        }

        // GET: api/NotificationForms
        [HttpGet]
        [Route("api/supervisors")]
        public async Task<ActionResult<IEnumerable<Supervisor>>> GetNotificationForms()
        {
            return await _supervisorcontext.Supervisors.ToListAsync();
        }

        // GET: api/NotificationForms/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<NotificationForm>> GetNotificationForm(long id)
        //{
        //    var notificationForm = await _context.NotificationForms.FindAsync(id);

        //    if (notificationForm == null)
        //    {
        //        return NotFound();
        //    }

        //    return notificationForm;
        //}

        // PUT: api/NotificationForms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutNotificationForm(long id, NotificationForm notificationForm)
        //{
        //    if (id != notificationForm.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(notificationForm).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!NotificationFormExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/NotificationForms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/submit")]
        public async Task<ActionResult<NotificationForm>> PostNotificationForm(NotificationForm notificationForm)
        {
            _context.NotificationForms.Add(notificationForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNotificationForm", new { id = notificationForm.Id }, notificationForm);
        }

        // DELETE: api/NotificationForms/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteNotificationForm(long id)
        //{
        //    var notificationForm = await _context.NotificationForms.FindAsync(id);
        //    if (notificationForm == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.NotificationForms.Remove(notificationForm);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool NotificationFormExists(long id)
        {
            return _context.NotificationForms.Any(e => e.Id == id);
        }
    }
}
