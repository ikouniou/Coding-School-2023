﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_07 {
    public class ActionResolver {
        
        //Properties
        public MessageLogger Logger { get; set; }
        //int i =0;
       
        //Constructor
        public ActionResolver() {
            Logger = new MessageLogger();
        }

        //Methods
        public ActionResponse Execute(ActionRequest request) {
            
            ActionResponse response = new ActionResponse();
            response.RequestID = request.RequestID;
            response.ResponseID = Guid.NewGuid();

            Log("Start of execution");

            try {
                switch (request.Action) {
                    case ActionEnum.Covnert:
                        response.Output = ConvertStr(request.Input);
                        // --- 1st case I made
                        //Logger.Messages[i] = new Message("Input converted from decimal to binary");
                        //i++;

                        // --- 2nd case I made
                        //Logger.Write(new Message("Input converted from decimal to binary"));
                        Log("Input converted from decimal to binary");
                        break;
                    case ActionEnum.Uppercase:
                        response.Output = UppercaseStr(request.Input);
                        Log("Biggest word from Input converted to uppercase");
                        break;
                    case ActionEnum.Reverse:
                        response.Output = ReverseStr(request.Input);
                        Log("Input string is reversed");
                        break;
                    default:
                        Log("No action has taken place");
                        break;
                }

            } catch (Exception ex) {
                Log(ex.Message);

            } finally {
                Log("End of execution");
            }

            return response;
        }

        public void Log(string text) {

            Logger.Write(new Message(text));
        }
        public string ConvertStr(string input) {
            
            StringConvert convert = new StringConvert();

            return convert.Manipulate(input);
        }

        public string UppercaseStr(string input) {

            StringUppercase uppercase = new StringUppercase();

            return uppercase.Manipulate(input);
        }

        public string ReverseStr(string input) {

            StringReverse reverse = new StringReverse();

            return reverse.Manipulate(input);
        }
    }


}
