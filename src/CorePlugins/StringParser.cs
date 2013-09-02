using System;
using System.Collections.Generic;
using System.Text;

namespace F_RS232Client.Plugins.Core
{
    public class StrToBytesConverter
    {
        #region Consts and static members
        private const char PreSign = '\\';
        private static readonly Dictionary<char, byte> SpecialCharacters = new Dictionary<char, byte>
            {
            {'n', 10},
            {'r', 13},
            {'0', 19},
            {'\\', 92}
        };
        #endregion

        #region Members
        readonly string str;
        int currPos;
        byte[] bytes;
        #endregion

        public StrToBytesConverter(string str)
        {
            this.str = str ?? string.Empty;
        }

        public byte[] GetBytes()
        {
            if (bytes == null)
                Parse();

            return bytes;
        }

        #region Private methods
        private void Parse()
        {
            var convertedBytes = new List<byte>();

            for (currPos = 0; currPos < str.Length; currPos++)
            {
                convertedBytes.Add(
                    (str[currPos] == PreSign) ?
                    ParseSpecialCharacter() :
                    Convert.ToByte(str[currPos]));
            }

            bytes = convertedBytes.ToArray();
        }

        private byte ParseSpecialCharacter()
        {
            if (currPos + 1 == str.Length)
                throw new Exception("Cannot parse string");

            switch (str[currPos + 1])
            {
                case 'x':
                    return ConvertHex();
                case 'd':
                    return ConvertDecimal();
                default:
                    return ConvertSpecialCharacter();
            }
        }

        #endregion

        #region Mini conversions
        private byte ConvertHex()
        {
            if (currPos + 3 >= str.Length)
                throw new Exception("Cannot parse string");

            currPos += 3;
            return Convert.ToByte(str.Substring(currPos - 1, 2), 16);
        }

        private byte ConvertDecimal()
        {
            if (currPos + 4 >= str.Length)
                throw new Exception("Cannot parse string");

            currPos += 4;
            return Convert.ToByte(str.Substring(currPos - 2, 3));
        }

        public byte ConvertSpecialCharacter()
        {
            if (SpecialCharacters.ContainsKey(str[++currPos]))
                return SpecialCharacters[str[currPos]];

            throw new Exception("Cannot find special character: " + str[currPos]);
        }

        #endregion
    }

    public class BytesToStrConverter
    {
        #region Members
        private readonly byte[] bytes;
        private string str;
        int currPos;
        #endregion

        public BytesToStrConverter(byte[] bytes)
        {
            this.bytes = bytes;
        }

        public string GetString()
        {
            if (str == null)
                Parse();

            return str;
        }

        #region Private methods
        private void Parse()
        {
            if (bytes == null)
            {
                str = String.Empty;
                return;
            }

            var strb = new StringBuilder();

            for(currPos = 0; currPos < bytes.Length; currPos++)
            {
                if (IsVisible())
                    strb.Append(Convert.ToChar(bytes[currPos]));
                else
                    strb.Append(ToHex());
            }

            str = strb.ToString();
        }

        private bool IsVisible()
        {
            return bytes[currPos] >= 32 && bytes[currPos] <= 126;
        }

        private string ToHex()
        {
            return "\\x" + bytes[currPos].ToString("X2");
        }
        #endregion
    }
}
