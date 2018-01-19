using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;

namespace ZaiPangBuy
{
    class Program
    {
        private static Timer timer = new Timer();
        static void Main(string[] args)
        {
            timer.Interval = 1000 * 0.5;
            timer.Elapsed += delegate
            {
                ExecutCmd(cmd, "shell input tap 526 1250");                
            };

            // List<string> devices = GetDevices();
            string result = ExecutCmd(cmd, "connect 127.0.0.1:21503");
            if (result.Contains("already connected to"))
            {
                timer.Start();
            }
            Console.ReadKey();
        }

        private static string cmd = @"D:\Program Files\Microvirt\MEmu\adb.exe";
        private static List<string> GetDevices()
        {
            string result = ExecutCmd(cmd, "devices");
            return GetIP(result);
        }

        private static List<string> GetIP(string str)
        {
            List<string> list = new List<string>();

            var ip_ip = "(25[0-5]|2[0-4]\\d|1\\d\\d|\\d\\d|\\d)";
            var ip_ipdot = ip_ip + "\\.";
            var ip_port = "(:(\\d\\d\\d\\d|\\d\\d\\d|\\d\\d|\\d|\\d))?";
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

        public static string ExecutCmd(string cmd, string args)
        {
            StringBuilder result = new StringBuilder();

            using (Process p = new Process())
            {
                p.StartInfo.FileName = cmd;
                p.StartInfo.Arguments = args;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                p.PriorityClass = ProcessPriorityClass.Normal;
                result.Append(p.StandardError.ReadToEnd());
                result.Append(p.StandardOutput.ReadToEnd());
                p.WaitForExit();
            }

            return result.ToString();
        }
    }
}
