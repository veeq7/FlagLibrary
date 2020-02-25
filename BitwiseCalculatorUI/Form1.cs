using FlagLibrary.Connections;
using FlagLibrary.Flags;
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
        Dictionary<string, FlagList> flagLists;
        FlagList selectedFlagList;

        public Form1()
        {
            InitializeComponent();
        }

        void InitializeFlagLists()
        {
            XMLLoader xml = new XMLLoader(filePath);
            flagLists = xml.GetFlagLists();
            foreach (KeyValuePair<string, FlagList> pair in flagLists)
            {
                comboBoxFlaga.Items.Add(pair.Key);
            }
            comboBoxFlaga.SelectedIndex = 0;
            selectedFlagList = flagLists[comboBoxFlaga.Items[0].ToString()];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBitButtons();

            LoadFilePathFromTxt();
            txtBoxBits.KeyPress += TxtBoxBitsKeyPress;
            this.AcceptButton = btnShow;
        }

        // not used, but may be useful
        private Button FindButtonByName(string name)
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null && b.Name == name)
                {
                    return b;
                }
            }

            return null;
        }

        void SetColor(Button btn, int i)
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
        /// Creates 32 buttons in form
        /// </summary>
        private void CreateBitButtons()
        {
            Point origin = new Point(27, 164);
            System.Windows.Forms.ToolTip toolTipSystem = new System.Windows.Forms.ToolTip();
            for (int i = 0; i < 32; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + i;
                Point loc = new Point(origin.X + i * 13, origin.Y);
                btn.Location = loc;
                btn.Text = "0";
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Size = new Size(17, 33);
                //btn.Font = new Font("Microsoft Sans Serif", 8);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(255, 255, 255, 255);
                toolTipSystem.SetToolTip(btn, "Bit " + (32 - i) + " - " + (1 << (31 - i)));


                SetColor(btn, i);



                btn.FlatAppearance.BorderSize = 0;
                btn.MouseClick += BtnMouseClick;

                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
                myBrush.Dispose();
                formGraphics.Dispose();

                this.Controls.Add(btn);
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

        /// <summary>
        /// Method refresch bit table and makes checkbox
        /// </summary>
        void ShowBits()
        {
            if (selectedFlagList == null)
                return;

            int value = GetValueFromTextBox();
            List<ParsedFlagData> flagDataList = selectedFlagList.Parse(value);

            dataGridView.Rows.Clear();
            dataGridView.Columns[0].ReadOnly = true;


            for (int i = 0; i < flagDataList.Count; i++)
            {
                int row = dataGridView.Rows.Add(flagDataList[i].bitNumber, flagDataList[i].bitSize, flagDataList[i].description, flagDataList[i].currentOption, flagDataList[i].value);

                dataGridView.Rows[i].Cells[3].Value = null; //this is important.
                DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();

                foreach (KeyValuePair<string, int> kv in flagDataList[i].options)
                {
                    c.Items.Add(kv.Key);
                }

                c.Value = c.Items[0];
                dataGridView.Rows[i].Cells[1] = c;
                dataGridView.Rows[i].Height = 35;

            }
            /*dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.Columns[2].ReadOnly = true;
            dataGridView.Columns[3].ReadOnly = true;


            for(int i = 0; i< flagDataList.Count; i++)
            {
                int row = dataGridView.Rows.Add(flagDataList[i].bitNumber, flagDataList[i].bitSize, flagDataList[i].description, flagDataList[i].currentOption, flagDataList[i].value);
            }*/

            SetBitsButton();
        }

        /// <summary>
        /// Method makes 32 buttons for bit table
        /// </summary>
        private void SetBitsButton()
        {

            string text = DecToBin();
            for (int i = 0; i < 32; i++)
            {
                Button btn = this.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                btn.Text = "0";
            }

            for (int i = 0; i < text.Length; i++)
            {
                Button btn = this.Controls.Find("btn" + (i + 32 - text.Length).ToString(), true).FirstOrDefault() as Button;
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
                e.KeyChar = (char) 0;
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
                Button bttn = this.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                bin += bttn.Text;
                SetColor(bttn, i);
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
            dlg.Filter = "XML (*.xml)|*.xml";
            dlg.Title = "Select XML file with Flag Definitions";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName.ToString();
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}