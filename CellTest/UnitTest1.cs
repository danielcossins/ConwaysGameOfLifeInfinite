using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace CellTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanCreateInstanceOfCell()
        {
            Cell cell = new Cell(0, 0, true);
            Assert.IsNotNull(cell);
        }

        [TestMethod]
        public void CellsCanBeCreatedDead()
        {
            Cell cell = new Cell(0, 0, true);
            Assert.AreEqual(true, cell.Dead);
        }

        [TestMethod]
        public void CellsCanBeCreatedNotDead()
        {
            Cell cell = new Cell(0, 0, false);
            Assert.AreEqual(false, cell.Dead);
        }

        [TestMethod]
        public void TestUpLeft()
        {
            Cell cell = new Cell(0, 0, true);
            cell.UpLeft = cell;
            Cell expected = new Cell(-1, 1, true);
            Assert.AreEqual(expected.X, cell.UpLeft.X);
            Assert.AreEqual(expected.Y, cell.UpLeft.Y);
        }

        [TestMethod]
        public void TestUp()
        {
            Cell cell = new Cell(0, 0, true);
            cell.Up = cell;
            Cell expected = new Cell(0, 1, true);
            Assert.AreEqual(expected.X, cell.Up.X);
            Assert.AreEqual(expected.Y, cell.Up.Y);
        }

        [TestMethod]
        public void TestUpRight()
        {
            Cell cell = new Cell(0, 0, true);
            cell.UpRight = cell;
            Cell expected = new Cell(1, 1, true);
            Assert.AreEqual(expected.X, cell.UpRight.X);
            Assert.AreEqual(expected.Y, cell.UpRight.Y);
        }

        [TestMethod]
        public void TestLeft()
        {
            Cell cell = new Cell(0, 0, true);
            cell.Left = cell;
            Cell expected = new Cell(-1, 0, true);
            Assert.AreEqual(expected.X, cell.Left.X);
            Assert.AreEqual(expected.Y, cell.Left.Y);
        }

        [TestMethod]
        public void TestRight()
        {
            Cell cell = new Cell(0, 0, true);
            cell.Right = cell;
            Cell expected = new Cell(1, 0, true);
            Assert.AreEqual(expected.X, cell.Right.X);
            Assert.AreEqual(expected.Y, cell.Right.Y);
        }

        [TestMethod]
        public void TestDownLeft()
        {
            Cell cell = new Cell(0, 0, true);
            cell.DownLeft = cell;
            Cell expected = new Cell(-1, -1, true);
            Assert.AreEqual(expected.X, cell.DownLeft.X);
            Assert.AreEqual(expected.Y, cell.DownLeft.Y);
        }

        [TestMethod]
        public void TestDown()
        {
            Cell cell = new Cell(0, 0, true);
            cell.Down = cell;
            Cell expected = new Cell(0, -1, true);
            Assert.AreEqual(expected.X, cell.Down.X);
            Assert.AreEqual(expected.Y, cell.Down.Y);
        }

        [TestMethod]
        public void TestDownRight()
        {
            Cell cell = new Cell(0, 0, true);
            //Cell storage = new Cell(0, 0, true);
            cell.DownRight = cell;
            Cell expected = new Cell(1, -1, true);
            Assert.AreEqual(expected.X, cell.DownRight.X);
            Assert.AreEqual(expected.Y, cell.DownRight.Y);
        }

        [TestMethod]
        public void TestSetUp()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setUp();
            Cell expected = new Cell(0, 1, true);
            Assert.AreEqual(expected.X, cell.Up.X);
            Assert.AreEqual(expected.Y, cell.Up.Y);
            Assert.AreEqual(cell.X, cell.Up.Down.X);
            Assert.AreEqual(cell.Y, cell.Up.Down.Y);

            Assert.AreEqual(cell.UpLeft.X, cell.Up.Left.X);
            Assert.AreEqual(cell.UpLeft.Y, cell.Up.Left.Y);
        }

        [TestMethod]
        public void TestSetUpLeft()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setUpLeft();
            Cell expected = new Cell(-1, 1, true);
            Assert.AreEqual(expected.X, cell.UpLeft.X);
            Assert.AreEqual(expected.Y, cell.UpLeft.Y);

            //Cell newCell = cell.UpLeft;
            Assert.AreEqual(cell.UpLeft.DownRight.X, cell.X);
            Assert.AreEqual(cell.UpLeft.DownRight.Y, cell.Y);
        }

        [TestMethod]
        public void TestSetUpRight()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setUpRight();
            Cell expected = new Cell(1, 1, true);
            Assert.AreEqual(expected.X, cell.UpRight.X);
            Assert.AreEqual(expected.Y, cell.UpRight.Y);
            Assert.AreEqual(cell.X, cell.UpRight.DownLeft.X);
            Assert.AreEqual(cell.Y, cell.UpRight.DownLeft.Y);
        }
        [TestMethod]
        public void TestSetLeft()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setLeft();
            Cell expected = new Cell(-1, 0, true);
            Assert.AreEqual(expected.X, cell.Left.X);
            Assert.AreEqual(expected.Y, cell.Left.Y);
            Assert.AreEqual(cell.X, cell.Left.Right.X);
            Assert.AreEqual(cell.Y, cell.Left.Right.Y);
        }
        [TestMethod]
        public void TestSetRight()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setRight();
            Cell expected = new Cell(1, 0, true);
            Assert.AreEqual(expected.X, cell.Right.X);
            Assert.AreEqual(expected.Y, cell.Right.Y);
            Assert.AreEqual(cell.X, cell.Right.Left.X);
            Assert.AreEqual(cell.Y, cell.Right.Left.Y);
        }
        [TestMethod]
        public void TestSetDown()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setDown();
            Cell expected = new Cell(0, -1, true);
            Assert.AreEqual(expected.X, cell.Down.X);
            Assert.AreEqual(expected.Y, cell.Down.Y);
            Assert.AreEqual(cell.X, cell.Down.Up.X);
            Assert.AreEqual(cell.Y, cell.Down.Up.Y);
        }
        [TestMethod]
        public void TestSetDownLeft()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setDownLeft();
            Cell expected = new Cell(-1, -1, true);
            Assert.AreEqual(expected.X, cell.DownLeft.X);
            Assert.AreEqual(expected.Y, cell.DownLeft.Y);
            Assert.AreEqual(cell.X, cell.DownLeft.UpRight.X);
            Assert.AreEqual(cell.Y, cell.DownLeft.UpRight.Y);
        }
        [TestMethod]
        public void TestSetDownRight()
        {
            Cell cell = new Cell(0, 0, true);
            cell.setDownRight();
            Cell expected = new Cell(1, -1, true);
            Assert.AreEqual(expected.X, cell.DownRight.X);
            Assert.AreEqual(expected.Y, cell.DownRight.Y);
            Assert.AreEqual(cell.X, cell.DownRight.UpLeft.X);
            Assert.AreEqual(cell.Y, cell.DownRight.UpLeft.Y);
        }

        //[TestMethod]
        //public void TestSetNeighbors()
        //{
        //    Cell cell = new Cell(0, 0, true);
        //    cell.setNeighbors();
        //    Cell expected = new Cell(-1, 1, true);
        //    Assert.AreEqual(expected.X, cell.UpLeft.X);
        //    Assert.AreEqual(expected.Y, cell.UpLeft.Y);
        //    Cell expected2 = new Cell(0, 1, true);
        //    Assert.AreEqual(expected2.X, cell.Up.X);
        //    Assert.AreEqual(expected2.Y, cell.Up.Y);
        //    Cell expected3 = new Cell(1, 1, true);
        //    Assert.AreEqual(expected3.X, cell.UpRight.X);
        //    Assert.AreEqual(expected3.Y, cell.UpRight.Y);
        //    Cell expected4 = new Cell(-1, 0, true);
        //    Assert.AreEqual(expected4.X, cell.Left.X);
        //    Assert.AreEqual(expected4.Y, cell.Left.Y);
        //    Cell expected5 = new Cell(1, 0, true);
        //    Assert.AreEqual(expected5.X, cell.Right.X);
        //    Assert.AreEqual(expected5.Y, cell.Right.Y);
        //    Cell expected6 = new Cell(-1, -1, true);
        //    Assert.AreEqual(expected6.X, cell.DownLeft.X);
        //    Assert.AreEqual(expected6.Y, cell.DownLeft.Y);
        //    Cell expected7 = new Cell(0, -1, true);
        //    Assert.AreEqual(expected7.X, cell.Down.X);
        //    Assert.AreEqual(expected7.Y, cell.Down.Y);
        //    Cell expected8 = new Cell(1, -1, true);
        //    Assert.AreEqual(expected8.X, cell.DownRight.X);
        //    Assert.AreEqual(expected8.Y, cell.DownRight.Y);
        //}
    }
}
