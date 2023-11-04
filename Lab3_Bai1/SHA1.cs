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
        Bai1 bai1 = new Bai1();
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
            string a = bai1.HextoString(text);
            return TextSHA1(a);
        }
        public void FileSHA1(string filename)
        {
            //Hàm băm cho file
        }
    }
}
