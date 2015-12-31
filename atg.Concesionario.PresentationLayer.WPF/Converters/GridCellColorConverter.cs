#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace atg.Concesionario.PresentationLayer.WPF.Converters
{
    public class GridCellColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //var source = value as ExpenseData;
            //var brushCoverter = new System.Windows.Media.BrushConverter();
            //var brush = (Brush)brushCoverter.ConvertFromString("#333333");
            //if (source == null)
            //    return brush;
            //if (source.AccountType == AccountType.Positve)
                return Brushes.Green;
            //else
            //    return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
