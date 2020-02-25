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
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOption = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindXML = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFlaga
            // 
            this.comboBoxFlaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboBoxFlaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxFlaga.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxFlaga.FormattingEnabled = true;
            this.comboBoxFlaga.Location = new System.Drawing.Point(174, 59);
            this.comboBoxFlaga.Name = "comboBoxFlaga";
            this.comboBoxFlaga.Size = new System.Drawing.Size(160, 33);
            this.comboBoxFlaga.Sorted = true;
            this.comboBoxFlaga.TabIndex = 0;
            this.comboBoxFlaga.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlaga_SelectedIndexChanged);
            // 
            // txtBoxBits
            // 
            this.txtBoxBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBoxBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxBits.ForeColor = System.Drawing.Color.White;
            this.txtBoxBits.Location = new System.Drawing.Point(486, 60);
            this.txtBoxBits.Name = "txtBoxBits";
            this.txtBoxBits.Size = new System.Drawing.Size(360, 32);
            this.txtBoxBits.TabIndex = 1;
            // 
            // lblFlaga
            // 
            this.lblFlaga.AutoSize = true;
            this.lblFlaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
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
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.btnShow.FlatAppearance.BorderSize = 2;
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
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.CurrentOption,
            this.Value});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(68, 204);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(935, 356);
            this.dataGridView.TabIndex = 4;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // CurrentOption
            // 
            this.CurrentOption.HeaderText = "Current option";
            this.CurrentOption.Name = "CurrentOption";
            this.CurrentOption.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentOption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Value
            // 
            this.Value.FillWeight = 30F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // btnFindXML
            // 
            this.btnFindXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnFindXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.btnFindXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindXML.ForeColor = System.Drawing.Color.White;
            this.btnFindXML.Location = new System.Drawing.Point(627, 127);
            this.btnFindXML.Name = "btnFindXML";
            this.btnFindXML.Size = new System.Drawing.Size(376, 33);
            this.btnFindXML.TabIndex = 5;
            this.btnFindXML.TabStop = false;
            this.btnFindXML.Text = "Wybierz plik XML";
            this.btnFindXML.UseVisualStyleBackColor = false;
            this.btnFindXML.Click += new System.EventHandler(this.btnFindXML_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(505, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Zerowanie";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_onClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFindXML);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblBity);
            this.Controls.Add(this.lblFlaga);
            this.Controls.Add(this.txtBoxBits);
            this.Controls.Add(this.comboBoxFlaga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button btnFindXML;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrentOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

