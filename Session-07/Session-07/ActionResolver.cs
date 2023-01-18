using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_07 {
    public class ActionResolver : ActionRequest {
        public MessageLogger Logger { get; set; }

        public ActionResponse Execute(ActionRequest request) {
            //string output = String.Empty;

            //switch (request.Action) {
            //    case ActionEnum.Covnert:
            //        output = ConvertTo(request.Input);
            //        break;

            //    case ActionEnum.Uppercase:

            //        break;

            //    case ActionEnum.Revert:
            //        output = ReverseString(request.Input);
            //        break;

            //    default:
            //        break;
            //}

            return null;
        }

        //public string ConvertTo(string input) {
        //    decimal result;
        //    if (Decimal.TryParse(input, out result)) {
        //        string binary = Convert.ToString((byte)result, (byte)2);
        //        return binary;
        //    } else {
        //        return "Error: Cannot convert decimal to binary";
        //    }

        //}

        //public string UppercaseString(string input) {
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
        //}
        //public string ReverseString(string input) {

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
        //}
    }


}
