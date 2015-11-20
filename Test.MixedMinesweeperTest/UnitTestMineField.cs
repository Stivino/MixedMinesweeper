using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixedMinesweeper.Model;

namespace Kroktosoft.Test.MixedMinesweeperTest
{
    [TestClass]
    public class UnitTestMineField
    {
        [TestMethod]
        public void Should_Add_Random_Mines_And_Fields()
        {
            Dictionary<MinesColors, int> coloring = new Dictionary<MinesColors, int>();
            coloring.Add(MinesColors.Blue, 2);
            coloring.Add(MinesColors.Yellow, 1);
            MineField field = new MineField(3, 3, coloring);

            Assert.AreEqual(3, field.MinesCount);
            Assert.AreEqual(9, field.FieldsCount);
            Assert.AreEqual(coloring, field.MineColoring);
        }

        
    }
}
