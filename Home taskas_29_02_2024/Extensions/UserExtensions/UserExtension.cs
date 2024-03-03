using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_taskas_29_02_2024.Extensions.UserExtensions
{
    public static class UserExtension
    {
                     
        public static bool CheckEmail(this string email)
        {
            return email.Contains("@");

        }

       


        public static bool CheckPasswordLength(this string password)
        {
            return password.Length > 8;
        }
    }
}
