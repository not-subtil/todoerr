using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TodoErr.UserControls.Common;

public partial class CardSelector : UserControl
{
    public int Index
    {
        get
        {
            return (int)GetValue(IndexProperty);
        }
        set
        {
            SetValue(IndexProperty, value);
        }
    }

    public static readonly DependencyProperty IndexProperty =
        DependencyProperty.Register("Index", typeof(int), typeof(CardSelector));

    public CardSelector()
    {
        InitializeComponent();
    }

    void SelectorMouseDown(object sender, MouseButtonEventArgs e)
    {
        var border = (Border)sender;
        var tag = (string)border.Tag;
        var index = int.Parse(tag);

        Index = index;
    }
}
