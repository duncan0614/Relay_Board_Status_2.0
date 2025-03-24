using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Relay_Board_Controller
{
    // public string Input_filename = null;
    
    public partial class Batch_Edit : System.Windows.Forms.Form
    {
        readonly RelayItems Ri2;
        readonly SaveFileDialog sf = new SaveFileDialog();
        string Copy_content = null;
        private string Listbox_Copy_Value = null;
        private bool Listbox_copyornot = false;
        bool DGV_paste = false;
        bool Saveornot = false;

        private Thread invokeThread;
        private DialogResult result;


        public Batch_Edit()
        {
            InitializeComponent();   
        }
        public Batch_Edit(RelayItems RI)
        {
            InitializeComponent();

            Ri2 = RI;

            Btn_Update.Enabled = false;          

            //根據Relay型號加入不同Item
            if (frmStation.strStation == "Arduino_UNO")
            {
                string[] strUNO = { "--Select--", "A0", "A1", "A2", "A3", "A4", "A5", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10", "D11", "D12", "D13" };
                for (int i = 0; i < strUNO.Length; i++)
                {
                    GridVeiw_Relay.Items.Add(strUNO[i]);
                }           
            }
            else if (frmStation.strStation == "Arduino_MEGA")
            {
                //處理Mega Relay資料
                List<string> Mega = new List<string>();
                Mega.Add("--Select--");
                for (int i = 0; i < 16; i++)
                {
                    Mega.Add("A" + i.ToString());
                }
                for (int i = 2; i < 54; i++)
                {
                    Mega.Add("D" + i.ToString());
                }
                
                for (int i = 0; i < Mega.Count; i++)
                {
                    GridVeiw_Relay.Items.Add(Mega[i]);
                }
            }

            if (Ri2.dict.Count > 0)
            {
                //SortedDictionary<string, string>.KeyCollection keyColl = Ri2.dict.Keys;
                foreach (var item in Ri2.Listbox_items)
                {
                    Lstb_batchname.Items.Add(item);
                }
                string Getfilename = Path.GetFileName(Ri2.dialog.FileName);
                if (Getfilename.Length > 20)
                {
                    Getfilename = Getfilename.Substring(0, 17);
                    Lbl_Filename.Text = Getfilename + "...";
                }
                else
                {
                    Lbl_Filename.Text = Getfilename;
                }
            }
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Batch_Edit_Closing);
            this.Load += new EventHandler(this.Batch_Edit_Load);
            GridV_Batch.Rows.Add();
        }
        public void Batch_Edit_Load(object sender, EventArgs e)
        {
            if (Lstb_batchname.Items.Count > 0)
            {
                string json = Ri2.dict[Lstb_batchname.Items[0].ToString()];
                JArray array = JsonConvert.DeserializeObject<JArray>(json);
                int i = 0;
                GridV_Batch.Rows.Clear();

                foreach (JObject Jobj in array)
                {
                    GridV_Batch.Rows.Add();

                    string ans = Jobj["Relay"].ToString();
                    GridV_Batch.Rows[i].Cells[1].Value = ans;
                    ans = Jobj["Status"].ToString();
                    GridV_Batch.Rows[i].Cells[2].Value = ans;
                    ans = Jobj["Delay Time (s)"].ToString();
                    GridV_Batch.Rows[i].Cells[3].Value = ans;
                    i += 1;
                }
            }
            
        }
        public void Batch_Edit_Closing(object sender, EventArgs e)
        {
            //string Fn = Ri2.dialog.FileName;
            //Fn = sf.FileName;

            DialogResult result;

            if (Lstb_batchname.Items.Count < 1)
            {
                return;
            }
            Ri2.Listbox_items.Clear();
            foreach (var item in Lstb_batchname.Items)
            {
                Ri2.Listbox_items.Add(item);
            }

            if (Saveornot == true)
            {
                result = MessageBox.Show("Do you want to save your file?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Savefile();
                }
                if (result == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void Batch_Edit_Shown(object sender, EventArgs e)
        {
            if (Lstb_batchname.Items.Count > 0)
            {
                Lstb_batchname.SelectedIndex = 0;
            }
        }
        private void Batch_MenuItem_Open_Click(object sender, EventArgs e)  //Open File
        {
            try
            {
                if (Saveornot == true)
                {
                    string Fn = Ri2.dialog.FileName;
                    DialogResult dialogresult;
                    if (Lstb_batchname.Items.Count > 0)
                    {
                        dialogresult = MessageBox.Show("Do you want to save your file?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogresult == DialogResult.Yes)
                        {
                            Savefile();
                        }
                    }
                }              

                Ri2.dialog.Multiselect = false;      //該值確定是否可以選擇多個檔案
                Ri2.dialog.Title = "Open File";
                Ri2.dialog.Filter = "Json files (*.json)|*.json";
                invokeThread = new Thread(new ThreadStart(InvokeMethod));
                invokeThread.SetApartmentState(ApartmentState.STA);
                invokeThread.Start();
                invokeThread.Join();

                Ri2.dict.Clear();
                Lstb_batchname.Items.Clear();
                string Json_content = null;

                if (result == DialogResult.OK)
                {
                    using (StreamReader sw = new StreamReader(Ri2.dialog.FileName))
                    {
                        Json_content = sw.ReadToEnd();
                    }
                    string[] Spilt1 = Json_content.Split(';');

                    for (int i = 0; i < Spilt1.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            string key = Spilt1[i];
                            Ri2.dict.Add(key, Spilt1[i + 1]);
                            Lstb_batchname.Items.Add(key);
                        }
                    }
                    string Getfilename = Path.GetFileName(Ri2.dialog.FileName);
                    if (Getfilename.Length > 20)
                    {
                        Getfilename = Getfilename.Substring(0, 17);
                        Lbl_Filename.Text = Getfilename + "...";
                    }
                    else
                    {
                        Lbl_Filename.Text = Getfilename;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Same batch name or file already opened.", "Warning!");
            }
        }
        private void InvokeMethod()
        {
            result = Ri2.dialog.ShowDialog();
        }
        private void Batch_MenuItem_New_Click(object sender, EventArgs e)  //New File
        {
            GridV_Batch.Rows.Clear();
            GridV_Batch.Rows.Add();
            Lbl_Filename.Text = "FileName:Untitled";
            Lstb_batchname.Items.Clear();
            Ri2.dict.Clear();
            Ri2.dialog.FileName = "";
        }
        private void Batch_MenuItem_Save_Click(object sender, EventArgs e)  //存檔
        {
            string Fn = Ri2.dialog.FileName;

            if (System.IO.File.Exists(Fn))
            {
                string str = null;

                for (int i = 0; i < Lstb_batchname.Items.Count; i++)
                {
                    string key = Lstb_batchname.Items[i].ToString();
                    str += ";" + key + ";" + Ri2.dict[key];
                }
                sf.FileName = Ri2.dialog.FileName;

                File.WriteAllText(sf.FileName, str);

                string Getfilename = Path.GetFileName(sf.FileName);
                if (Getfilename.Length > 20)
                {
                    Getfilename = Getfilename.Substring(0, 17);
                    Lbl_Filename.Text = Getfilename + "...";
                }
                else
                {
                    Lbl_Filename.Text = Getfilename;
                }
            }
            else
            {
                Savefile();
            }
            Saveornot = false;
        }
        private void Batch_MenuItem_SaveAs_Click(object sender, EventArgs e)  //另存新檔
        {
            Savefile();
            Saveornot = false;
        }
        public void Savefile()  //Save File
        {
            string str = null;

            for (int i = 0; i < Lstb_batchname.Items.Count; i++)
            {
                string key = Lstb_batchname.Items[i].ToString();
                str += ";" + key + ";" + Ri2.dict[key];
            }
            sf.Filter = "Json files (*.json)|*.json";
            sf.FileName = "Test01";
            sf.FilterIndex = 2;
            sf.RestoreDirectory = true;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                //@"D:\workbase\test\Relay_Board_Status\Relay_Board_Status\bin\Debug\test.json"
                //File.WriteAllText(sf.FileName, str);
                Ri2.dialog.FileName = sf.FileName;

                using (StreamWriter sw = new StreamWriter(sf.FileName))
                {
                    sw.Write(str);
                }

                //MessageBox.Show("Success!");
                string Getfilename = Path.GetFileName(sf.FileName);
                if (Getfilename.Length > 20)
                {
                    Getfilename = Getfilename.Substring(0, 17);
                    Lbl_Filename.Text = Getfilename + "...";
                }
                else
                {
                    Lbl_Filename.Text = Getfilename;
                }
            }

        }
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridV_Batch.Rows.Count == 1)
                {
                    MessageBox.Show("Your data is empty.", "Warning!");
                    return;
                }
                for (int i = 0; i < GridV_Batch.Rows.Count-1; i++)
                {
                    if (GridV_Batch.Rows[i].Cells[1].Value == null || GridV_Batch.Rows[i].Cells[2].Value == null)
                    {
                        MessageBox.Show("Every rows' relay cannot be empty! Please select relay name.", "Warning!");
                        return;
                    }
                    if (GridV_Batch.Rows[i].Cells[1].Value.ToString() == "--Select--" || GridV_Batch.Rows[i].Cells[2].Value.ToString() == "--Select--")
                    {
                        MessageBox.Show("Every rows' relay cannot be empty! Please select relay name.", "Warning!");
                        return;
                    }
                }

                DataTable Datatable_batch = new DataTable();

                Inputbox.Inputbox_item = 2;
                System.Windows.Forms.Form f4 = new Inputbox();
                f4.ShowDialog();

                //Input_filename = Interaction.InputBox("New batch Name", "Create new batch", "NewTest", -1, -1);
                if (Inputbox.Cancelornot == false)
                {
                    return;
                }
                if (string.IsNullOrEmpty(Inputbox.Input_content))
                {
                    MessageBox.Show("File name cannot be empty.", "Warning!");
                    return;
                }
                else if (Lstb_batchname.Items.Contains(Inputbox.Input_content))
                {
                    MessageBox.Show("Same batch name", "Warning!");
                    return;
                }

                Datatable_batch = new DataTable(Inputbox.Input_content);
                string json = GetDgvToTable(GridV_Batch);

                // Datatable_batch = new DataTable(Input_filename);
                // json= "{ \"" + Input_filename + "\":  " + json + "}";
                // JObject iobj = JObject.Parse(json);

                Ri2.dict.Add(Inputbox.Input_content, json);
                Lstb_batchname.Items.Add(Inputbox.Input_content);
                GridV_Batch.Rows.Clear();
                GridV_Batch.Rows.Add();
            }
            catch (Exception)
            {
                MessageBox.Show("Same batch name.", "Warning!");
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (GridV_Batch.Rows.Count == 1)
            {
                MessageBox.Show("Your data is empty.", "Warning!");
                return;
            }
            int count = 0;
            for (int i = 0; i < GridV_Batch.Rows.Count - 1; i++)
            {
                if (GridV_Batch.Rows[i].Cells[1].Value == null || GridV_Batch.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Every rows' relay cannot be empty. Please select relay name.", "Warning!");
                    return;
                }
                if (GridV_Batch.Rows[i].Cells[1].Value.ToString() == "--Select--" || GridV_Batch.Rows[i].Cells[2].Value.ToString() == "--Select--")
                {
                    MessageBox.Show("Every rows' relay cannot be empty. Please select relay name.", "Warning!");
                    return;
                }
            }
            if (count != 0)
            {
                MessageBox.Show("Every rows' relay cannot be empty. Please select relay name.", "Warning!");
                return;
            }

            string json = GetDgvToTable(GridV_Batch);
            string Input_filename = Lstb_batchname.SelectedItem.ToString();
            Ri2.dict[Input_filename] = json;
            GridV_Batch.Rows.Clear();
            GridV_Batch.Rows.Add();
        }
        
        #region --Datagridview to Datatable to Json--
        public string GetDgvToTable(DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();

                // 列強制轉換

                for (int count = 0; count < dgv.Columns.Count; count++)
                {
                    DataColumn dc = new DataColumn(dgv.Columns[count].HeaderText);

                    dt.Columns.Add(dc);
                }
                // 循環行

                for (int count = 0; count < dgv.Rows.Count - 1; count++)
                {
                    DataRow dr = dt.NewRow();
                    if (dgv.Rows[count].Cells[3].Value == null)
                    {
                        dgv.Rows[count].Cells[3].Value = "0";
                    }
                    for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                    {
                        
                        dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                    }
                    dt.Rows.Add(dr);
                }
                string str_dt = DataTableToJSONWithJSONNet(dt);

                return str_dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Key value in the form.", "Warning!");

                return "";
            }

        }
        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }
        public string DataTableToJson(string jsonName, DataTable DataTableTojson)
        {
            StringBuilder Json = new StringBuilder();

            Json.Append("{\"" + jsonName + "\":[");

            if (DataTableTojson.Rows.Count > 0)
            {
                for (int i = 0; i < DataTableTojson.Rows.Count; i++)
                {
                    Json.Append("{");

                    for (int j = 0; j < DataTableTojson.Columns.Count; j++)
                    {
                        Json.Append("\"" + DataTableTojson.Columns[j].ColumnName.ToString() + "\":\"" + DataTableTojson.Rows[i][j].ToString() + "\"");

                        if (j < DataTableTojson.Columns.Count - 1)
                        {
                            Json.Append(",");
                        }
                    }
                    Json.Append("}");

                    if (i < DataTableTojson.Rows.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("]}");

            return Json.ToString();
        }
        #endregion

        private void Lstb_batchname_SelectedIndexChanged(object sender, EventArgs e)  //根據listbox selectedindex，datagridview要做改變
        {
            Btn_Update.Enabled = true;

            if (Lstb_batchname.SelectedIndex < 0)
            {
                return;
            }
            String key = Lstb_batchname.SelectedItem.ToString();

            if (!Ri2.dict.ContainsKey(key))
            {
                return;
            }

            string json = Ri2.dict[key];

            // string str = json.ToString();
            // var result = JsonConvert.DeserializeObject<List<JsonResult>>(json);
            //DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            JArray array = JsonConvert.DeserializeObject<JArray>(json);

            var ans = "";

            int i = 0;

            GridV_Batch.Rows.Clear();

            try {
                foreach (JObject Jobj in array) {
                    GridV_Batch.Rows.Add();
                    ans = Jobj["Relay"].ToString();
                    //因為UNO版只有到D13，預防Json檔有設定Mega的Relay
                    if (frmStation.strStation == "Arduino_UNO" && int.Parse(ans.Substring(1)) > 13) {
                        MessageBox.Show("此json檔有不存在的Relay Name");
                        return;
                    }
                    GridV_Batch.Rows[i].Cells[1].Value = ans;
                    ans = Jobj["Status"].ToString();
                    GridV_Batch.Rows[i].Cells[2].Value = ans;
                    ans = Jobj["Delay Time (s)"].ToString();
                    GridV_Batch.Rows[i].Cells[3].Value = ans;
                    i += 1;
                }
            }
            catch(Exception) {
                MessageBox.Show("此json檔有不存在的Relay Name");
                return;
            }
        }

        #region --datagridview mouse right click event--
        private void GridV_Batch_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) //滑鼠右鍵
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0)
                    {
                        GridV_Batch.ClearSelection();
                        GridV_Batch.Rows[e.RowIndex].Selected = true;
                        Point point = new Point(e.X, e.Y);
                        if ( e.RowIndex == 0 )
                        {
                            if(GridV_Batch[1,e.RowIndex].Value == null)
                            {
                                copyToolStripMenuItem.Enabled = false;
                                deleteToolStripMenuItem.Enabled = false;
                            }
                            if (GridV_Batch[1, e.RowIndex].Value != null)
                            {
                                deleteToolStripMenuItem.Enabled = true;
                                copyToolStripMenuItem.Enabled = true;
                            }                           
                            pasteToolStripMenuItem.Enabled = false;
                        }
                        else if(e.RowIndex == GridV_Batch.Rows.Count -1)
                        {
                            deleteToolStripMenuItem.Enabled = false;
                            copyToolStripMenuItem.Enabled = false;
                        }
                        else
                        {
                            deleteToolStripMenuItem.Enabled = true;
                            insertToolStripMenuItem.Enabled = true;
                            copyToolStripMenuItem.Enabled = true;
                            pasteToolStripMenuItem.Enabled = false;
                        }
                        if(DGV_paste == true)
                        {
                            pasteToolStripMenuItem.Enabled = true;
                        }
                        ContMenu_batch.Show(MousePosition.X, MousePosition.Y);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Choose the content.", "Warning!");
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.GridV_Batch.SelectedRows)
            {
                {
                    if (!row.IsNewRow)
                    {
                        this.GridV_Batch.Rows.Remove(row);
                    }
                }
            }
        }
        private void GridV_Batch_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow startingBalanceRow = GridV_Batch.Rows[GridV_Batch.Rows.Count - 1];

            if (GridV_Batch.SelectedRows.Contains(startingBalanceRow))
            {
                e.Cancel = true;
            }
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridViewRow examplerow = GridV_Batch.Rows[GridV_Batch.Rows.Count - 1];
            int Rowindex = GridV_Batch.CurrentCell.RowIndex;

            GridV_Batch.Rows.Insert(Rowindex, new DataGridViewRow());
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GridV_Batch.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(GridV_Batch.GetClipboardContent());

                    Copy_content = Clipboard.GetText();

                    DGV_paste = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Copy failed.", "Warning!");
                }
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GridV_Batch.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    string[] Paste_content = Copy_content.Split('\t');

                    int i = 0;

                    int Rowindex = GridV_Batch.CurrentRow.Index;

                    foreach (string str in Paste_content)
                    {
                        if (i != 0)
                        {
                            GridV_Batch.Rows[Rowindex].Cells[i].Value = str;
                        }
                        i++;
                    }
                    GridV_Batch.CurrentCell = null;
                    GridV_Batch.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Paste failed.", "Warning!");
                }
            }
        }
        private void GridV_Batch_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 1; i < GridV_Batch.Rows.Count + 1; i++)
            {
                object obj = i;
                GridV_Batch[0, i-1].Value = obj;
            }
            //GridV_Batch[1, GridV_Batch.Rows.Count - 1].Value = "Select";
            //GridV_Batch[2, GridV_Batch.Rows.Count - 1].Value = "ON";
            //GridV_Batch[3, GridV_Batch.Rows.Count - 1].Value = "0";
        }
        private void GridV_Batch_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 1; i < GridV_Batch.Rows.Count + 1; i++)
            {
                object obj = i;
                GridV_Batch[0, i - 1].Value = obj;
            }
        }
        private void GridV_Batch_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3))
                {
                    object relay = GridV_Batch[1, e.RowIndex].Value;
                    object lastrelay = GridV_Batch[1, GridV_Batch.Rows.Count - 1].Value;
                    object status = GridV_Batch[2, e.RowIndex].Value;
                    object laststatus = GridV_Batch[2, GridV_Batch.Rows.Count - 1].Value;
                    object delay_time = GridV_Batch[3, e.RowIndex].Value;
                    object lastdelay_time = GridV_Batch[3, GridV_Batch.Rows.Count - 1].Value;
                    if ((relay == null || lastrelay == null) && (status == null || laststatus == null) && (delay_time == null || lastdelay_time == null))
                    {
                        return;
                    }
                    if (delay_time != null)
                    {
                        int delaytime = Int32.Parse(delay_time.ToString());
                        if (delaytime > 0 && lastdelay_time.ToString() != "0")
                        {
                            GridV_Batch.Rows.Add();
                            return;
                        }
                    }
                    GridV_Batch.Rows.Add();
 
                }
                
            }
            catch(Exception)
            {
                return;
            }           
        }
        private void GridV_Batch_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GridV_Batch.IsCurrentCellDirty)
            {
                GridV_Batch.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void GridV_Batch_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (GridV_Batch.CurrentCell.Value == null)
                {
                    GridV_Batch.CurrentCell.Value = "0";
                    return;
                }
                if (GridV_Batch.CurrentCell.Value.ToString() == "")
                {
                    GridV_Batch.CurrentCell.Value = "0";
                    return;
                }
                else if (GridV_Batch.CurrentCell.Value.ToString() == "0") {
                    return;
                }

                if (!float.TryParse(GridV_Batch.CurrentCell.Value.ToString(), out float Text)) {
                    GridV_Batch.CurrentCell.Value = "0";
                    MessageBox.Show($"Please check the number you have inputed is correct or not.", "Warning!");
                    return;
                }
                if (Text > 3600 || Text < 0.1)
                {
                    GridV_Batch.CurrentCell.Value = "0";
                    MessageBox.Show("Delay time cannot longer than 3600(s) or shorter than 0.1(s).", "Warning!");
                    return;
                } 
                else {
                    GridV_Batch.CurrentCell.Value = Text.ToString();
                }
            }
            Saveornot = true;
        }
        private void GridV_Batch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = GridV_Batch.HitTest(e.X, e.Y);
                if (hti.RowIndex > -1)
                {
                    GridV_Batch.ClearSelection();
                    GridV_Batch.CurrentCell = GridV_Batch.Rows[hti.RowIndex].Cells[1];
                    // GridV_Batch.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
        #endregion

        #region --listbox mouse right click event--
        private void Lstb_batchname_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {                   
                    Point point = new Point(e.X, e.Y);
                    int index = Lstb_batchname.SelectedIndex;
                    int position = Lstb_batchname.IndexFromPoint(point);
                    if(position == index && position != -1)
                    {
                        pasteToolStripMenuItem1.Enabled = false;
                        deleteToolStripMenuItem1.Enabled = true;
                        renameToolStripMenuItem.Enabled = true;
                        copyToolStripMenuItem1.Enabled = true;
                    }
                    else if(position != index && position != -1)
                    {
                        deleteToolStripMenuItem1.Enabled = false;
                        renameToolStripMenuItem.Enabled = false;
                        copyToolStripMenuItem1.Enabled = false;
                        pasteToolStripMenuItem1.Enabled = false;
                    }
                    else if(position == -1)
                    {
                        deleteToolStripMenuItem1.Enabled = false;
                        renameToolStripMenuItem.Enabled = false;
                        copyToolStripMenuItem1.Enabled = false;
                        pasteToolStripMenuItem1.Enabled = false;
                        if (Listbox_copyornot == true)
                        {
                            pasteToolStripMenuItem1.Enabled = true;
                        }                      
                    }
                    ContMenu_listbox.Show(MousePosition.X, MousePosition.Y);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Choose the content");
            }
        }
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lstb_batchname.SelectedIndex > -1)
            {
                string json = Ri2.dict[Lstb_batchname.SelectedItem.ToString()];
                Inputbox.Inputbox_item = 1;
                Inputbox.Batch_name = Lstb_batchname.SelectedItem.ToString();
                System.Windows.Forms.Form f4 = new Inputbox();
                f4.ShowDialog();
                //string Rename_batch = Interaction.InputBox("Batch Name", "Rename", "", -1, -1);

                //if (Inputbox.Input_content.Length > 11)
                //{
                //    MessageBox.Show("Batch name cannot surpass more than ten words!");

                //    return;
                //}
                if (Inputbox.Cancelornot == false)
                {
                    return;
                }
                if (string.IsNullOrEmpty(Inputbox.Input_content))
                {
                    MessageBox.Show("Batch name cannot be empty.", "Warning!");

                    return;
                }
                else if (Lstb_batchname.Items.Contains(Inputbox.Input_content))
                {
                    MessageBox.Show("Same batch name.", "Warning!");
                    return;
                }

                Ri2.dict[Inputbox.Input_content] = Ri2.dict[Lstb_batchname.SelectedItem.ToString()];
                Ri2.dict.Remove(Lstb_batchname.SelectedItem.ToString());
                Lstb_batchname.Items[Lstb_batchname.SelectedIndex] = Inputbox.Input_content;
                //Ri2.dict.Add(Inputbox.Input_content, json);
                Saveornot = true;
            }
        }
        private void Lstb_batchname_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int position = Lstb_batchname.IndexFromPoint(point);
            if (Lstb_batchname.SelectedIndex != -1 && position > -1)
            {
                string json = Ri2.dict[Lstb_batchname.SelectedItem.ToString()];
                Inputbox.Inputbox_item = 1;
                Inputbox.Batch_name = Lstb_batchname.SelectedItem.ToString();
                System.Windows.Forms.Form f4 = new Inputbox();
                f4.ShowDialog();
                //string Rename_batch = Interaction.InputBox("Batch Name", "Rename", "", -1, -1);

                //if (Inputbox.Input_content.Length > 11)
                //{
                //    MessageBox.Show("Batch name cannot surpass more than ten words!");
                //    return;
                //}
                if (Inputbox.Cancelornot == false)
                {
                    return;
                }
                if (string.IsNullOrEmpty(Inputbox.Input_content))
                {
                    MessageBox.Show("Batch naem cannot be empty.", "Warning!");
                    return;
                }
                else if (Lstb_batchname.Items.Contains(Inputbox.Input_content))
                {
                    MessageBox.Show("Same batch name.", "Warning!");
                    return;
                }

                Ri2.dict.Remove(Lstb_batchname.SelectedItem.ToString());
                Lstb_batchname.Items[Lstb_batchname.SelectedIndex] = Inputbox.Input_content;
                Ri2.dict.Add(Inputbox.Input_content, json);
                Saveornot = true;
            }
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ri2.dict.Remove(Lstb_batchname.SelectedItem.ToString());
            this.Lstb_batchname.Items.Remove(Lstb_batchname.SelectedItem);
            Saveornot = true;
        }
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string key = Lstb_batchname.SelectedItem.ToString();
            Listbox_Copy_Value = Ri2.dict[key];
            Listbox_copyornot = true;
        }
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inputbox.Inputbox_item = 3;
            Inputbox.Batch_name = Lstb_batchname.SelectedItem.ToString();
            System.Windows.Forms.Form f4 = new Inputbox();
            f4.ShowDialog();
            //string New_key = Interaction.InputBox("Copy batch name:" + Lstb_batchname.SelectedItem, "Create New Batch", Lstb_batchname.SelectedItem + "(Copy)", -1, -1);
            if (Inputbox.Cancelornot == false)
            {
                return;
            }
            if (string.IsNullOrEmpty(Inputbox.Input_content))
            {
                MessageBox.Show("Batch naem cannot be empty.", "Warning!");
                return;
            }
            else if (Lstb_batchname.Items.Contains(Inputbox.Input_content))
            {
                MessageBox.Show("Same batch name.", "Warning!");
                return;
            }
            Lstb_batchname.Items.Add(Inputbox.Input_content);
            Ri2.dict.Add(Inputbox.Input_content, Listbox_Copy_Value);
            Saveornot = true;
            //Listbox_copyornot = false;
        }
        #endregion

        #region --datagridview Delay Time卡控數字--
        private void GridV_Batch_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (GridV_Batch.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
                if (tb.Text != "")
                {
                    float Text = float.Parse(tb.Text);
                    if (Text > 3600 || Text < 0.1)
                    {
                        tb.Text = "0";
                        tb.Focus();
                        return;
                    }
                }
            }          
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;            
            }
        }       
        #endregion
    }


}
