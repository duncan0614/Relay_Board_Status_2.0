
namespace Relay_Board_Controller
{
    partial class Batch_Edit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batch_Edit));
            this.Batch_Menu = new System.Windows.Forms.MenuStrip();
            this.Batch_MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Batch_MenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Batch_MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Batch_MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Batch_MenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Gpb_Data = new System.Windows.Forms.GroupBox();
            this.GridV_Batch = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridVeiw_Relay = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GridVeiw_Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GridVeiw_DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContMenu_batch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Lstb_batchname = new System.Windows.Forms.ListBox();
            this.ContMenu_listbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Filename = new System.Windows.Forms.Label();
            this.Batch_Menu.SuspendLayout();
            this.Gpb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridV_Batch)).BeginInit();
            this.ContMenu_batch.SuspendLayout();
            this.ContMenu_listbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Batch_Menu
            // 
            this.Batch_Menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Batch_Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Batch_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Batch_MenuItem_File});
            this.Batch_Menu.Location = new System.Drawing.Point(0, 0);
            this.Batch_Menu.Name = "Batch_Menu";
            this.Batch_Menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.Batch_Menu.Size = new System.Drawing.Size(509, 24);
            this.Batch_Menu.TabIndex = 0;
            this.Batch_Menu.Text = "Batch Menu";
            // 
            // Batch_MenuItem_File
            // 
            this.Batch_MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Batch_MenuItem_New,
            this.Batch_MenuItem_Open,
            this.Batch_MenuItem_Save,
            this.Batch_MenuItem_SaveAs});
            this.Batch_MenuItem_File.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Batch_MenuItem_File.Name = "Batch_MenuItem_File";
            this.Batch_MenuItem_File.Size = new System.Drawing.Size(38, 22);
            this.Batch_MenuItem_File.Text = "File";
            // 
            // Batch_MenuItem_New
            // 
            this.Batch_MenuItem_New.Name = "Batch_MenuItem_New";
            this.Batch_MenuItem_New.Size = new System.Drawing.Size(122, 22);
            this.Batch_MenuItem_New.Text = "New File";
            this.Batch_MenuItem_New.Click += new System.EventHandler(this.Batch_MenuItem_New_Click);
            // 
            // Batch_MenuItem_Open
            // 
            this.Batch_MenuItem_Open.Name = "Batch_MenuItem_Open";
            this.Batch_MenuItem_Open.Size = new System.Drawing.Size(122, 22);
            this.Batch_MenuItem_Open.Text = "Open";
            this.Batch_MenuItem_Open.Click += new System.EventHandler(this.Batch_MenuItem_Open_Click);
            // 
            // Batch_MenuItem_Save
            // 
            this.Batch_MenuItem_Save.Name = "Batch_MenuItem_Save";
            this.Batch_MenuItem_Save.Size = new System.Drawing.Size(122, 22);
            this.Batch_MenuItem_Save.Text = "Save";
            this.Batch_MenuItem_Save.Click += new System.EventHandler(this.Batch_MenuItem_Save_Click);
            // 
            // Batch_MenuItem_SaveAs
            // 
            this.Batch_MenuItem_SaveAs.Name = "Batch_MenuItem_SaveAs";
            this.Batch_MenuItem_SaveAs.Size = new System.Drawing.Size(122, 22);
            this.Batch_MenuItem_SaveAs.Text = "Save As";
            this.Batch_MenuItem_SaveAs.Click += new System.EventHandler(this.Batch_MenuItem_SaveAs_Click);
            // 
            // Gpb_Data
            // 
            this.Gpb_Data.Controls.Add(this.GridV_Batch);
            this.Gpb_Data.Location = new System.Drawing.Point(8, 37);
            this.Gpb_Data.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_Data.Name = "Gpb_Data";
            this.Gpb_Data.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_Data.Size = new System.Drawing.Size(321, 254);
            this.Gpb_Data.TabIndex = 2;
            this.Gpb_Data.TabStop = false;
            this.Gpb_Data.Text = "DATA";
            // 
            // GridV_Batch
            // 
            this.GridV_Batch.AllowUserToAddRows = false;
            this.GridV_Batch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridV_Batch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.GridV_Batch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridV_Batch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.GridVeiw_Relay,
            this.GridVeiw_Status,
            this.GridVeiw_DelayTime});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridV_Batch.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridV_Batch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridV_Batch.Location = new System.Drawing.Point(4, 19);
            this.GridV_Batch.Margin = new System.Windows.Forms.Padding(2);
            this.GridV_Batch.Name = "GridV_Batch";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridV_Batch.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridV_Batch.RowHeadersVisible = false;
            this.GridV_Batch.RowHeadersWidth = 62;
            this.GridV_Batch.RowTemplate.Height = 31;
            this.GridV_Batch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridV_Batch.Size = new System.Drawing.Size(313, 231);
            this.GridV_Batch.TabIndex = 0;
            this.GridV_Batch.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridV_Batch_CellEndEdit);
            this.GridV_Batch.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridV_Batch_CellMouseDown);
            this.GridV_Batch.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridV_Batch_CellValueChanged);
            this.GridV_Batch.CurrentCellDirtyStateChanged += new System.EventHandler(this.GridV_Batch_CurrentCellDirtyStateChanged);
            this.GridV_Batch.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GridV_Batch_EditingControlShowing);
            this.GridV_Batch.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridV_Batch_RowsAdded);
            this.GridV_Batch.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridV_Batch_RowsRemoved);
            this.GridV_Batch.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GridV_Batch_UserDeletingRow);
            this.GridV_Batch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridV_Batch_MouseDown);
            // 
            // No
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.No.DefaultCellStyle = dataGridViewCellStyle1;
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 8;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 50;
            // 
            // GridVeiw_Relay
            // 
            dataGridViewCellStyle2.NullValue = "--Select--";
            this.GridVeiw_Relay.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridVeiw_Relay.HeaderText = "Relay";
            this.GridVeiw_Relay.MinimumWidth = 8;
            this.GridVeiw_Relay.Name = "GridVeiw_Relay";
            this.GridVeiw_Relay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVeiw_Relay.Width = 80;
            // 
            // GridVeiw_Status
            // 
            dataGridViewCellStyle3.NullValue = "--Select--";
            this.GridVeiw_Status.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridVeiw_Status.HeaderText = "Status";
            this.GridVeiw_Status.Items.AddRange(new object[] {
            "--Select--",
            "ON",
            "OFF"});
            this.GridVeiw_Status.MinimumWidth = 8;
            this.GridVeiw_Status.Name = "GridVeiw_Status";
            this.GridVeiw_Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVeiw_Status.Width = 80;
            // 
            // GridVeiw_DelayTime
            // 
            this.GridVeiw_DelayTime.HeaderText = "Delay Time (s)";
            this.GridVeiw_DelayTime.MaxInputLength = 4;
            this.GridVeiw_DelayTime.MinimumWidth = 8;
            this.GridVeiw_DelayTime.Name = "GridVeiw_DelayTime";
            this.GridVeiw_DelayTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVeiw_DelayTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GridVeiw_DelayTime.Width = 150;
            // 
            // ContMenu_batch
            // 
            this.ContMenu_batch.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContMenu_batch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.ContMenu_batch.Name = "ContMenu_batch";
            this.ContMenu_batch.Size = new System.Drawing.Size(112, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(265, 295);
            this.Btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(50, 21);
            this.Btn_Create.TabIndex = 4;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(201, 295);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(50, 21);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Lstb_batchname
            // 
            this.Lstb_batchname.FormattingEnabled = true;
            this.Lstb_batchname.ItemHeight = 12;
            this.Lstb_batchname.Location = new System.Drawing.Point(361, 67);
            this.Lstb_batchname.Margin = new System.Windows.Forms.Padding(2);
            this.Lstb_batchname.Name = "Lstb_batchname";
            this.Lstb_batchname.Size = new System.Drawing.Size(134, 256);
            this.Lstb_batchname.TabIndex = 7;
            this.Lstb_batchname.SelectedIndexChanged += new System.EventHandler(this.Lstb_batchname_SelectedIndexChanged);
            this.Lstb_batchname.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lstb_batchname_MouseDoubleClick);
            this.Lstb_batchname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lstb_batchname_MouseDown);
            // 
            // ContMenu_listbox
            // 
            this.ContMenu_listbox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContMenu_listbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.ContMenu_listbox.Name = "ContMenu_listbox";
            this.ContMenu_listbox.Size = new System.Drawing.Size(122, 92);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // Lbl_Filename
            // 
            this.Lbl_Filename.AutoSize = true;
            this.Lbl_Filename.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Filename.Location = new System.Drawing.Point(358, 43);
            this.Lbl_Filename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Filename.Name = "Lbl_Filename";
            this.Lbl_Filename.Size = new System.Drawing.Size(63, 14);
            this.Lbl_Filename.TabIndex = 8;
            this.Lbl_Filename.Text = "NO FILE";
            // 
            // Batch_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 336);
            this.Controls.Add(this.Lbl_Filename);
            this.Controls.Add(this.Lstb_batchname);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Gpb_Data);
            this.Controls.Add(this.Batch_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Batch_Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Batch_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Edit";
            this.Shown += new System.EventHandler(this.Batch_Edit_Shown);
            this.Batch_Menu.ResumeLayout(false);
            this.Batch_Menu.PerformLayout();
            this.Gpb_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridV_Batch)).EndInit();
            this.ContMenu_batch.ResumeLayout(false);
            this.ContMenu_listbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Batch_Menu;
        private System.Windows.Forms.ToolStripMenuItem Batch_MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem Batch_MenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem Batch_MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem Batch_MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem Batch_MenuItem_SaveAs;
        private System.Windows.Forms.GroupBox Gpb_Data;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.DataGridView GridV_Batch;
        private System.Windows.Forms.ListBox Lstb_batchname;
        private System.Windows.Forms.ContextMenuStrip ContMenu_batch;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContMenu_listbox;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridVeiw_Relay;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridVeiw_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridVeiw_DelayTime;
        private System.Windows.Forms.Label Lbl_Filename;
    }
}