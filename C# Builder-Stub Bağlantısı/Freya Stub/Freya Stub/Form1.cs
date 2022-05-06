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

namespace Freya_Stub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            StreamReader sr = new StreamReader(path);
            StreamReader sr2 = new StreamReader(path);


            string Read1IP = sr.ReadToEnd();
            string Read2Port = sr2.ReadToEnd();

            sr.Close();
            sr2.Close();

            Read1IP = Read1IP.Substring(Read1IP.IndexOf("StartIP:"), Read1IP.IndexOf(":EndIP") - Read1IP.IndexOf("StartIP:"));
            Read1IP = Read1IP.Replace("StartIP:", "");

            Read2Port = Read2Port.Substring(Read2Port.IndexOf("StartPort:"), Read2Port.IndexOf(":EndPort") - Read2Port.IndexOf("StartPort:"));
            Read2Port = Read2Port.Replace("StartPort:", "");

            label1.Text = Read1IP;
            label2.Text = Read2Port;

        }
    }
}
