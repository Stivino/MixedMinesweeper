using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixedMinesweeper.Model;
using System.Collections.Generic;

namespace Test.MixedMinesweeperTest
{
    [TestClass]
    public class UnitTestField
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_On_XCoordinate()
        {
            new Field(-1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_On_YCoordinate()
        {
            new Field(0, -1);
        }

        [TestMethod]
        public void Should_Correctly_Resolve_Relationship_To_Neighbours()
        {
            Field f1 = new Field(0, 1);
            // Setting neighbours (2 fields, 2 red mines, 1 blue mine)
            List<Field> neighbours = new List<Field> { new Field(0, 0), new Field(0, 2), new Field(1, 0, MinesColors.Blue), new Field(1, 1, MinesColors.Red), new Field(1, 2, MinesColors.Red) };
            f1.NeighbouringFields = neighbours;

            Assert.IsFalse(f1.IsMine);
            Assert.AreEqual(f1.Color, MinesColors.NoColor);
            Assert.IsTrue(f1.NeighbouringMines == 3);
            Assert.IsTrue(f1.NeighbouringFields.Count == 5);
            Assert.IsTrue(f1.GetColoredMines(MinesColors.Red) == 2) ;
            Assert.IsTrue(f1.GetColoredMines(MinesColors.Blue) == 1);
        }
    }
}
