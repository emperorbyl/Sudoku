using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Board
    {
        private int size { get; set; }
        public List<Square> grid = new List<Square>();
        public List<char> validSymbol = new List<char>();
        public Board(int count)
        {
            size = count;
        }
    }
}
