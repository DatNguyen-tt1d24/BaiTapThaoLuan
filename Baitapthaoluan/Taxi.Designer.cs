namespace Baitapthaoluan
{
    partial class Taxi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtSoKM = new System.Windows.Forms.TextBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblSoKM = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtSoKM);
            this.groupBox1.Controls.Add(this.lblTien);
            this.groupBox1.Controls.Add(this.lblSoKM);
            this.groupBox1.Controls.Add(this.btnLamLai);
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Location = new System.Drawing.Point(50, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÍNH TIỀN TAXI";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(149, 162);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(373, 22);
            this.txtTien.TabIndex = 2;
            // 
            // txtSoKM
            // 
            this.txtSoKM.Location = new System.Drawing.Point(149, 101);
            this.txtSoKM.Name = "txtSoKM";
            this.txtSoKM.Size = new System.Drawing.Size(373, 22);
            this.txtSoKM.TabIndex = 2;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(34, 168);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(95, 16);
            this.lblTien.TabIndex = 1;
            this.lblTien.Text = "Số tiền phải trả";
            // 
            // lblSoKM
            // 
            this.lblSoKM.AutoSize = true;
            this.lblSoKM.Location = new System.Drawing.Point(34, 101);
            this.lblSoKM.Name = "lblSoKM";
            this.lblSoKM.Size = new System.Drawing.Size(46, 16);
            this.lblSoKM.TabIndex = 1;
            this.lblSoKM.Text = "Số Km";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(468, 265);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(88, 39);
            this.btnLamLai.TabIndex = 0;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(290, 265);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(110, 39);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính ";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Taxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Taxi";
            this.Text = "Tiền Taxi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtSoKM;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblSoKM;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTinh;
    }
}