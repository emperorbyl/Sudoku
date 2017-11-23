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
        public List<char> validSymbol = new List<char>();
        public char symbol = '1';
        public Square(char sym)
        {
            symbol = sym;
        }
    }
}
