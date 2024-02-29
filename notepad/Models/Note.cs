using System.ComponentModel.DataAnnotations;

namespace notepad.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }    
        [Required]
        public string Content { get; set; }
        public int NoteId { get; set; }
    }
}
