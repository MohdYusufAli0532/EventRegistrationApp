using EventRegistrationAPI.Models;
using EventRegistrationAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }

        // GET: api/events
        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(_eventService.GetAllEvents());
        }

        // POST: api/events
        [HttpPost]
        public IActionResult CreateEvent([FromBody] Event evt)
        {
            if (evt == null)
                return BadRequest();

            var created = _eventService.CreateEvent(evt);
            return Ok(created);
        }

        // POST: api/events/{eventId}/register
        [HttpPost("{eventId}/register")]
        public IActionResult RegisterParticipant(int eventId, [FromBody] Participant participant)
        {
            if (participant == null)
                return BadRequest();

            var success = _eventService.RegisterParticipant(eventId, participant);

            if (!success)
                return BadRequest("Registration failed — event not found or seats full.");

            return Ok("Registration successful!");
        }
    }
}