using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSenderApp.Logic
{
    interface ILogic
    {
        void SendMessage(Message message);
        void ReciveMessage(Message message);
    }
}
