namespace Relay_Board_Controller
{
    partial class frmStation
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Station = new System.Windows.Forms.ComboBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Station
            // 
            this.comboBox_Station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Station.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Station.FormattingEnabled = true;
            this.comboBox_Station.Location = new System.Drawing.Point(19, 12);
            this.comboBox_Station.Name = "comboBox_Station";
            this.comboBox_Station.Size = new System.Drawing.Size(213, 27);
            this.comboBox_Station.TabIndex = 0;
            this.comboBox_Station.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Station_KeyDown);
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_cancel.Location = new System.Drawing.Point(137, 54);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(69, 27);
            this.but_cancel.TabIndex = 11;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_OK
            // 
            this.but_OK.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_OK.Location = new System.Drawing.Point(41, 54);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(69, 27);
            this.but_OK.TabIndex = 10;
            this.but_OK.Text = "OK";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click_1);
            // 
            // frmStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 95);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.comboBox_Station);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimizeBox = false;
            this.Name = "frmStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStation";
            this.Load += new System.EventHandler(this.frmStation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Station;
        internal System.Windows.Forms.Button but_cancel;
        internal System.Windows.Forms.Button but_OK;
    }
}