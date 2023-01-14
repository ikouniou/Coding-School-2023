using System;

public class ReverseString
{
	public string Reverse()
	{
        //1. Write a C# program that reverses a given string (your name)

        string name = "Ioanna";
		char[] charArray = name.ToCharArray();
		string reversedString = string.Empty;

		for(int i=charArray.Length - 1; i>=0; i--)
		{
			reversedString+= charArray[i];
		}

		return reversedString;
	}
}
