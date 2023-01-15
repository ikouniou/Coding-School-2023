using System;

public class Bubblesort
{

    //5. Write a C# program to sort the given array of integers from the lowest to the highest number

    public void sort()
	{
		int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
		int temp;
		for(int i=0; i < array.Length - 1; i++)
		{
			for(int j=0; j < array.Length - i - 1; j++)
			{
				if (array[j] > array[j + 1])
				{
					temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
				}
			}
		}

		Console.WriteLine("The array[0,-2,1,20,-31,50,-4,17,89,100] sorted from the lowest to the highest number is:");
        Console.WriteLine("[{0}]", string.Join(", ", array));

    }
}
