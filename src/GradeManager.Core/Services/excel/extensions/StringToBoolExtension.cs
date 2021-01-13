namespace GradeManager.Core.Services
{
    public static class StringToBoolExtension
    {
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