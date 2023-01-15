using System;

public class MultiplyArrays
{

    /* 4. Write a C# program to multiply all values from Array1
     * with all values from Array2 and display the results in a new Array.
     * • Array1: [2, 4, 9, 12] • Array2: [1, 3, 7, 10]
	 */

	public void Multiply()
	{
        int[] array1 = { 2, 4, 9, 12 };
        int[] array2 = { 1, 3, 7, 10 };
        int[] newArray = new int[16];
        int k = 0;

        for(int i=0; i<array1.Length; i++)
        {
            for(int j=0; j<array2.Length; j++)
            {
                newArray[k] = array1[i] * array2[j];
                k++;
            }
        }

        Console.WriteLine("The multiplications of all values from array1[2,4,9,12] with all values from array2[1,3,7,10] are:");
        //for (int i = 0; i < newArray.Length; i++)
        //{
        //    Console.Write(newArray[i] + " ");
        //}
        Console.WriteLine("newArray[{0}]", string.Join(", ", newArray));

    }
}
