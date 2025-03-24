
namespace Relay_Board_Controller
{
    partial class Inputbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inputbox));
            this.Lbl_Content = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Txt_input = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_Content
            // 
            this.Lbl_Content.AutoSize = true;
            this.Lbl_Content.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Content.Location = new System.Drawing.Point(11, 22);
            this.Lbl_Content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Content.Name = "Lbl_Content";
            this.Lbl_Content.Size = new System.Drawing.Size(46, 16);
            this.Lbl_Content.TabIndex = 0;
            this.Lbl_Content.Text = "label1";
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(271, 22);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(67, 33);
            this.Btn_Confirm.TabIndex = 1;
            this.Btn_Confirm.Text = "確認";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(271, 96);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(67, 33);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Txt_input
            // 
            this.Txt_input.Location = new System.Drawing.Point(21, 139);
            this.Txt_input.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_input.Name = "Txt_input";
            this.Txt_input.Size = new System.Drawing.Size(227, 22);
            this.Txt_input.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "勾選後不再提示";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Inputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 171);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Txt_input);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Lbl_Content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Inputbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inputbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inputbox_Closing);
            this.Load += new System.EventHandler(this.Inputbox_Load);
            this.Shown += new System.EventHandler(this.Inputbox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Content;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox Txt_input;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}