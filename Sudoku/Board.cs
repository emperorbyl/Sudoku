using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Board
    {
        public int size { get; set; }
        public List<Square> grid = new List<Square>();
        public Board(int count)
        {
            size = count;
        }
    }
}
