namespace QuanLyBanVeTau
{
    partial class TaoAccount
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtXacnhan = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Image = global::QuanLyBanVeTau.Properties.Resources.background1;
            label2.Location = new System.Drawing.Point(10, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 19);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Image = global::QuanLyBanVeTau.Properties.Resources.background1;
            label3.Location = new System.Drawing.Point(9, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 19);
            label3.TabIndex = 0;
            label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Image = global::QuanLyBanVeTau.Properties.Resources.background1;
            label4.Location = new System.Drawing.Point(9, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 19);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Image = global::QuanLyBanVeTau.Properties.Resources.background1;
            label5.Location = new System.Drawing.Point(8, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(146, 19);
            label5.TabIndex = 0;
            label5.Text = "Xác nhận Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Image = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.label7.Location = new System.Drawing.Point(555, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tạo Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Image = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.label1.Location = new System.Drawing.Point(90, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Account";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.panel1.Controls.Add(this.data2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(35, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 339);
            this.panel1.TabIndex = 7;
            // 
            // data2
            // 
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Location = new System.Drawing.Point(3, 29);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(395, 307);
            this.data2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.panel2.Controls.Add(this.txtAccount);
            this.panel2.Controls.Add(label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(462, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 44);
            this.panel2.TabIndex = 1;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(99, 9);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(208, 20);
            this.txtAccount.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Controls.Add(label3);
            this.panel3.Location = new System.Drawing.Point(462, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 44);
            this.panel3.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(99, 9);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(208, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Controls.Add(label4);
            this.panel4.Location = new System.Drawing.Point(462, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 44);
            this.panel4.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(99, 10);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(208, 20);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.panel5.Controls.Add(this.txtXacnhan);
            this.panel5.Controls.Add(label5);
            this.panel5.Location = new System.Drawing.Point(439, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 44);
            this.panel5.TabIndex = 4;
            // 
            // txtXacnhan
            // 
            this.txtXacnhan.Location = new System.Drawing.Point(160, 11);
            this.txtXacnhan.Name = "txtXacnhan";
            this.txtXacnhan.Size = new System.Drawing.Size(170, 20);
            this.txtXacnhan.TabIndex = 1;
            this.txtXacnhan.UseSystemPasswordChar = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(462, 359);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(106, 36);
            this.btnTao.TabIndex = 5;
            this.btnTao.Text = "Tạo Account";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(672, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TaoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(781, 454);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TaoAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoAccount";
            this.Load += new System.EventHandler(this.TaoAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacnhan;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnThoat;
    }
}