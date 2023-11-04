using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace Lab3_Bai1
{
    internal class MD5
    {
        Bai1 bai1 = new Bai1();
        public string TextMD5(string text)
        {
            //Hàm băm cho Text
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            //Chuyển chuỗi thành kiểu byte và mã hoá chuỗi đã chuyển
            byte[] hash = md5provider.ComputeHash(Encoding.UTF8.GetBytes(text));
            //tạo đối tượng stringbuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));// chữ cái in hoa
            }
            return hashSb.ToString();
        }
        public string HexMD5 (string text)
        {
            //Hàm băm cho hex
            string a=bai1.HextoString(text);
            return TextMD5(a);
        }
        public void FileMD5(string filename)
        {
            //Hàm băm cho file

        }

    }
}
