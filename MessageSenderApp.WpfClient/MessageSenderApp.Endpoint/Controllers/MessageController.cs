using MessageSenderApp.Endpoint.Models;
using MessageSenderApp.Endpoint.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageSenderApp.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class MessageController : ControllerBase
    {
        IHubContext<SignalRHub> hub;

        public MessageController(IHubContext<SignalRHub> hub)
        {
            this.hub = hub;
        }

        [HttpPost]
        public void Send([FromBody] Message value)
        {
            this.hub.Clients.All.SendAsync("MessageSend", value);
        }
    }
}
