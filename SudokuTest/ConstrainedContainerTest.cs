using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTest
{
    [TestClass]
    public class ConstrainedContainerTest
    {
        [TestMethod]
        public void ConstrainedContainerConstructor()
        {
            ConstrainedContainer container = new ConstrainedContainer();
            Assert.IsNotNull(container);
            Assert.IsNotNull(container.content);
        }
    }
}
