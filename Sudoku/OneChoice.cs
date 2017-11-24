using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class OneChoice : SolveSquare
    {
        public override char SelectSymbol()
        {
            char sym = new char();
            foreach (var ch in square.validSymbol)
            {
                if (needsSymbol && !inBlock && !inColumn && !inRow)
                {
                    sym = ch;
                    break;
                }
                else
                    sym = square.symbol;
            }
            return sym;
        }
    }
}
