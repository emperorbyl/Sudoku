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
            foreach (var ch in square.validSymbol)
            {
                if (needsSymbol && !inBlock && !inColumn && !inRow)
                {
                    sym = characater;
                }
                else
                    sym = square.symbol;
            }
            return sym;
        }
    }
}
