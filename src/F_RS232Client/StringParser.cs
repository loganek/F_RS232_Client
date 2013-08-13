using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_RS232Client
{
    class StrToBytesConverter
    {
        #region Static members
        private static char preSign = '\\';
        private static Dictionary<char, byte> specialCharacters = new Dictionary<char, byte>(){
            {'n', 10},
            {'r', 13},
            {'0', 19},
            {'\\', 92}
        };
        #endregion

        #region Members
        string str;
        int currPos = 0;
        byte[] bytes = null;
        #endregion

        public StrToBytesConverter(string str)
        {
            this.str = str;
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
            List<byte> convertedBytes = new List<byte>();

            for (currPos = 0; currPos < str.Length; currPos++)
            {
                convertedBytes.Add(
                    (str[currPos] == preSign) ?
                    ParseSpecialCharacter() :
                    Convert.ToByte(str[currPos]));
            }

            bytes = convertedBytes.ToArray();
        }

        private byte ParseSpecialCharacter()
        {
            if (currPos + 1 == str.Length)
                throw new Exception("Cannot parse string");

            if (str[currPos + 1] == 'x')
                return ConvertHex();
            else if (str[currPos + 1] == 'd')
                return ConvertDecimal();
            else
                return ConvertSpecialCharacter();
        }
        #endregion

        #region Mini conversions
        private byte ConvertHex()
        {
            if (currPos + 3 == str.Length)
                throw new Exception("Cannot parse string");

            currPos += 3;
            return Convert.ToByte(str.Substring(currPos + 2, 2), 16);
        }

        private byte ConvertDecimal()
        {
            if (currPos + 4 == str.Length)
                throw new Exception("Cannot parse string");

            currPos += 4;
            return Convert.ToByte(str.Substring(currPos + 2, 3));
        }

        public byte ConvertSpecialCharacter()
        {
            if (specialCharacters.ContainsKey(str[++currPos]))
                return specialCharacters[str[currPos]];
            else
                throw new Exception("Cannot find special character: " + str[currPos]);
        }
        #endregion
    }

    class BytesToStrConverter
    {
        #region Members
        private byte[] bytes;
        private string? str;
        int currPos = 0;
        #endregion

        public BytesToStrConverter(byte[] bytes)
        {
            this.bytes = bytes;
        }

        public string GetString()
        {
            if (str == null)
                Parse();

            return str.GetValueOrDefault(String.Empty);
        }

        #region Private methods
        private void Parse()
        {
            if (bytes == null)
                str = String.Empty;

            StringBuilder strb = new StringBuilder();

            for(int i =0; i < currPos; i++)
            {
                if (IsVisible())
                    strb.Append(bytes[currPos]);
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
