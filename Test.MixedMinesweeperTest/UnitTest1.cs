using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixedMinesweeper.Model;
using System.Collections.Generic;

namespace Test.MixedMinesweeperTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dictionary<FieldColors, int> coloring = new Dictionary<FieldColors, int>();
            coloring.Add(FieldColors.Black,4);
            MineField field = new MineField(3,3, coloring);
        }
    }
}
