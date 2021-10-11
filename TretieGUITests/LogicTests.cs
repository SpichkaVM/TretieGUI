using Microsoft.VisualStudio.TestTools.UnitTesting;
using TretieGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretieGUI.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CoupleTest1()
        {
            string str = "Green Heel";
            string outMessege = Logic.Couple(str);
            Assert.AreEqual("ee - количество одинаковых соседних букв: 2\nee - количество одинаковых соседних букв: 2\n", outMessege);
        }
        [TestMethod()]
        public void CoupleTest2()
        {
            string str = "     ";
            string outMessege = Logic.Couple(str);
            Assert.AreEqual(" - количество одинаковых соседних букв: 0\n", outMessege);
        }
        [TestMethod()]
        public void CoupleTest3()
        {
            string str = "";
            string outMessege = Logic.Couple(str);
            Assert.AreEqual("Пустая строка!", outMessege);
        }
        
    }
}