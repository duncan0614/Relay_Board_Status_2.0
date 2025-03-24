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
    public partial class Inputbox : Form
    {
        public static string Input_content = "";
        public static bool Cancelornot = false;
        public static int Inputbox_item;
        public static string Batch_name;
        private bool bHint;

        public Inputbox()
        {
            InitializeComponent();
                       
            Cancelornot = false;
        }

        public void Inputbox_Load(object sender, EventArgs e)
        {
            if (Inputbox_item == 1) //重新命名
            {
                checkBox1.Hide();
                this.Text = "Rename batch";
                Lbl_Content.Text = "Previous batch name:" + Batch_name;
                Txt_input.Text = Batch_name + "(1)";
            }
            else if (Inputbox_item == 2)    //創建新檔
            {
                checkBox1.Hide();
                this.Text = "Create New batch";
                Lbl_Content.Text = "New batch Name:";
                Txt_input.Text = frmStation.strStation + "_NewTest";
            }
            else if (Inputbox_item == 3)    //複製檔案
            {
                checkBox1.Hide();
                this.Text = "Create New Batch";
                Lbl_Content.Text = "Copy batch name:" + Batch_name;
                Txt_input.Text = Batch_name + "(Copy)";
            }
            else if (Inputbox_item == 4) {
                Txt_input.Hide();
                Btn_Cancel.Hide();
                Lbl_Content.Text = "(＊)標示星號的腳位代表剛接上電時\n此腳位訊號會有浮動。";
                this.Text = "Warning";
                this.Size = new System.Drawing.Size(365, 130);
            }
        }

        public void Inputbox_Closing(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                bHint = true;              
                Properties.Settings.Default.Hint = bHint;
                Properties.Settings.Default.Save();
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (Inputbox_item != 4)
                Input_content = Txt_input.Text;
            Cancelornot = true;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancelornot = false;
            this.Close();
        }

        private void Inputbox_Shown(object sender, EventArgs e)
        {
            Txt_input.Focus();
        }
    }
}
