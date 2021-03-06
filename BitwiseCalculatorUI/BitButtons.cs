﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitwiseCalculatorUI
{
    class BitButtons
    {
        public static List<Button> buttons = new List<Button>();

        public static void Create()
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
                btn.FlatAppearance.BorderSize = 0;
                btn.MouseClick += BtnMouseClick;

                buttons.Add(btn);
                BitwiseCalculator.form.Controls.Add(btn);
            }

            SetColorsToAll();
        }

        public static void SetColorsToAll()
        {
            for(int i = 0; i<buttons.Count; i++)
            {
                SetColor(buttons[i], i);
            }
        }

        static void SetColor(Button btn, int i)
        {

            //Back color buttons

            if (i % 16 < 8)
                btn.BackColor = Color.FromArgb(255, 60, 60, 60);
            else
                btn.BackColor = Color.FromArgb(255, 40, 40, 40);


            //Font buttons color
            if (i % 8 < 4)
                btn.ForeColor = Color.FromArgb(255, 255, 153, 51);
            else
                btn.ForeColor = Color.FromArgb(255, 255, 255, 255);

        }

        static void BtnMouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "1")
            {
                btn.Text = "0";
            }
            else btn.Text = "1";

            //btn.ForeColor = Color.FromArgb(255, 255, 255, 255);


            BitwiseCalculator.form.RefreshTxtBoxBits();
            BitwiseCalculator.form.RefreshDataGridView();
        }

        public static void SetAllBitsTo(bool state)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if(state) buttons[i].Text = "1";
                else buttons[i].Text = "0";
            }
        }

        public static void RefreshAll()
        {
            string text = "";

            try
            {
                int x = Int32.Parse(BitwiseCalculator.form.ReturnTxtBoxBits().Text);
                text = Convert.ToString(x, 2);
            }
            catch
            {
            }

            for (int i = 0; i < 32; i++)
            {
                Button btn = BitwiseCalculator.form.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                btn.Text = "0";
            }

            for (int i = 0; i < text.Length; i++)
            {
                Button btn = BitwiseCalculator.form.Controls.Find("btn" + (i + 32 - text.Length).ToString(), true).FirstOrDefault() as Button;
                string bits = text;
                btn.Text = bits.Substring(i, 1);
            }
        }
    }
}
