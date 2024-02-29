using Microsoft.AspNetCore.Mvc;
using notepad.Models;
using PusherServer;

namespace notepad.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocketsController : ControllerBase
    {
        private readonly Pusher _pusher;

        public SocketsController()
        {
            var options = new PusherOptions
            {
                Cluster = "us2",
                Encrypted = true
            };

            _pusher = new Pusher(
                "1764331",
                "8067abac095cb571203d",
                "615e8d6874f2bc23e774",
                options
            );
        }

        [HttpPost("update/{noteId}")]
        public IActionResult UpdateNote(int noteId, [FromBody] Note request)
        {
          

            _pusher.TriggerAsync("notepad-channel", "note-update", new { noteId = noteId, username = request.Username, content = request.Content, id = request.Id });
            return Ok();
        }
    }
}
