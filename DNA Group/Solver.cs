using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RosalindTemplate {
    public static class Solver {
        public static string Solve(string input) {

            var DnaGrouped = input.OrderBy(p => p).GroupBy(p => p);

            var Numbers = DnaGrouped.Select(s => s.Count());

            return string.Join(" ", Numbers.ToArray());
        }
    }
}
