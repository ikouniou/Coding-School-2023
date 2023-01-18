using Session_07;

ActionRequest request = new ActionRequest() {
    Input = "ioanna",
    Action = ActionEnum.Uppercase
};

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);


resolver.Logger.ReadAll();
Console.WriteLine(response.Output);


Console.ReadLine();