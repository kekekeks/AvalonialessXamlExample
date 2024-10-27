using Avalonia;
using System;

namespace AvalonialessXamlSample;

class Program
{

    public static void Main(string[] args)
    {
        var xamlClass = new MyXamlClass();
        Console.WriteLine(xamlClass.Content.Property);
    }
}