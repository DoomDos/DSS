namespace WindowsFormsApplication1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonTruong = new System.Windows.Forms.Button();
            this.buttonTuVan = new System.Windows.Forms.Button();
            this.labelMainForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonThoat.Location = new System.Drawing.Point(499, 169);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(190, 170);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonThoat.UseVisualStyleBackColor = false;
            // 
            // buttonTruong
            // 
            this.buttonTruong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonTruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTruong.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTruong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTruong.Image = ((System.Drawing.Image)(resources.GetObject("buttonTruong.Image")));
            this.buttonTruong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTruong.Location = new System.Drawing.Point(54, 166);
            this.buttonTruong.Name = "buttonTruong";
            this.buttonTruong.Size = new System.Drawing.Size(190, 170);
            this.buttonTruong.TabIndex = 1;
            this.buttonTruong.Text = "Dữ liệu";
            this.buttonTruong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonTruong.UseVisualStyleBackColor = false;
            this.buttonTruong.Click += new System.EventHandler(this.buttonTruong_Click);
            // 
            // buttonTuVan
            // 
            this.buttonTuVan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(46)))));
            this.buttonTuVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuVan.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTuVan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTuVan.Image = ((System.Drawing.Image)(resources.GetObject("buttonTuVan.Image")));
            this.buttonTuVan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTuVan.Location = new System.Drawing.Point(277, 166);
            this.buttonTuVan.Name = "buttonTuVan";
            this.buttonTuVan.Size = new System.Drawing.Size(190, 170);
            this.buttonTuVan.TabIndex = 2;
            this.buttonTuVan.Text = "Tư vấn";
            this.buttonTuVan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonTuVan.UseVisualStyleBackColor = false;
            this.buttonTuVan.Click += new System.EventHandler(this.buttonTroGiup_Click);
            // 
            // labelMainForm
            // 
            this.labelMainForm.AllowDrop = true;
            this.labelMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMainForm.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMainForm.Location = new System.Drawing.Point(54, 28);
            this.labelMainForm.Name = "labelMainForm";
            this.labelMainForm.Size = new System.Drawing.Size(635, 77);
            this.labelMainForm.TabIndex = 4;
            this.labelMainForm.Text = "Phần mềm dự báo số lượng sinh viên Công nghệ Thông tin của các trường đại học";
            this.labelMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(250)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(757, 383);
            this.Controls.Add(this.labelMainForm);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonTruong);
            this.Controls.Add(this.buttonTuVan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Phần mềm dự báo số lượng sinh viên Công nghệ Thông tin của các Trường Đại học";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonTuVan;
        private System.Windows.Forms.Button buttonTruong;
        private System.Windows.Forms.Label labelMainForm;
    }
}

