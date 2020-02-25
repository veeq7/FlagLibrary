﻿namespace BitwiseCalculatorUI
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
            this.btnFindXML = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetOne = new System.Windows.Forms.Button();
            this.txtBoxMysqlFormula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnGenerateInsert = new System.Windows.Forms.Button();
            this.btnGenerateUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOption = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFlaga
            // 
            this.comboBoxFlaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboBoxFlaga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFlaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxFlaga.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxFlaga.FormattingEnabled = true;
            this.comboBoxFlaga.IntegralHeight = false;
            this.comboBoxFlaga.ItemHeight = 25;
            this.comboBoxFlaga.Location = new System.Drawing.Point(27, 85);
            this.comboBoxFlaga.MaxDropDownItems = 12;
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
            this.txtBoxBits.Location = new System.Drawing.Point(568, 84);
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
            this.lblFlaga.Location = new System.Drawing.Point(21, 51);
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
            this.lblBity.Location = new System.Drawing.Point(562, 50);
            this.lblBity.Name = "lblBity";
            this.lblBity.Size = new System.Drawing.Size(68, 31);
            this.lblBity.TabIndex = 3;
            this.lblBity.Text = "Bity:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(934, 84);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 33);
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
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BitId,
            this.BitSize,
            this.Description,
            this.CurrentOption,
            this.Value});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(27, 215);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1002, 301);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnFindXML
            // 
            this.btnFindXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnFindXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnFindXML.FlatAppearance.BorderSize = 2;
            this.btnFindXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindXML.ForeColor = System.Drawing.Color.White;
            this.btnFindXML.Location = new System.Drawing.Point(193, 85);
            this.btnFindXML.Name = "btnFindXML";
            this.btnFindXML.Size = new System.Drawing.Size(37, 33);
            this.btnFindXML.TabIndex = 5;
            this.btnFindXML.TabStop = false;
            this.btnFindXML.Text = "...";
            this.btnFindXML.UseVisualStyleBackColor = false;
            this.btnFindXML.Click += new System.EventHandler(this.btnFindXML_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(452, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "0";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_onClick);
            // 
            // btnSetOne
            // 
            this.btnSetOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnSetOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnSetOne.FlatAppearance.BorderSize = 2;
            this.btnSetOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetOne.ForeColor = System.Drawing.Color.White;
            this.btnSetOne.Location = new System.Drawing.Point(508, 165);
            this.btnSetOne.Name = "btnSetOne";
            this.btnSetOne.Size = new System.Drawing.Size(50, 33);
            this.btnSetOne.TabIndex = 7;
            this.btnSetOne.Text = "1";
            this.btnSetOne.UseVisualStyleBackColor = false;
            this.btnSetOne.Click += new System.EventHandler(this.btnSetOne_onClick);
            // 
            // txtBoxMysqlFormula
            // 
            this.txtBoxMysqlFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBoxMysqlFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMysqlFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxMysqlFormula.ForeColor = System.Drawing.Color.White;
            this.txtBoxMysqlFormula.Location = new System.Drawing.Point(271, 610);
            this.txtBoxMysqlFormula.Name = "txtBoxMysqlFormula";
            this.txtBoxMysqlFormula.Size = new System.Drawing.Size(360, 32);
            this.txtBoxMysqlFormula.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Generuj";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnCopyToClipboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnCopyToClipboard.FlatAppearance.BorderSize = 2;
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(637, 610);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(37, 33);
            this.btnCopyToClipboard.TabIndex = 10;
            this.btnCopyToClipboard.TabStop = false;
            this.btnCopyToClipboard.Text = "...";
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            // 
            // btnGenerateInsert
            // 
            this.btnGenerateInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnGenerateInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnGenerateInsert.FlatAppearance.BorderSize = 2;
            this.btnGenerateInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateInsert.ForeColor = System.Drawing.Color.White;
            this.btnGenerateInsert.Location = new System.Drawing.Point(28, 609);
            this.btnGenerateInsert.Name = "btnGenerateInsert";
            this.btnGenerateInsert.Size = new System.Drawing.Size(104, 33);
            this.btnGenerateInsert.TabIndex = 11;
            this.btnGenerateInsert.Text = "Insert";
            this.btnGenerateInsert.UseVisualStyleBackColor = false;
            // 
            // btnGenerateUpdate
            // 
            this.btnGenerateUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnGenerateUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnGenerateUpdate.FlatAppearance.BorderSize = 2;
            this.btnGenerateUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateUpdate.ForeColor = System.Drawing.Color.White;
            this.btnGenerateUpdate.Location = new System.Drawing.Point(138, 609);
            this.btnGenerateUpdate.Name = "btnGenerateUpdate";
            this.btnGenerateUpdate.Size = new System.Drawing.Size(104, 33);
            this.btnGenerateUpdate.TabIndex = 12;
            this.btnGenerateUpdate.Text = "Update";
            this.btnGenerateUpdate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "SQL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(728, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "LST";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(723, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plik";
            // 
            // BitId
            // 
            this.BitId.FillWeight = 25F;
            this.BitId.HeaderText = "Bit";
            this.BitId.Name = "BitId";
            // 
            // BitSize
            // 
            this.BitSize.FillWeight = 30F;
            this.BitSize.HeaderText = "Max Size";
            this.BitSize.Name = "BitSize";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CurrentOption
            // 
            this.CurrentOption.FillWeight = 75F;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateUpdate);
            this.Controls.Add(this.btnGenerateInsert);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMysqlFormula);
            this.Controls.Add(this.btnSetOne);
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
        private System.Windows.Forms.Button btnSetOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSize;
        private System.Windows.Forms.TextBox txtBoxMysqlFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnGenerateInsert;
        private System.Windows.Forms.Button btnGenerateUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrentOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

