using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_
{
    public partial class Form1 : Form
        
    {
        public SerialPort myport;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           


        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM6";
            myport.Open();
            myport.WriteLine("O");
            myport.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM6";
            myport.Open();
            myport.WriteLine("F");
            myport.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
