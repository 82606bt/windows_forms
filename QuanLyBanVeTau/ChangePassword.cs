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
    public partial class ChangePassword : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True");

        public ChangePassword()
        {
            InitializeComponent();
        }
  
        void xoatextbox()
        {
            txtAccount.Clear();
            matkhauht.Clear();

            txtXacnhan.Clear();
        }
        void change()
        {
            connect.Open();
            string sql = ("update Account set Password ='"+matkhaumoi.Text+"' where UserName ='"+txtAccount.Text+"' and Password ='"+matkhauht.Text+"'");
            SqlCommand com = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "Select Count(*) From Account Where UserName=@acc And Password =@pass";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@acc", txtAccount.Text));
                cmd.Parameters.Add(new SqlParameter("@pass", matkhauht.Text));
                int x = (int)cmd.ExecuteScalar();
                connect.Close();
                if (x == 1)
                {
                    if (matkhaumoi.Text != txtXacnhan.Text)
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp", "Thông Báo");
                    }
                    else
                    {
                        change();
                        xoatextbox();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mặt khẩu", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
 
        }
    }
}
