using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_RS232Client.DataProtocols
{
    abstract class DataProtocol
    {
        public abstract void Open();
        public abstract bool IsOpen();
        public abstract void Close();
    }
}
