namespace Notenverwaltung.Core.Services
{
    /// <summary>
    /// StringToBoolExtension.
    /// </summary>
    public static class StringToBoolExtension
    {
        /// <summary>
        /// Klassenleiters to bool.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static bool KlassenleiterToBool(this string value)
        {
            if (value.ToLower().Contains("x"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}