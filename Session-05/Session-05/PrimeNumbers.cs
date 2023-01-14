using System;

public class PrimeNumbers
{

    // 3. Write a C# program that asks the user for an integer (n) and finds all
    // the prime numbers from 1 to n.

    public bool Primes(int number)
	{
		for(int i=2; i<number ; i++) 
		{
			if(number % i == 0) 
			{
				return false;

			}
		}

		return true;
	}
}
