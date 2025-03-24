
namespace Relay_Board_Controller
{
    partial class RS232_Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RS232_Setting));
            this.lbl_Comport = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cbo_Comport = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Comport
            // 
            this.lbl_Comport.AutoSize = true;
            this.lbl_Comport.Location = new System.Drawing.Point(35, 55);
            this.lbl_Comport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Comport.Name = "lbl_Comport";
            this.lbl_Comport.Size = new System.Drawing.Size(47, 12);
            this.lbl_Comport.TabIndex = 0;
            this.lbl_Comport.Text = "Comport";
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Connect.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Connect.Location = new System.Drawing.Point(127, 177);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(81, 30);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cbo_Comport
            // 
            this.cbo_Comport.BackColor = System.Drawing.SystemColors.Control;
            this.cbo_Comport.FormattingEnabled = true;
            this.cbo_Comport.Location = new System.Drawing.Point(127, 53);
            this.cbo_Comport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_Comport.Name = "cbo_Comport";
            this.cbo_Comport.Size = new System.Drawing.Size(82, 20);
            this.cbo_Comport.TabIndex = 5;
            // 
            // RS232_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(239, 235);
            this.Controls.Add(this.cbo_Comport);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lbl_Comport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RS232_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS232 Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Comport;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox cbo_Comport;
    }
}