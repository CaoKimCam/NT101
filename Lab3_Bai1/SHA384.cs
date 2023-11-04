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
        Bai1 bai1 = new Bai1();
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
            string a=bai1.HextoString(text);
            return TextSHA384(a);

        }
        public void FileSHA3(string filename)
        {
            //Hàm băm cho file
            
        }
    }
}
