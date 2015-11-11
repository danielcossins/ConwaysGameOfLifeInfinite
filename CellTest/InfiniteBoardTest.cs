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

        [TestMethod]
        public void InfiniteBoardGetNumberOfAliveNeighhbors()
        {
            InfiniteBoard world = new InfiniteBoard();

            world.AddCell(0, 0);
            world.AddCell(1, 0);
            world.AddCell(0, 1);
            world.AddCell(1, 1);
            int alive = world.getNumberOfAliveNeighbors(world.Cells[0].X, world.Cells[0].Y);
            Assert.AreEqual(3, alive);
        }

        [TestMethod]
        public void InfiniteBoardCellDoesExist()
        {
            InfiniteBoard world = new InfiniteBoard();
            world.AddCell(0, 0);
            Assert.IsTrue(world.CellDoesExist(0, 0));
        }

        [TestMethod]
        public void InfiniteBoardTestRemoveCell()
        {
            InfiniteBoard world = new InfiniteBoard();
            world.AddCell(0, 0);
            world.RemoveCell(0, 0);
            Assert.IsFalse(world.CellDoesExist(0, 0));
            Assert.AreEqual(0, world.CellCount());
        }

        [TestMethod]
        public void InfiniteBoardAliveRule()
        {
            InfiniteBoard world = new InfiniteBoard();

            world.AddCell(0, 0);
            world.AddCell(1, 0);
            world.AddCell(0, 1);
            world.AddCell(1, 1);
            world.AliveRule(0, 0);
            Assert.AreEqual(true, world.CellDoesExist(0, 0));
        }
    }
}
