using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Avalonia.ValidationTest.View.Control
{
    public class HeaderTextBox : UserControl
    {
        private readonly Border _textBoxBorder; 
        private bool _isChanged;
        private string _text;
        
        public HeaderTextBox()
        {
            AvaloniaXamlLoader.Load(this);
            
            StackPanel root = this.FindControl<StackPanel>("Root");
            _textBoxBorder = this.FindControl<Border>("TextBoxBorder");
            
            root.DataContext = this;
        }
        
        public static readonly StyledProperty<string> HeaderProperty = AvaloniaProperty
            .Register<HeaderTextBox, string>(nameof(Header), defaultBindingMode: BindingMode.OneWay);
        
        // A try to get validations working on Composite control. Didn't work...
        public static readonly DirectProperty<HeaderTextBox, string> TextProperty = TextBlock.TextProperty
            .AddOwnerWithDataValidation<HeaderTextBox>(
                o => o.Text,
                (o, v) => o.Text = v,
                defaultBindingMode: BindingMode.TwoWay,
                enableDataValidation: true);
        
        public static readonly DirectProperty<HeaderTextBox, bool> IsChangedProperty = AvaloniaProperty
            .RegisterDirect<HeaderTextBox, bool>(nameof(IsChanged), o => o.IsChanged,
                (o, v) => o.IsChanged = v);
        
        public static readonly StyledProperty<string> OriginalValueProperty = AvaloniaProperty
            .Register<HeaderTextBox, string>(nameof(OriginalValue), defaultBindingMode: BindingMode.OneWay);
        
        public static readonly StyledProperty<IBrush> IsChangedColorProperty = AvaloniaProperty
            .Register<HeaderTextBox, IBrush>(nameof(IsChangedColor), defaultBindingMode: BindingMode.TwoWay);

        public string Header
        {
            get => GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }

        public string Text
        {
            get => _text;
            set => SetAndRaise(TextProperty, ref _text, value);
        }

        public bool IsChanged
        {
            get => _isChanged;
            private set
            {
                SetAndRaise(IsChangedProperty, ref _isChanged, value);
                
                // Triggers changed of background color when Property IsChanged
                // This would on WPF be done with Style Trigger or Behaviors
                if (IsChanged)
                {
                    _textBoxBorder.Background = Brushes.SteelBlue;
                    return;
                }
                _textBoxBorder.Background = Brushes.Transparent;
            }
        }

        public string OriginalValue
        {
            get => GetValue(OriginalValueProperty);
            set => SetValue(OriginalValueProperty, value);
        }
        
        public IBrush IsChangedColor
        {
            get => GetValue(IsChangedColorProperty);
            set => SetValue(IsChangedColorProperty, value);
        }
    }
}