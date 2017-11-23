using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTest
{
    [TestClass]
    public class SolveSquareTest
    {
        [TestMethod]
        public void SolveSquareConstructorTest()
        {
            SolveSquare solSq = new SolveSquare();
            Assert.IsNotNull(solSq);
        }

        [TestMethod]
        public void SolveSquareBoolTests()
        {
            SolveSquare solSq = new SolveSquare();
            bool need = solSq.CheckSquare();
            bool col = solSq.ValidateColumn();
            bool row = solSq.ValidateRow();
            bool block = solSq.ValidateBlock();
            Assert.IsNotNull(solSq);
            Assert.IsFalse(need);
            Assert.IsFalse(col);
            Assert.IsFalse(row);
            Assert.IsFalse(block);
        }
    }
}
