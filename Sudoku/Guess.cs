using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Guess:SolveSquare
    {
        public override char SelectSymbol()
        {
            char sym = new char();
            Guess guess = new Guess();
            foreach (var ch in guess.square.validSymbol)
            {
                if (guess.needsSymbol && !guess.inBlock && !guess.inColumn && !guess.inRow)
                {
                    sym = characater;
                }
            }
            return sym;
        }
    }
}
