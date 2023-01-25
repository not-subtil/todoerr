using System.ComponentModel;

namespace TodoErr.UserControls.Base;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        if (PropertyChanged == null)
        {
            return;
        }

        PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}
