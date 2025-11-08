using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NIOPDCXmlGenerator.Data
{

    public static class PersianDateHelper
    {
        private static PersianCalendar _pc = new PersianCalendar();

        // ورودی: yyyy/MM/dd یا dd/MM/yyyy بسته به UI شما — در این مثال yyyy/MM/dd
        public static DateTime ParseShamsiToGregorian(string shamsi)
        {
            var parts = shamsi.Split('/', '-');
            if (parts.Length < 3) throw new FormatException("فرمت تاریخ صحیح نیست");
            int y = int.Parse(parts[0]);
            int m = int.Parse(parts[1]);
            int d = int.Parse(parts[2]);
            return _pc.ToDateTime(y, m, d, 0, 0, 0, 0);
        }

        public static string ToShamsi(DateTime dt)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}",
              _pc.GetYear(dt), _pc.GetMonth(dt), _pc.GetDayOfMonth(dt));
        }
    }

}
