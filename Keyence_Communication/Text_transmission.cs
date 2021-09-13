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
    public partial class Text_transmission : Form
    {
        public Text_transmission()
        {
            InitializeComponent();
            sp_main.BaudRate = 9600;
            sp_main.DataBits = 8;
            sp_main.StopBits = StopBits.One;
            sp_main.Parity = Parity.Even;

            sp_main.DataReceived += Sp_main_DataReceived;
        }

        private void Sp_main_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            SerialPort sp_receive = (SerialPort)sender;
            string rcv = sp_receive.ReadExisting();
            rtxt_receive.Text += rcv;
        }

        SerialPort sp_main = new SerialPort();
        private void Text_transmission_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbo_port.Items.Add(port);
            }

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            sp_main.Open();
            if (sp_main.IsOpen)
            {
                btn_close.Enabled = true;
                btn_open.Enabled = false;
                MessageBox.Show("Đã mở kết nối thành công");
            }
            else
            {
                MessageBox.Show("Không thể kết nối");
            }
        }

        private void cbo_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp_main.PortName = cbo_port.Text;

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            sp_main.Write("\u0002" + txt_send.Text + "\u0003");
            MessageBox.Show("Gửi thành công");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            sp_main.Close(); 
            btn_close.Enabled = false;
            btn_open.Enabled = true;
            MessageBox.Show("Đã đóng kết nối thành công");

        }
    }
}
