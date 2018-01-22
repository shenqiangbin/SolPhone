using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ZaiPangWin
{
    public class RegexHelper
    {
        public static List<string> GetIP(string str)
        {
            List<string> list = new List<string>();

            var ip_ip = "(25[0-5]|2[0-4]\\d|1\\d\\d|\\d\\d|\\d)";
            var ip_ipdot = ip_ip + "\\.";
            var ip_port = "(:(\\d\\d\\d\\d\\d|\\d\\d\\d\\d|\\d\\d\\d|\\d\\d|\\d))?";
            string RegexStr = ip_ipdot + ip_ipdot + ip_ipdot + ip_ip + ip_port;

            if (Regex.IsMatch(str, RegexStr))
            {
                MatchCollection matchs = Regex.Matches(str, RegexStr);
                foreach (Match item in matchs)
                {
                    list.Add(item.Value);
                }
            }

            return list;
        }
    }
}
