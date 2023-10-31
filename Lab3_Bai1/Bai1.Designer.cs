namespace Lab3_Bai1
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Data = new TextBox();
            cb_DataFormat = new ComboBox();
            chb_MD5 = new CheckBox();
            label1 = new Label();
            cb_KeyFormat = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txt_Key = new TextBox();
            txt_SHA1 = new TextBox();
            chb_SHA1 = new CheckBox();
            chb_SHA3 = new CheckBox();
            txt_SHA3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txt_MD5 = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txt_Data
            // 
            txt_Data.Location = new Point(180, 30);
            txt_Data.Name = "txt_Data";
            txt_Data.Size = new Size(774, 27);
            txt_Data.TabIndex = 0;
            txt_Data.TextChanged += txt_Data_TextChanged;
            // 
            // cb_DataFormat
            // 
            cb_DataFormat.FormattingEnabled = true;
            cb_DataFormat.Items.AddRange(new object[] { "Text string", "Hex String", "File" });
            cb_DataFormat.Location = new Point(12, 29);
            cb_DataFormat.Name = "cb_DataFormat";
            cb_DataFormat.Size = new Size(145, 28);
            cb_DataFormat.TabIndex = 1;
            // 
            // chb_MD5
            // 
            chb_MD5.AutoSize = true;
            chb_MD5.Location = new Point(12, 135);
            chb_MD5.Name = "chb_MD5";
            chb_MD5.Size = new Size(63, 24);
            chb_MD5.TabIndex = 2;
            chb_MD5.Text = "MD5";
            chb_MD5.UseVisualStyleBackColor = true;
            chb_MD5.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Data Format:";
            // 
            // cb_KeyFormat
            // 
            cb_KeyFormat.FormattingEnabled = true;
            cb_KeyFormat.Items.AddRange(new object[] { "Text string", "Hex String", "File" });
            cb_KeyFormat.Location = new Point(180, 79);
            cb_KeyFormat.Name = "cb_KeyFormat";
            cb_KeyFormat.Size = new Size(89, 28);
            cb_KeyFormat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 60);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 5;
            label2.Text = "Data Format:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 10);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 6;
            label3.Text = "Data Format:";
            // 
            // txt_Key
            // 
            txt_Key.Location = new Point(297, 79);
            txt_Key.Name = "txt_Key";
            txt_Key.Size = new Size(657, 27);
            txt_Key.TabIndex = 7;
            txt_Key.TextChanged += txt_Key_TextChanged;
            // 
            // txt_SHA1
            // 
            txt_SHA1.Location = new Point(180, 175);
            txt_SHA1.Name = "txt_SHA1";
            txt_SHA1.Size = new Size(774, 27);
            txt_SHA1.TabIndex = 8;
            txt_SHA1.TextChanged += txt_SHA1_TextChanged;
            // 
            // chb_SHA1
            // 
            chb_SHA1.AutoSize = true;
            chb_SHA1.Location = new Point(12, 178);
            chb_SHA1.Name = "chb_SHA1";
            chb_SHA1.Size = new Size(68, 24);
            chb_SHA1.TabIndex = 9;
            chb_SHA1.Text = "SHA1";
            chb_SHA1.UseVisualStyleBackColor = true;
            // 
            // chb_SHA3
            // 
            chb_SHA3.AutoSize = true;
            chb_SHA3.Location = new Point(12, 222);
            chb_SHA3.Name = "chb_SHA3";
            chb_SHA3.Size = new Size(68, 24);
            chb_SHA3.TabIndex = 10;
            chb_SHA3.Text = "SHA3";
            chb_SHA3.UseVisualStyleBackColor = true;
            // 
            // txt_SHA3
            // 
            txt_SHA3.Location = new Point(180, 222);
            txt_SHA3.Name = "txt_SHA3";
            txt_SHA3.Size = new Size(774, 27);
            txt_SHA3.TabIndex = 11;
            txt_SHA3.TextChanged += txt_SHA3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(395, 455);
            button1.Name = "button1";
            button1.Size = new Size(119, 47);
            button1.TabIndex = 12;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(523, 455);
            button2.Name = "button2";
            button2.Size = new Size(119, 47);
            button2.TabIndex = 13;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            // 
            // txt_MD5
            // 
            txt_MD5.Location = new Point(180, 132);
            txt_MD5.Name = "txt_MD5";
            txt_MD5.Size = new Size(774, 27);
            txt_MD5.TabIndex = 14;
            txt_MD5.TextChanged += txt_MD5_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "HMAC";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 514);
            Controls.Add(checkBox1);
            Controls.Add(txt_MD5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_SHA3);
            Controls.Add(chb_SHA3);
            Controls.Add(chb_SHA1);
            Controls.Add(txt_SHA1);
            Controls.Add(txt_Key);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_KeyFormat);
            Controls.Add(label1);
            Controls.Add(chb_MD5);
            Controls.Add(cb_DataFormat);
            Controls.Add(txt_Data);
            Name = "Bai1";
            Text = "Form1";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Data;
        private ComboBox cb_DataFormat;
        private CheckBox chb_MD5;
        private Label label1;
        private ComboBox cb_KeyFormat;
        private Label label2;
        private Label label3;
        private TextBox txt_Key;
        private TextBox txt_SHA1;
        private CheckBox chb_SHA1;
        private CheckBox chb_SHA3;
        private TextBox txt_SHA3;
        private Button button1;
        private Button button2;
        private TextBox txt_MD5;
        private CheckBox checkBox1;
    }
}