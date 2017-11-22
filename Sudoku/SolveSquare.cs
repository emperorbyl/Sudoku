using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SolveSquare
    {
        private Square square { get; set; }
        public void FindCharacter()
        {
            CheckSquare();
            ValidateBlock();
            ValidateRow();
            ValidateColumn();
            SelectSymbol();
            InsertSymbol();
        }
        public void CheckSquare()
        {

        }
        public void ValidateRow()
        {

        }
        public void ValidateColumn()
        {

        }
        public void ValidateBlock()
        {

        }
        public void InsertSymbol()
        {

        }
        public virtual void SelectSymbol() { }
    }
}
