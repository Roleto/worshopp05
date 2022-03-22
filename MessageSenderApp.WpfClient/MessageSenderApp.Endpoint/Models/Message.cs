using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageSenderApp.Endpoint.Models
{
    public class Message
    {
        private string messageValue;
        private string name;
        private string date;

        public Message(string messageValue, string name, string date)
        {
            this.messageValue = messageValue;
            this.name = name;
            this.date = date;
        }

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

        public override string ToString()
        {
            return $"{this.MessageValue}, by:{this.Name}  {this.Date}";
        }
    }
}
