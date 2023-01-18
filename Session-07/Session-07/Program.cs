using Session_07;

//Console.WriteLine("Hello, World!");

//ActionRequest request = new ActionRequest();
//ActionResponse response = new ActionResponse();

//ActionResolver resolver= new ActionResolver();

//response = resolver.Execute(request);

////DISPLAY MESSAGES FROM LOGGER
//foreach (Message message in resolver.Logger.Messages) {

//    Console.WriteLine(message);

//}

ActionRequest request = new ActionRequest() {
    Input = "anastasia",
    Action = ActionEnum.Reverse
};

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);

//DISPLAY MESSAGES FROM LOGGER

//foreach (Message message in resolver.Logger.Messages) {

//    Console.WriteLine(resolver.Logger.Messages);

//}

Console.WriteLine(resolver.Logger.Messages[1].MessageText); 
Console.WriteLine(response.Output);


Console.ReadLine();