namespace BitwiseCalculatorUI
{
    partial class Form1
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
            this.comboBoxFlaga = new System.Windows.Forms.ComboBox();
            this.txtBoxBits = new System.Windows.Forms.TextBox();
            this.lblFlaga = new System.Windows.Forms.Label();
            this.lblBity = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFlaga
            // 
            this.comboBoxFlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxFlaga.FormattingEnabled = true;
            this.comboBoxFlaga.Location = new System.Drawing.Point(174, 59);
            this.comboBoxFlaga.Name = "comboBoxFlaga";
            this.comboBoxFlaga.Size = new System.Drawing.Size(160, 33);
            this.comboBoxFlaga.TabIndex = 0;
            this.comboBoxFlaga.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlaga_SelectedIndexChanged);
            // 
            // txtBoxBits
            // 
            this.txtBoxBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxBits.Location = new System.Drawing.Point(486, 60);
            this.txtBoxBits.Name = "txtBoxBits";
            this.txtBoxBits.Size = new System.Drawing.Size(360, 32);
            this.txtBoxBits.TabIndex = 1;
            // 
            // lblFlaga
            // 
            this.lblFlaga.AutoSize = true;
            this.lblFlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFlaga.ForeColor = System.Drawing.Color.White;
            this.lblFlaga.Location = new System.Drawing.Point(62, 59);
            this.lblFlaga.Name = "lblFlaga";
            this.lblFlaga.Size = new System.Drawing.Size(90, 31);
            this.lblFlaga.TabIndex = 2;
            this.lblFlaga.Text = "Flaga:";
            // 
            // lblBity
            // 
            this.lblBity.AutoSize = true;
            this.lblBity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBity.ForeColor = System.Drawing.Color.White;
            this.lblBity.Location = new System.Drawing.Point(385, 61);
            this.lblBity.Name = "lblBity";
            this.lblBity.Size = new System.Drawing.Size(68, 31);
            this.lblBity.TabIndex = 3;
            this.lblBity.Text = "Bity:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Black;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(877, 59);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 33);
            this.btnShow.TabIndex = 0;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Wyświetl";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(539, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(464, 529);
            this.dataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblBity);
            this.Controls.Add(this.lblFlaga);
            this.Controls.Add(this.txtBoxBits);
            this.Controls.Add(this.comboBoxFlaga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFlaga;
        private System.Windows.Forms.TextBox txtBoxBits;
        private System.Windows.Forms.Label lblFlaga;
        private System.Windows.Forms.Label lblBity;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

