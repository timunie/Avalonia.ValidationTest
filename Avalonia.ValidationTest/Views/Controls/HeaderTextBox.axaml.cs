using Avalonia.Controls.Primitives;
using Avalonia.Data;

namespace Avalonia.ValidationTest.Views.Controls;

public class HeaderTextBox : TemplatedControl
{
    public static readonly StyledProperty<string> HeaderProperty = AvaloniaProperty
        .Register<HeaderTextBox, string>(nameof(Header), defaultBindingMode: BindingMode.OneWay);
    
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty
        .Register<HeaderTextBox, string>(nameof(Text), defaultBindingMode: BindingMode.TwoWay);
    
    public static readonly StyledProperty<bool> IsChangedProperty = AvaloniaProperty
        .Register<HeaderTextBox, bool>(nameof(IsChanged), defaultBindingMode: BindingMode.OneWay);
        
    public static readonly StyledProperty<string> OriginalValueProperty = AvaloniaProperty
        .Register<HeaderTextBox, string>(nameof(OriginalValue), defaultBindingMode: BindingMode.OneWay);


    public string Header
    {
        get => GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }
    
    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public bool IsChanged
    {
        get => GetValue(IsChangedProperty);
        set => SetValue(IsChangedProperty, value);
    }

    public string OriginalValue
    {
        get => GetValue(OriginalValueProperty);
        set => SetValue(OriginalValueProperty, value);
    }
}