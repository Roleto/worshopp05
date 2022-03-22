using MessageSenderApp.Endpoint.Services;
using MessageSenderApp.Logic;
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
        ILogic logic;
        IHubContext<SignalRHub> hub;

        public MessageController(ILogic logic, IHubContext<SignalRHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpPost]
        public void Send([FromBody] Message value)
        {
            this.logic.SendMessage(value);
            this.hub.Clients.All.SendAsync("MessageSend", value.MessageValue);
        }
    }
}
