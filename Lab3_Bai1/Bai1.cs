using System.Text;

namespace Lab3_Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        //Hàm xử lý input đầu vào 
        public string HextoString(string hexString)
        {
            hexString = hexString.Trim();
            var bytes = new byte [hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
        }
        public string StringfromFile(string filename)
        {
            return filename;
            string linte = "";
            System.IO.StreamReader streamReader = new System.IO.StreamReader(filename);
            while ((linte = streamReader.ReadLine()) != null)
            {
                


            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Data_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Key_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MD5_TextChanged(object sender, EventArgs e)
        {
            //chuỗi băm MD5
        }

        private void txt_SHA1_TextChanged(object sender, EventArgs e)
        {
            //chuỗi băm SHA1
        }

        private void txt_SHA3_TextChanged(object sender, EventArgs e)
        {
            //chuỗi băm SHA3
        }
    }
}