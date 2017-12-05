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
            this.ColumnDaTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChiTieuTuyenSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.buttonNam = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(254)))), ((int)(((byte)(46)))));
            this.panelButton.Controls.Add(this.buttonDong);
            this.panelButton.Controls.Add(this.buttonXoa);
            this.panelButton.Controls.Add(this.buttonSua);
            this.panelButton.Controls.Add(this.buttonThem);
            this.panelButton.Location = new System.Drawing.Point(0, 392);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(828, 71);
            this.panelButton.TabIndex = 1;
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDong.Location = new System.Drawing.Point(548, 19);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(100, 40);
            this.buttonDong.TabIndex = 4;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoa.Location = new System.Drawing.Point(424, 19);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 40);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSua.Location = new System.Drawing.Point(288, 19);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(100, 40);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(158, 19);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 40);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // ColumnDaTuyen
            // 
            this.ColumnDaTuyen.HeaderText = "Đã Tuyển";
            this.ColumnDaTuyen.Name = "ColumnDaTuyen";
            this.ColumnDaTuyen.ReadOnly = true;
            // 
            // ColumnChiTieuTuyenSinh
            // 
            this.ColumnChiTieuTuyenSinh.HeaderText = "Chỉ tiêu tuyển sinh";
            this.ColumnChiTieuTuyenSinh.Name = "ColumnChiTieuTuyenSinh";
            this.ColumnChiTieuTuyenSinh.ReadOnly = true;
            // 
            // ColumnNam
            // 
            this.ColumnNam.HeaderText = "Năm";
            this.ColumnNam.Name = "ColumnNam";
            this.ColumnNam.ReadOnly = true;
            // 
            // ColumnMaTruong
            // 
            this.ColumnMaTruong.HeaderText = "Mã Trường";
            this.ColumnMaTruong.Name = "ColumnMaTruong";
            this.ColumnMaTruong.ReadOnly = true;
            // 
            // ColumnTenTruong
            // 
            this.ColumnTenTruong.HeaderText = "Tên Trường";
            this.ColumnTenTruong.Name = "ColumnTenTruong";
            this.ColumnTenTruong.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenTruong,
            this.ColumnMaTruong,
            this.ColumnNam,
            this.ColumnChiTieuTuyenSinh,
            this.ColumnDaTuyen});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(805, 318);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.comboBoxNam.Location = new System.Drawing.Point(344, 26);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 30);
            this.comboBoxNam.TabIndex = 3;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.ForeColor = System.Drawing.Color.White;
            this.labelNam.Location = new System.Drawing.Point(218, 26);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(106, 26);
            this.labelNam.TabIndex = 4;
            this.labelNam.Text = "Chọn năm";
            // 
            // buttonNam
            // 
            this.buttonNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNam.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNam.Location = new System.Drawing.Point(501, 20);
            this.buttonNam.Name = "buttonNam";
            this.buttonNam.Size = new System.Drawing.Size(100, 40);
            this.buttonNam.TabIndex = 5;
            this.buttonNam.Text = "Xong";
            this.buttonNam.UseVisualStyleBackColor = false;
            // 
            // FormTuyenSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(254)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.buttonNam);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTuyenSinh";
            this.Text = "Dữ liệu Tuyển sinh";
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDaTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChiTieuTuyenSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenTruong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.Button buttonNam;
    }
}