using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var divisibleByFour = year % 4 == 0;

        if (!divisibleByFour)
            return divisibleByFour;

        var divisibleByFourHundred = year % 400 == 0;
        var divisibleByHundred = year % 100 == 0;
        
        return divisibleByFour && (divisibleByFourHundred || !divisibleByHundred);
    }
}