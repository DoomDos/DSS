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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonTuVan = new System.Windows.Forms.Button();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.buttonDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTuVan
            // 
            this.comboBoxTuVan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTuVan.FormattingEnabled = true;
            this.comboBoxTuVan.Items.AddRange(new object[] {
            "Tên Trường",
            "Mã Trường"});
            this.comboBoxTuVan.Location = new System.Drawing.Point(23, 22);
            this.comboBoxTuVan.Name = "comboBoxTuVan";
            this.comboBoxTuVan.Size = new System.Drawing.Size(121, 30);
            this.comboBoxTuVan.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(170, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 29);
            this.textBox1.TabIndex = 1;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.ForeColor = System.Drawing.Color.White;
            this.labelNam.Location = new System.Drawing.Point(19, 64);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(56, 26);
            this.labelNam.TabIndex = 2;
            this.labelNam.Text = "Năm";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(170, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(403, 29);
            this.textBox2.TabIndex = 3;
            // 
            // buttonTuVan
            // 
            this.buttonTuVan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.buttonTuVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuVan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTuVan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTuVan.Location = new System.Drawing.Point(170, 109);
            this.buttonTuVan.Name = "buttonTuVan";
            this.buttonTuVan.Size = new System.Drawing.Size(403, 30);
            this.buttonTuVan.TabIndex = 4;
            this.buttonTuVan.Text = "Tư Vấn";
            this.buttonTuVan.UseVisualStyleBackColor = false;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.Color.Red;
            this.labelSoLuong.Location = new System.Drawing.Point(19, 188);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(124, 22);
            this.labelSoLuong.TabIndex = 5;
            this.labelSoLuong.Text = "Số lượng tuyển";
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.ForeColor = System.Drawing.Color.Red;
            this.labelKetQua.Location = new System.Drawing.Point(166, 188);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(163, 22);
            this.labelKetQua.TabIndex = 6;
            this.labelKetQua.Text = "Đây là kết quả trả về";
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.buttonDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDong.Location = new System.Drawing.Point(486, 182);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(87, 34);
            this.buttonDong.TabIndex = 7;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            // 
            // FormTuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(254)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(594, 241);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.buttonTuVan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxTuVan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTuVan";
            this.Text = "Tư vấn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTuVan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonTuVan;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.Button buttonDong;
    }
}