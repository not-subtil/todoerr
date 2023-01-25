using FontAwesome5;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TodoErr.UserControls.Common;

public partial class WindowButton : UserControl
{
    public ICommand Cmd
    {
        get
        {
            return (ICommand)GetValue(CmdProperty);
        }
        set
        {
            SetValue(CmdProperty, value);
        }
    }

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

    public static readonly DependencyProperty CmdProperty =
        DependencyProperty.Register("Cmd", typeof(ICommand), typeof(WindowButton));

    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register("Icon", typeof(EFontAwesomeIcon), typeof(WindowButton));

    public WindowButton()
    {
        InitializeComponent();
    }
}
