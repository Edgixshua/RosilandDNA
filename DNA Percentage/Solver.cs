using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RosalindTemplate
{
    public static class Solver
    {
        public static string Solve(string input)
        {
            List<string> DnaList = new List<string>();
            foreach (Match line in Regex.Matches(input, @">([A-Za-z0-9_]+)\s+([A-Za-z\s]+)"))
            {
                var DnaCapture = line.Groups[2].Value.Replace("\r\n", "").Trim();

                var DnaCount = DnaCapture.Count(p => p == 'G' || p == 'C');

                var Total = (((double)DnaCount / DnaCapture.Length) * 100);

                DnaList.Add($"{line.Groups[1].Value}\r\n{Total}");
            }

            return string.Join("\r\n", DnaList.ToArray());
        }
    }
}
