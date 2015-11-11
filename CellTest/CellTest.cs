﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace CellTest
{
    [TestClass]
    public class CellTest
    {
        //[TestMethod]
        //public void CellEnsureCellIsAlive()
        //{
        //    // Object Initializer Syntax
        //    // Use Public setters when creating new instance
        //    Cell my_cell = new Cell { IsAlive = true };
        //    Assert.IsTrue(my_cell.IsAlive);
        //}

        //[TestMethod]
        //public void CellEnsureCellIsDeadByDefault()
        //{
        //    Cell my_cell = new Cell();
        //    Assert.IsFalse(my_cell.IsAlive);
        //}

        [TestMethod]
        public void CellEnsureCellHasAPosition()
        {
            Cell cell = new Cell();
            Assert.AreEqual(0, cell.X);
            Assert.AreEqual(0, cell.Y);
        }

        [TestMethod]
        public void CellEnsureWeCanProvidePosition()
        {
            int x = 1;
            int y = 2;
            Cell cell = new Cell { X = x, Y = y };
            Assert.AreEqual(x, cell.X);
            Assert.AreEqual(y, cell.Y);
        }
    }
}