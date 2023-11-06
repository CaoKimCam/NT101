using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab3_Bai1
{
    internal class SHA1
    {
        public string HextoString(string hexString)
        {
            hexString = hexString.Trim();
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
        }
        public string TextSHA1(string text)
        {
            //Hàm băm cho Text
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
        public string HexSHA1(string text)
        {
            //Hàm băm cho hex
            string a = HextoString(text);
            return TextSHA1(a);
        }
        public void FileSHA1(string filename)
        {
            //Hàm băm cho file
        }
    }
}
