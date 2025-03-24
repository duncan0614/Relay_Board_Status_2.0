using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//指示詞
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace Relay_Board_Controller
{
    public partial class RS232_Setting : System.Windows.Forms.Form
    {

        bool Connect;

        public RS232_Setting()
        {
            InitializeComponent();

            string[] ports = System.IO.Ports.SerialPort.GetPortNames(); //判斷是否有連接阜

            if (ports.Length == 0)
            {
                MessageBox.Show("No port in computer！");

                return;
            }

            //if(Relay_Board_Menu.port.IsOpen)
            //{
            //    btn_Connect.Text = "Disconnect";

            //    Connect = false;
            //}
            //if (!Relay_Board_Menu.port.IsOpen)
            //{
            //    btn_Connect.Text = "Connect";

            //    Connect = true;
            //}

            cbo_Comport.Items.AddRange(ports);

            cbo_Comport.SelectedIndex = 0;

            btn_Connect.Enabled = true;

            //string[] Baud_Rate = new string[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400",

            //"56000", "57600", "115200"};
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Connect)
            //    {
            //        if (Relay_Board_Menu.port.IsOpen == true)
            //        {
            //            Relay_Board_Menu.port.Close();

            //            Relay_Board_Menu.port.Dispose();
            //        }
            //        //int BaudRate = Int32.Parse(cbo_Baud_Rate.Text);

            //        Relay_Board_Menu.port.PortName = cbo_Comport.Text;//連接埠號COM4

            //        Relay_Board_Menu.port.BaudRate = 115200;        //Baud Rate

            //        Relay_Board_Menu.port.DataBits = 8;//Data Bits

            //        Relay_Board_Menu.port.StopBits = System.IO.Ports.StopBits.One;//Stop Bits

            //        Relay_Board_Menu.port.Encoding = System.Text.Encoding.GetEncoding("utf-8");//此行非常重要，解決接收中文亂碼的問題

            //        if (Relay_Board_Menu.port.IsOpen == false)
            //        {
            //            Relay_Board_Menu.port.Open();

            //            //MessageBox.Show("Open Sucess");
            //        }
            //        Connect = false;

            //        btn_Connect.Text = "Disconnect";

            //        this.Close();
            //    }
            //    else if(!Connect)
            //    {
            //        Relay_Board_Menu.port.Close();

            //        Relay_Board_Menu.port.Dispose();

            //        Connect = true;

            //        btn_Connect.Text = "Connect";

            //        //MessageBox.Show("Port closed!");

            //        this.Close();
            //    }
                
                
            //}
            //catch
            //{
            //    Relay_Board_Menu.port = new System.IO.Ports.SerialPort();

            //    //將異常資訊傳遞給使用者。

            //    MessageBox.Show("Open failed!");

            //    return;
            //}
        }

    }
}
