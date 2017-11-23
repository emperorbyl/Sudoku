using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareConstructorTest()
        {
            Square square = new Square('1');
            
            Assert.IsNotNull(square);
            Assert.IsNotNull(square.block);
            Assert.IsNotNull(square.row);
            Assert.IsNotNull(square.column);
            Assert.IsNotNull(square.validSymbol);
            Assert.AreEqual('1', square.symbol);
        }
    }
}
