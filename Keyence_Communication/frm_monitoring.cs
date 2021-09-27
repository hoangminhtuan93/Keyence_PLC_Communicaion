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
    public partial class frm_monitoring : Form
    {
        public frm_monitoring()
        {
            InitializeComponent();
            sp_main.BaudRate = 9600;
            sp_main.DataBits = 8;
            sp_main.StopBits = StopBits.One;
            sp_main.Parity = Parity.Even;

            sp_main.DataReceived += Sp_main_DataReceived;
        }

        SerialPort sp_main = new SerialPort();
        string str_current_step = string.Empty;

        private void Sp_main_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            SerialPort sp_receive = (SerialPort)sender;
            string rcv = sp_receive.ReadExisting().Trim();
            bool check = true;

            if (str_current_step == "")
            {
                if (rcv == "A")
                {
                    btn_A.BackColor = Color.LightGreen;
                    check = true;
                    btn_B.BackColor = Color.LightGray;
                    btn_B.BackColor = Color.LightGray;
                }
                else
                {
                    btn_A.BackColor = Color.Red;
                    check = false;
                }
            }
            else if (str_current_step == "A")
            {
                if (rcv == "B")
                {
                    btn_B.BackColor = Color.LightGreen;
                    check = true;
                    btn_C.BackColor = Color.LightGray;
                    btn_A.BackColor = Color.LightGray;
                }
                else
                {
                    btn_B.BackColor = Color.Red;
                    check = false;
                }
            }
            else if (str_current_step == "B")
            {
                if (rcv == "C")
                {
                    btn_C.BackColor = Color.LightGreen;
                    check = true;
                    lbl_count.Text = (int.Parse(lbl_count.Text) + 1).ToString();
                    btn_B.BackColor = Color.LightGray;
                    btn_A.BackColor = Color.LightGray;
                }
                else
                {
                    btn_C.BackColor = Color.Red;
                    check = false;
                }
            }
            else if (str_current_step == "C")
            {
                if (rcv == "A")
                {
                    btn_A.BackColor = Color.LightGreen;
                    check = true;
                    btn_C.BackColor = Color.LightGray;
                    btn_B.BackColor = Color.LightGray;
                }
                else
                {
                    btn_A.BackColor = Color.Red;
                    check = false;
                }
            }

            if (check)
            {
                lbl_status.Text = "Đang hoạt động";
                lbl_status.ForeColor = Color.Green;
                str_current_step = rcv;
            }
            else
            {
                lbl_status.Text = "Bỏ công đoạn";
                lbl_status.ForeColor = Color.Red;
            }
           
        }

        private void frm_monitoring_Load(object sender, EventArgs e)
        {
            sp_main.PortName = "COM5";
            sp_main.Open();
            if (sp_main.IsOpen)
            {
                lbl_status.Text = "Đã kết nối với PLC";
                lbl_status.ForeColor = Color.DarkBlue;
            }
            else
            {
                lbl_status.Text = "Không thể kết nối với PLC";
                lbl_status.ForeColor = Color.Red;
            }
        }
    }
}
