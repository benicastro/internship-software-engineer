using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipPetProject
{
    public static class Utils
    {
        // Check if the specified form is open
        public static bool FormIsOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }

        // Verify if email is valid
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        public static bool IsValidEmailDomain(string email)
        {
            if (!IsValidEmail(email))
            {
                return false;
            }

            string[] parts = email.Split('@');
            string localPart = parts[0];
            string domainPart = parts[1];

            try
            {
                // check if domain name has a valid MX record
                var hostEntry = Dns.GetHostEntry(domainPart);
                return hostEntry.HostName.Length > 0;
            }
            catch
            {
                return false; // domain name is invalid or does not have a valid MX record
            }
        }
    }
}
