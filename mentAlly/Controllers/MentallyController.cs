using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace mentAlly.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentallyController : ControllerBase
    {
        private readonly ILogger<MentallyController> _logger;

        public MentallyController(ILogger<MentallyController> logger)
        {
            _logger = logger;
        }

        [HttpPost("SummarizeChat")]
        public ActionResult<ChatSummary> SummarizeChat()
        {
            var chatSummary = new ChatSummary
            {
                UserId = Guid.Parse("014db2614e5d4069962b0e212e8b3190"),
                TimeStamp = DateTime.UtcNow,
                Summary = "This is a sample summary",
            };

            return Ok(chatSummary);
        }

        [HttpPost("GetGptResponse")]
        public ActionResult<Chat> GetGptResponse()
        {
            var chat = new Chat
            {
                UserId = Guid.Parse("014db2614e5d4069962b0e212e8b3190"),
                TimeStamp = DateTime.UtcNow,
                Message = "Try to empathize with people"
            };

            return Ok(chat);
        }
    }
}