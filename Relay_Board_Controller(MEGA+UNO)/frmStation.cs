using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relay_Board_Controller
{
    public partial class frmStation : Form
    {
        public static string strStation;
        public frmStation()
        {
            InitializeComponent();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Station_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strStation = comboBox_Station.SelectedItem.ToString();                  
                Close();
            }
        }

        private void but_OK_Click_1(object sender, EventArgs e)
        {
            strStation = comboBox_Station.SelectedItem.ToString();
            Close();
        }

        private void frmStation_Load(object sender, EventArgs e)
        {
            string[] strRelayType = { "Arduino_UNO", "Arduino_MEGA" };
            for (int i = 0; i < strRelayType.Length; i++)
            {
                comboBox_Station.Items.Add(strRelayType[i]);
            }           
            comboBox_Station.SelectedIndex = 0;
        }
    }
}