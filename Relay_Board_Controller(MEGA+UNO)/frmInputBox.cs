using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relay_Board_Controller
{
    public partial class frmInputBox : Form
    {
        public static string strCOMPort_name = string.Empty;
        public static bool bCheck_Cancel;

        public frmInputBox()
        {
            InitializeComponent();
            strCOMPort_name = string.Empty;
            bCheck_Cancel = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            strCOMPort_name = txt_COMPort.Text;
            bCheck_Cancel = false;
            this.Close();
        }

        private void frmInputBox_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
