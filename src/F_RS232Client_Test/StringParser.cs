using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace F_RS232Client_Test
{
    [TestClass]
    public class StringParser
    {
        [TestMethod]
        public void ExpectedEmptyStringOnNullInput()
        {
            Assert.AreEqual(string.Empty, new F_RS232Client.BytesToStrConverter(null).GetString());
        }

        [TestMethod]
        public void ExpectedEmptyStringOnEmptyInput()
        {
            Assert.AreEqual(string.Empty, new F_RS232Client.BytesToStrConverter(new byte[]{}).GetString());
        }

        [TestMethod]
        public void ExpectedValidConvertByteArray()
        {
            byte[] input = new byte[] {0, 2, 25, 30, 31, 32, 49, 68, 96, 125, 126, 127, 200, 230, 255 };
            string expected="\\x00\\x02\\x19\\x1E\\x1F 1D`}~\\x7F\\xC8\\xE6\\xFF";

            Assert.AreEqual(expected, new F_RS232Client.BytesToStrConverter(input).GetString());
        }
    }
}
