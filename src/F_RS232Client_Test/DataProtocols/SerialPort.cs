using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace F_RS232Client_Test.DataProtocols
{
    [TestClass]
    public class SerialPort
    {
        [TestMethod]
        public void ShouldReturnMaybeEmptyArrayOfPortNames()
        {
            string[] ports = F_RS232Client.DataProtocols.SerialPort.AvailablePorts;

            Assert.AreNotEqual(null, ports);
        }

        [TestMethod]
        public void ShouldValidOpenAndClosePortIfExists()
        { 
            string[] ports = F_RS232Client.DataProtocols.SerialPort.AvailablePorts;
            
            if (ports.Length == 0)
                return;

            try
            {
                F_RS232Client.DataProtocols.SerialPort port = new F_RS232Client.DataProtocols.SerialPort(ports[0]);
                port.Open();
                Assert.IsTrue(port.IsOpen);
                port.Close();
                Assert.IsFalse(port.IsOpen);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldNotThrowExceptionOnOpenOpennedPort()
        {
            string[] ports = F_RS232Client.DataProtocols.SerialPort.AvailablePorts;

            if (ports.Length == 0)
                return;

            try
            {
                F_RS232Client.DataProtocols.SerialPort port = new F_RS232Client.DataProtocols.SerialPort(ports[0]);
                port.Open();
                Assert.IsTrue(port.IsOpen);
                port.Open();
                Assert.IsTrue(port.IsOpen);
                port.Close();
                Assert.IsFalse(port.IsOpen);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
