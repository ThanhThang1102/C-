using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace buithanhthang_2121110129.Functions
{
    internal static class Checking
    {
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
