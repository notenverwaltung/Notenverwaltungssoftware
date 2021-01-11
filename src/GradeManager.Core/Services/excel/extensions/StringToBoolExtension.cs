using System;
using System.Collections.Generic;
using System.Text;

namespace GradeManager.Core.Services.excel
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