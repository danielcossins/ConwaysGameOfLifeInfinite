using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace CellTest
{
    [TestClass]
    public class InfiniteBoardTest
    {
        [TestMethod]
        public void InfiniteBoardEnsureICanCreateInstance()
        {
            InfiniteBoard world = new InfiniteBoard();
            Assert.IsNotNull(world);
        }

        [TestMethod]
        public void InfiniteBoardEnsureTheWorldHasZeroCells()
        {
            InfiniteBoard world = new InfiniteBoard();
            int expectedNumberOfCells = 0;
            int actualNumberOfCells = world.CellCount();

            Assert.AreEqual(expectedNumberOfCells, actualNumberOfCells);
        }

        [TestMethod]
        public void InfiniteBoardEnsureThereAreCells()
        {
            InfiniteBoard world = new InfiniteBoard();

            int x = 4;
            int y = 3;
            world.AddCell(x, y);

            Assert.AreEqual(1, world.CellCount());
        }
    }
}
