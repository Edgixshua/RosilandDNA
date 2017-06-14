using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RosalindTemplate {
    public static class Solver {
        public static string Solve(string input) {

            return string.Join("", input.Replace('C', 'x').Replace('G', 'C').Replace('x', 'G').Replace('A', 'z').Replace('T', 'A').Replace('z', 'T').Reverse().ToArray());
            
        }
    }
}
