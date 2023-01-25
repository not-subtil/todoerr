using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace TodoErr.Classes.Converters;

class CardSVHeight : MarkupExtension, IValueConverter
{
    static CardSVHeight? _converter = null;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return ((double)value - 144);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ?? (_converter = new());
    }
}
