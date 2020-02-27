using System;
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
            switch (i / 8)
            {
                case 0:
                case 2: btn.BackColor = Color.FromArgb(255, 60, 60, 60); break;
                case 1:
                case 3: btn.BackColor = Color.FromArgb(255, 40, 40, 40); break;
            }
            switch (i / 4)
            {
                case 0: btn.ForeColor = Color.FromArgb(255, 255, 153, 51); break;
                case 1:
                case 3:
                case 5: btn.ForeColor = Color.FromArgb(255, 255, 255, 255); break;
                case 2:
                case 4:
                case 6: btn.ForeColor = Color.FromArgb(255, 255, 153, 51); break;
                case 7: btn.ForeColor = Color.FromArgb(255, 255, 255, 255); break;
            }
        }

        static void BtnMouseClick(object sender, MouseEventArgs e)
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
                Button bttn = BitwiseCalculator.form.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                bin += bttn.Text;
            }

            TextBox txtBoxBits = BitwiseCalculator.form.ReturnTxtBoxBits();

            txtBoxBits.Text = Convert.ToInt32(bin, 2).ToString();
            BitwiseCalculator.form.RefreshDataGridView();
        }
    }
}
