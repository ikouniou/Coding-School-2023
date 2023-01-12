using System;

public class TimeConvertion
{
    /* 5. Write a C# program that takes an integer representing seconds (for example 45678) and converts it to :
     • Minutes
     • Hours
     • Days
     • Years
    */

    int seconds = 45678;

    public int Minutes()
	{
        int minutes = seconds / 60;
        return minutes;

	}

    public int Hours() 
    {
        int hours = seconds / 3600;
        return hours;

    }

    public int Days()
    {
        int days =  Hours() / 24;
        return days;


    }

    public int Years() 
    {
        int years = Days() / 365;
        return years;
    }
}
