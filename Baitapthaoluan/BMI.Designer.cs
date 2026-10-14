namespace Baitapthaoluan
{
    partial class BMI
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
            this.grpChieuCao = new System.Windows.Forms.GroupBox();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.grpChieuCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChieuCao
            // 
            this.grpChieuCao.Controls.Add(this.txtPhanLoai);
            this.grpChieuCao.Controls.Add(this.txtBMI);
            this.grpChieuCao.Controls.Add(this.txtCanNang);
            this.grpChieuCao.Controls.Add(this.txtChieuCao);
            this.grpChieuCao.Controls.Add(this.lblPhanLoai);
            this.grpChieuCao.Controls.Add(this.lblBMI);
            this.grpChieuCao.Controls.Add(this.lblCanNang);
            this.grpChieuCao.Controls.Add(this.lblChieuCao);
            this.grpChieuCao.Location = new System.Drawing.Point(63, 26);
            this.grpChieuCao.Name = "grpChieuCao";
            this.grpChieuCao.Size = new System.Drawing.Size(520, 273);
            this.grpChieuCao.TabIndex = 0;
            this.grpChieuCao.TabStop = false;
            this.grpChieuCao.Text = "Thông tin cơ thể";
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(170, 326);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(75, 23);
            this.btnBMI.TabIndex = 1;
            this.btnBMI.Text = "Tính BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(385, 326);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 1;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(25, 44);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(95, 16);
            this.lblChieuCao.TabIndex = 0;
            this.lblChieuCao.Text = "Chiều cao(Cm)";
            // 
            // lblCanNang
            // 
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location = new System.Drawing.Point(25, 101);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Size = new System.Drawing.Size(87, 16);
            this.lblCanNang.TabIndex = 0;
            this.lblCanNang.Text = "Cân nặng(kg)";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(38, 155);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(70, 16);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "Chỉ số BMI";
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(38, 213);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(63, 16);
            this.lblPhanLoai.TabIndex = 0;
            this.lblPhanLoai.Text = "Phân loại";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(126, 41);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(292, 22);
            this.txtChieuCao.TabIndex = 1;
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(126, 101);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(292, 22);
            this.txtCanNang.TabIndex = 1;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(126, 155);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(292, 22);
            this.txtBMI.TabIndex = 1;
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.Location = new System.Drawing.Point(126, 213);
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.Size = new System.Drawing.Size(292, 22);
            this.txtPhanLoai.TabIndex = 1;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.grpChieuCao);
            this.Name = "BMI";
            this.Text = "BMI";
            this.grpChieuCao.ResumeLayout(false);
            this.grpChieuCao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChieuCao;
        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnLamLai;
    }
}