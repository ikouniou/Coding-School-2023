using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringManipulator {

        public virtual string Manipulate(string text) {

            return string.Empty;
        }
    }

    public class StringConvert : StringManipulator {

        public override string Manipulate(string text) {

            decimal result;
            if (Decimal.TryParse(text, out result)) {
                string binary = Convert.ToString((byte)result, (byte)2);
                return binary;
            } else {
                return string.Empty;
            }
        }
    }

    public class StringUppercase : StringManipulator{

        public override string Manipulate(string text) {

            if ( !text.Any(char.IsDigit) && text.Contains(" ")) {
                string[] words = text.Split(new[] { " " }, StringSplitOptions.None);
                string word = string.Empty;
                int ctr = 0;
                foreach (String s in words) {
                    if (s.Length > ctr) {
                        word = s;
                        ctr = s.Length;
                    }
                }
                return word.ToUpper();
            } else {
                return string.Empty;
            }
        }
    }

    public class StringReverse : StringManipulator{

        public override string Manipulate(string text) {

            if (!text.Any(char.IsDigit)) {

                // reverse string with recursion
                if (text.Length > 0)
                    return text[text.Length - 1] + Manipulate(text.Substring(0, text.Length - 1));
                else
                    return text;

            } else {
                return string.Empty;
            }
        }
    }
}
