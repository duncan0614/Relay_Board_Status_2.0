using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;


//指示詞
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Management;

namespace Relay_Board_Controller
{

    public partial class Relay_Board_MEGA : System.Windows.Forms.Form
    {
        public static SerialPort port = new SerialPort();
        private readonly RelayItems Ri = new RelayItems();
        private bool initialization = false;
        private bool Connect = true;
        private bool bSwitchForm;
        private bool bCycleRun;
        private bool bHint;
        private string strState;

        private Thread invokeThread;
        private DialogResult result;

        public Relay_Board_MEGA()
        {
            InitializeComponent();

            bHint = Properties.Settings.Default.Hint;
            if (!bHint) {
                Inputbox.Inputbox_item = 4;
                Inputbox inputbox = new Inputbox();
                inputbox.ShowDialog();
            }

            strip_label_version.Text = "Ver " + Version.ToString();

            Button_EnabledORDisabled(false);

            List<ComPort> ports = GetAllPorts(); ; //判斷是否有連接阜
            Btn_Connect.Enabled = true;

            if (Cbo_Comport.Items.Count == 0) {
                Cbo_Comport.Items.Add("NONE");
                Cbo_Comport.SelectedIndex = 0;
                Cbo_Comport.Focus();
                Btn_Connect.Enabled = false;
                return;
            }
        }

        private void Relay_Board_MEGA_Load(object sender, EventArgs e)
        {
            //以防port早已打開先初始關閉
            if (port.IsOpen == true) {
                try {
                    port.Close();
                    port.Dispose();
                    Ri.dict.Clear();
                    Lstbox_batch.Items.Clear();
                }
                catch (Exception) {
                    MessageBox.Show("Your port already opened and failed to close.", "Warning!");
                }
            }
        }
        public void Relay_Board_Menu_Closing(object sender, EventArgs e)
        {
            try {
                if (port != null && port.IsOpen) {
                    port.Close();
                    port.Dispose();
                }
                if (bSwitchForm)
                    frmStation.strStation = "Arduino_UNO";
                else
                    frmStation.strStation = "Closing";
            }
            catch (Exception) {
                //將異常資訊傳遞給使用者。
                MessageBox.Show("Failed.", "Warning!");
                return;
            }
        }
        private void strip_menuitem_Open_Click(object sender, EventArgs e) //Open File
        {
            //開啟批次執行Relay的檔案
            try {
                Ri.dialog.Multiselect = true;      //該值確定是否可以選擇多個檔案

                Ri.dialog.Title = "Open File";

                Ri.dialog.Filter = "Json files (*.json)|*.json";
                invokeThread = new Thread(new ThreadStart(InvokeMethod));
                invokeThread.SetApartmentState(ApartmentState.STA);
                invokeThread.Start();
                invokeThread.Join();
                string Json_content = null;

                Ri.dict.Clear();
                Lstbox_batch.Items.Clear();

                //讀取JSON檔並拆解字串放進字典裡，檔名加入Listbox
                if (result == DialogResult.OK) {
                    using (StreamReader sw = new StreamReader(Ri.dialog.FileName)) {
                        Json_content = sw.ReadToEnd();
                    }
                    string[] Spilt1 = Json_content.Split(';');
                    for (int i = 0; i < Spilt1.Length; i++) {
                        if (i % 2 != 0) {
                            string key = Spilt1[i];
                            Ri.dict.Add(key, Spilt1[i + 1]);
                            Lstbox_batch.Items.Add(key);
                        }
                    }

                    //修正介面顯示檔名最大長度
                    string Getfilename = Path.GetFileName(Ri.dialog.FileName);
                    if (Getfilename.Length > 20) {
                        Getfilename = Getfilename.Substring(0, 17);
                        btn_batch.Text = Getfilename + "...";
                    }
                    else {
                        btn_batch.Text = Getfilename;
                    }

                }
            }
            catch (Exception) {
                MessageBox.Show("This file already opened.", "Warning!");
            }

        }
        //Switch Relay
        private void Strip_MenuItem_ArduinoUNO_Click(object sender, EventArgs e)
        {
            try {
                if (port != null && port.IsOpen) {
                    port.Close();
                    port.Dispose();
                }
                bSwitchForm = true;
                Close();
            }
            catch (Exception) {
                //將異常資訊傳遞給使用者。
                MessageBox.Show("Failed.", "Warning!");
                return;
            }
        }
        private void InvokeMethod()
        {
            result = Ri.dialog.ShowDialog();
        }
        private void btn_start_Click(object sender, EventArgs e)  //批次啟動
        {
            try {
                if (port.IsOpen == false) {
                    MessageBox.Show("The port isn't open.", "Warning!");
                    return;
                }
                if (Lstbox_batch.Items.Count < 1) {
                    MessageBox.Show("Batch file is empty!", "Warning!");
                    return;
                }
                Button[] buttons_All = { btn_D2, btn_D3, btn_D4, btn_D5, btn_D6, btn_D7, btn_D8, btn_D9, btn_D10, btn_D11, btn_D12, btn_D13, btn_D14, btn_D15, btn_D16,btn_D17, btn_D18,
                                         btn_D19, btn_D20, btn_D21, btn_D22, btn_AnaAlloff, btn_DigAlloff, btn_AnaAllon, btn_DigAllon, btn_Allon, Btn_Alloff, btn_RD_allon, Btn_RD_Alloff,
                                         btn_State, btn_start, btn_CycleRun, btn_batch};
                foreach (var item in buttons_All) {
                    item.Enabled = false;
                }
                Relay_Batch_Process(buttons_All);
                foreach (var item in buttons_All) {
                    item.Enabled = true;
                }
                //檢查analog, digital All on All off按鈕是否需要變更
                DigtalBtn_AllOnOROff_Controll();
                Dig_Group_Controll();
                Ana_Group_Controll();
                //Button_DisableOrEnable();
            }
            catch (Exception) {
                MessageBox.Show("The port isn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void btn_CycleRun_Click(object sender, EventArgs e)
        {
            try {
                if (port.IsOpen == false) {
                    MessageBox.Show("The port isn't open.", "Warning!");
                    strip_label_comport.Text = "Disconnected";
                    strip_label_comport.BackColor = Color.Red;
                    return;
                }
                if (Lstbox_batch.Items.Count < 1) {
                    MessageBox.Show("Batch file is empty!", "Warning!");
                    return;
                }
                frmCycleRun cycleRun = new frmCycleRun();
                cycleRun.ShowDialog();
                if (frmCycleRun.Cycletimes == 0)
                    return;
                bCycleRun = true;
                strip_lable_response.Text = "Cycle Run測試中，請稍後。";
                Button[] buttons_All = { btn_D2, btn_D3, btn_D4, btn_D5, btn_D6, btn_D7, btn_D8, btn_D9, btn_D10, btn_D11, btn_D12, btn_D13, btn_D14, btn_D15, btn_D16,btn_D17, btn_D18,
                                         btn_D19, btn_D20, btn_D21, btn_D22, btn_AnaAlloff, btn_DigAlloff, btn_AnaAllon, btn_DigAllon, btn_Allon, Btn_Alloff, btn_RD_allon, Btn_RD_Alloff,
                                         btn_State, btn_start, btn_CycleRun, btn_batch};
                foreach (var item in buttons_All) {
                    item.Enabled = false;
                }
                for (int i = 0; i < frmCycleRun.Cycletimes; i++)
                    Relay_Batch_Process(buttons_All);
                foreach (var item in buttons_All) {
                    item.Enabled = true;
                }
                //檢查analog, digital All on All off按鈕是否需要變更
                DigtalBtn_AllOnOROff_Controll();
                Dig_Group_Controll();
                Ana_Group_Controll();
                //Button_DisableOrEnable();
                bCycleRun = false;
                strip_lable_response.Text = "";
            }
            catch (Exception) {
                MessageBox.Show("The port isn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }           
        }

        #region --button D_Group click--

        private void btn_D2_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D2, "D2");
        }


        private void btn_D3_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D3, "D3");
        }

        private void btn_D4_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D4, "D4");
        }

        private void btn_D5_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D5, "D5");
        }

        private void btn_D6_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D6, "D6");
        }

        private void btn_D7_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D7, "D7");
        }

        private void btn_D8_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D8, "D8");
        }

        private void btn_D9_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D9, "D9");
        }

        private void btn_D10_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D10, "D10");
        }

        private void btn_D11_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D11, "D11");
        }
        private void btn_D12_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D12, "D12");
        }
        private void btn_D13_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D13, "D13");
        }

        private void btn_D14_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D14, "D14");
        }

        private void btn_D15_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D15, "D15");
        }

        private void btn_D16_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D16, "D16");
        }

        private void btn_D17_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D17, "D17");
        }

        private void btn_D18_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D18, "D18");
        }

        private void btn_D19_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D19, "D19");
        }

        private void btn_D20_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D20, "D20");
        }

        private void btn_D21_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D21, "D21");
        }

        private void btn_D22_Click(object sender, EventArgs e)
        {
            Relay_Controll(btn_D22, "D22");
        }

        private void Relay_Controll(Button button, string strRelay)
        {
            try {
                if (button.Text == "OFF") {
                    button.BackColor = Color.Green;
                    button.Text = "ON";
                    Buffer_process(strRelay + "=1\r\n");
                    if (button != btn_AnaControll || button != btn_DigControll)
                        DigtalBtn_AllOnOROff_Controll();
                    return;
                }
                else if (button.Text == "ON") {
                    button.BackColor = Color.Red;
                    button.Text = "OFF";
                    Buffer_process(strRelay + "=0\r\n");
                    if (button != btn_AnaControll || button != btn_DigControll)
                        DigtalBtn_AllOnOROff_Controll();
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }
        #endregion

        #region --button all click--

        private void btn_RD_allon_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                DigitalLayout_Controll("1");
                //改變介面Layout 顯示與控制
                DigitalBtn_Layout_Controll("ON", Color.Green);
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");
                btn_RD_allon.Enabled = false;
                btn_RD_allon.BackColor = Color.WhiteSmoke;
                Btn_RD_Alloff.Enabled = true;
                Btn_RD_Alloff.BackColor = Color.Red;
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void Btn_RD_Alloff_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                DigitalLayout_Controll("0");
                //改變介面Layout 顯示與控制
                DigitalBtn_Layout_Controll("OFF", Color.Red);
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");
                Btn_RD_Alloff.Enabled = false;
                Btn_RD_Alloff.BackColor = Color.WhiteSmoke;
                btn_RD_allon.Enabled = true;
                btn_RD_allon.BackColor = Color.Green;
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void btn_allon_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                Buffer_process("ALL=1\r\n");
                //改變介面Layout 顯示與控制
                DigitalBtn_Layout_Controll("ON", Color.Green);
                //檢查Digtal All on All off按鈕是否需要變更
                DigtalBtn_AllOnOROff_Controll();
                btn_AnaControll.Text = "ON";
                btn_AnaControll.BackColor = Color.Green;
                btn_DigControll.Text = "ON";
                btn_DigControll.BackColor = Color.Green;
                Dig_Group_Controll();
                Ana_Group_Controll();
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void Btn_Alloff_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                Buffer_process("ALL=0\r\n");
                //改變介面Layout 顯示與控制
                DigitalBtn_Layout_Controll("OFF", Color.Red);
                //檢查analog, digital All on All off按鈕是否需要變更
                DigtalBtn_AllOnOROff_Controll();
                btn_AnaControll.Text = "OFF";
                btn_AnaControll.BackColor = Color.Red;
                btn_DigControll.Text = "OFF";
                btn_DigControll.BackColor = Color.Red;
                Dig_Group_Controll();
                Ana_Group_Controll();              
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        //Digital 指令
        private void DigitalLayout_Controll(string strSwitch)
        {
            int Relay_Count = 23;
            int First_Relay = 2;
            for (int i = First_Relay; i < Relay_Count; i++) {
                Buffer_process("D" + i.ToString() + "=" + strSwitch + "\r\n");
            }
        }
        //Analog 指令
        private void AllAnalog_Controll(string strSwitch)
        {
            int Relay_Count = 16;
            int First_Relay = 0;
            for (int i = First_Relay; i < Relay_Count; i++) {
                Buffer_process("A" + i.ToString() + "=" + strSwitch + "\r\n");
                if (cbo_Analog.SelectedItem != null) {
                    if (cbo_Analog.SelectedItem.ToString().Contains(i.ToString())) {
                        if (strSwitch.Equals("1")) {
                            btn_AnaControll.Text = "ON";
                            btn_AnaControll.BackColor = Color.Green;
                        }
                        else {
                            btn_AnaControll.Text = "OFF";
                            btn_AnaControll.BackColor = Color.Red;
                        }
                    }
                }             
            }
        }

        private void DigitalGroup_Controll(string strSwitch)
        {
            int Relay_Count = 54;
            int First_Relay = 23;
            for (int i = First_Relay; i < Relay_Count; i++) {
                Buffer_process("D" + i.ToString() + "=" + strSwitch + "\r\n");
                if (cbo_Digital.SelectedItem != null) {
                    if (cbo_Digital.SelectedItem.ToString().Contains(i.ToString())) {
                        if (strSwitch.Equals("1")) {
                            btn_DigControll.Text = "ON";
                            btn_DigControll.BackColor = Color.Green;
                        }
                        else {
                            btn_DigControll.Text = "OFF";
                            btn_DigControll.BackColor = Color.Red;
                        }
                    }
                }                
            }
        }     
        #endregion

        #region --comport edit event click--
        private void Cbo_Comport_Click(object sender, EventArgs e)
        {
            if (Cbo_Comport.Items.Count == 0) {
                string[] ports = System.IO.Ports.SerialPort.GetPortNames(); //判斷是否有連接阜
                if (ports.Length == 0) {
                    return;
                }
                Cbo_Comport.Items.AddRange(ports);
                Cbo_Comport.SelectedIndex = 0;
                Cbo_Comport.Focus();
            }
        }
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try {
                if (Connect) {
                    if (port.IsOpen == true) {
                        port.Close();
                        port.Dispose();
                    }
                    string strCOM = "";
                    Match match1 = Regex.Match(Cbo_Comport.Text, "COM[0-9]+");
                    Match match2 = Regex.Match(frmInputBox.strCOMPort_name, "COM[0-9]+");

                    if (match1.Success) {
                        strCOM = match1.Value;
                    }
                    else if (match2.Success) {
                        strCOM = match2.Value;
                        frmInputBox.strCOMPort_name = string.Empty;
                    }
                    else {
                        MessageBox.Show("Invalid COM Port name.");
                        return;
                    }                      

                    port.PortName = strCOM;//連接埠號COM4
                    port.BaudRate = 115200;        //Baud Rate
                    port.DataBits = 8;//Data Bits
                    port.StopBits = System.IO.Ports.StopBits.One;//Stop Bits
                    port.Encoding = System.Text.Encoding.GetEncoding("utf-8");//此行非常重要，解決接收中文亂碼的問題
                    port.Open();

                    Connect = false;
                    initialization = true;
                    Btn_Connect.Text = "DISCONNECT";
                    btnRescan.Enabled = false;
                    btn_Customize.Enabled = false;
                    strip_label_comport.Text = "Connect";
                    strip_label_comport.BackColor = Color.Green;
                    //btn_RD_allon.BackColor = Color.Green;
                    //btn_DigAllon.BackColor = Color.Green;
                    //btn_AnaAllon.BackColor = Color.Green;
                    //btn_DigAlloff.BackColor = Color.Red;
                    //btn_DigAlloff.BackColor = Color.Red;
                    //btn_AnaAlloff.BackColor = Color.Red;

                    Button_EnabledORDisabled(true);                   
                    Buffer_process("STATE\r\n");
                    DigtalBtn_AllOnOROff_Controll();
                    Ana_Group_Controll();
                    Dig_Group_Controll();
                    //Button_DisableOrEnable();
                }
                else if (!Connect) {
                    port.Close();
                    port.Dispose();

                    Connect = true;
                    Btn_Connect.Text = "CONNECT";
                    btnRescan.Enabled = true;
                    btn_Customize.Enabled = true;
                    strip_label_comport.Text = "Disconnect";
                    strip_label_comport.BackColor = Color.Red;

                    Button_EnabledORDisabled(false);
                    //WhenPortDisconnected();
                    //MessageBox.Show("Port closed!");
                }
            }
            catch (Exception ex) {
                port.Close();
                port.Dispose();

                Connect = true;
                Btn_Connect.Text = "CONNECT";
                strip_label_comport.Text = "Disconnect";
                strip_label_comport.BackColor = Color.Red;
                strip_lable_response.Text = "Connect wrong port!";

                Button_EnabledORDisabled(false);

                //將異常資訊傳遞給使用者。
                MessageBox.Show("Connect failed" + ex);            
                return;
            }
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            Cbo_Comport.Items.Clear();
            Btn_Connect.Enabled = true;

            List<ComPort> ports = GetAllPorts(); ; //判斷是否有連接阜
            if (Cbo_Comport.Items.Count == 0) {
                Cbo_Comport.Items.Add("NONE");
                Cbo_Comport.SelectedIndex = 0;
                Cbo_Comport.Focus();
                Btn_Connect.Enabled = false;
                return;
            }
        }

        private void btn_Customize_Click(object sender, EventArgs e)
        {
            frmInputBox inputBox = new frmInputBox();
            inputBox.ShowDialog();

            if (frmInputBox.bCheck_Cancel) {              
                return;
            }
            else if (string.IsNullOrEmpty(frmInputBox.strCOMPort_name)) {
                MessageBox.Show("Invalid COM Port name.");
                return;
            }

            Btn_Connect_Click(sender, e);
        }

        private void strip_label_comport_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Form f2 = new RS232_Setting();
            //this.Hide();
            //f2.ShowDialog();

            //try
            //{
            //    if (Connect)
            //    {
            //        if (port.IsOpen == true)
            //        {
            //            port.Close();
            //            port.Dispose();
            //        }
            //        port.PortName = Cbo_Comport.Text;//連接埠號COM4
            //        port.BaudRate = 115200;        //Baud Rate
            //        port.DataBits = 8;//Data Bits
            //        port.StopBits = System.IO.Ports.StopBits.One;//Stop Bits
            //        port.Encoding = System.Text.Encoding.GetEncoding("utf-8");//此行非常重要，解決接收中文亂碼的問題
            //        if (port.IsOpen == false)
            //        {
            //            port.Open();

            //            //MessageBox.Show("Open Sucess");
            //        }
            //        Connect = false;
            //        Btn_Connect.Text = "DISCONNECT";
            //        strip_label_comport.Text = "Connect";
            //        strip_label_comport.BackColor = Color.Green;
            //        Button_Enabled();
            //        buffer_process("STATE\r\n");
            //        Button_DisableOrEnable();
            //    }
            //    else if (!Connect)
            //    {
            //        port.Close();
            //        port.Dispose();
            //        Connect = true;
            //        Btn_Connect.Text = "CONNECT";
            //        strip_label_comport.Text = "Disconnect";
            //        strip_label_comport.BackColor = Color.Red;
            //        Button_Disabled();
            //        WhenPortDisconnected();
            //        //MessageBox.Show("Port closed!");
            //    }
            //}
            //catch
            //{
            //    Relay_Board_MEGA.port = new System.IO.Ports.SerialPort();
            //    //將異常資訊傳遞給使用者。
            //    MessageBox.Show("Open failed!");
            //    return;
            //}          
        }
        #endregion

        #region --batch edit event click--
        private void strip_menuitem_batchEdit_Click(object sender, EventArgs e)
        {
            Ri.Listbox_items.Clear();
            foreach (var item in Lstbox_batch.Items) {
                Ri.Listbox_items.Add(item);
            }
            System.Windows.Forms.Form f3 = new Batch_Edit(Ri);
            f3.ShowDialog();

            Lstbox_batch.Items.Clear();
            foreach (var item in Ri.Listbox_items) {
                Lstbox_batch.Items.Add(item);
            }

            string Getfilename = Path.GetFileName(Ri.dialog.FileName);
            if (Getfilename.Length > 20) {
                Getfilename = Getfilename.Substring(0, 17);
                btn_batch.Text = Getfilename + "...";
            }
            else if (Getfilename == "") {
                btn_batch.Text = "NO FILE";
            }
            else if (Getfilename.Length <= 20) {
                btn_batch.Text = Getfilename;
            }
        }
        private void btn_batch_Click(object sender, EventArgs e)
        {
            Ri.Listbox_items.Clear();
            foreach (var item in Lstbox_batch.Items) {
                Ri.Listbox_items.Add(item);
            }
            //System.Windows.Forms.Form f3 = new Batch_Edit(this);
            System.Windows.Forms.Form f3 = new Batch_Edit(Ri);
            f3.ShowDialog();

            Lstbox_batch.Items.Clear();
            foreach (var item in Ri.Listbox_items) {
                Lstbox_batch.Items.Add(item);
            }

            string Getfilename = Path.GetFileName(Ri.dialog.FileName);
            if (Getfilename.Length > 20) {
                Getfilename = Getfilename.Substring(0, 17);
                btn_batch.Text = Getfilename + "...";
            }
            else if (Getfilename == "") {
                btn_batch.Text = "NO FILE";
            }
            else if (Getfilename.Length <= 20) {
                btn_batch.Text = Getfilename;
            }
        }
        #endregion

        #region --groupbox backcolor clear--
        //groupbox去邊框
        private void gpb_RA_Button_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
        }

        private void gpb_RD_Button1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
        }

        private void gpb_RD_Button2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
        }

        #endregion       

        #region --mouse right key event--
        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ri.dict.Remove(Lstbox_batch.SelectedItem.ToString());
            this.Lstbox_batch.Items.Remove(Lstbox_batch.SelectedItem);
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lstbox_batch.SelectedIndex > -1) {
                string json = Ri.dict[Lstbox_batch.SelectedItem.ToString()];
                Inputbox.Inputbox_item = 1;
                Inputbox.Batch_name = Lstbox_batch.SelectedItem.ToString();
                System.Windows.Forms.Form f4 = new Inputbox();
                f4.ShowDialog();

                //string Rename_batch = Interaction.InputBox("Batch Name", "Rename", "", -1, -1);

                //if (Inputbox.Input_content.Length > 11)
                //{
                //    MessageBox.Show("Batch name cannot surpass more than ten words!");
                //    return;
                //}
                if (Inputbox.Cancelornot == false) {
                    return;
                }
                if (string.IsNullOrEmpty(Inputbox.Input_content)) {
                    MessageBox.Show("Batch name cannot be empty.", "Warning!");
                    return;
                }
                else {
                    Ri.dict.Remove(Lstbox_batch.SelectedItem.ToString());
                    Lstbox_batch.Items[Lstbox_batch.SelectedIndex] = Inputbox.Input_content;
                    Ri.dict.Add(Inputbox.Input_content, json);
                }
            }
        }

        private void Lstbox_batch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int position = Lstbox_batch.IndexFromPoint(point);
            if (Lstbox_batch.SelectedIndex != -1 && position != -1) {
                string json = Ri.dict[Lstbox_batch.SelectedItem.ToString()];
                Inputbox.Inputbox_item = 1;
                Inputbox.Batch_name = Lstbox_batch.SelectedItem.ToString();
                System.Windows.Forms.Form f4 = new Inputbox();
                f4.ShowDialog();

                //string Rename_batch = Interaction.InputBox("Batch Name", "Rename", "", -1, -1);

                //if (Inputbox.Input_content.Length > 11)
                //{
                //    MessageBox.Show("Batch name cannot surpass more than ten words!");
                //    return;
                //}
                if (Inputbox.Cancelornot == false) {
                    return;
                }
                if (string.IsNullOrEmpty(Inputbox.Input_content)) {
                    MessageBox.Show("Batch name cannot be empty.", "Warning!");
                    return;
                }
                else {
                    Ri.dict.Remove(Lstbox_batch.SelectedItem.ToString());
                    Lstbox_batch.Items[Lstbox_batch.SelectedIndex] = Inputbox.Input_content;
                    Ri.dict.Add(Inputbox.Input_content, json);
                }
            }
        }

        private void Lstbox_batch_MouseDown(object sender, MouseEventArgs e)
        {
            try {
                if (e.Button == MouseButtons.Right) {
                    Point point = new Point(e.X, e.Y);
                    int index = Lstbox_batch.SelectedIndex;
                    int position = Lstbox_batch.IndexFromPoint(point);

                    if (position == index) {
                        dToolStripMenuItem.Enabled = true;
                        renameToolStripMenuItem.Enabled = true;
                    }
                    else {
                        dToolStripMenuItem.Enabled = false;
                        renameToolStripMenuItem.Enabled = false;
                    }
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
            catch (Exception) {
                MessageBox.Show("Choose the content.", "Warning!");
            }
        }

        #endregion
        

        private void Button_EnabledORDisabled(bool bEnable)
        {
            Button[] buttons_GD = { btn_D2, btn_D3, btn_D4, btn_D5, btn_D6, btn_D7, btn_D8, btn_D9, btn_D10, btn_D11, btn_D12, btn_D13, btn_D14, btn_D15, btn_D16,
                                    btn_D17, btn_D18, btn_D19, btn_D20, btn_D21, btn_D22};
            Button[] buttons_ALL = { btn_Allon, Btn_Alloff, btn_RD_allon, Btn_RD_Alloff, btn_AnaAllon, btn_AnaAlloff, btn_DigAllon, btn_DigAlloff, btn_State, btn_AnaControll,
                                    btn_DigControll};

            foreach (var item in buttons_GD) {
                item.Enabled = bEnable;
                item.BackColor = Color.WhiteSmoke;
            }
            foreach (var item in buttons_ALL) {
                item.Enabled = bEnable;
                item.BackColor = Color.WhiteSmoke;
            }

            cbo_Analog.Enabled = bEnable;
            cbo_Digital.Enabled = bEnable;
        }

        #region --Analog and Digtal groupbtn controll--
        private void btn_AnaAllon_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                AllAnalog_Controll("1");

                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");

                btn_AnaAllon.Enabled = false;
                btn_AnaAllon.BackColor = Color.WhiteSmoke;
                btn_AnaAlloff.Enabled = true;
                btn_AnaAlloff.BackColor = Color.Red;
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void btn_AnaAlloff_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                AllAnalog_Controll("0");

                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");

                btn_AnaAlloff.Enabled = false;
                btn_AnaAlloff.BackColor = Color.WhiteSmoke;
                btn_AnaAllon.Enabled = true;
                btn_AnaAllon.BackColor = Color.Green;
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void btn_DigAllon_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                DigitalGroup_Controll("1");
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");
                btn_DigAllon.Enabled = false;
                btn_DigAllon.BackColor = Color.WhiteSmoke;
                btn_DigAlloff.Enabled = true;
                btn_DigAlloff.BackColor = Color.Red;
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void btn_DigAlloff_Click(object sender, EventArgs e)
        {
            try {
                //下指令
                DigitalGroup_Controll("0");
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = false;
                Buffer_process("STATE\r\n");
                btn_DigAlloff.Enabled = false;
                btn_DigAlloff.BackColor = Color.WhiteSmoke;
                btn_DigAllon.Enabled = true;
                btn_DigAllon.BackColor = Color.Green;
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }       

        private void Btn_State_Click(object sender, EventArgs e)
        {
            try {
                //檢查STATE狀態與All on All off按鈕是否需要變更
                initialization = true;
                Buffer_process("STATE\r\n");
                Clipboard.SetText(strip_lable_response.Text);
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }

        private void btn_AnaControll_Click(object sender, EventArgs e)
        {
            //下指令
            Relay_Controll(btn_AnaControll, cbo_Analog.SelectedItem.ToString());
            //Analog All on 和 All off 控制與顯示
            Ana_Group_Controll();
        }

        private void btn_DigControll_Click(object sender, EventArgs e)
        {
            //下指令
            Relay_Controll(btn_DigControll, cbo_Digital.SelectedItem.ToString());
            //Digital All on 和 All off 控制與顯示
            Dig_Group_Controll();
        }     
        #endregion

        #region --Analog and Digtal combobox controll--
        private void cbo_Analog_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                initialization = false;
                Buffer_process("STATE\r\n");

                strState = Regex.Replace(strState, "[^0-9]", "");
                if (strState[cbo_Analog.SelectedIndex + 52].Equals('0')) {
                    btn_AnaControll.Text = "OFF";
                    btn_AnaControll.BackColor = Color.Red;
                }
                else {
                    btn_AnaControll.Text = "ON";
                    btn_AnaControll.BackColor = Color.Green;
                }
                    
            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }   

        private void cbo_Digital_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                initialization = false;
                Buffer_process("STATE\r\n");

                strState = Regex.Replace(strState, "[^0-9]", "");
                if (strState[cbo_Digital.SelectedIndex + 22].Equals('0')) {
                    btn_DigControll.Text = "OFF";
                    btn_DigControll.BackColor = Color.Red;
                }
                else {
                    btn_DigControll.Text = "ON";
                    btn_DigControll.BackColor = Color.Green;
                }

            }
            catch (Exception) {
                MessageBox.Show("Port didn't open.", "Warning!");
                strip_label_comport.Text = "Disconnected";
                strip_label_comport.BackColor = Color.Red;
            }
        }
        #endregion

        private void Buffer_process(string input_buffer)
        {
            try {
                byte[] readBuffer = new byte[500];

                port.DiscardInBuffer();
                port.DiscardOutBuffer();

                port.Write(input_buffer);
                //Thread.Sleep(50);

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int offset = 0;
                int total_BytesToRead = 0;
                bool overbuf = false;
                bool end = false;

                while (sw.ElapsedMilliseconds < 2000) //timeout卡控
                {
                    if (port.BytesToRead <= 0)  //若response是0則
                    {
                        continue;
                    }

                    total_BytesToRead += port.BytesToRead;  //計算每一次response裡的byte數，加起來看會讀到readbuffer的哪個位置
                    int last_buffer = readBuffer.Length - offset;

                    int count;
                    if (total_BytesToRead < readBuffer.Length)    //如果當前readbuffer還夠用，可直接讀取完整的byteToRead，若readbuffer不夠用，則讀取readbuffer剩餘byte數
                    {
                        count = port.Read(readBuffer, offset, port.BytesToRead);
                        offset += count;
                    }
                    else {
                        count = port.Read(readBuffer, offset, last_buffer);
                        offset += count;
                        overbuf = true;
                    }
                    for (int search = 0; search < offset - 1; search++) //卡控，若reponse裡讀到OK兩個字，則跳脫迴圈
                    {
                        if (readBuffer[search] == 'O' && readBuffer[search + 1] == 'K') {
                            end = true;
                            break;
                        }
                    }
                    if (end || overbuf)  //前面兩個卡控的布林值判斷
                    {
                        break;
                    }

                }
                sw.Stop(); //計時器停止

                byte[] temp = new byte[offset];     //新增空的array來複製readbuffer的內容
                Array.Copy(readBuffer, 0, temp, 0, offset);

                if (input_buffer == "STATE\r\n") {
                    string Text = Encoding.ASCII.GetString(temp).Replace("\r\n", string.Empty);
                    Text = Text.Replace("?", string.Empty);
                    Text = Text.Replace("\r", string.Empty);
                    strState = Text;
                    if (initialization == true && bCycleRun == false) {
                        strip_lable_response.Text = Text;
                    }
                    this.Refresh();
                    All_Relay_OnOROff(Text);                   
                }
                else {
                    string Batch_Text = "";
                    Batch_Text = Encoding.ASCII.GetString(temp).Replace("\r\n", string.Empty);
                    Batch_Text = Batch_Text.Replace("\r", string.Empty);
                    if (bCycleRun == false)
                        strip_lable_response.Text = Batch_Text;        //strip_label_response顯示出response
                    this.Refresh();
                }
            }
            catch (Exception) {
                //MessageBox.Show("Failed.", "Warning!");
                return;
            }
        }

        //取得檔案版本
        public static string Version
        {
            get {
                Assembly asm = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);
                return fvi.FileVersion;
            }
        }

        //Digital 設計版面21個Relay的顯示
        private void DigitalBtn_Layout_Controll(string strSwitch, Color color)
        {
            Button[] buttons_GD = { btn_D2, btn_D3, btn_D4, btn_D5, btn_D6, btn_D7, btn_D8, btn_D9, btn_D10, btn_D11, btn_D12, btn_D13, btn_D14, btn_D15, btn_D16,
                                    btn_D17, btn_D18, btn_D19, btn_D20, btn_D21, btn_D22};
            foreach (Button button in buttons_GD) {
                button.Text = strSwitch;
                button.BackColor = color;
            }
        }
        //Relay全開全關的按鈕顯示與控制
        private void All_Relay_OnOROff(string str)
        {
            string Text_number = Regex.Replace(str, "[^0-9]", "");
            int Text_number_index = 0;
            Button[] buttons_GD = { btn_D2, btn_D3, btn_D4, btn_D5, btn_D6, btn_D7, btn_D8, btn_D9, btn_D10, btn_D11, btn_D12, btn_D13, btn_D14, btn_D15, btn_D16,
                                    btn_D17, btn_D18, btn_D19, btn_D20, btn_D21, btn_D22};

            foreach (Button btn in buttons_GD) {
                if (Text_number[Text_number_index].ToString() == "1") {
                    btn.Text = "ON";
                    btn.BackColor = Color.Green;
                }
                else if (Text_number[Text_number_index].ToString() == "0") {
                    btn.Text = "OFF";
                    btn.BackColor = Color.Red;
                }
                Text_number_index++;
            }

            if (Text_number.Contains("1")) {
                Btn_Alloff.Enabled = true;
                Btn_Alloff.BackColor = Color.Red;
            }
            else {
                Btn_Alloff.Enabled = false;
                Btn_Alloff.BackColor = Color.WhiteSmoke;
            }
            if (Text_number.Contains("0")) {
                btn_Allon.Enabled = true;
                btn_Allon.BackColor = Color.Green;
            }
            else {
                btn_Allon.Enabled = false;
                btn_Allon.BackColor = Color.WhiteSmoke;
            }
        }
        //D2~D22的Relay All ON和All OFF 的顯示與控制
        private void DigtalBtn_AllOnOROff_Controll()
        {
            //21個Relay
            Button[] buttons_GD = { btn_D2, btn_D3, btn_D4, btn_D5, btn_D6, btn_D7, btn_D8, btn_D9, btn_D10, btn_D11, btn_D12, btn_D13, btn_D14, btn_D15, btn_D16,
                                    btn_D17, btn_D18, btn_D19, btn_D20, btn_D21, btn_D22};
            var Record = 0;
            foreach (var item in buttons_GD) {
                if (item.Text == "ON")
                    Record += 1;
            }
            if (Record == 21) {
                btn_RD_allon.Enabled = false;
                btn_RD_allon.BackColor = Color.WhiteSmoke;
                Btn_RD_Alloff.Enabled = true;
                Btn_RD_Alloff.BackColor = Color.Red;
            }
            else if (Record == 0) {
                btn_RD_allon.Enabled = true;
                btn_RD_allon.BackColor = Color.Green;
                Btn_RD_Alloff.Enabled = false;
                Btn_RD_Alloff.BackColor = Color.WhiteSmoke;
            }
            else {
                btn_RD_allon.Enabled = true;
                btn_RD_allon.BackColor = Color.Green;
                Btn_RD_Alloff.Enabled = true;
                Btn_RD_Alloff.BackColor = Color.Red;
            }
        }
        //Analog All on 和 All off 控制與顯示
        private void Ana_Group_Controll()
        {
            initialization = false;
            Buffer_process("STATE\r\n");
            strState = Regex.Replace(strState, "[^0-9]", "");
            if (strState.Substring(52).Contains("0")) {
                btn_AnaAllon.Enabled = true;
                btn_AnaAllon.BackColor = Color.Green;
            }
            else {
                btn_AnaAllon.Enabled = false;
                btn_AnaAllon.BackColor = Color.WhiteSmoke;
            }
            if (strState.Substring(52).Contains("1")) {
                btn_AnaAlloff.Enabled = true;
                btn_AnaAlloff.BackColor = Color.Red;
            }
            else {
                btn_AnaAlloff.Enabled = false;
                btn_AnaAlloff.BackColor = Color.WhiteSmoke;
            }
        }
        //Digital All on 和 All off 控制與顯示
        private void Dig_Group_Controll()
        {
            initialization = false;
            Buffer_process("STATE\r\n");
            strState = Regex.Replace(strState, "[^0-9]", "");
            if (strState.Substring(21, 31).Contains("0")) {
                btn_DigAllon.Enabled = true;
                btn_DigAllon.BackColor = Color.Green;
            }
            else {
                btn_DigAllon.Enabled = false;
                btn_DigAllon.BackColor = Color.WhiteSmoke;
            }
            if (strState.Substring(21, 31).Contains("1")) {
                btn_DigAlloff.Enabled = true;
                btn_DigAlloff.BackColor = Color.Red;
            }
            else {
                btn_DigAlloff.Enabled = false;
                btn_DigAlloff.BackColor = Color.WhiteSmoke;
            }
        }

        private void Cbo_Comport_MouseHover(object sender, EventArgs e)
        {
            // 設定顯示樣式
            toolTip_Port.AutoPopDelay = 5000;//提示資訊的可見時間
            toolTip_Port.InitialDelay = 500;//事件觸發多久後出現提示
            toolTip_Port.ReshowDelay = 500;//指標從一個控制元件移向另一個控制元件時，經過多久才會顯示下一個提示框
            toolTip_Port.ShowAlways = true;//是否顯示提示框
            //  設定伴隨的物件.
            if (Cbo_Comport.Items.Count != 0) {
                Cbo_Comport.SelectedIndex = 0;
                toolTip_Port.SetToolTip(Cbo_Comport, Cbo_Comport.SelectedItem.ToString());//設定提示按鈕和提示內容
            }               
        }

        private void Relay_Batch_Process(Button[] buttons_All)
        {
            

            for (int i = 0; i < Lstbox_batch.Items.Count; i++) {
                String key = Lstbox_batch.Items[i].ToString();
                if (!Ri.dict.ContainsKey(key)) {
                    return;
                }
                string json = Ri.dict[key];
                JArray array = JsonConvert.DeserializeObject<JArray>(json);

                var ans = "";
                int status = 0;
                int time = 0;

                foreach (JObject Jobj in array) {
                    if (Jobj["Status"].ToString() == "ON") {
                        status = 1;
                    }

                    ans = Jobj["Relay"].ToString() + "=" + status;
                    int Relay = int.Parse(Regex.Replace(Jobj["Relay"].ToString(), "[^0-9]", ""));
                    if (ans.Contains("D") && Relay <= 22) {
                        if (status == 1) {
                            buttons_All[Relay - 2].Text = "ON";
                            buttons_All[Relay - 2].BackColor = Color.Green;
                        }
                        else {
                            buttons_All[Relay - 2].Text = "OFF";
                            buttons_All[Relay - 2].BackColor = Color.Red;
                        }
                    }
                    Buffer_process(ans + "\r\n");
                    time = Int32.Parse(Jobj["Delay Time (s)"].ToString());
                    Thread.Sleep(time * 1000);
                }
            }
            initialization = true;
            Buffer_process("STATE\r\n");

            Thread.Sleep(1000);
            Application.DoEvents();           
        }

        private void pinoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPic pic = new frmPic();
            pic.ShowDialog();
        }

        // custom struct with our desired values
        struct ComPort
        {
            public string name;
            public string description;

            public ComPort(string name, string description)
            {
                this.name = name;
                this.description = description;
            }
        }

        // Method 2 function
        private List<ComPort> GetPortNames()
        {
            List<ComPort> ports = new List<ComPort>();
            //var searcher = new ManagementObjectSearcher("SELECT DeviceID,Caption FROM WIN32_SerialPort");
            var searcher = new ManagementObjectSearcher("SELECT DeviceID, Name, Description FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"");
            //Regex rx = new Regex("\\(COM.*\\)");
            Regex rx = new Regex("\\(COM[0-9]+\\)");
            foreach (ManagementObject port in searcher.Get())
            {
                string name = port.GetPropertyValue("Name").ToString();
                Match match = rx.Match(name);
                if (!match.Success)
                    continue;

                // show the service
                ComPort c = new ComPort();
                c.name = match.Value;
                c.description = port.GetPropertyValue("Description").ToString();
                ports.Add(c);
            }
            return ports;
        }

        private List<ComPort> GetAllPorts()
        {
            // Method 2
            List<ComPort> ports = GetPortNames();
            foreach (ComPort port in ports)
            {
                string name = port.description;
                if (name.Contains("Arduino") || name.Contains("CH340"))
                    Cbo_Comport.Items.Add(port.name + port.description);
            }

            if (Cbo_Comport.Items.Count == 0)
            {
                string[] ports2 = SerialPort.GetPortNames();
                foreach (string port in ports2)
                {
                    Cbo_Comport.Items.Add(port);
                }
            }
            // Method 1
            //string[] ports2 = SerialPort.GetPortNames();
            //foreach (string port in ports2) {
            //    // Only need to check the Port Name
            //    if (!ports.Exists(x => x.name == port)) {
            //        Cbo_Comport.Items.Add(port);
            //    }
            //}
            return ports;
        }

    }
}
