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
        int i =0;
       
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
                        Logger.Messages[i] = new Message("Input converted from decimal to binary");
                        i++;
                        break;
                    case ActionEnum.Uppercase:
                        response.Output = UppercaseStr(request.Input);
                        Logger.Messages[i] = new Message("Biggest word from Input converted to uppercase");
                        i++;
                        break;
                    case ActionEnum.Reverse:
                        response.Output = ReverseStr(request.Input);
                        Logger.Messages[i] = new Message("Input string is reversed");
                        i++;
                        break;
                    default:
                        Logger.Messages[i] = new Message("No action has took place");
                        i++;
                        break;
                }

            } catch (Exception ex) {
                Logger.Messages[i] = new Message("shit");
                i++;

            } finally {
                Logger.Messages[i] = new Message("End of procedure");
                i++;
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
