using System.Windows.Controls;
using TodoErr.Classes.Entities;

namespace TodoErr.UserControls.Common;

public partial class Banner : UserControl
{
    public Tasks? Data { get; set; }

    public Banner(Tasks data)
    {
        InitializeComponent();

        Data = data;

        DataContext = this;
    }
}
