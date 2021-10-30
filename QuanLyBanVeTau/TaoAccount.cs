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
    public partial class TaoAccount : Form

    {

        SqlConnection connect = new SqlConnection(@"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True");
        void loaddata()
        {
            connect.Open();
            string sql= ("select UserName as N'Tài khoản', Name as N'Tên', Type as N'Loại tài khoản(0 = admin)' from Account");
            SqlCommand com = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            data2.DataSource = dt;
        }
        void xoatextbox()
        {
            txtAccount.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtXacnhan.Clear();
        }
        int check(string Account)
        {
            string sql = "select *from Account where UserName = '" + Account + "'";
            DataTable result = ExecuteQuery(sql);
            return result.Rows.Count;
        }
        void taoaccount()
        {
            connect.Open();
            string sql = ("insert Account values('" + txtAccount.Text + "','" + txtMatKhau.Text + "',N'" + txtHoTen.Text + "',1)");
            SqlCommand com = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            data2.DataSource = dt;
        }
        public TaoAccount()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaoAccount_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (check(txtAccount.Text) != 0) {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
            else  if(txtMatKhau.Text != txtXacnhan.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp","Thông Báo");
            }
            else
            {
                taoaccount();
                loaddata();
                xoatextbox();
            }
        }
        private DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            string con = @"Data Source = JACKL\SQLEXPRESS; Initial Catalog = QLT; Integrated Security = True";
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                //Tạo biến cmd để thực thi Excute câu query, connection để biết kết nối đến dtb nào
                SqlCommand cmd = new SqlCommand(query, connect);
                //Lấy dữ liệu ra (cmd.ExecuteReader)

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //Lấy dữ liệu xuất ra từ cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Cho dữ liệu từ adapter vào dữ liệu bản data
                adapter.Fill(data);
                connect.Close();
            }

            return data;
        }

    }
}
