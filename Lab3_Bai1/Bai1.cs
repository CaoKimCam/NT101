using System.Text;

namespace Lab3_Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        MD5 md5 = new MD5();
        SHA1 sha1 = new SHA1();
        SHA384 sha384 = new SHA384();
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

        private void button1_Click(object sender, EventArgs e)
        {
            String a;
            if (chb_MD5.Checked == true)
            {
                if (cb_DataFormat.SelectedItem.ToString() == "Text string")
                {
                    a = txt_Data.Text.Trim();
                    txt_MD5.Text = md5.TextMD5(a);
                }
                if (cb_DataFormat.SelectedItem.ToString() == "Hex String")
                {
                    a = txt_Data.Text.Trim();
                    txt_MD5.Text = md5.HexMD5(a);
                }
            }
            if (chb_SHA384.Checked == true)
            {
                if (cb_DataFormat.SelectedItem.ToString() == "Text string")
                {
                    a = txt_Data.Text.Trim();
                    txt_SHA384.Text = sha384.TextSHA384(a);
                }
                if (cb_DataFormat.SelectedItem.ToString() == "Hex String")
                {
                    a = txt_Data.Text.Trim();
                    txt_SHA384.Text = sha384.HexSHA384(a);
                }
            }
            if (chb_SHA1.Checked == true)
            {
                if (cb_DataFormat.SelectedItem.ToString() == "Text string")
                {
                    a = txt_Data.Text.Trim();
                    txt_SHA1.Text = sha1.TextSHA1(a);
                }
                if (cb_DataFormat.SelectedItem.ToString() == "Hex String")
                {
                    a = txt_Data.Text.Trim();
                    txt_SHA1.Text = sha1.HexSHA1(a);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}