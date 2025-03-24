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
    public partial class frmCycleRun : Form
    {
        public static int Cycletimes;
        public frmCycleRun()
        {
            InitializeComponent();
            Cycletimes = 0;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            int i;
            string strCycleTimes = txtCycletimes.Text;
            bool tryparse = int.TryParse(strCycleTimes, out i);
            if ( tryparse && !string.IsNullOrEmpty(strCycleTimes)) {
                if (int.Parse(strCycleTimes) > 0 && int.Parse(strCycleTimes) <= 1000) {
                    Cycletimes = int.Parse(strCycleTimes);
                    Close();
                }
                else {
                    MessageBox.Show("The number cannot smaller than 1 time or bigger than 1000 times.");
                    return;
                }
            }               
            else {
                MessageBox.Show("Please enter number.");
                return;
            }
        }
    }
}
