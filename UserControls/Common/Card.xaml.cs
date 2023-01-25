using FontAwesome5;
using System.Windows;
using System.Windows.Controls;

namespace TodoErr.UserControls.Common;

public partial class Card : UserControl
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
        DependencyProperty.Register("Header", typeof(string), typeof(Card));

    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register("Icon", typeof(EFontAwesomeIcon), typeof(Card));

    public Card()
    {
        InitializeComponent();
    }

    void AddBanner(Banner banner)
    {
        var childrenCollection = ContentStkPnl.Children;

        childrenCollection.Add(banner);
    }

    void RemoveBanner(Banner banner)
    {
        var childrenCollection = ContentStkPnl.Children;

        childrenCollection.Remove(banner);
    }
}
