using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NIOPDCXmlGenerator.Services
{
    public static class ValidationHelper
    {
        public static bool ValidatePersonnelCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code)) return false;
            return Regex.IsMatch(code.Trim(), @"^\d{8}$");
        }
        public static bool IsMainInsured(string code)
        {
            if (!ValidatePersonnelCode(code)) return false;
            var suffix = code.Trim().Split('-')[1];
            return suffix == "00";
        }

        public static bool ValidateMobile(string? mobile)
        {
            //if (mobile == "09") return true;
            if (string.IsNullOrWhiteSpace(mobile)) return true;
            return Regex.IsMatch(mobile!.Trim(), @"^09\d{9}$");
        }

        public static bool ValidateNationalCode(string? code)
        {
            if (string.IsNullOrWhiteSpace(code)) return true;
            var s = code!.Trim();
            if (!Regex.IsMatch(s, @"^\d{10}$")) return false;
            if (s.Distinct().Count() == 1) return false;

            var check = int.Parse(s[9].ToString());
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(s[i].ToString()) * (10 - i);
            var r = sum % 11;
            return (r < 2 && check == r) || (r >= 2 && check == 11 - r);
        }
    }
}
