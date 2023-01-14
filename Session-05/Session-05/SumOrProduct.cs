using System;

public class SumOrProduct
{
    /*   2. Write a C# program that asks the user for an integer (n) and gives them
         the possibility to choose between computing the sum and computing
         the product of 1,…,n.2.
	*/


    public int Sum(int number)
	{
		int sum = 0;
		for(int i  = 1; i <= number; i++) 
		{
			sum += i;
		}

		return sum;
	}

	public int Product(int number) 
	{
		int product = 1;
		for(int i = 1; i <= number; i++)
		{
			product *= i;
		}

		return product;

	}
}
