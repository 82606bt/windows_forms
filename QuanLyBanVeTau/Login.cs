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

    
    public partial class Login : Form 
    {
        string strConnection = @"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
     
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thoat == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void checkmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmatkhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Count(*) From Account Where UserName=@acc And Password =@pass";
                conn = new SqlConnection(strConnection);
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txttaikhoan.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtmatkhau.Text));
                int x = (int)command.ExecuteScalar();
                string userName = txttaikhoan.Text;
                
                if (x == 1)
                {
                    Account loginAccount = GetAccountByUserName(userName);
                    GiaoDien giaodien = new GiaoDien(loginAccount);                   
                    this.Hide();
                    giaodien.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mặt khẩu","Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Account GetAccountByUserName(string username)
        {
            conn = new SqlConnection(strConnection);
            conn.Open();
            command = new SqlCommand(("select * from Account where UserName = '" + username + "'"), conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow item in dt.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
