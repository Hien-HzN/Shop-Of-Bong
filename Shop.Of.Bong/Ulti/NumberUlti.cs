using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Of.Bong.Ulti
{
    public class NumberUlti
    {
        public bool IsNumber(string value)
        {
            int result;
            return int.TryParse(value, out result);
        }

        public int ConvertStringToInt(string value)
        {
            if (IsNumber(value))
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }
    }
}