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

<<<<<<< HEAD
=======
            LoadFilePathFromTxt();
>>>>>>> 39568b395db866e3bf768d83af6d47ffb857aace
            txtBoxBits.KeyPress += TxtBoxBitsKeyPress;
            this.AcceptButton = btnShow;
        }

        /// <summary>
        /// Creates 32 buttons in form
        /// </summary>
        private void CreateBitButtons()
        {
            for (int i = 0; i < 32; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Location = new Point(65 + i * 13, 127);
                btn.Text = "0";
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Size = new Size(17, 25);
                //btn.Font = new Font("Microsoft Sans Serif", 8);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(255, 255, 255, 255);

                switch (i / 8)
                {
                    case 0: btn.BackColor = Color.FromArgb(255, 60, 60, 60); break;
                    case 1: btn.BackColor = Color.FromArgb(255, 40, 40, 40); break;
                    case 2: btn.BackColor = Color.FromArgb(255, 60, 60, 60); break;
                    case 3: btn.BackColor = Color.FromArgb(255, 40, 40, 40); break;
                }
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
            if (selectedFlagList == null) return;

            int value = GetValueFromTextBox();
            List<ParsedFlagData> flagDataList = selectedFlagList.Parse(value);

            dataGridView.DataSource = flagDataList;
            dataGridView.Columns[2].Width = 50;
            dataGridView.Columns[2].ReadOnly = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.ReadOnly = false;
            }

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

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
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
                Button bttn = this.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                bin += bttn.Text;
            }

            txtBoxBits.Text = Convert.ToInt64(bin, 2).ToString();
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
            dlg.Title = "Select meme";

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
    }
}