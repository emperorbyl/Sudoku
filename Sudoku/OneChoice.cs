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
            OneChoice one = new OneChoice();
            foreach (var ch in one.square.validSymbol)
            {
                if (one.needsSymbol && !one.inBlock && !one.inColumn && !one.inRow)
                {
                    sym = characater;
                    break;
                }
            }
            return sym;
        }
    }
}
