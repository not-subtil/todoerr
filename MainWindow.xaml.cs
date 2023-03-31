using System.Windows;
using TodoErr.UserControls.Base;

namespace TodoErr;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new WindowViewModel(this);
    }
}
