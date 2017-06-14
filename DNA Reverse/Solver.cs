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

            //var result= s.Select(x=> x == 'A' ? 'B' : (x=='B' ? 'A' : x)).ToArray();
        }

        private static String ReplaceChars(this string Text, char OldChar, char NewChar)

            => string.Join("", Text.Select(x => x == 'A' ? 'B' : (x == 'B' ? 'A' : x)).ToArray());
        
    }
}
