using System.Windows;
using System.Windows.Controls;

namespace TodoErr.UserControls.Common;

public partial class PriorityIndicator : UserControl
{
    public ushort Priority
    {
        get
        {
            return (ushort)GetValue(PriorityProperty);
        }
        set
        {
            SetValue(PriorityProperty, value);
        }
    }

    public static readonly DependencyProperty PriorityProperty =
        DependencyProperty.Register("Priority", typeof(ushort), typeof(PriorityIndicator));

    public PriorityIndicator()
    {
        InitializeComponent();

        DataContext = this;
    }
}
