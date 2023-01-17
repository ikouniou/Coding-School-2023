using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {
        public Message[] Messages { get; set; }

        public void ReadAll() { 
        
        }

        public void Clear() {
        
        }

        public void Write(Message message) {
            Messages[0].ID = message.ID;
            Messages[0].TimeStamp = message.TimeStamp;
            Messages[0].MessageDetails = message.MessageDetails;

        
        }

    }
}
