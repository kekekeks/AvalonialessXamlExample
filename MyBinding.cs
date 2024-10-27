using System;
using Avalonia.Data.Core;
using Avalonia.Markup.Xaml;

namespace AvalonialessXamlSample;

public class MyBinding
{
    [ConstructorArgument("path")]
    public string Path { get; set; } = "";

    public MyBinding()
    {
        
    }

    public MyBinding(string path)
    {
        Path = path;
    }
    
    public object ProvideValue(IServiceProvider sp)
    {
        var pvt = (IProvideValueTarget)sp.GetService(typeof(IProvideValueTarget));
        var property = (IPropertyInfo)pvt.TargetProperty;
        return $"Binding with path {Path} for {pvt.TargetObject.GetType()} property {property.Name} of type {property.PropertyType}";
    }
}