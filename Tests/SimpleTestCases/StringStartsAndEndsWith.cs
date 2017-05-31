using System;

public static class Program {
    public static void PrintBool (bool b) {
        Console.WriteLine(b ? 1 : 0);
    }

    public static void Main (string[] args) {
        PrintBool("abcdef".StartsWith("abc"));
        PrintBool("abcdef".StartsWith("bcd"));
        PrintBool("abcdef".StartsWith("ABC", StringComparison.OrdinalIgnoreCase));
        PrintBool("abcdef".StartsWith("BCD", StringComparison.OrdinalIgnoreCase));
        PrintBool("abcdef".EndsWith("def"));
        PrintBool("abcdef".EndsWith("cde"));
        PrintBool("abcdef".EndsWith("DEF", StringComparison.OrdinalIgnoreCase));
        PrintBool("abcdef".EndsWith("CDE", StringComparison.OrdinalIgnoreCase));
    }
}