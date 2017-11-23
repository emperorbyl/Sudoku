using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTest
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void SolverConstructorTest()
        {
            Solver solver = new Solver("Puzze1.txt", "PuzzleSol1.txt");
            Assert.IsNotNull(solver);
        }
    }
}
