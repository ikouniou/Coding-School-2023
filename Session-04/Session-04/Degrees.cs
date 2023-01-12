using System;

public class Degrees
{
	// 7. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit

	double celsius = 28.00;

	public double Kelvin()
	{
		double kelvin = celsius + 273.15;
		return kelvin;

	}

	public double Fahrenheit() 
	{
		double fahrenheit = celsius * 1.8 + 32;
		return fahrenheit;
	}
}
