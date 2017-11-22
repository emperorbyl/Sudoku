using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Square
    {
        
        public ConstrainedContainer row = new ConstrainedContainer();
        public ConstrainedContainer column = new ConstrainedContainer();
        public ConstrainedContainer block = new ConstrainedContainer();
        public SolveSquare solveSquare = new SolveSquare();
        private char symbol { get; set; }
        public Square(char sym)
        {
            symbol = sym;
        }
    }
}
