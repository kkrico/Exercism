using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Hey(string statement)
    {
        statement = statement.Trim();

        if (statement.ToUpper() == statement && Regex.Matches(statement, @"[a-zA-Z]").Cast<Match>().Any())
            return "Whoa, chill out!";
        
        if (statement.EndsWith("?"))
            return "Sure.";

        if (statement.Replace(" ","") == "")
            return "Fine. Be that way!";

        return "Whatever.";
    }
}