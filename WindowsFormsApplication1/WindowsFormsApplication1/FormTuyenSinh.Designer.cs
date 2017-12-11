namespace WindowsFormsApplication1
{
    partial class FormTuyenSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTuyenSinh));
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonDong = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewTS = new System.Windows.Forms.DataGridView();
            this.TenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDaTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panelButton.Controls.Add(this.buttonDong);
            this.panelButton.Controls.Add(this.buttonXoa);
            this.panelButton.Controls.Add(this.buttonSua);
            this.panelButton.Controls.Add(this.buttonThem);
            this.panelButton.Location = new System.Drawing.Point(12, 448);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(996, 71);
            this.panelButton.TabIndex = 1;
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDong.Location = new System.Drawing.Point(671, 19);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(100, 40);
            this.buttonDong.TabIndex = 4;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoa.Location = new System.Drawing.Point(542, 19);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 40);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSua.Location = new System.Drawing.Point(416, 19);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(100, 40);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(283, 19);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 40);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewTS
            // 
            this.dataGridViewTS.AllowUserToAddRows = false;
            this.dataGridViewTS.AllowUserToDeleteRows = false;
            this.dataGridViewTS.AllowUserToOrderColumns = true;
            this.dataGridViewTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTS.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTruong,
            this.MaTruong,
            this.Nam,
            this.ChiTieu,
            this.SLDaTuyen});
            this.dataGridViewTS.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewTS.Name = "dataGridViewTS";
            this.dataGridViewTS.ReadOnly = true;
            this.dataGridViewTS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTS.RowHeadersVisible = false;
            this.dataGridViewTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTS.Size = new System.Drawing.Size(996, 356);
            this.dataGridViewTS.TabIndex = 2;
            // 
            // TenTruong
            // 
            this.TenTruong.DataPropertyName = "TenTruong";
            this.TenTruong.HeaderText = "Tên Trường";
            this.TenTruong.Name = "TenTruong";
            this.TenTruong.ReadOnly = true;
            // 
            // MaTruong
            // 
            this.MaTruong.DataPropertyName = "MaTruong";
            this.MaTruong.HeaderText = "Mã Trường";
            this.MaTruong.Name = "MaTruong";
            this.MaTruong.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // ChiTieu
            // 
            this.ChiTieu.DataPropertyName = "ChiTieu";
            this.ChiTieu.HeaderText = "Chỉ tiêu tuyển sinh";
            this.ChiTieu.Name = "ChiTieu";
            this.ChiTieu.ReadOnly = true;
            // 
            // SLDaTuyen
            // 
            this.SLDaTuyen.DataPropertyName = "SLDaTuyen";
            this.SLDaTuyen.HeaderText = "Đã Tuyển";
            this.SLDaTuyen.Name = "SLDaTuyen";
            this.SLDaTuyen.ReadOnly = true;
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNam.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "Tất cả",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.comboBoxNam.Location = new System.Drawing.Point(513, 26);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 30);
            this.comboBoxNam.TabIndex = 3;
            this.comboBoxNam.SelectedIndexChanged += new System.EventHandler(this.comboBoxNam_SelectedIndexChanged);
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.ForeColor = System.Drawing.Color.White;
            this.labelNam.Location = new System.Drawing.Point(384, 26);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(106, 26);
            this.labelNam.TabIndex = 4;
            this.labelNam.Text = "Chọn năm";
            // 
            // FormTuyenSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1020, 550);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.dataGridViewTS);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTuyenSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dữ liệu Tuyển sinh";
            this.Load += new System.EventHandler(this.FormTuyenSinh_Load);
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewTS;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDaTuyen;
    }
}