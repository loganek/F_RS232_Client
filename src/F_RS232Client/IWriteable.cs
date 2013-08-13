using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_RS232Client
{
    public interface IWriteable
    {
        void Write(byte[] bytes);
        void Write(byte b);
        void Write(string str);
    }
}
