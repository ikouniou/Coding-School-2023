using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {
        public Message[] Messages { get; set; }
        private int _counter = 0;

        public MessageLogger() {
            Messages = new Message[1000];
        }
        public void ReadAll() { 
        
        }

        public void Clear() {
        
        }

        public void Write(Message message) {
            Messages[_counter] = message;
            _counter++;
        
        }

    }
}
