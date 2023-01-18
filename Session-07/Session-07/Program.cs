using Session_07;

ActionRequest request = new ActionRequest() {
    Input = "12",
    Action = ActionEnum.Reverse
};

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);


resolver.Logger.ReadAll();
Console.WriteLine(response.Output);


Console.ReadLine();