using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SolveSquare
    {
        protected Square square = new Square('1');
        protected bool needsSymbol { get; set; }
        protected bool inRow { get; set; }
        protected bool inColumn { get; set; }
        protected bool inBlock { get; set; }
        protected char characater = '1';
        public void FindCharacter(Square sq)
        {
            square = sq;
            square.symbol = sq.symbol;
            square.column = sq.column;
            square.block = sq.block;
            square.row = sq.row;
            square.validSymbol = sq.validSymbol;
            needsSymbol = CheckSquare();
            inBlock = ValidateBlock();
            inRow = ValidateRow();
            inColumn = ValidateColumn();
            characater = SelectSymbol();
            InsertSymbol();
        }
        public bool CheckSquare()
        {
            
            if (square.symbol != '-')
                needsSymbol = false;
            else
                needsSymbol = true;
            return needsSymbol;
        }
        public bool ValidateRow()
        {
            if (square.row.content.Contains(characater))
                inRow = true;
            else
                inRow = false;
            return inRow;
        }
        public bool ValidateColumn()
        {
            if (square.column.content.Contains(characater))
                inColumn = true;
            else
                inColumn = false;
            return inColumn;
        }
        public bool ValidateBlock()
        {
            if (square.block.content.Contains(characater))
                inBlock = true;
            else
                inBlock = false;
            return inBlock;
        }
        public void InsertSymbol()
        {
            square.symbol = characater;
        }
        public virtual char SelectSymbol() { return characater; }
    }
}
