using System;
using System.Windows.Input;

namespace TodoErr.UserControls.Base;

public class RelayCommand : ICommand
{
    Action _action;

    public event EventHandler? CanExecuteChanged = null;

    public RelayCommand(Action action)
    {
        _action = action;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _action();
    }
}
