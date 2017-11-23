using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void BoardConstructorTest()
        {
            Board board = new Board(4);
            Assert.IsNotNull(board);
            Assert.AreEqual(4, board.size);
            Assert.IsNotNull(board.grid);
        }
    }
}
