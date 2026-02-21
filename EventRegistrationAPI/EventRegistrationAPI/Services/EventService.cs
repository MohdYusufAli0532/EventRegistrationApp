using EventRegistrationAPI.Models;

namespace EventRegistrationAPI.Services
{
    public class EventService
    {
        // Store events in memory
        private readonly List<Event> _events = new();
        private int _eventIdCounter = 1;
        private int _participantIdCounter = 1;

        // Get all events
        public List<Event> GetAllEvents()
        {
            return _events;
        }

        // Create an event
        public Event CreateEvent(Event evt)
        {
            evt.Id = _eventIdCounter++;
            _events.Add(evt);
            return evt;
        }

        // Register a participant (with seat availability)
        public bool RegisterParticipant(int eventId, Participant participant)
        {
            var evt = _events.FirstOrDefault(e => e.Id == eventId);
            if (evt == null)
                return false;

            if (evt.Participants.Count >= evt.MaxSeats)
                return false; // No seats left

            participant.Id = _participantIdCounter++;
            evt.Participants.Add(participant);

            return true;
        }
    }
}