using FlagLibrary.Connections;
using FlagLibrary.Flags;
using FlagLibrary.Utils;
using FlagLibrary.Generators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BitwiseCalculatorUI
{
    public partial class Form1 : Form
    {
        string filePath = "";
        bool isFolder = false;
        Dictionary<string, FlagList> flagLists;
        FlagList selectedFlagList;

        const int IDColumnIndex = 0;
        const int CurrentOptionColumnIndex = 3;
        const int ValueColumnIndex = 4;

        public Form1()
        {
            InitializeComponent();
            dataGridView.CellEndEdit += new DataGridViewCellEventHandler(dataGridView_OnTextChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBitButtons();

            LoadFilePathFromTxt();
            txtBoxBits.KeyPress += TxtBoxBitsKeyPress;
            AcceptButton = btnShow;
        }

        void InitializeFlagLists()
        {
            ILoader loader;
            if (filePath.EndsWith(".xml") || isFolder)
            {
                loader = new XMLLoader();
            } else if (filePath.EndsWith(".lst"))
            {
                loader = new LSTLoader();
            }
            else
            {
                MessageBox.Show("Unsupported file type!");
                return;
            }
            LoadFlagLists(loader);            
        }

        void LoadFlagLists(ILoader loader)
        {
            if (isFolder) flagLists = loader.GetFlagListsFromFolder(filePath);
            else flagLists = loader.GetFlagLists(filePath);
            comboBoxFlaga.Items.Clear();
            foreach (KeyValuePair<string, FlagList> pair in flagLists)
            {
                comboBoxFlaga.Items.Add(pair.Key);
            }
            comboBoxFlaga.SelectedIndex = 0;
            selectedFlagList = flagLists[comboBoxFlaga.Items[0].ToString()];
        }

        /// <summary>
        /// Creates 32 buttons in form
        /// </summary>
        private void CreateBitButtons()
        {
            Point origin = new Point(400, 55);
            ToolTip toolTipSystem = new ToolTip();
            for (int i = 0; i < 32; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + i;
                Point loc = new Point(origin.X + i * 13, origin.Y);
                btn.Location = loc;
                btn.Text = "0";
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Size = new Size(17, 33);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(255, 255, 255, 255);
                toolTipSystem.SetToolTip(btn, "Bit " + (31 - i) + " - " + (1 << (31 - i)));

                SetBitButtonsColors(btn, i);

                btn.FlatAppearance.BorderSize = 0;
                btn.MouseClick += BtnMouseClick;

                SolidBrush myBrush = new SolidBrush(Color.Red);
                Graphics formGraphics;
                formGraphics = CreateGraphics();
                formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
                myBrush.Dispose();
                formGraphics.Dispose();

                Controls.Add(btn);
            }
        }

        void SetBitButtonsColors(Button btn, int i)
        {
            switch (i / 8)
            {
                case 0: btn.BackColor = Color.FromArgb(255, 60, 60, 60); break;
                case 1: btn.BackColor = Color.FromArgb(255, 40, 40, 40); break;
                case 2: btn.BackColor = Color.FromArgb(255, 60, 60, 60); break;
                case 3: btn.BackColor = Color.FromArgb(255, 40, 40, 40); break;
            }
            switch (i / 4)
            {
                case 0: btn.ForeColor = Color.FromArgb(255, 255, 153, 51); break;
                case 1: btn.ForeColor = Color.FromArgb(255, 255, 255, 255); break;
                case 3: btn.ForeColor = Color.FromArgb(255, 255, 255, 255); break;
                case 5: btn.ForeColor = Color.FromArgb(255, 255, 255, 255); break;
                case 2: btn.ForeColor = Color.FromArgb(255, 255, 153, 51); break;
                case 4: btn.ForeColor = Color.FromArgb(255, 255, 153, 51); break;
                case 6: btn.ForeColor = Color.FromArgb(255, 255, 153, 51); break;
                case 7: btn.ForeColor = Color.FromArgb(255, 255, 255, 255); break;
            }
        }

        /// <summary>
        /// Method called after clicking 'Wyświetl button'
        /// shows bits
        /// </summary>
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowBits();
        }

        int GetValueFromTextBox()
        {
            try
            {
                return int.Parse(txtBoxBits.Text);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        #region Data grid view

        void dataGridView_OnTextChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CurrentOptionColumnIndex || e.ColumnIndex == ValueColumnIndex)
            {
                DataGridViewCell cell = dataGridView[e.ColumnIndex, e.RowIndex];
                int bitID;
                try
                {
                    bitID = int.Parse(dataGridView.Rows[cell.RowIndex].Cells[IDColumnIndex].Value.ToString());
                }
                catch
                {
                    return;
                }
                BitGroup flag = selectedFlagList.flags[bitID];
                if (e.ColumnIndex == ValueColumnIndex)
                {
                    try
                    {
                        cell.Value = CommonUtils.Clamp(int.Parse(cell.Value.ToString()), 0, flag.GetMaxSize());
                        
                    }
                    catch
                    {
                        cell.Value = 0;
                    }
                }
                int i32 = GetValueFromTextBox();
                txtBoxBits.Text = GetFlagIntWithModifedFlagFromCell(cell, i32, flag).ToString();
                txtBoxBits.Refresh();

                if(e.ColumnIndex == CurrentOptionColumnIndex) RefreshValueInDataGridView();
                if(e.ColumnIndex == ValueColumnIndex) RefreshCurrentOptionInDataGridView();

                SetColorsInDataGridView();
                RefreshBitButtonsText();
            }
        }

        void RefreshValueInDataGridView()
        {
            int value = GetValueFromTextBox();
            List<ParsedFlagData> flagDataList = selectedFlagList.Parse(value);

            for (int i = 0; i < flagDataList.Count; i++)
            {
                dataGridView.Rows[i].Cells[ValueColumnIndex].Value = flagDataList[i].value;
            }
        }

        void RefreshCurrentOptionInDataGridView()
        {
            int value = GetValueFromTextBox();
            List<ParsedFlagData> flagDataList = selectedFlagList.Parse(value);

            for (int i = 0; i < flagDataList.Count; i++)
            {
                dataGridView.Rows[i].Cells[CurrentOptionColumnIndex].Value = null; //this is important.
                DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();

                foreach (KeyValuePair<string, int> kv in flagDataList[i].options)
                {
                    c.Items.Add(kv.Key);
                }

                try
                {
                    c.Value = flagDataList[i].currentOption;
                    dataGridView.Rows[i].Cells[CurrentOptionColumnIndex] = c;
                }
                catch
                {

                }
                
            }
        }

        int GetFlagIntWithModifedFlagFromCell(DataGridViewCell cell, int i32, BitGroup flag)
        {
            int value = 0;
            if (cell is DataGridViewComboBoxCell)
            {
                string optionName = cell.Value.ToString();
                value = selectedFlagList.GetParsedFlagOptions(flag)[optionName];
            }
            else if (cell is DataGridViewTextBoxCell)
            {
                value = int.Parse(cell.Value.ToString());
            }
            else
            {
                return 0;
            }
            return flag.GetModifiedValue(i32, value);
        }

        #endregion

        /// <summary>
        /// Method refresh bit table and makes checkbox
        /// </summary>
        void ShowBits()
        {
            if (selectedFlagList == null)
                return;

            int value = GetValueFromTextBox();
            List<ParsedFlagData> flagDataList = selectedFlagList.Parse(value);

            dataGridView.Rows.Clear();
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.Columns[2].ReadOnly = true;


            for (int i = 0; i < flagDataList.Count; i++)
            {
                int row = dataGridView.Rows.Add(flagDataList[i].bitNumber, flagDataList[i].bitSize, flagDataList[i].description, flagDataList[i].currentOption, flagDataList[i].value);

                dataGridView.Rows[i].Cells[3].Value = null; //this is important.
                DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();

                foreach (KeyValuePair<string, int> kv in flagDataList[i].options)
                {
                    c.Items.Add(kv.Key);
                }

                //.Value = c.Items[0];
                c.Value = flagDataList[i].currentOption;
                dataGridView.Rows[i].Cells[CurrentOptionColumnIndex] = c;
                dataGridView.Rows[i].Height = 25;
            }

            RefreshBitButtonsText();
            SetColorsInDataGridView();
        }

        void SetColorsInDataGridView()
        {
            for (int i=0; i<dataGridView.Rows.Count;i++)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();

                switch ((string)((DataGridViewComboBoxCell)dataGridView[CurrentOptionColumnIndex, i]).Value)
                {
                    case "???": style.BackColor = Color.FromArgb(255, 51, 51, 51); break;
                    case "On": style.BackColor = Color.FromArgb(255, 100, 255, 100); break;
                    case "OFF": style.BackColor = Color.FromArgb(255, 100, 255, 100); break;
                    default: style.BackColor = Color.FromArgb(255, 255, 0, 0); break;
                }

                dataGridView[ValueColumnIndex, i].Style = style;
            }
        }

        private void RefreshBitButtonsText()
        {
            string text = DecToBin();
            for (int i = 0; i < 32; i++)
            {
                Button btn = Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                btn.Text = "0";
            }

            for (int i = 0; i < text.Length; i++)
            {
                Button btn = Controls.Find("btn" + (i + 32 - text.Length).ToString(), true).FirstOrDefault() as Button;
                string bits = text;
                btn.Text = bits.Substring(i, 1);
            }
        }

        /// <summary>
        /// Method whenever user click bad char when it is not displane
        /// </summary>
        void TxtBoxBitsKeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtBoxBits.Text;

            if (e.KeyChar == 8) return;
            else if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar == '-')
                {
                    if (text[0] == '-')
                    {
                        txtBoxBits.Text = text.Substring(1);
                    }
                    else
                    {
                        txtBoxBits.Text = '-' + text;
                    }
                }
                e.KeyChar = (char)0;
            }
        }

        /// <summary>
        /// Method convert string to int and return binary
        /// </summary>
        string DecToBin()
        {
            try
            {
                int x = Int32.Parse(txtBoxBits.Text);
                string binary = Convert.ToString(x, 2);
                return binary;
            }
            catch
            {
                return "0";
            }
        }

        /// <summary>
        /// Method check button value and change on click
        /// </summary>
        void BtnMouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "1")
            {
                btn.Text = "0";
            }
            else btn.Text = "1";

            btn.ForeColor = Color.FromArgb(255, 255, 255, 255);


            string bin = "";

            for (int i = 0; i < 32; i++)
            {
                Button bttn = Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                bin += bttn.Text;
                SetBitButtonsColors(bttn, i);
            }

            txtBoxBits.Text = Convert.ToInt32(bin, 2).ToString();
            ShowBits();
        }

        private void comboBoxFlaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFlagName = comboBoxFlaga.Items[comboBoxFlaga.SelectedIndex].ToString();
            if (flagLists.ContainsKey(selectedFlagName))
            {
                selectedFlagList = flagLists[selectedFlagName];
                ShowBits();
            }
        }

        private void btnFindXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML or LST (*.xml; *.lst)|*.xml; *.lst";
            dlg.Title = "Select XML or LST file with Flag Definitions";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName.ToString();
                isFolder = false;
                InitializeFlagLists();
                File.WriteAllText("XMLPath.txt", filePath);
            }
        }

        private void btnFindXMLFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.SelectedPath.ToString();
                isFolder = true;
                InitializeFlagLists();
                File.WriteAllText("XMLPath.txt", filePath);
            }
        }

        private void LoadFilePathFromTxt()
        {
            if (File.Exists("XMLPath.txt"))
            {
                try
                {
                    string[] data = new string[2];

                    data = File.ReadAllLines("XMLPath.txt");
                    filePath = data[0];
                    InitializeFlagLists();
                }
                catch
                {
                }
            }
        }

        private void btnReset_onClick(object sender, EventArgs e)
        {
            SetAllBits(false);
        }

        private void btnSetOne_onClick(object sender, EventArgs e)
        {
            SetAllBits(true);
        }

        private void SetAllBits(bool isOne)
        {
            if (isOne) txtBoxBits.Text = "-1";
            else txtBoxBits.Text = "0";
            ShowBits();
        }

        private void btnGenerateSqlText_Click(object sender, EventArgs e)
        {
            SqlCommandType type = GetCommandType();
            if (type == SqlCommandType.Unknown) return;

            string bits = "";

            var rows = dataGridView.Rows;
            SqlGenerator generator = new SqlGenerator();

            if (type == SqlCommandType.Insert)
            {
                bits = Convert.ToString(GetValueFromTextBox(), 2);
                SetStringInSqlOutput(generator.GenerateInsert(bits, selectedFlagList.name));
            }
            else if (type == SqlCommandType.Update)
            {
                bits = Convert.ToString(GetValueFromTextBox(), 2);
                foreach (DataGridViewRow row in rows)
                {
                    try
                    {
                        var id = int.Parse(row.Cells[IDColumnIndex].Value.ToString());
                        var val = row.Cells[ValueColumnIndex].Value.ToString();
                        var flag = selectedFlagList.flags[id];
                        if (val == "?")
                        {
                            foreach(var bitRef in flag.bitRefs)
                            {
                                bits = SetStringCharFromEnd(bits, bitRef, '?');
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                SetStringInSqlOutput(generator.GenerateUpdate(bits, selectedFlagList.name));
            }

        }

        string SetStringCharFromEnd(string str, int index, char ch)
        {
            char[] chars = str.ToCharArray();
            chars[str.Length - index - 1] = ch;
            return chars.ToString();
        }

        enum SqlCommandType
        {
            Insert,
            Update,
            Unknown
        }

        private SqlCommandType GetCommandType()
        {
            // TODO: Return correct type using current selection from combo box, return unknown on exception
            return SqlCommandType.Update;
            //return SqlCommandType.Update;
        }

        void SetStringInSqlOutput(string str)
        {
            if (str == "")
                return;

            txtBoxMysqlFormula.Text = str;
        }

        private void btnQuestionMark_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                ((DataGridViewComboBoxCell)dataGridView[CurrentOptionColumnIndex, i]).Value = "???";
            }

            SetColorsInDataGridView();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxMysqlFormula.Text);
        }
    }
}