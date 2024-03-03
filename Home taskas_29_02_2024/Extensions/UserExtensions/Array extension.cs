using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_taskas_29_02_2024.Extensions.UserExtensions
{
    public static class Array_extension
    {
        public static int MyArray(this int[] array)
        {
            int result = 1;

            foreach (int item in array)
            {
                result *= item;
            }

            return result;
        }


    }
}
