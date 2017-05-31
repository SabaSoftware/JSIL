using System;

public static class Program
{
    public static void Main(string[] args)
    {
        var s = "abcdefabcdef";
        Console.WriteLine(s.IndexOf("ABC", StringComparison.OrdinalIgnoreCase));
    }
}