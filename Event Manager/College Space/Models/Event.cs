using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace College_Space.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Event Name can't be blank!")]
        [MinLength(2, ErrorMessage = "Event Name must be meaningful!")]
        public string? EventName { get; set; }

        [Required(ErrorMessage = "Event Organizer can't be blank!")]
        [MinLength(2, ErrorMessage = "Enter valid Organizer!")]
        public string? EventOrganizer { get; set; }

        [Required(ErrorMessage = "Event Type can't be blank!")]
        [MinLength(2, ErrorMessage = "Enter valid Event Type!")]
        public string? EventType { get; set; }

        [Required(ErrorMessage = "Event Dtae & Time can't be empty!")]
        public DateTime? EventDate { get; set; }

    }
}
