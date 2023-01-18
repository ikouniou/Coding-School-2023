using Session_07;

ActionRequest request = new ActionRequest() {
    Input = "ioanna is big girlllllllllllllllllll",
    Action = ActionEnum.Reverse
};

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);


resolver.Logger.ReadAll();
Console.WriteLine(response.Output);


Console.ReadLine();