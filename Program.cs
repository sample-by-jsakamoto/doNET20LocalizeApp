using System;
using System.Globalization;
using doNET20LocalizeApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Culture = en ----");
        Console.WriteLine("expected: Hello");
        Console.WriteLine("actula:   " + _Localize.ResourceManager.GetString("Hello", CultureInfo.GetCultureInfo("en")));

        Console.WriteLine();

        Console.WriteLine("---- Culture = ja ----");
        Console.WriteLine("expected: こんにちは");
        Console.WriteLine("actual:   " + _Localize.ResourceManager.GetString("Hello", CultureInfo.GetCultureInfo("ja")));
    }
}
