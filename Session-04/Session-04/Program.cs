// See https://aka.ms/new-console-template for more information


Greeting greeting = new Greeting();
Console.WriteLine(greeting.Get());
Console.WriteLine();

SimpleOperations simpleOperations = new SimpleOperations();
Console.WriteLine(simpleOperations.Addition());
Console.WriteLine(simpleOperations.Devision());
Console.WriteLine();

Operations operations = new Operations();
Console.WriteLine(operations.FirstOp());
Console.WriteLine(operations.SecondOp());
Console.WriteLine(operations.ThirdOp());
Console.WriteLine(operations.FourthOp());
Console.WriteLine(operations.FifthOp());
Console.WriteLine();

GenderAge genderAge = new GenderAge();
Console.WriteLine("You are " + genderAge.Gender() + " and look younger than " + genderAge.Age() + ".");
Console.WriteLine();

TimeConvertion timeConvertion = new TimeConvertion();
Console.WriteLine(timeConvertion.Minutes() + " minutes");
Console.WriteLine(timeConvertion.Hours() + " hours");
Console.WriteLine(timeConvertion.Days() + " days");
Console.WriteLine(timeConvertion.Years() + " years");
Console.WriteLine();

// 6. Rewrite Program #5 using .Net Libraries

TimeSpan ts = TimeSpan.FromSeconds(45678);
Console.WriteLine( (int) ts.TotalMinutes + " minutes");
Console.WriteLine(ts.Hours + " hours");
Console.WriteLine(ts.Days + " days");
Console.WriteLine(ts.Days / 365 + " years");
Console.WriteLine();

Degrees degrees = new Degrees();
Console.WriteLine(degrees.Kelvin() + " Kelvin");
Console.WriteLine(degrees.Fahrenheit() + " Fahrenheit");



Console.ReadLine();



