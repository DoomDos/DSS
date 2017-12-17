namespace WindowsFormsApplication1
{
    partial class FormTuVan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTuVan));
            this.comboBoxTuVan = new System.Windows.Forms.ComboBox();
            this.textBoxTruong = new System.Windows.Forms.TextBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.buttonTuVan = new System.Windows.Forms.Button();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.buttonDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTuVan
            // 
            this.comboBoxTuVan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTuVan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTuVan.FormattingEnabled = true;
            this.comboBoxTuVan.Items.AddRange(new object[] {
            "Mã Trường",
            "Tên Trường"});
            this.comboBoxTuVan.Location = new System.Drawing.Point(185, 64);
            this.comboBoxTuVan.Name = "comboBoxTuVan";
            this.comboBoxTuVan.Size = new System.Drawing.Size(174, 30);
            this.comboBoxTuVan.TabIndex = 0;
            // 
            // textBoxTruong
            // 
            this.textBoxTruong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTruong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTruong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTruong.Location = new System.Drawing.Point(404, 61);
            this.textBoxTruong.Name = "textBoxTruong";
            this.textBoxTruong.Size = new System.Drawing.Size(516, 29);
            this.textBoxTruong.TabIndex = 1;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.ForeColor = System.Drawing.Color.White;
            this.labelNam.Location = new System.Drawing.Point(303, 114);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(56, 26);
            this.labelNam.TabIndex = 2;
            this.labelNam.Text = "Năm";
            // 
            // textBoxNam
            // 
            this.textBoxNam.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNam.Location = new System.Drawing.Point(404, 114);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(516, 29);
            this.textBoxNam.TabIndex = 3;
            // 
            // buttonTuVan
            // 
            this.buttonTuVan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.buttonTuVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuVan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTuVan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTuVan.Location = new System.Drawing.Point(404, 188);
            this.buttonTuVan.Name = "buttonTuVan";
            this.buttonTuVan.Size = new System.Drawing.Size(516, 40);
            this.buttonTuVan.TabIndex = 4;
            this.buttonTuVan.Text = "Tư Vấn";
            this.buttonTuVan.UseVisualStyleBackColor = false;
            this.buttonTuVan.Click += new System.EventHandler(this.buttonTuVan_Click);
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.Color.Red;
            this.labelSoLuong.Location = new System.Drawing.Point(195, 270);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(174, 28);
            this.labelSoLuong.TabIndex = 5;
            this.labelSoLuong.Text = "Số lượng tuyển: ";
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.ForeColor = System.Drawing.Color.Red;
            this.labelKetQua.Location = new System.Drawing.Point(399, 270);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(0, 28);
            this.labelKetQua.TabIndex = 6;
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.buttonDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDong.Location = new System.Drawing.Point(563, 372);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(216, 34);
            this.buttonDong.TabIndex = 7;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // FormTuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.buttonTuVan);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.textBoxTruong);
            this.Controls.Add(this.comboBoxTuVan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTuVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tư vấn";
            this.Load += new System.EventHandler(this.FormTuVan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTuVan;
        private System.Windows.Forms.TextBox textBoxTruong;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Button buttonTuVan;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.Button buttonDong;
    }
}