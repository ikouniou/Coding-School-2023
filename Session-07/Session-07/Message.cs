using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class Message {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MessageText { get; set; }

        public Message(string messageText) {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            MessageText = messageText;
        }
    }

    
}
