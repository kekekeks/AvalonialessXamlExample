using Avalonia;
using System;
using Avalonia.Metadata;

[assembly:XmlnsDefinition("com.mycompany.xaml", "AvalonialessXamlSample")]
namespace AvalonialessXamlSample;

class Program
{

    public static void Main(string[] args)
    {
        var xamlClass = new MyXamlClass();
        Console.WriteLine(xamlClass.Content.Property);
    }
}