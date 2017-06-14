using System;
using System.IO;
using System.Windows.Forms;

namespace RosalindTemplate {
    class Program {
        [STAThreadAttribute]
        static void Main(string[] args) {
            // you'll need to update this filename for each problem.  Or do something cleverer..
            string fileContents = File.ReadAllText(@"C:\Users\joshuas\Downloads\rosalind_gc.txt").Trim();
            string result = Solver.Solve(fileContents);
            Clipboard.SetText(result);
            Console.WriteLine("Result:\n\n" + result);
            Console.WriteLine("\nResult written to clipboard.");
            //243 238 261 258
            //252 268 214 245

            Console.Read();
        }
    }
}
