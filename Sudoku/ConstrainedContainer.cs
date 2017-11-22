using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class ConstrainedContainer
    {
        private int size { get; set; }
        public List<char> content = new List<char>();
        public ConstrainedContainer()
        {
            content.Capacity = size;
        }
    }
}
