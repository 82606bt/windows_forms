using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   

namespace QuanLyBanVeTau
{
    
    public partial class GiaoDien : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=PC01_22;Initial Catalog=QLT;Integrated Security=True");

        private Account loginAccount;

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value; ChangeAccount(loginAccount.Type);
            }
        }
        void ChangeAccount(int type)
        {
            doanhThuToolStripMenuItem.Enabled = type == 0;
            createAccountToolStripMenuItem.Enabled = type == 0;

        }

        public GiaoDien(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đặtĐổiVéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemVeTau banve = new ThemVeTau();
            banve.Show();
        }

        private void traCứuVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuu tracuu = new TraCuu();
            tracuu.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke thongke = new Thongke();
            thongke.Show();
        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }

        private void giớiThiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Được thiết kế bởi:Văn Long & Công Hiếu", "Copyright");
            Application.Exit();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoAccount New = new TaoAccount();
            New.Show();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void bánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
