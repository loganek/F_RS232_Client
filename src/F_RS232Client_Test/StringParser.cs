using System;
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
            var input = new byte[] {0, 2, 25, 30, 31, 32, 49, 68, 96, 125, 126, 127, 200, 230, 255 };
            const string expected = "\\x00\\x02\\x19\\x1E\\x1F 1D`}~\\x7F\\xC8\\xE6\\xFF";

            Assert.AreEqual(expected, new F_RS232Client.BytesToStrConverter(input).GetString());
        }

        [TestMethod]
        public void ExpectedEmptyByteArrayOnEmptyInput()
        {
            Assert.AreEqual(0, new F_RS232Client.StrToBytesConverter(string.Empty).GetBytes().Length);
        }

        [TestMethod]
        public void ExpectedEmptyByteArrayOnNullInput()
        {
            Assert.AreEqual(0, new F_RS232Client.StrToBytesConverter(null).GetBytes().Length);
        }

        [TestMethod]
        public void ExpectedValidConvertStringToByteArray()
        {
            const string input = @"This\nis\rSPARTA!\\and test other \0 special signs";
            var expected = new byte[] { 84, 104, 105, 115, 10, 105, 115, 13, 83, 
                80, 65, 82, 84, 65, 33, 92, 97, 110, 100, 32, 116, 101, 115, 116,
                32, 111, 116, 104, 101, 114, 32, 19, 32, 115, 112, 101, 99, 105, 
                97, 108, 32, 115, 105, 103, 110, 115};

            byte[] output = new F_RS232Client.StrToBytesConverter(input).GetBytes();

            Assert.AreEqual(expected.Length, output.Length);

            for (int i = 0; i < output.Length; i++)
                Assert.AreEqual(expected[i], output[i]);
        }

        [TestMethod]
        public void ShouldThrowExceptionBecauseOfWrongInputFormat()
        {
            const string input = @"This is invalid format\";

            try
            {
                new F_RS232Client.StrToBytesConverter(input).GetBytes();
                Assert.Fail();
            }
            catch (Exception)
            {
            }
        }

        [TestMethod]
        public void ShouldCorrectParseDifferentFormats()
        {
            const string input = @"A\x44B\d102\d123";
            var expected = new byte[] { 65, 0x44, 66, 102, 123 };

            byte[] output = new F_RS232Client.StrToBytesConverter(input).GetBytes();

            Assert.AreEqual(expected.Length, output.Length);

            for (int i = 0; i < output.Length; i++)
                Assert.AreEqual(expected[i], output[i]);
        }

        [TestMethod]
        public void ShouldThrowExceptionBecauseOfTooShortHex()
        {
            bool ok = false;
            try
            {
                new F_RS232Client.StrToBytesConverter(@"This is too short hex: \x1").GetBytes();
            }
            catch
            {
                ok = true;
            }
            finally
            {
                if (!ok)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldThrowExceptionBecauseOfTooShortDec()
        {
            bool ok = false;
            try
            {
                new F_RS232Client.StrToBytesConverter(@"This is too short dec: \d13").GetBytes();
            }
            catch
            {
                ok = true;
            }
            finally
            {
                if (!ok)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldThrowExceptionBecauseOfUnknowSpecialCharacter()
        {
            bool ok = false;
            try
            {
                new F_RS232Client.StrToBytesConverter(@"This is unknow character: \s").GetBytes();
            }
            catch
            {
                ok = true;
            }
            finally
            {
                if (!ok)
                    Assert.Fail();
            }
        }
    }
}
