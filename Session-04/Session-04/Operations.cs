using System;

public class Operations
{
    //3. Write a C# program to print the result of specified operations

    public float FirstOp()
	{
        float first = -1 + (5 * 6);
        return first;
	}

    public float SecondOp()
    {
        float second = 38 + (5 % 7);
        return second;
    }

    public double ThirdOp()
    {
        double third = 14.0 + (-3.0 * 6.0 / 7.0);
        return third;
    }

    public double FourthOp()
    {
        double fourth = 2.0 + (13.0 / 6.0 * 6.0) + Math.Sqrt(7);
        return fourth;
    }

    public double FifthOp()
    {
        double fifth = (Math.Pow(6,4) + Math.Pow(5,7)) / (9 % 4);
        return fifth;
    }
}
