using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyence_Communication
{
    public partial class Form1 : Form
    {
        SerialPort sp_main = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            sp_main.BaudRate = 9600;
            sp_main.DataBits = 8;
            sp_main.StopBits = StopBits.One;
            sp_main.Parity = Parity.Even;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arr_port_list = SerialPort.GetPortNames();
            cbo_port.Items.Add(string.Empty);
            foreach (string item in arr_port_list)
            {
                cbo_port.Items.Add(item);
            }

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            sp_main.PortName = cbo_port.Text;
            sp_main.Open();
            //byte[] command = { 0x43, 0x52, 0x0d };
            string command = "CR\r\n";
            sp_main.Write(command);
            rtb_result.Text += sp_main.ReadLine();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (!sp_main.IsOpen)
            {
                sp_main.PortName = cbo_port.Text; 
            }
            string command = "CQ\r\n";
            sp_main.Write(command);
            rtb_result.Text += sp_main.ReadLine();
        }
    }
}
