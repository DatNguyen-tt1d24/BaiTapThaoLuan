namespace Baitapthaoluan
{
    partial class NhietDo
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
            this.grpHuong = new System.Windows.Forms.GroupBox();
            this.radFtoC = new System.Windows.Forms.RadioButton();
            this.radCtoF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhietdo = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtNhietdo = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnChuyendoi = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.grpHuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHuong
            // 
            this.grpHuong.Controls.Add(this.radFtoC);
            this.grpHuong.Controls.Add(this.radCtoF);
            this.grpHuong.Location = new System.Drawing.Point(180, 97);
            this.grpHuong.Name = "grpHuong";
            this.grpHuong.Size = new System.Drawing.Size(313, 109);
            this.grpHuong.TabIndex = 0;
            this.grpHuong.TabStop = false;
            this.grpHuong.Text = "Chọn hướng chuyển đổi";
            // 
            // radFtoC
            // 
            this.radFtoC.AutoSize = true;
            this.radFtoC.Location = new System.Drawing.Point(30, 58);
            this.radFtoC.Name = "radFtoC";
            this.radFtoC.Size = new System.Drawing.Size(100, 20);
            this.radFtoC.TabIndex = 0;
            this.radFtoC.TabStop = true;
            this.radFtoC.Text = "Từ F sang C";
            this.radFtoC.UseVisualStyleBackColor = true;
            // 
            // radCtoF
            // 
            this.radCtoF.AutoSize = true;
            this.radCtoF.Location = new System.Drawing.Point(30, 32);
            this.radCtoF.Name = "radCtoF";
            this.radCtoF.Size = new System.Drawing.Size(100, 20);
            this.radCtoF.TabIndex = 0;
            this.radCtoF.TabStop = true;
            this.radCtoF.Text = "Từ C sang F";
            this.radCtoF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHUYỂN ĐỔI NHIỆT ĐỘ ";
            // 
            // lblNhietdo
            // 
            this.lblNhietdo.AutoSize = true;
            this.lblNhietdo.Location = new System.Drawing.Point(54, 216);
            this.lblNhietdo.Name = "lblNhietdo";
            this.lblNhietdo.Size = new System.Drawing.Size(90, 16);
            this.lblNhietdo.TabIndex = 1;
            this.lblNhietdo.Text = "Nhiệt độ nhập";
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(54, 284);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(52, 16);
            this.lblKetqua.TabIndex = 1;
            this.lblKetqua.Text = "Kết quả";
            // 
            // txtNhietdo
            // 
            this.txtNhietdo.Location = new System.Drawing.Point(95, 246);
            this.txtNhietdo.Name = "txtNhietdo";
            this.txtNhietdo.Size = new System.Drawing.Size(346, 22);
            this.txtNhietdo.TabIndex = 2;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(86, 319);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(346, 22);
            this.txtKetqua.TabIndex = 2;
            // 
            // btnChuyendoi
            // 
            this.btnChuyendoi.Location = new System.Drawing.Point(486, 246);
            this.btnChuyendoi.Name = "btnChuyendoi";
            this.btnChuyendoi.Size = new System.Drawing.Size(104, 23);
            this.btnChuyendoi.TabIndex = 3;
            this.btnChuyendoi.Text = "Chuyển đổi";
            this.btnChuyendoi.UseVisualStyleBackColor = true;
            this.btnChuyendoi.Click += new System.EventHandler(this.btnChuyendoi_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(486, 307);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(104, 23);
            this.btnLamlai.TabIndex = 3;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // NhietDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnChuyendoi);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtNhietdo);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.lblNhietdo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpHuong);
            this.Name = "NhietDo";
            this.Text = "Chuyển đổi nhiệt độ";
            this.grpHuong.ResumeLayout(false);
            this.grpHuong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhietdo;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtNhietdo;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.RadioButton radFtoC;
        private System.Windows.Forms.RadioButton radCtoF;
        private System.Windows.Forms.Button btnChuyendoi;
        private System.Windows.Forms.Button btnLamlai;
    }
}