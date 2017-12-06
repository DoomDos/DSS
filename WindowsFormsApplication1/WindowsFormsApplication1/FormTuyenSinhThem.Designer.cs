namespace WindowsFormsApplication1
{
    partial class FormTuyenSinhThem
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
            this.labelDaTuyen = new System.Windows.Forms.Label();
            this.labelChiTieu = new System.Windows.Forms.Label();
            this.labelNam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTenTruong = new System.Windows.Forms.Label();
            this.ChiTieu = new System.Windows.Forms.TextBox();
            this.Nam = new System.Windows.Forms.TextBox();
            this.DaTuyen = new System.Windows.Forms.TextBox();
            this.TenTruong = new System.Windows.Forms.ComboBox();
            this.MaTruong = new System.Windows.Forms.ComboBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDaTuyen
            // 
            this.labelDaTuyen.AutoSize = true;
            this.labelDaTuyen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaTuyen.ForeColor = System.Drawing.Color.White;
            this.labelDaTuyen.Location = new System.Drawing.Point(63, 240);
            this.labelDaTuyen.Name = "labelDaTuyen";
            this.labelDaTuyen.Size = new System.Drawing.Size(100, 26);
            this.labelDaTuyen.TabIndex = 1;
            this.labelDaTuyen.Text = "Đã Tuyển";
            // 
            // labelChiTieu
            // 
            this.labelChiTieu.AutoSize = true;
            this.labelChiTieu.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiTieu.ForeColor = System.Drawing.Color.White;
            this.labelChiTieu.Location = new System.Drawing.Point(74, 190);
            this.labelChiTieu.Name = "labelChiTieu";
            this.labelChiTieu.Size = new System.Drawing.Size(84, 26);
            this.labelChiTieu.TabIndex = 2;
            this.labelChiTieu.Text = "Chỉ tiêu";
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.ForeColor = System.Drawing.Color.White;
            this.labelNam.Location = new System.Drawing.Point(102, 140);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(56, 26);
            this.labelNam.TabIndex = 3;
            this.labelNam.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Trường";
            // 
            // labelTenTruong
            // 
            this.labelTenTruong.AutoSize = true;
            this.labelTenTruong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTruong.ForeColor = System.Drawing.Color.White;
            this.labelTenTruong.Location = new System.Drawing.Point(40, 40);
            this.labelTenTruong.Name = "labelTenTruong";
            this.labelTenTruong.Size = new System.Drawing.Size(119, 26);
            this.labelTenTruong.TabIndex = 5;
            this.labelTenTruong.Text = "Tên Trường";
            // 
            // ChiTieu
            // 
            this.ChiTieu.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTieu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ChiTieu.Location = new System.Drawing.Point(183, 187);
            this.ChiTieu.Name = "ChiTieu";
            this.ChiTieu.Size = new System.Drawing.Size(386, 33);
            this.ChiTieu.TabIndex = 7;
            // 
            // Nam
            // 
            this.Nam.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Nam.Location = new System.Drawing.Point(183, 137);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(386, 33);
            this.Nam.TabIndex = 8;
            // 
            // DaTuyen
            // 
            this.DaTuyen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaTuyen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DaTuyen.Location = new System.Drawing.Point(183, 237);
            this.DaTuyen.Name = "DaTuyen";
            this.DaTuyen.Size = new System.Drawing.Size(386, 33);
            this.DaTuyen.TabIndex = 10;
            // 
            // TenTruong
            // 
            this.TenTruong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTruong.FormattingEnabled = true;
            this.TenTruong.Location = new System.Drawing.Point(183, 37);
            this.TenTruong.Name = "TenTruong";
            this.TenTruong.Size = new System.Drawing.Size(386, 34);
            this.TenTruong.TabIndex = 11;
            // 
            // MaTruong
            // 
            this.MaTruong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTruong.FormattingEnabled = true;
            this.MaTruong.Location = new System.Drawing.Point(183, 87);
            this.MaTruong.Name = "MaTruong";
            this.MaTruong.Size = new System.Drawing.Size(386, 34);
            this.MaTruong.TabIndex = 12;
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLuu.Location = new System.Drawing.Point(183, 295);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(174, 35);
            this.buttonLuu.TabIndex = 13;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(254)))));
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHuy.Location = new System.Drawing.Point(395, 295);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(174, 35);
            this.buttonHuy.TabIndex = 14;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // FormTuyenSinhThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(254)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(617, 357);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.MaTruong);
            this.Controls.Add(this.TenTruong);
            this.Controls.Add(this.DaTuyen);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.ChiTieu);
            this.Controls.Add(this.labelTenTruong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelChiTieu);
            this.Controls.Add(this.labelDaTuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTuyenSinhThem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTuyenSinhThem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDaTuyen;
        private System.Windows.Forms.Label labelChiTieu;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTenTruong;
        private System.Windows.Forms.TextBox ChiTieu;
        private System.Windows.Forms.TextBox Nam;
        private System.Windows.Forms.TextBox DaTuyen;
        private System.Windows.Forms.ComboBox TenTruong;
        private System.Windows.Forms.ComboBox MaTruong;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHuy;
    }
}