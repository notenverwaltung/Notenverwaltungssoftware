using System;
using System.ComponentModel;

namespace Notenverwaltung.Core
{
    /// <summary>
    /// ConvertToNullableExtension.
    /// </summary>
    public static class NullableExtension
    {
        /// <summary>
        /// Rounds the specified digits.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="digits">The digits.</param>
        /// <returns></returns>
        public static double? RoundNullableDouble(this double? value, int digits = 1)
        {
            if (value.HasValue)
            {
                value = Math.Round(value.Value, digits);
            }

            return value;
        }

        /// <summary>
        /// Converts to nullable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Nullable<T> ToNullable<T>(this string param) where T : struct
        {
            Nullable<T> result = new Nullable<T>();
            try
            {
                if (!string.IsNullOrEmpty(param) && param.Trim().Length > 0)
                {
                    TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                    result = (T)conv.ConvertFrom(param);
                }
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Converts to nullablestring.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static string ToNullableString(this string param)
        {
            if (param.Length == 0)
            {
                return null;
            }

            return param;
        }
    }
}