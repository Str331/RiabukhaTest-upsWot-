using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace upswot.Domain.Extension
{
    public static class GetId
    {
        public static int GetURLid(this string URL)
        {
            Regex regex = new Regex(@"\d*$");
            if (regex.Match(URL).Value == string.Empty)
                return 0;
            return Convert.ToInt32(regex.Match(URL).Value);
        }
    }
}
