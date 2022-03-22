using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSenderApp.Logic
{
    public class Message
    {
        private string messageValue;
        private string name;
        private string date;

        public string MessageValue
        {
            get { return messageValue; }
            set { messageValue = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public string Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
