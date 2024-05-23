using System;

namespace prac7
{
    public class Message
    {
        public DateTime TimeStampiic { get; set; }
        public string TextSoobshenie { get; set; }

        public Message(DateTime timeStamp, string messageText)
        {
            TimeStampiic = timeStamp;
            TextSoobshenie = messageText;
        }
    }
}
