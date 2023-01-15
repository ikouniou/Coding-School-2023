
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

Console.WriteLine();

Console.WriteLine("Give an integer:");
var integer2 = Console.ReadLine();
int number2;
bool isNumerical2 = int.TryParse(integer2, out number2);
while (!isNumerical2)
{
    Console.WriteLine("Not an integer, please try again");
    integer2 = Console.ReadLine();
    isNumerical2 = int.TryParse(integer2, out number2);
}

PrimeNumbers primeNumbers = new PrimeNumbers();
Console.WriteLine("The prime numbers from 1 to " + number2 + " are:");
if(number2 == 1) 
{
    Console.WriteLine("No prime numbers");
}
for(int i = 2; i <= number2; i++) 
{
    if (primeNumbers.Primes(i)) 
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

MultiplyArrays multiplyArrays = new MultiplyArrays();
multiplyArrays.Multiply();

Console.WriteLine();
Bubblesort bubblesort = new Bubblesort();
bubblesort.sort();








Console.ReadLine();

