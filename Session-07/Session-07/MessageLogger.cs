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

            //display messages from logger

            foreach (Message message in Messages) {

                if(message != null) {
                    Console.Write(message.ID);
                    Console.Write(" ");
                    Console.Write(message.TimeStamp);
                    Console.WriteLine(" " + message.MessageText);
                }

            }

        }

        public void Clear() {

            Messages = new Message[1000];
            _counter = 0;
        
        }

        public void Write(Message message) {
            Messages[_counter] = message;
            _counter++;
        
        }

    }
}
