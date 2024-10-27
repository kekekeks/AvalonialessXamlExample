using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvalonialessXamlSample;

public partial class MyXamlClass : MyBaseClass
{
    public MyXamlClass()
    {
        AvaloniaXamlLoader.Load(this);
    }
}