using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the files from the command line arguments
            string inputFile = args[0];
            string outFile = "";
            if (args.Count() > 1)
                outFile = args[1];
            // Give them to the solver
            Solver solve = new Solver(inputFile, outFile);
            solve.IntializeBoard();
            solve.Solve();
        }
    }
}
