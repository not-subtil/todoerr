using FontAwesome5;
using System.Windows;
using System.Windows.Controls;

namespace TodoErr.UserControls.Common;

public partial class Indicator : UserControl
{
    public EFontAwesomeIcon Icon
    {
        get
        {
            return (EFontAwesomeIcon)GetValue(IconProperty);
        }
        set
        {
            SetValue(IconProperty, value);
        }
    }

    public string Header
    {
        get
        {
            return (string)GetValue(HeaderProperty);
        }
        set
        {
            SetValue(HeaderProperty, value);
        }
    }

    public static readonly DependencyProperty HeaderProperty =
        DependencyProperty.Register("Header", typeof(string), typeof(Indicator));

    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register("Icon", typeof(EFontAwesomeIcon), typeof(Indicator));

    public Indicator()
    {
        InitializeComponent();
    }
}
