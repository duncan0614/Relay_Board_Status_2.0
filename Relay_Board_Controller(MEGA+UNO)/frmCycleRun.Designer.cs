
namespace Relay_Board_Controller
{
    partial class frmCycleRun
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
            if (disposing && (components != null)) {
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
            this.txtCycletimes = new System.Windows.Forms.TextBox();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_Cycletimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCycletimes
            // 
            this.txtCycletimes.Location = new System.Drawing.Point(179, 50);
            this.txtCycletimes.Name = "txtCycletimes";
            this.txtCycletimes.Size = new System.Drawing.Size(49, 22);
            this.txtCycletimes.TabIndex = 0;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Confirm.Location = new System.Drawing.Point(97, 93);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(100, 50);
            this.Btn_Confirm.TabIndex = 1;
            this.Btn_Confirm.Text = "確認";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // lbl_Cycletimes
            // 
            this.lbl_Cycletimes.AutoSize = true;
            this.lbl_Cycletimes.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Cycletimes.Location = new System.Drawing.Point(25, 51);
            this.lbl_Cycletimes.Name = "lbl_Cycletimes";
            this.lbl_Cycletimes.Size = new System.Drawing.Size(148, 19);
            this.lbl_Cycletimes.TabIndex = 2;
            this.lbl_Cycletimes.Text = "Cycle Run 次數：";
            // 
            // frmCycleRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 172);
            this.Controls.Add(this.lbl_Cycletimes);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.txtCycletimes);
            this.Name = "frmCycleRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCycletimes;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Label lbl_Cycletimes;
    }
}