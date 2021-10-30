namespace QuanLyBanVeTau
{
    partial class Thongke
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
            this.btnThongke = new System.Windows.Forms.Button();
            this.dataNgay = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datathongke = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datathongke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongke);
            this.groupBox1.Controls.Add(this.dataNgay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(307, 25);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(108, 23);
            this.btnThongke.TabIndex = 1;
            this.btnThongke.Text = "Xem thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dataNgay
            // 
            this.dataNgay.Location = new System.Drawing.Point(31, 21);
            this.dataNgay.Name = "dataNgay";
            this.dataNgay.Size = new System.Drawing.Size(200, 22);
            this.dataNgay.TabIndex = 0;
            this.dataNgay.ValueChanged += new System.EventHandler(this.dataNgay_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.panel1.Controls.Add(this.datathongke);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 434);
            this.panel1.TabIndex = 2;
            // 
            // datathongke
            // 
            this.datathongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongke.Location = new System.Drawing.Point(10, 9);
            this.datathongke.Name = "datathongke";
            this.datathongke.Size = new System.Drawing.Size(422, 418);
            this.datathongke.TabIndex = 0;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeTau.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(462, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datathongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DateTimePicker dataNgay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datathongke;
    }
}