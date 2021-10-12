using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeBinder.Authentication.DataModels;
using FeBinder.Authentication.Pages;
using FeBinder.Authentication.ValueConverter.Base;

namespace FeBinder.Authentication.ValueConverter
{
    /// <summary>
    /// Converts the <see cref="AuthenticationPage"/> to an actual view/page
    /// </summary>
    class AuthenticationPageValueConverter : BaseValueConverter<AuthenticationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((AuthenticationPage)value)
            {
                case AuthenticationPage.Login:
                    return new LoginPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
