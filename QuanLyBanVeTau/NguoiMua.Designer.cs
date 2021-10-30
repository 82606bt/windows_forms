namespace QuanLyBanVeTau
{
    partial class NguoiMua
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
            this.SDT = new System.Windows.Forms.TextBox();
            this.CMND = new System.Windows.Forms.TextBox();
            this.IDVT = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbanve = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.datamua = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SDT);
            this.groupBox1.Controls.Add(this.CMND);
            this.groupBox1.Controls.Add(this.IDVT);
            this.groupBox1.Controls.Add(this.Ten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(447, 121);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(116, 21);
            this.SDT.TabIndex = 4;
            this.SDT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(447, 26);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(116, 21);
            this.CMND.TabIndex = 3;
            this.CMND.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IDVT
            // 
            this.IDVT.Location = new System.Drawing.Point(122, 25);
            this.IDVT.Name = "IDVT";
            this.IDVT.Size = new System.Drawing.Size(126, 21);
            this.IDVT.TabIndex = 1;
            this.IDVT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(122, 118);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(126, 21);
            this.Ten.TabIndex = 2;
            this.Ten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã vé tàu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người mua:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbanve);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Location = new System.Drawing.Point(256, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnbanve
            // 
            this.btnbanve.Location = new System.Drawing.Point(20, 40);
            this.btnbanve.Name = "btnbanve";
            this.btnbanve.Size = new System.Drawing.Size(75, 23);
            this.btnbanve.TabIndex = 0;
            this.btnbanve.Text = "Bán Vé";
            this.btnbanve.UseVisualStyleBackColor = true;
            this.btnbanve.Click += new System.EventHandler(this.btnbanve_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(191, 40);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // datamua
            // 
            this.datamua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamua.Location = new System.Drawing.Point(49, 284);
            this.datamua.Name = "datamua";
            this.datamua.Size = new System.Drawing.Size(678, 150);
            this.datamua.TabIndex = 0;
            // 
            // NguoiMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(775, 584);
            this.Controls.Add(this.datamua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NguoiMua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NguoiMua";
            this.Load += new System.EventHandler(this.NguoiMua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datamua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbanve;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView datamua;
    }
}