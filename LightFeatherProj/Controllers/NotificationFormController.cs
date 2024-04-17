using LightFeatherProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LightFeatherProj.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class NotificationFormController : ControllerBase
    {
        private readonly NotificationFormContext _notificationformcontext;
        private readonly SupervisorContext _supervisorcontext;

        public NotificationFormController(NotificationFormContext notificationformcontext, SupervisorContext supervisorcontext)
        {
            _notificationformcontext = notificationformcontext;
            _supervisorcontext = supervisorcontext;
        }

        // GET: api/NotificationForms
        [HttpGet]
        [Route("api/supervisors")]
        public async Task<ActionResult<IEnumerable<Supervisor>>> GetNotificationForms()
        {
            return await _supervisorcontext.Supervisors.ToListAsync();
        }       

        // POST: api/NotificationForms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/submit")]
        public async Task<ActionResult<NotificationForm>> PostNotificationForm(NotificationForm notificationForm)
        {
            _notificationformcontext.NotificationForms.Add(notificationForm);
            await _notificationformcontext.SaveChangesAsync();

            return CreatedAtAction("GetNotificationForm", new { id = notificationForm.Id }, notificationForm);
        }

        private bool NotificationFormExists(long id)
        {
            return _notificationformcontext.NotificationForms.Any(e => e.Id == id);
        }
    }
}
