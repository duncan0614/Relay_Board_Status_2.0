﻿using System;
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
    public partial class frmPic : Form
    {
        string strLoaclPath = System.IO.Directory.GetCurrentDirectory();
        public frmPic()
        {
            InitializeComponent();

            if (frmStation.strStation == "Arduino_UNO") {
                pictureBox1.Image = Properties.Resources.Uno0;
            }
            else if (frmStation.strStation == "Arduino_MEGA") {
                pictureBox1.Image = Properties.Resources.Mega0;
            }
        }
    }
}
