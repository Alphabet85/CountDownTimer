using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace CountDownTimer.Resources.Converters
{
    /// <summary>
    /// IntValueToRightOrLeftConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntValueToRightOrLeftConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "Right";
                }
                else if ((int)value == 0)
                {
                    return "Left";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitValueToYesorNoConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitValueToYesorNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "Yes";
                }
                else if ((int)value == 0)
                {
                    return "No";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntValueToNotGoodOrFaultConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntValueToNotGoodOrFaultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "Good";
                }
                else if ((int)value == 0)
                {
                    return "Fault";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitValueToNotYesorNoConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitValueToNotYesorNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "No";
                }
                else if ((int)value == 0)
                {
                    return "Yes";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// BooleanToVisibilityCollapsedConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if (value != null)
                {
                    if ((bool)value)
                    {
                        return Visibility.Visible;
                    }
                    else
                    {
                        return Visibility.Collapsed;
                    }
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// BooleanToVisibilityHiddenConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityHiddenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if (value != null)
                {
                    if ((bool)value)
                    {
                        return Visibility.Visible;
                    }
                    else
                    {
                        return Visibility.Hidden;
                    }
                }
                else
                {
                    return Visibility.Hidden;
                }
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// BooleanNotToVisibilityCollapsedConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanNotToVisibilityCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if (value != null)
                {
                    if ((bool)value)
                    {
                        return Visibility.Collapsed;
                    }
                    else
                    {
                        return Visibility.Visible;
                    }
                }
                else
                {
                    return Visibility.Visible;
                }
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// BooleanNotToVisibilityHiddenConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanNotToVisibilityHiddenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && (bool)value)
            {
                return Visibility.Hidden;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntValueToColorConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(SolidColorBrush))]
    public class IntValueToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return new SolidColorBrush(Colors.LightGreen);
                }
                else if ((int)value == 0)
                {
                    return new SolidColorBrush(Colors.OrangeRed);
                }
                else
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
            }
            else
            {
                return new SolidColorBrush(Colors.OrangeRed);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitValueToGoodOrBadConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitValueToGoodOrBadConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "Good";
                }
                else if ((int)value == 0)
                {
                    return "Bad";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// BooleanToGoodOrBadConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(string))]
    public class BooleanToGoodOrBadConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((bool)value == true)
                {
                    return "Good";
                }
                else if ((bool)value == false)
                {
                    return "Bad";
                }
                else
                {
                    return "Unknown (" + (bool)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// BooleanToColorConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(SolidColorBrush))]
    public class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((bool)value == true)
                {
                    return new SolidColorBrush(Colors.LightGreen);
                }
                else if ((bool)value == false)
                {
                    return new SolidColorBrush(Colors.OrangeRed);
                }
                else
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
            }
            else
            {
                return new SolidColorBrush(Colors.OrangeRed);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitValueToActiveOrInactiveConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitValueToActiveOrInactiveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "Active";
                }
                else if ((int)value == 0)
                {
                    return "Inactive";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitValueToRadiationModeConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitValueToRadiationModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 1)
                {
                    return "CBCT";
                }
                else if ((int)value == 0)
                {
                    return "PAN/CEPH";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitsToSensorTypeConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitsToSensorTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 000)
                {
                    return "CEPH";
                }
                else if ((int)value == 001)
                {
                    return "PAN";
                }
                else if ((int)value == 002)
                {
                    return "SMALL";
                }
                else if ((int)value == 003)
                {
                    return "Medium";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitsToSensorMountPositionTypeConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitsToSensorMountPositionTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 000)
                {
                    return "PAN/CBCT";
                }
                else if ((int)value == 001)
                {
                    return "CEPH";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitsToBLDApertureSizeConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitsToBLDApertureSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 000)
                {
                    return "CEPH";
                }
                else if ((int)value == 001)
                {
                    return "PAN";
                }
                else if ((int)value == 002)
                {
                    return "CBCT";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitsToStudyStatusConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitsToStudyStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 000)
                {
                    return "STOPPED";
                }
                else if ((int)value == 001)
                {
                    return "RUNNING";
                }
                else if ((int)value == 002)
                {
                    return "NOT STARTED";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitsToStudyPhaseConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitsToStudyPhaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 000)
                {
                    return "INACTIVE";
                }
                else if ((int)value == 001)
                {
                    return "IDLE";
                }
                else if ((int)value == 002)
                {
                    return "DARK";
                }
                else if ((int)value == 003)
                {
                    return "DAWN";
                }
                else if ((int)value == 004)
                {
                    return "LIGHT";
                }
                else if ((int)value == 005)
                {
                    return "DUSK";
                }
                else if ((int)value == 006)
                {
                    return "ERROR";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// IntBitsToStudyTypeConverter
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class IntBitsToStudyTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((int)value == 000)
                {
                    return "CEPH";
                }
                else if ((int)value == 001)
                {
                    return "PAN";
                }
                else if ((int)value == 002)
                {
                    return "CBCT";
                }
                else
                {
                    return "Unknown (" + (int)value + ")";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// EnumMatchToBooleanConverter
    /// </summary>
    [ValueConversion(typeof(string), typeof(bool))]
    public class EnumMatchToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return false;
            }

            return value.ToString().Equals(parameter.ToString(), StringComparison.InvariantCultureIgnoreCase);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return null;
            }

            if ((bool)value)
            {
                return Enum.Parse(targetType, parameter.ToString());
            }

            return null;
        }
    }

    /// <summary>
    /// EnumMatchToNotBooleanConverter
    /// </summary>
    [ValueConversion(typeof(string), typeof(bool))]
    public class EnumMatchToNotBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return true;
            }

            return !value.ToString().Equals(parameter.ToString(), StringComparison.InvariantCultureIgnoreCase);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return null;
            }

            if ((bool)value)
            {
                return Enum.Parse(targetType, parameter.ToString());
            }

            return null;
        }
    }

    public class RelativePositionConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values?.Length < 2
                || !(values[0] is double relativePosition)
                || !(values[1] is double size)
                || !(parameter is string)
                || !double.TryParse((string)parameter, out double relativeToValue))
            {
                return DependencyProperty.UnsetValue;
            }

            return relativePosition * relativeToValue - size / 2;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// BooleanFlipConverter
    /// </summary>
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BooleanFlipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if (value != null)
                {
                    if ((bool)value)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    /// <summary>
    /// StringTimeToColorConverter
    /// </summary>
    [ValueConversion(typeof(string), typeof(SolidColorBrush))]
    public class StringTimeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (int.Parse(value.ToString()) <= 30 && int.Parse(value.ToString()) > 10)
                {
                    return new SolidColorBrush(Colors.DarkRed);
                }
                else if (int.Parse(value.ToString()) <= 10)
                {
                    return new SolidColorBrush(Colors.Red);
                }
                else
                {
                    return new SolidColorBrush(Colors.White);
                }
            }
            else
            {
                return new SolidColorBrush(Colors.White);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
