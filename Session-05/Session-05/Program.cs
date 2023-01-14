
Console.WriteLine("Reverse of name: Ioanna");
ReverseString reverseString = new ReverseString();
Console.WriteLine(reverseString.Reverse());
Console.WriteLine();

Console.WriteLine("Give an integer:");
var integer = Console.ReadLine();
int number;
bool isNumerical = int.TryParse(integer, out number);
while(!isNumerical)
{
    Console.WriteLine("Not an integer, please try again");
    integer = Console.ReadLine();
    isNumerical = int.TryParse(integer, out number);
}

Console.WriteLine("For sum write 'sum' for product write 'product'");
string operation = Console.ReadLine();
while(operation != "sum" && operation != "product")
{
    Console.WriteLine("Please give an acceptable value");
    operation = Console.ReadLine();
}

SumOrProduct sumOrProduct = new SumOrProduct();
if(operation == "sum")
{
    Console.WriteLine(sumOrProduct.Sum(number));
}
else 
{
    Console.WriteLine(sumOrProduct.Product(number));
}







Console.ReadLine();

