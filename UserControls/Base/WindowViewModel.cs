using System.Windows;
using System.Windows.Input;

namespace TodoErr.UserControls.Base;

public class WindowViewModel : BaseViewModel
{
    Window _window;

    public int WindowWidth { get; set; } = 1700;
    public int WindowMinWidth { get; set; } = 1500;
    public int WindowHeight { get; set; } = 650;
    public int WindowMinHeight { get; set; } = 800;
    public int WindowCornerRadius { get; set; } = 12;

    public RelayCommand MinimizeCommand { get; set; }
    public RelayCommand MaximizeCommand { get; set; }
    public RelayCommand CloseCommand { get; set; }

    public WindowViewModel(Window window)
    {
        _window = window;

        _window.MouseDown += (s, e) => { MoveWindow(s, e); };
        _window.StateChanged += (s, e) => { WindowResized(); };

        CloseCommand = new RelayCommand(() => _window.Close());
        MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
        MaximizeCommand = new RelayCommand(() => MaximizeWindow());
    }

    void MaximizeWindow()
    {
        var isMaximized = (_window.WindowState == WindowState.Maximized);

        WindowCornerRadius = (isMaximized ? 12 : 0);

        _window.WindowState = (isMaximized ? WindowState.Normal : WindowState.Maximized);
    }

    void MoveWindow(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton != MouseButtonState.Pressed)
        {
            return;
        }

        _window.DragMove();
    }

    void WindowResized()
    {
        OnPropertyChanged(nameof(WindowWidth));
        OnPropertyChanged(nameof(WindowHeight));
        OnPropertyChanged(nameof(WindowCornerRadius));
    }
}
