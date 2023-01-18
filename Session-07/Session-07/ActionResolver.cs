using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_07 {
    public class ActionResolver : ActionRequest {
        
        //Properties
        public MessageLogger Logger { get; set; }
       
        //Constructor
        public ActionResolver() {
            Logger = new MessageLogger();
        }

        //Methods
        public ActionResponse Execute(ActionRequest request) {
            
            ActionResponse response = new ActionResponse();
            response.RequestID = request.RequestID;
            response.ResponseID = Guid.NewGuid();

            try {
                switch (request.Action) {
                    case ActionEnum.Covnert:
                        response.Output = ConvertStr(request.Input);
                        Logger.Messages[0] = new Message("Input converted from decimal to binary");
                        break;
                    case ActionEnum.Uppercase:
                        response.Output = UppercaseStr(request.Input);
                        Logger.Messages[0] = new Message("Biggest word from Input converted to uppercase");
                        break;
                    case ActionEnum.Reverse:
                        response.Output = ReverseStr(request.Input);
                        Logger.Messages[0] = new Message("Input string is reversed");
                        break;
                    default:
                        Logger.Messages[0] = new Message("No action has took place");
                        break;
                }

            } catch (Exception ex) {
                Logger.Messages[0] = new Message("shit");

            } finally {
                Logger.Messages[0] = new Message("End of procedure");
            }

            

            return response;
        }

        public string ConvertStr(string input) {
            //    decimal result;
            //    if (Decimal.TryParse(input, out result)) {
            //        string binary = Convert.ToString((byte)result, (byte)2);
            //        return binary;
            //    } else {
            //        return "Error: Cannot convert decimal to binary";
            //    }
            return "hi";
        }

        public string UppercaseStr(string input) {
            //    if ( input is string) {
            //        string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
            //        string word = string.Empty;
            //        int ctr = 0;
            //        foreach (String s in words) {
            //            if (s.Length > ctr) {
            //                word = s;
            //                ctr = s.Length;
            //            }
            //        }

            //        return word.ToUpper();
            //    }else {
            //        return "Error: Cannot find biggest word";
            //    }
            return "hi2";
        }

        public string ReverseStr(string input) {

            //    if (input is string) {
            //        char[] charArray = input.ToCharArray();
            //        string reversedString = string.Empty;

            //        for (int i = charArray.Length - 1; i >= 0; i--) {
            //            reversedString += charArray[i];
            //        }

            //        return reversedString;
            //    } else {
            //        return "Error: Cannot reverse string";
            //    }
            return "hi3";
        }
    }


}
