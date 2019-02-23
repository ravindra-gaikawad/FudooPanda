using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda.Core
{
    public static class CustomExtensions
    {
        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            if (list.Count == 0)
            {
                return true;
            }

            return false;
        }

    }
}
