using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace Lab3_Bai1
{
    internal class SHA384
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
        public string TextSHA384(string text)
        {
            //Hàm băm cho Text 
            SHA384Managed sha384 = new SHA384Managed();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes (text);
            byte[] hash = sha384.ComputeHash(inputBytes);
            StringBuilder hashsb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashsb.Append (b.ToString("X2"));
            }
            return hashsb.ToString();
        }
        public string HexSHA384(string text)
        {
            //Hàm băm cho hex
            string a=HextoString(text);
            return TextSHA384(a);

        }
        public void FileSHA384(string filename)
        {
            //Hàm băm cho file
            
        }
    }
}
