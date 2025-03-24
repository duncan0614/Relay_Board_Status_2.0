
namespace Relay_Board_Controller
{
    partial class Relay_Board_MEGA
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relay_Board_MEGA));
            this.Relay_Menu = new System.Windows.Forms.MenuStrip();
            this.strip_menuitem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_menuitem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_menuitem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_menuitem_batchEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.relayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_MenuItem_ArduinoUNO = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpb_Layout = new System.Windows.Forms.GroupBox();
            this.btn_D22 = new System.Windows.Forms.Button();
            this.lbl_D22 = new System.Windows.Forms.Label();
            this.btn_D16 = new System.Windows.Forms.Button();
            this.btn_D17 = new System.Windows.Forms.Button();
            this.btn_D21 = new System.Windows.Forms.Button();
            this.btn_D20 = new System.Windows.Forms.Button();
            this.lbl_D21 = new System.Windows.Forms.Label();
            this.btn_D19 = new System.Windows.Forms.Button();
            this.lbl_D20 = new System.Windows.Forms.Label();
            this.btn_D18 = new System.Windows.Forms.Button();
            this.lbl_D19 = new System.Windows.Forms.Label();
            this.lbl_D18 = new System.Windows.Forms.Label();
            this.lbl_D17 = new System.Windows.Forms.Label();
            this.lbl_D16 = new System.Windows.Forms.Label();
            this.btn_D15 = new System.Windows.Forms.Button();
            this.lbl_D15 = new System.Windows.Forms.Label();
            this.btn_D7 = new System.Windows.Forms.Button();
            this.lbl_D7 = new System.Windows.Forms.Label();
            this.btn_D6 = new System.Windows.Forms.Button();
            this.btn_D5 = new System.Windows.Forms.Button();
            this.btn_D13 = new System.Windows.Forms.Button();
            this.btn_D14 = new System.Windows.Forms.Button();
            this.btn_D12 = new System.Windows.Forms.Button();
            this.Btn_RD_Alloff = new System.Windows.Forms.Button();
            this.btn_D11 = new System.Windows.Forms.Button();
            this.btn_D2 = new System.Windows.Forms.Button();
            this.btn_RD_allon = new System.Windows.Forms.Button();
            this.lbl_D14 = new System.Windows.Forms.Label();
            this.btn_D3 = new System.Windows.Forms.Button();
            this.btn_D10 = new System.Windows.Forms.Button();
            this.lbl_D2 = new System.Windows.Forms.Label();
            this.btn_D4 = new System.Windows.Forms.Button();
            this.lbl_D3 = new System.Windows.Forms.Label();
            this.btn_D9 = new System.Windows.Forms.Button();
            this.lbl_D4 = new System.Windows.Forms.Label();
            this.lbl_D5 = new System.Windows.Forms.Label();
            this.btn_D8 = new System.Windows.Forms.Button();
            this.lbl_D6 = new System.Windows.Forms.Label();
            this.lbl_D8 = new System.Windows.Forms.Label();
            this.lbl_D9 = new System.Windows.Forms.Label();
            this.lbl_D10 = new System.Windows.Forms.Label();
            this.lbl_D11 = new System.Windows.Forms.Label();
            this.lbl_D12 = new System.Windows.Forms.Label();
            this.lbl_D13 = new System.Windows.Forms.Label();
            this.btn_batch = new System.Windows.Forms.Button();
            this.btn_Allon = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.strip_label_comport = new System.Windows.Forms.ToolStripStatusLabel();
            this.strip_lable_response = new System.Windows.Forms.ToolStripStatusLabel();
            this.strip_label_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lstbox_batch = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Alloff = new System.Windows.Forms.Button();
            this.Cbo_Comport = new System.Windows.Forms.ComboBox();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Gbx_Comport = new System.Windows.Forms.GroupBox();
            this.btnRescan = new System.Windows.Forms.Button();
            this.Gbx_Analog = new System.Windows.Forms.GroupBox();
            this.btn_AnaControll = new System.Windows.Forms.Button();
            this.btn_AnaAlloff = new System.Windows.Forms.Button();
            this.btn_AnaAllon = new System.Windows.Forms.Button();
            this.cbo_Analog = new System.Windows.Forms.ComboBox();
            this.Gbx_Digital = new System.Windows.Forms.GroupBox();
            this.btn_DigControll = new System.Windows.Forms.Button();
            this.btn_DigAlloff = new System.Windows.Forms.Button();
            this.btn_DigAllon = new System.Windows.Forms.Button();
            this.cbo_Digital = new System.Windows.Forms.ComboBox();
            this.btn_State = new System.Windows.Forms.Button();
            this.toolTip_Port = new System.Windows.Forms.ToolTip(this.components);
            this.btn_CycleRun = new System.Windows.Forms.Button();
            this.btn_Customize = new System.Windows.Forms.Button();
            this.Relay_Menu.SuspendLayout();
            this.gpb_Layout.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Gbx_Comport.SuspendLayout();
            this.Gbx_Analog.SuspendLayout();
            this.Gbx_Digital.SuspendLayout();
            this.SuspendLayout();
            // 
            // Relay_Menu
            // 
            this.Relay_Menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Relay_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Relay_Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Relay_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_menuitem_File,
            this.strip_menuitem_Edit,
            this.relayToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Relay_Menu.Location = new System.Drawing.Point(0, 0);
            this.Relay_Menu.Name = "Relay_Menu";
            this.Relay_Menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.Relay_Menu.Size = new System.Drawing.Size(947, 24);
            this.Relay_Menu.TabIndex = 4;
            this.Relay_Menu.Text = "Relay_Menu";
            // 
            // strip_menuitem_File
            // 
            this.strip_menuitem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_menuitem_Open});
            this.strip_menuitem_File.Name = "strip_menuitem_File";
            this.strip_menuitem_File.Size = new System.Drawing.Size(38, 22);
            this.strip_menuitem_File.Text = "File";
            // 
            // strip_menuitem_Open
            // 
            this.strip_menuitem_Open.Name = "strip_menuitem_Open";
            this.strip_menuitem_Open.Size = new System.Drawing.Size(108, 22);
            this.strip_menuitem_Open.Text = "OPEN";
            this.strip_menuitem_Open.Click += new System.EventHandler(this.strip_menuitem_Open_Click);
            // 
            // strip_menuitem_Edit
            // 
            this.strip_menuitem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_menuitem_batchEdit});
            this.strip_menuitem_Edit.Name = "strip_menuitem_Edit";
            this.strip_menuitem_Edit.Size = new System.Drawing.Size(41, 22);
            this.strip_menuitem_Edit.Text = "Edit";
            // 
            // strip_menuitem_batchEdit
            // 
            this.strip_menuitem_batchEdit.Name = "strip_menuitem_batchEdit";
            this.strip_menuitem_batchEdit.Size = new System.Drawing.Size(130, 22);
            this.strip_menuitem_batchEdit.Text = "Batch Edit";
            this.strip_menuitem_batchEdit.Click += new System.EventHandler(this.strip_menuitem_batchEdit_Click);
            // 
            // relayToolStripMenuItem
            // 
            this.relayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_MenuItem_ArduinoUNO});
            this.relayToolStripMenuItem.Name = "relayToolStripMenuItem";
            this.relayToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.relayToolStripMenuItem.Text = "Relay";
            // 
            // Strip_MenuItem_ArduinoUNO
            // 
            this.Strip_MenuItem_ArduinoUNO.Name = "Strip_MenuItem_ArduinoUNO";
            this.Strip_MenuItem_ArduinoUNO.Size = new System.Drawing.Size(151, 22);
            this.Strip_MenuItem_ArduinoUNO.Text = "Arduino UNO";
            this.Strip_MenuItem_ArduinoUNO.Click += new System.EventHandler(this.Strip_MenuItem_ArduinoUNO_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinoutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pinoutToolStripMenuItem
            // 
            this.pinoutToolStripMenuItem.Name = "pinoutToolStripMenuItem";
            this.pinoutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pinoutToolStripMenuItem.Text = "Pinout";
            this.pinoutToolStripMenuItem.Click += new System.EventHandler(this.pinoutToolStripMenuItem_Click);
            // 
            // gpb_Layout
            // 
            this.gpb_Layout.AutoSize = true;
            this.gpb_Layout.BackColor = System.Drawing.SystemColors.Control;
            this.gpb_Layout.Controls.Add(this.btn_D22);
            this.gpb_Layout.Controls.Add(this.lbl_D22);
            this.gpb_Layout.Controls.Add(this.btn_D16);
            this.gpb_Layout.Controls.Add(this.btn_D17);
            this.gpb_Layout.Controls.Add(this.btn_D21);
            this.gpb_Layout.Controls.Add(this.btn_D20);
            this.gpb_Layout.Controls.Add(this.lbl_D21);
            this.gpb_Layout.Controls.Add(this.btn_D19);
            this.gpb_Layout.Controls.Add(this.lbl_D20);
            this.gpb_Layout.Controls.Add(this.btn_D18);
            this.gpb_Layout.Controls.Add(this.lbl_D19);
            this.gpb_Layout.Controls.Add(this.lbl_D18);
            this.gpb_Layout.Controls.Add(this.lbl_D17);
            this.gpb_Layout.Controls.Add(this.lbl_D16);
            this.gpb_Layout.Controls.Add(this.btn_D15);
            this.gpb_Layout.Controls.Add(this.lbl_D15);
            this.gpb_Layout.Controls.Add(this.btn_D7);
            this.gpb_Layout.Controls.Add(this.lbl_D7);
            this.gpb_Layout.Controls.Add(this.btn_D6);
            this.gpb_Layout.Controls.Add(this.btn_D5);
            this.gpb_Layout.Controls.Add(this.btn_D13);
            this.gpb_Layout.Controls.Add(this.btn_D14);
            this.gpb_Layout.Controls.Add(this.btn_D12);
            this.gpb_Layout.Controls.Add(this.Btn_RD_Alloff);
            this.gpb_Layout.Controls.Add(this.btn_D11);
            this.gpb_Layout.Controls.Add(this.btn_D2);
            this.gpb_Layout.Controls.Add(this.btn_RD_allon);
            this.gpb_Layout.Controls.Add(this.lbl_D14);
            this.gpb_Layout.Controls.Add(this.btn_D3);
            this.gpb_Layout.Controls.Add(this.btn_D10);
            this.gpb_Layout.Controls.Add(this.lbl_D2);
            this.gpb_Layout.Controls.Add(this.btn_D4);
            this.gpb_Layout.Controls.Add(this.lbl_D3);
            this.gpb_Layout.Controls.Add(this.btn_D9);
            this.gpb_Layout.Controls.Add(this.lbl_D4);
            this.gpb_Layout.Controls.Add(this.lbl_D5);
            this.gpb_Layout.Controls.Add(this.btn_D8);
            this.gpb_Layout.Controls.Add(this.lbl_D6);
            this.gpb_Layout.Controls.Add(this.lbl_D8);
            this.gpb_Layout.Controls.Add(this.lbl_D9);
            this.gpb_Layout.Controls.Add(this.lbl_D10);
            this.gpb_Layout.Controls.Add(this.lbl_D11);
            this.gpb_Layout.Controls.Add(this.lbl_D12);
            this.gpb_Layout.Controls.Add(this.lbl_D13);
            this.gpb_Layout.Location = new System.Drawing.Point(8, 80);
            this.gpb_Layout.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_Layout.Name = "gpb_Layout";
            this.gpb_Layout.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_Layout.Size = new System.Drawing.Size(779, 312);
            this.gpb_Layout.TabIndex = 6;
            this.gpb_Layout.TabStop = false;
            this.gpb_Layout.Text = "Digital Layout";
            // 
            // btn_D22
            // 
            this.btn_D22.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D22.Location = new System.Drawing.Point(674, 197);
            this.btn_D22.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D22.Name = "btn_D22";
            this.btn_D22.Size = new System.Drawing.Size(80, 27);
            this.btn_D22.TabIndex = 44;
            this.btn_D22.Text = "OFF";
            this.btn_D22.UseVisualStyleBackColor = false;
            this.btn_D22.Click += new System.EventHandler(this.btn_D22_Click);
            // 
            // lbl_D22
            // 
            this.lbl_D22.AutoSize = true;
            this.lbl_D22.Location = new System.Drawing.Point(701, 179);
            this.lbl_D22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D22.Name = "lbl_D22";
            this.lbl_D22.Size = new System.Drawing.Size(25, 12);
            this.lbl_D22.TabIndex = 43;
            this.lbl_D22.Text = "D22";
            // 
            // btn_D16
            // 
            this.btn_D16.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D16.Location = new System.Drawing.Point(20, 197);
            this.btn_D16.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D16.Name = "btn_D16";
            this.btn_D16.Size = new System.Drawing.Size(80, 27);
            this.btn_D16.TabIndex = 42;
            this.btn_D16.Text = "OFF";
            this.btn_D16.UseVisualStyleBackColor = false;
            this.btn_D16.Click += new System.EventHandler(this.btn_D16_Click);
            // 
            // btn_D17
            // 
            this.btn_D17.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D17.Location = new System.Drawing.Point(129, 197);
            this.btn_D17.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D17.Name = "btn_D17";
            this.btn_D17.Size = new System.Drawing.Size(80, 27);
            this.btn_D17.TabIndex = 41;
            this.btn_D17.Text = "OFF";
            this.btn_D17.UseVisualStyleBackColor = false;
            this.btn_D17.Click += new System.EventHandler(this.btn_D17_Click);
            // 
            // btn_D21
            // 
            this.btn_D21.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D21.Location = new System.Drawing.Point(565, 197);
            this.btn_D21.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D21.Name = "btn_D21";
            this.btn_D21.Size = new System.Drawing.Size(80, 27);
            this.btn_D21.TabIndex = 37;
            this.btn_D21.Text = "OFF";
            this.btn_D21.UseVisualStyleBackColor = false;
            this.btn_D21.Click += new System.EventHandler(this.btn_D21_Click);
            // 
            // btn_D20
            // 
            this.btn_D20.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D20.Location = new System.Drawing.Point(456, 197);
            this.btn_D20.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D20.Name = "btn_D20";
            this.btn_D20.Size = new System.Drawing.Size(80, 27);
            this.btn_D20.TabIndex = 38;
            this.btn_D20.Text = "OFF";
            this.btn_D20.UseVisualStyleBackColor = false;
            this.btn_D20.Click += new System.EventHandler(this.btn_D20_Click);
            // 
            // lbl_D21
            // 
            this.lbl_D21.AutoSize = true;
            this.lbl_D21.ForeColor = System.Drawing.Color.Red;
            this.lbl_D21.Location = new System.Drawing.Point(594, 179);
            this.lbl_D21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D21.Name = "lbl_D21";
            this.lbl_D21.Size = new System.Drawing.Size(45, 12);
            this.lbl_D21.TabIndex = 36;
            this.lbl_D21.Text = "D21(＊)";
            // 
            // btn_D19
            // 
            this.btn_D19.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D19.Location = new System.Drawing.Point(347, 197);
            this.btn_D19.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D19.Name = "btn_D19";
            this.btn_D19.Size = new System.Drawing.Size(80, 27);
            this.btn_D19.TabIndex = 39;
            this.btn_D19.Text = "OFF";
            this.btn_D19.UseVisualStyleBackColor = false;
            this.btn_D19.Click += new System.EventHandler(this.btn_D19_Click);
            // 
            // lbl_D20
            // 
            this.lbl_D20.AutoSize = true;
            this.lbl_D20.ForeColor = System.Drawing.Color.Red;
            this.lbl_D20.Location = new System.Drawing.Point(484, 179);
            this.lbl_D20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D20.Name = "lbl_D20";
            this.lbl_D20.Size = new System.Drawing.Size(45, 12);
            this.lbl_D20.TabIndex = 35;
            this.lbl_D20.Text = "D20(＊)";
            // 
            // btn_D18
            // 
            this.btn_D18.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D18.Location = new System.Drawing.Point(238, 197);
            this.btn_D18.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D18.Name = "btn_D18";
            this.btn_D18.Size = new System.Drawing.Size(80, 27);
            this.btn_D18.TabIndex = 40;
            this.btn_D18.Text = "OFF";
            this.btn_D18.UseVisualStyleBackColor = false;
            this.btn_D18.Click += new System.EventHandler(this.btn_D18_Click);
            // 
            // lbl_D19
            // 
            this.lbl_D19.AutoSize = true;
            this.lbl_D19.Location = new System.Drawing.Point(376, 179);
            this.lbl_D19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D19.Name = "lbl_D19";
            this.lbl_D19.Size = new System.Drawing.Size(25, 12);
            this.lbl_D19.TabIndex = 34;
            this.lbl_D19.Text = "D19";
            // 
            // lbl_D18
            // 
            this.lbl_D18.AutoSize = true;
            this.lbl_D18.Location = new System.Drawing.Point(266, 179);
            this.lbl_D18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D18.Name = "lbl_D18";
            this.lbl_D18.Size = new System.Drawing.Size(25, 12);
            this.lbl_D18.TabIndex = 33;
            this.lbl_D18.Text = "D18";
            // 
            // lbl_D17
            // 
            this.lbl_D17.AutoSize = true;
            this.lbl_D17.Location = new System.Drawing.Point(159, 179);
            this.lbl_D17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D17.Name = "lbl_D17";
            this.lbl_D17.Size = new System.Drawing.Size(25, 12);
            this.lbl_D17.TabIndex = 32;
            this.lbl_D17.Text = "D17";
            // 
            // lbl_D16
            // 
            this.lbl_D16.AutoSize = true;
            this.lbl_D16.Location = new System.Drawing.Point(48, 179);
            this.lbl_D16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D16.Name = "lbl_D16";
            this.lbl_D16.Size = new System.Drawing.Size(25, 12);
            this.lbl_D16.TabIndex = 31;
            this.lbl_D16.Text = "D16";
            // 
            // btn_D15
            // 
            this.btn_D15.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D15.Location = new System.Drawing.Point(674, 117);
            this.btn_D15.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D15.Name = "btn_D15";
            this.btn_D15.Size = new System.Drawing.Size(80, 27);
            this.btn_D15.TabIndex = 30;
            this.btn_D15.Text = "OFF";
            this.btn_D15.UseVisualStyleBackColor = false;
            this.btn_D15.Click += new System.EventHandler(this.btn_D15_Click);
            // 
            // lbl_D15
            // 
            this.lbl_D15.AutoSize = true;
            this.lbl_D15.Location = new System.Drawing.Point(701, 101);
            this.lbl_D15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D15.Name = "lbl_D15";
            this.lbl_D15.Size = new System.Drawing.Size(25, 12);
            this.lbl_D15.TabIndex = 29;
            this.lbl_D15.Text = "D15";
            // 
            // btn_D7
            // 
            this.btn_D7.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D7.Location = new System.Drawing.Point(674, 37);
            this.btn_D7.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D7.Name = "btn_D7";
            this.btn_D7.Size = new System.Drawing.Size(80, 27);
            this.btn_D7.TabIndex = 28;
            this.btn_D7.Text = "OFF";
            this.btn_D7.UseVisualStyleBackColor = false;
            this.btn_D7.Click += new System.EventHandler(this.btn_D7_Click);
            // 
            // lbl_D7
            // 
            this.lbl_D7.AutoSize = true;
            this.lbl_D7.Location = new System.Drawing.Point(703, 23);
            this.lbl_D7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D7.Name = "lbl_D7";
            this.lbl_D7.Size = new System.Drawing.Size(19, 12);
            this.lbl_D7.TabIndex = 27;
            this.lbl_D7.Text = "D7";
            // 
            // btn_D6
            // 
            this.btn_D6.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D6.Location = new System.Drawing.Point(20, 117);
            this.btn_D6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D6.Name = "btn_D6";
            this.btn_D6.Size = new System.Drawing.Size(80, 27);
            this.btn_D6.TabIndex = 24;
            this.btn_D6.Text = "OFF";
            this.btn_D6.UseVisualStyleBackColor = false;
            this.btn_D6.Click += new System.EventHandler(this.btn_D6_Click);
            // 
            // btn_D5
            // 
            this.btn_D5.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D5.Location = new System.Drawing.Point(129, 117);
            this.btn_D5.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D5.Name = "btn_D5";
            this.btn_D5.Size = new System.Drawing.Size(80, 27);
            this.btn_D5.TabIndex = 23;
            this.btn_D5.Text = "OFF";
            this.btn_D5.UseVisualStyleBackColor = false;
            this.btn_D5.Click += new System.EventHandler(this.btn_D5_Click);
            // 
            // btn_D13
            // 
            this.btn_D13.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D13.Location = new System.Drawing.Point(20, 37);
            this.btn_D13.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D13.Name = "btn_D13";
            this.btn_D13.Size = new System.Drawing.Size(80, 27);
            this.btn_D13.TabIndex = 12;
            this.btn_D13.Text = "OFF";
            this.btn_D13.UseVisualStyleBackColor = false;
            this.btn_D13.Click += new System.EventHandler(this.btn_D13_Click);
            // 
            // btn_D14
            // 
            this.btn_D14.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D14.Location = new System.Drawing.Point(565, 117);
            this.btn_D14.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D14.Name = "btn_D14";
            this.btn_D14.Size = new System.Drawing.Size(80, 27);
            this.btn_D14.TabIndex = 19;
            this.btn_D14.Text = "OFF";
            this.btn_D14.UseVisualStyleBackColor = false;
            this.btn_D14.Click += new System.EventHandler(this.btn_D14_Click);
            // 
            // btn_D12
            // 
            this.btn_D12.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D12.Location = new System.Drawing.Point(129, 37);
            this.btn_D12.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D12.Name = "btn_D12";
            this.btn_D12.Size = new System.Drawing.Size(80, 27);
            this.btn_D12.TabIndex = 11;
            this.btn_D12.Text = "OFF";
            this.btn_D12.UseVisualStyleBackColor = false;
            this.btn_D12.Click += new System.EventHandler(this.btn_D12_Click);
            // 
            // Btn_RD_Alloff
            // 
            this.Btn_RD_Alloff.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_RD_Alloff.Enabled = false;
            this.Btn_RD_Alloff.Location = new System.Drawing.Point(443, 255);
            this.Btn_RD_Alloff.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_RD_Alloff.Name = "Btn_RD_Alloff";
            this.Btn_RD_Alloff.Size = new System.Drawing.Size(93, 33);
            this.Btn_RD_Alloff.TabIndex = 26;
            this.Btn_RD_Alloff.Text = "ALL OFF";
            this.Btn_RD_Alloff.UseVisualStyleBackColor = false;
            this.Btn_RD_Alloff.Click += new System.EventHandler(this.Btn_RD_Alloff_Click);
            // 
            // btn_D11
            // 
            this.btn_D11.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D11.Location = new System.Drawing.Point(238, 37);
            this.btn_D11.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D11.Name = "btn_D11";
            this.btn_D11.Size = new System.Drawing.Size(80, 27);
            this.btn_D11.TabIndex = 10;
            this.btn_D11.Text = "OFF";
            this.btn_D11.UseVisualStyleBackColor = false;
            this.btn_D11.Click += new System.EventHandler(this.btn_D11_Click);
            // 
            // btn_D2
            // 
            this.btn_D2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D2.Location = new System.Drawing.Point(456, 117);
            this.btn_D2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D2.Name = "btn_D2";
            this.btn_D2.Size = new System.Drawing.Size(80, 27);
            this.btn_D2.TabIndex = 20;
            this.btn_D2.Text = "OFF";
            this.btn_D2.UseVisualStyleBackColor = false;
            this.btn_D2.Click += new System.EventHandler(this.btn_D2_Click);
            // 
            // btn_RD_allon
            // 
            this.btn_RD_allon.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RD_allon.Enabled = false;
            this.btn_RD_allon.Location = new System.Drawing.Point(238, 255);
            this.btn_RD_allon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RD_allon.Name = "btn_RD_allon";
            this.btn_RD_allon.Size = new System.Drawing.Size(93, 33);
            this.btn_RD_allon.TabIndex = 25;
            this.btn_RD_allon.Text = "ALL ON";
            this.btn_RD_allon.UseVisualStyleBackColor = false;
            this.btn_RD_allon.Click += new System.EventHandler(this.btn_RD_allon_Click);
            // 
            // lbl_D14
            // 
            this.lbl_D14.AutoSize = true;
            this.lbl_D14.Location = new System.Drawing.Point(592, 101);
            this.lbl_D14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D14.Name = "lbl_D14";
            this.lbl_D14.Size = new System.Drawing.Size(25, 12);
            this.lbl_D14.TabIndex = 18;
            this.lbl_D14.Text = "D14";
            // 
            // btn_D3
            // 
            this.btn_D3.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D3.Location = new System.Drawing.Point(347, 117);
            this.btn_D3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D3.Name = "btn_D3";
            this.btn_D3.Size = new System.Drawing.Size(80, 27);
            this.btn_D3.TabIndex = 21;
            this.btn_D3.Text = "OFF";
            this.btn_D3.UseVisualStyleBackColor = false;
            this.btn_D3.Click += new System.EventHandler(this.btn_D3_Click);
            // 
            // btn_D10
            // 
            this.btn_D10.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D10.Location = new System.Drawing.Point(347, 37);
            this.btn_D10.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D10.Name = "btn_D10";
            this.btn_D10.Size = new System.Drawing.Size(80, 27);
            this.btn_D10.TabIndex = 9;
            this.btn_D10.Text = "OFF";
            this.btn_D10.UseVisualStyleBackColor = false;
            this.btn_D10.Click += new System.EventHandler(this.btn_D10_Click);
            // 
            // lbl_D2
            // 
            this.lbl_D2.AutoSize = true;
            this.lbl_D2.Location = new System.Drawing.Point(486, 101);
            this.lbl_D2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D2.Name = "lbl_D2";
            this.lbl_D2.Size = new System.Drawing.Size(19, 12);
            this.lbl_D2.TabIndex = 17;
            this.lbl_D2.Text = "D2";
            // 
            // btn_D4
            // 
            this.btn_D4.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D4.Location = new System.Drawing.Point(238, 117);
            this.btn_D4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D4.Name = "btn_D4";
            this.btn_D4.Size = new System.Drawing.Size(80, 27);
            this.btn_D4.TabIndex = 22;
            this.btn_D4.Text = "OFF";
            this.btn_D4.UseVisualStyleBackColor = false;
            this.btn_D4.Click += new System.EventHandler(this.btn_D4_Click);
            // 
            // lbl_D3
            // 
            this.lbl_D3.AutoSize = true;
            this.lbl_D3.Location = new System.Drawing.Point(377, 101);
            this.lbl_D3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D3.Name = "lbl_D3";
            this.lbl_D3.Size = new System.Drawing.Size(19, 12);
            this.lbl_D3.TabIndex = 16;
            this.lbl_D3.Text = "D3";
            // 
            // btn_D9
            // 
            this.btn_D9.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D9.Location = new System.Drawing.Point(456, 37);
            this.btn_D9.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D9.Name = "btn_D9";
            this.btn_D9.Size = new System.Drawing.Size(80, 27);
            this.btn_D9.TabIndex = 8;
            this.btn_D9.Text = "OFF";
            this.btn_D9.UseVisualStyleBackColor = false;
            this.btn_D9.Click += new System.EventHandler(this.btn_D9_Click);
            // 
            // lbl_D4
            // 
            this.lbl_D4.AutoSize = true;
            this.lbl_D4.Location = new System.Drawing.Point(269, 101);
            this.lbl_D4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D4.Name = "lbl_D4";
            this.lbl_D4.Size = new System.Drawing.Size(19, 12);
            this.lbl_D4.TabIndex = 15;
            this.lbl_D4.Text = "D4";
            // 
            // lbl_D5
            // 
            this.lbl_D5.AutoSize = true;
            this.lbl_D5.Location = new System.Drawing.Point(160, 101);
            this.lbl_D5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D5.Name = "lbl_D5";
            this.lbl_D5.Size = new System.Drawing.Size(19, 12);
            this.lbl_D5.TabIndex = 14;
            this.lbl_D5.Text = "D5";
            // 
            // btn_D8
            // 
            this.btn_D8.BackColor = System.Drawing.SystemColors.Control;
            this.btn_D8.Location = new System.Drawing.Point(565, 37);
            this.btn_D8.Margin = new System.Windows.Forms.Padding(2);
            this.btn_D8.Name = "btn_D8";
            this.btn_D8.Size = new System.Drawing.Size(80, 27);
            this.btn_D8.TabIndex = 7;
            this.btn_D8.Text = "OFF";
            this.btn_D8.UseVisualStyleBackColor = false;
            this.btn_D8.Click += new System.EventHandler(this.btn_D8_Click);
            // 
            // lbl_D6
            // 
            this.lbl_D6.AutoSize = true;
            this.lbl_D6.Location = new System.Drawing.Point(51, 101);
            this.lbl_D6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D6.Name = "lbl_D6";
            this.lbl_D6.Size = new System.Drawing.Size(19, 12);
            this.lbl_D6.TabIndex = 13;
            this.lbl_D6.Text = "D6";
            // 
            // lbl_D8
            // 
            this.lbl_D8.AutoSize = true;
            this.lbl_D8.Location = new System.Drawing.Point(595, 23);
            this.lbl_D8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D8.Name = "lbl_D8";
            this.lbl_D8.Size = new System.Drawing.Size(19, 12);
            this.lbl_D8.TabIndex = 6;
            this.lbl_D8.Text = "D8";
            // 
            // lbl_D9
            // 
            this.lbl_D9.AutoSize = true;
            this.lbl_D9.Location = new System.Drawing.Point(486, 23);
            this.lbl_D9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D9.Name = "lbl_D9";
            this.lbl_D9.Size = new System.Drawing.Size(19, 12);
            this.lbl_D9.TabIndex = 5;
            this.lbl_D9.Text = "D9";
            // 
            // lbl_D10
            // 
            this.lbl_D10.AutoSize = true;
            this.lbl_D10.Location = new System.Drawing.Point(375, 23);
            this.lbl_D10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D10.Name = "lbl_D10";
            this.lbl_D10.Size = new System.Drawing.Size(25, 12);
            this.lbl_D10.TabIndex = 4;
            this.lbl_D10.Text = "D10";
            // 
            // lbl_D11
            // 
            this.lbl_D11.AutoSize = true;
            this.lbl_D11.Location = new System.Drawing.Point(267, 23);
            this.lbl_D11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D11.Name = "lbl_D11";
            this.lbl_D11.Size = new System.Drawing.Size(25, 12);
            this.lbl_D11.TabIndex = 3;
            this.lbl_D11.Text = "D11";
            // 
            // lbl_D12
            // 
            this.lbl_D12.AutoSize = true;
            this.lbl_D12.Location = new System.Drawing.Point(155, 23);
            this.lbl_D12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D12.Name = "lbl_D12";
            this.lbl_D12.Size = new System.Drawing.Size(25, 12);
            this.lbl_D12.TabIndex = 2;
            this.lbl_D12.Text = "D12";
            // 
            // lbl_D13
            // 
            this.lbl_D13.AutoSize = true;
            this.lbl_D13.ForeColor = System.Drawing.Color.Red;
            this.lbl_D13.Location = new System.Drawing.Point(48, 23);
            this.lbl_D13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D13.Name = "lbl_D13";
            this.lbl_D13.Size = new System.Drawing.Size(45, 12);
            this.lbl_D13.TabIndex = 1;
            this.lbl_D13.Text = "D13(＊)";
            // 
            // btn_batch
            // 
            this.btn_batch.AutoSize = true;
            this.btn_batch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_batch.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_batch.Location = new System.Drawing.Point(803, 31);
            this.btn_batch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_batch.Name = "btn_batch";
            this.btn_batch.Size = new System.Drawing.Size(135, 45);
            this.btn_batch.TabIndex = 7;
            this.btn_batch.Text = "NO FILE";
            this.btn_batch.UseVisualStyleBackColor = false;
            this.btn_batch.Click += new System.EventHandler(this.btn_batch_Click);
            // 
            // btn_Allon
            // 
            this.btn_Allon.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Allon.Enabled = false;
            this.btn_Allon.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Allon.Location = new System.Drawing.Point(620, 403);
            this.btn_Allon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Allon.Name = "btn_Allon";
            this.btn_Allon.Size = new System.Drawing.Size(167, 40);
            this.btn_Allon.TabIndex = 9;
            this.btn_Allon.Text = "ALL ON";
            this.btn_Allon.UseVisualStyleBackColor = false;
            this.btn_Allon.Click += new System.EventHandler(this.btn_allon_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.Location = new System.Drawing.Point(803, 308);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(135, 39);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_label_comport,
            this.strip_lable_response,
            this.strip_label_version});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(947, 34);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // strip_label_comport
            // 
            this.strip_label_comport.AutoSize = false;
            this.strip_label_comport.BackColor = System.Drawing.Color.Red;
            this.strip_label_comport.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.strip_label_comport.Name = "strip_label_comport";
            this.strip_label_comport.Size = new System.Drawing.Size(196, 29);
            this.strip_label_comport.Text = "Disconnected";
            // 
            // strip_lable_response
            // 
            this.strip_lable_response.AutoSize = false;
            this.strip_lable_response.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.strip_lable_response.Font = new System.Drawing.Font("Microsoft JhengHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.strip_lable_response.Name = "strip_lable_response";
            this.strip_lable_response.Size = new System.Drawing.Size(541, 29);
            this.strip_lable_response.Spring = true;
            this.strip_lable_response.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // strip_label_version
            // 
            this.strip_label_version.AutoSize = false;
            this.strip_label_version.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.strip_label_version.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.strip_label_version.Name = "strip_label_version";
            this.strip_label_version.Size = new System.Drawing.Size(200, 29);
            this.strip_label_version.Text = "Ver 2.0.0.0";
            // 
            // Lstbox_batch
            // 
            this.Lstbox_batch.ContextMenuStrip = this.contextMenuStrip1;
            this.Lstbox_batch.FormattingEnabled = true;
            this.Lstbox_batch.ItemHeight = 12;
            this.Lstbox_batch.Location = new System.Drawing.Point(803, 82);
            this.Lstbox_batch.Margin = new System.Windows.Forms.Padding(2);
            this.Lstbox_batch.Name = "Lstbox_batch";
            this.Lstbox_batch.Size = new System.Drawing.Size(135, 220);
            this.Lstbox_batch.TabIndex = 12;
            this.Lstbox_batch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lstbox_batch_MouseDoubleClick);
            this.Lstbox_batch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lstbox_batch_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.dToolStripMenuItem.Text = "Delete";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // Btn_Alloff
            // 
            this.Btn_Alloff.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Alloff.Enabled = false;
            this.Btn_Alloff.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Alloff.Location = new System.Drawing.Point(620, 470);
            this.Btn_Alloff.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Alloff.Name = "Btn_Alloff";
            this.Btn_Alloff.Size = new System.Drawing.Size(167, 40);
            this.Btn_Alloff.TabIndex = 13;
            this.Btn_Alloff.Text = "ALL OFF";
            this.Btn_Alloff.UseVisualStyleBackColor = false;
            this.Btn_Alloff.Click += new System.EventHandler(this.Btn_Alloff_Click);
            // 
            // Cbo_Comport
            // 
            this.Cbo_Comport.BackColor = System.Drawing.SystemColors.Control;
            this.Cbo_Comport.FormattingEnabled = true;
            this.Cbo_Comport.Location = new System.Drawing.Point(4, 17);
            this.Cbo_Comport.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Comport.Name = "Cbo_Comport";
            this.Cbo_Comport.Size = new System.Drawing.Size(160, 20);
            this.Cbo_Comport.TabIndex = 15;
            this.Cbo_Comport.Click += new System.EventHandler(this.Cbo_Comport_Click);
            this.Cbo_Comport.MouseHover += new System.EventHandler(this.Cbo_Comport_MouseHover);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(168, 13);
            this.Btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(95, 26);
            this.Btn_Connect.TabIndex = 16;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Gbx_Comport
            // 
            this.Gbx_Comport.Controls.Add(this.btn_Customize);
            this.Gbx_Comport.Controls.Add(this.btnRescan);
            this.Gbx_Comport.Controls.Add(this.Cbo_Comport);
            this.Gbx_Comport.Controls.Add(this.Btn_Connect);
            this.Gbx_Comport.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gbx_Comport.Location = new System.Drawing.Point(8, 31);
            this.Gbx_Comport.Margin = new System.Windows.Forms.Padding(2);
            this.Gbx_Comport.Name = "Gbx_Comport";
            this.Gbx_Comport.Padding = new System.Windows.Forms.Padding(2);
            this.Gbx_Comport.Size = new System.Drawing.Size(467, 45);
            this.Gbx_Comport.TabIndex = 17;
            this.Gbx_Comport.TabStop = false;
            this.Gbx_Comport.Text = "COM PORT";
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(267, 13);
            this.btnRescan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(95, 26);
            this.btnRescan.TabIndex = 17;
            this.btnRescan.Text = "Rescan";
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // Gbx_Analog
            // 
            this.Gbx_Analog.Controls.Add(this.btn_AnaControll);
            this.Gbx_Analog.Controls.Add(this.btn_AnaAlloff);
            this.Gbx_Analog.Controls.Add(this.btn_AnaAllon);
            this.Gbx_Analog.Controls.Add(this.cbo_Analog);
            this.Gbx_Analog.Location = new System.Drawing.Point(8, 397);
            this.Gbx_Analog.Name = "Gbx_Analog";
            this.Gbx_Analog.Size = new System.Drawing.Size(260, 180);
            this.Gbx_Analog.TabIndex = 18;
            this.Gbx_Analog.TabStop = false;
            this.Gbx_Analog.Text = "Analog Group";
            // 
            // btn_AnaControll
            // 
            this.btn_AnaControll.Location = new System.Drawing.Point(161, 48);
            this.btn_AnaControll.Name = "btn_AnaControll";
            this.btn_AnaControll.Size = new System.Drawing.Size(75, 23);
            this.btn_AnaControll.TabIndex = 3;
            this.btn_AnaControll.Text = "OFF";
            this.btn_AnaControll.UseVisualStyleBackColor = true;
            this.btn_AnaControll.Click += new System.EventHandler(this.btn_AnaControll_Click);
            // 
            // btn_AnaAlloff
            // 
            this.btn_AnaAlloff.Location = new System.Drawing.Point(161, 109);
            this.btn_AnaAlloff.Name = "btn_AnaAlloff";
            this.btn_AnaAlloff.Size = new System.Drawing.Size(75, 35);
            this.btn_AnaAlloff.TabIndex = 2;
            this.btn_AnaAlloff.Text = "ALL OFF";
            this.btn_AnaAlloff.UseVisualStyleBackColor = true;
            this.btn_AnaAlloff.Click += new System.EventHandler(this.btn_AnaAlloff_Click);
            // 
            // btn_AnaAllon
            // 
            this.btn_AnaAllon.Location = new System.Drawing.Point(19, 109);
            this.btn_AnaAllon.Name = "btn_AnaAllon";
            this.btn_AnaAllon.Size = new System.Drawing.Size(75, 35);
            this.btn_AnaAllon.TabIndex = 1;
            this.btn_AnaAllon.Text = "ALL ON";
            this.btn_AnaAllon.UseVisualStyleBackColor = true;
            this.btn_AnaAllon.Click += new System.EventHandler(this.btn_AnaAllon_Click);
            // 
            // cbo_Analog
            // 
            this.cbo_Analog.FormattingEnabled = true;
            this.cbo_Analog.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "A10",
            "A11",
            "A12",
            "A13",
            "A14",
            "A15"});
            this.cbo_Analog.Location = new System.Drawing.Point(19, 48);
            this.cbo_Analog.Name = "cbo_Analog";
            this.cbo_Analog.Size = new System.Drawing.Size(75, 20);
            this.cbo_Analog.TabIndex = 0;
            this.cbo_Analog.SelectedIndexChanged += new System.EventHandler(this.cbo_Analog_SelectedIndexChanged);
            // 
            // Gbx_Digital
            // 
            this.Gbx_Digital.Controls.Add(this.btn_DigControll);
            this.Gbx_Digital.Controls.Add(this.btn_DigAlloff);
            this.Gbx_Digital.Controls.Add(this.btn_DigAllon);
            this.Gbx_Digital.Controls.Add(this.cbo_Digital);
            this.Gbx_Digital.Location = new System.Drawing.Point(314, 397);
            this.Gbx_Digital.Name = "Gbx_Digital";
            this.Gbx_Digital.Size = new System.Drawing.Size(260, 180);
            this.Gbx_Digital.TabIndex = 19;
            this.Gbx_Digital.TabStop = false;
            this.Gbx_Digital.Text = "Digital Group";
            // 
            // btn_DigControll
            // 
            this.btn_DigControll.Location = new System.Drawing.Point(163, 46);
            this.btn_DigControll.Name = "btn_DigControll";
            this.btn_DigControll.Size = new System.Drawing.Size(75, 23);
            this.btn_DigControll.TabIndex = 3;
            this.btn_DigControll.Text = "OFF";
            this.btn_DigControll.UseVisualStyleBackColor = true;
            this.btn_DigControll.Click += new System.EventHandler(this.btn_DigControll_Click);
            // 
            // btn_DigAlloff
            // 
            this.btn_DigAlloff.Location = new System.Drawing.Point(163, 109);
            this.btn_DigAlloff.Name = "btn_DigAlloff";
            this.btn_DigAlloff.Size = new System.Drawing.Size(75, 35);
            this.btn_DigAlloff.TabIndex = 2;
            this.btn_DigAlloff.Text = "ALL OFF";
            this.btn_DigAlloff.UseVisualStyleBackColor = true;
            this.btn_DigAlloff.Click += new System.EventHandler(this.btn_DigAlloff_Click);
            // 
            // btn_DigAllon
            // 
            this.btn_DigAllon.Location = new System.Drawing.Point(27, 109);
            this.btn_DigAllon.Name = "btn_DigAllon";
            this.btn_DigAllon.Size = new System.Drawing.Size(75, 35);
            this.btn_DigAllon.TabIndex = 1;
            this.btn_DigAllon.Text = "ALL ON";
            this.btn_DigAllon.UseVisualStyleBackColor = true;
            this.btn_DigAllon.Click += new System.EventHandler(this.btn_DigAllon_Click);
            // 
            // cbo_Digital
            // 
            this.cbo_Digital.FormattingEnabled = true;
            this.cbo_Digital.Items.AddRange(new object[] {
            "D23",
            "D24",
            "D25",
            "D26",
            "D27",
            "D28",
            "D29",
            "D30",
            "D31",
            "D32",
            "D33",
            "D34",
            "D35",
            "D36",
            "D37",
            "D38",
            "D39",
            "D40",
            "D41",
            "D42",
            "D43",
            "D44",
            "D45",
            "D46",
            "D47",
            "D48",
            "D49",
            "D50",
            "D51",
            "D52",
            "D53"});
            this.cbo_Digital.Location = new System.Drawing.Point(27, 48);
            this.cbo_Digital.Name = "cbo_Digital";
            this.cbo_Digital.Size = new System.Drawing.Size(75, 20);
            this.cbo_Digital.TabIndex = 0;
            this.cbo_Digital.SelectedIndexChanged += new System.EventHandler(this.cbo_Digital_SelectedIndexChanged);
            // 
            // btn_State
            // 
            this.btn_State.BackColor = System.Drawing.Color.LightGray;
            this.btn_State.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_State.Location = new System.Drawing.Point(620, 537);
            this.btn_State.Name = "btn_State";
            this.btn_State.Size = new System.Drawing.Size(167, 40);
            this.btn_State.TabIndex = 20;
            this.btn_State.Text = "STATE";
            this.btn_State.UseVisualStyleBackColor = false;
            this.btn_State.Click += new System.EventHandler(this.Btn_State_Click);
            // 
            // btn_CycleRun
            // 
            this.btn_CycleRun.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CycleRun.Location = new System.Drawing.Point(803, 353);
            this.btn_CycleRun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CycleRun.Name = "btn_CycleRun";
            this.btn_CycleRun.Size = new System.Drawing.Size(135, 39);
            this.btn_CycleRun.TabIndex = 21;
            this.btn_CycleRun.Text = "Cycle Run";
            this.btn_CycleRun.UseVisualStyleBackColor = true;
            this.btn_CycleRun.Click += new System.EventHandler(this.btn_CycleRun_Click);
            // 
            // btn_Customize
            // 
            this.btn_Customize.Location = new System.Drawing.Point(366, 13);
            this.btn_Customize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Customize.Name = "btn_Customize";
            this.btn_Customize.Size = new System.Drawing.Size(95, 26);
            this.btn_Customize.TabIndex = 18;
            this.btn_Customize.Text = "Customize";
            this.btn_Customize.UseVisualStyleBackColor = true;
            this.btn_Customize.Click += new System.EventHandler(this.btn_Customize_Click);
            // 
            // Relay_Board_MEGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(947, 617);
            this.Controls.Add(this.btn_CycleRun);
            this.Controls.Add(this.btn_State);
            this.Controls.Add(this.Gbx_Digital);
            this.Controls.Add(this.Gbx_Analog);
            this.Controls.Add(this.Gbx_Comport);
            this.Controls.Add(this.Btn_Alloff);
            this.Controls.Add(this.Lstbox_batch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_Allon);
            this.Controls.Add(this.btn_batch);
            this.Controls.Add(this.gpb_Layout);
            this.Controls.Add(this.Relay_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Relay_Board_MEGA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relay Board Controller (Arduino MEGA)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relay_Board_Menu_Closing);
            this.Load += new System.EventHandler(this.Relay_Board_MEGA_Load);
            this.Relay_Menu.ResumeLayout(false);
            this.Relay_Menu.PerformLayout();
            this.gpb_Layout.ResumeLayout(false);
            this.gpb_Layout.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Gbx_Comport.ResumeLayout(false);
            this.Gbx_Analog.ResumeLayout(false);
            this.Gbx_Digital.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Relay_Menu;
        private System.Windows.Forms.ToolStripMenuItem strip_menuitem_File;
        private System.Windows.Forms.ToolStripMenuItem strip_menuitem_Open;
        private System.Windows.Forms.ToolStripMenuItem strip_menuitem_Edit;
        private System.Windows.Forms.ToolStripMenuItem strip_menuitem_batchEdit;
        private System.Windows.Forms.GroupBox gpb_Layout;
        private System.Windows.Forms.Button btn_RD_allon;
        private System.Windows.Forms.Button btn_D6;
        private System.Windows.Forms.Button btn_D5;
        private System.Windows.Forms.Button btn_D4;
        private System.Windows.Forms.Button btn_D3;
        private System.Windows.Forms.Button btn_D2;
        private System.Windows.Forms.Button btn_D14;
        private System.Windows.Forms.Label lbl_D14;
        private System.Windows.Forms.Label lbl_D2;
        private System.Windows.Forms.Label lbl_D3;
        private System.Windows.Forms.Label lbl_D4;
        private System.Windows.Forms.Label lbl_D5;
        private System.Windows.Forms.Label lbl_D6;
        private System.Windows.Forms.Button btn_D13;
        private System.Windows.Forms.Button btn_D12;
        private System.Windows.Forms.Button btn_D11;
        private System.Windows.Forms.Button btn_D10;
        private System.Windows.Forms.Button btn_D9;
        private System.Windows.Forms.Button btn_D8;
        private System.Windows.Forms.Label lbl_D8;
        private System.Windows.Forms.Label lbl_D9;
        private System.Windows.Forms.Label lbl_D10;
        private System.Windows.Forms.Label lbl_D11;
        private System.Windows.Forms.Label lbl_D12;
        private System.Windows.Forms.Label lbl_D13;
        private System.Windows.Forms.Button btn_batch;
        private System.Windows.Forms.Button btn_Allon;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel strip_label_comport;
        private System.Windows.Forms.ToolStripStatusLabel strip_lable_response;
        private System.Windows.Forms.ToolStripStatusLabel strip_label_version;
        private System.Windows.Forms.ListBox Lstbox_batch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Button Btn_RD_Alloff;
        private System.Windows.Forms.Button Btn_Alloff;
        private System.Windows.Forms.ComboBox Cbo_Comport;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.GroupBox Gbx_Comport;
        private System.Windows.Forms.Button btn_D22;
        private System.Windows.Forms.Label lbl_D22;
        private System.Windows.Forms.Button btn_D16;
        private System.Windows.Forms.Button btn_D17;
        private System.Windows.Forms.Button btn_D21;
        private System.Windows.Forms.Button btn_D20;
        private System.Windows.Forms.Label lbl_D21;
        private System.Windows.Forms.Button btn_D19;
        private System.Windows.Forms.Label lbl_D20;
        private System.Windows.Forms.Button btn_D18;
        private System.Windows.Forms.Label lbl_D19;
        private System.Windows.Forms.Label lbl_D18;
        private System.Windows.Forms.Label lbl_D17;
        private System.Windows.Forms.Label lbl_D16;
        private System.Windows.Forms.Button btn_D15;
        private System.Windows.Forms.Label lbl_D15;
        private System.Windows.Forms.Button btn_D7;
        private System.Windows.Forms.Label lbl_D7;
        private System.Windows.Forms.GroupBox Gbx_Analog;
        private System.Windows.Forms.GroupBox Gbx_Digital;
        private System.Windows.Forms.ComboBox cbo_Analog;
        private System.Windows.Forms.Button btn_AnaAlloff;
        private System.Windows.Forms.Button btn_AnaAllon;
        private System.Windows.Forms.Button btn_DigAlloff;
        private System.Windows.Forms.Button btn_DigAllon;
        private System.Windows.Forms.ComboBox cbo_Digital;
        private System.Windows.Forms.Button btn_State;
        private System.Windows.Forms.ToolStripMenuItem relayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Strip_MenuItem_ArduinoUNO;
        private System.Windows.Forms.Button btn_AnaControll;
        private System.Windows.Forms.Button btn_DigControll;
        private System.Windows.Forms.ToolTip toolTip_Port;
        private System.Windows.Forms.Button btn_CycleRun;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinoutToolStripMenuItem;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btn_Customize;
    }
}

