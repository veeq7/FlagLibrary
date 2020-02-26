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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxFlaga = new System.Windows.Forms.ComboBox();
            this.txtBoxBits = new System.Windows.Forms.TextBox();
            this.lblFlaga = new System.Windows.Forms.Label();
            this.lblBity = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOption = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetOne = new System.Windows.Forms.Button();
            this.txtBoxMysqlFormula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateSqlText = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuestionMark = new System.Windows.Forms.Button();
            this.cmbBoxSql = new System.Windows.Forms.ComboBox();
            this.cmbBoxConvert = new System.Windows.Forms.ComboBox();
            this.btnFindXMLs = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnFindXML = new System.Windows.Forms.Button();
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
            this.comboBoxFlaga.Location = new System.Drawing.Point(115, 55);
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
            this.txtBoxBits.Location = new System.Drawing.Point(1107, 56);
            this.txtBoxBits.Name = "txtBoxBits";
            this.txtBoxBits.Size = new System.Drawing.Size(162, 32);
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
            this.lblBity.Location = new System.Drawing.Point(1033, 57);
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
            this.btnShow.Location = new System.Drawing.Point(1275, 56);
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
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView.Location = new System.Drawing.Point(27, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(1332, 471);
            this.dataGridView.TabIndex = 4;
            // 
            // BitId
            // 
            this.BitId.FillWeight = 0.35F;
            this.BitId.HeaderText = "Bit";
            this.BitId.Name = "BitId";
            // 
            // BitSize
            // 
            this.BitSize.FillWeight = 0.45F;
            this.BitSize.HeaderText = "Max Size";
            this.BitSize.Name = "BitSize";
            // 
            // Description
            // 
            this.Description.FillWeight = 4F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CurrentOption
            // 
            this.CurrentOption.FillWeight = 0.8F;
            this.CurrentOption.HeaderText = "Current option";
            this.CurrentOption.Name = "CurrentOption";
            this.CurrentOption.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentOption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Value
            // 
            this.Value.FillWeight = 0.4F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(921, 56);
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
            this.btnSetOne.Location = new System.Drawing.Point(977, 56);
            this.btnSetOne.Name = "btnSetOne";
            this.btnSetOne.Size = new System.Drawing.Size(50, 33);
            this.btnSetOne.TabIndex = 7;
            this.btnSetOne.Text = "1";
            this.btnSetOne.UseVisualStyleBackColor = false;
            this.btnSetOne.Click += new System.EventHandler(this.btnSetOne_onClick);
            // 
            // txtBoxMysqlFormula
            // 
            this.txtBoxMysqlFormula.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxMysqlFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBoxMysqlFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMysqlFormula.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtBoxMysqlFormula.ForeColor = System.Drawing.Color.White;
            this.txtBoxMysqlFormula.Location = new System.Drawing.Point(402, 620);
            this.txtBoxMysqlFormula.Name = "txtBoxMysqlFormula";
            this.txtBoxMysqlFormula.Size = new System.Drawing.Size(672, 26);
            this.txtBoxMysqlFormula.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Generuj:";
            // 
            // btnGenerateSqlText
            // 
            this.btnGenerateSqlText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerateSqlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnGenerateSqlText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnGenerateSqlText.FlatAppearance.BorderSize = 2;
            this.btnGenerateSqlText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSqlText.ForeColor = System.Drawing.Color.White;
            this.btnGenerateSqlText.Location = new System.Drawing.Point(287, 613);
            this.btnGenerateSqlText.Name = "btnGenerateSqlText";
            this.btnGenerateSqlText.Size = new System.Drawing.Size(104, 33);
            this.btnGenerateSqlText.TabIndex = 12;
            this.btnGenerateSqlText.Text = "Stwórz";
            this.btnGenerateSqlText.UseVisualStyleBackColor = false;
            this.btnGenerateSqlText.Click += new System.EventHandler(this.btnGenerateSqlText_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "SQL";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnConvert.FlatAppearance.BorderSize = 2;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(1266, 612);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 33);
            this.btnConvert.TabIndex = 14;
            this.btnConvert.TabStop = false;
            this.btnConvert.Text = "Konwertuj";
            this.btnConvert.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1132, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plik";
            // 
            // btnQuestionMark
            // 
            this.btnQuestionMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnQuestionMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnQuestionMark.FlatAppearance.BorderSize = 2;
            this.btnQuestionMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionMark.ForeColor = System.Drawing.Color.White;
            this.btnQuestionMark.Location = new System.Drawing.Point(865, 56);
            this.btnQuestionMark.Name = "btnQuestionMark";
            this.btnQuestionMark.Size = new System.Drawing.Size(50, 33);
            this.btnQuestionMark.TabIndex = 16;
            this.btnQuestionMark.Text = "?";
            this.btnQuestionMark.UseVisualStyleBackColor = false;
            this.btnQuestionMark.Click += new System.EventHandler(this.btnQuestionMark_Click);
            // 
            // cmbBoxSql
            // 
            this.cmbBoxSql.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbBoxSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbBoxSql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSql.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbBoxSql.FormattingEnabled = true;
            this.cmbBoxSql.Items.AddRange(new object[] {
            "Insert",
            "Update"});
            this.cmbBoxSql.Location = new System.Drawing.Point(146, 617);
            this.cmbBoxSql.Name = "cmbBoxSql";
            this.cmbBoxSql.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxSql.TabIndex = 17;
            // 
            // cmbBoxConvert
            // 
            this.cmbBoxConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbBoxConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbBoxConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxConvert.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbBoxConvert.FormattingEnabled = true;
            this.cmbBoxConvert.Items.AddRange(new object[] {
            "lst to xml",
            "xml to lst"});
            this.cmbBoxConvert.Location = new System.Drawing.Point(1132, 617);
            this.cmbBoxConvert.Name = "cmbBoxConvert";
            this.cmbBoxConvert.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxConvert.TabIndex = 18;
            // 
            // btnFindXMLs
            // 
            this.btnFindXMLs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnFindXMLs.BackgroundImage = global::BitwiseCalculatorUI.Properties.Resources.Folder2;
            this.btnFindXMLs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindXMLs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindXMLs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnFindXMLs.FlatAppearance.BorderSize = 5;
            this.btnFindXMLs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindXMLs.ForeColor = System.Drawing.Color.White;
            this.btnFindXMLs.Location = new System.Drawing.Point(324, 56);
            this.btnFindXMLs.Name = "btnFindXMLs";
            this.btnFindXMLs.Size = new System.Drawing.Size(33, 33);
            this.btnFindXMLs.TabIndex = 17;
            this.btnFindXMLs.TabStop = false;
            this.btnFindXMLs.UseVisualStyleBackColor = false;
            this.btnFindXMLs.Click += new System.EventHandler(this.btnFindXMLFolder_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnCopyToClipboard.BackgroundImage = global::BitwiseCalculatorUI.Properties.Resources.document4;
            this.btnCopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopyToClipboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnCopyToClipboard.FlatAppearance.BorderSize = 5;
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(1085, 612);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(37, 33);
            this.btnCopyToClipboard.TabIndex = 10;
            this.btnCopyToClipboard.TabStop = false;
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnFindXML
            // 
            this.btnFindXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnFindXML.BackgroundImage = global::BitwiseCalculatorUI.Properties.Resources.Document5;
            this.btnFindXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(220)))));
            this.btnFindXML.FlatAppearance.BorderSize = 5;
            this.btnFindXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindXML.ForeColor = System.Drawing.Color.White;
            this.btnFindXML.Location = new System.Drawing.Point(281, 55);
            this.btnFindXML.Name = "btnFindXML";
            this.btnFindXML.Size = new System.Drawing.Size(37, 33);
            this.btnFindXML.TabIndex = 5;
            this.btnFindXML.TabStop = false;
            this.btnFindXML.UseVisualStyleBackColor = false;
            this.btnFindXML.Click += new System.EventHandler(this.btnFindXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1400, 681);
            this.Controls.Add(this.cmbBoxConvert);
            this.Controls.Add(this.cmbBoxSql);
            this.Controls.Add(this.btnFindXMLs);
            this.Controls.Add(this.btnQuestionMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateSqlText);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculator";
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
        private System.Windows.Forms.Button btnGenerateSqlText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuestionMark;
        private System.Windows.Forms.ComboBox cmbBoxSql;
        private System.Windows.Forms.ComboBox cmbBoxConvert;

        private System.Windows.Forms.Button btnFindXMLs;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrentOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

