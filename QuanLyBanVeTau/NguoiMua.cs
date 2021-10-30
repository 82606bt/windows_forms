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
using System.Text.RegularExpressions;

namespace QuanLyBanVeTau
{
    public partial class NguoiMua : Form

    {
        SqlConnection connect = new SqlConnection(@"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True");
        public NguoiMua()
        {
            InitializeComponent();
        }
        void loadata()
        {
           
        
                connect.Open();
                string sql = 
                "select IDVE as N'Mã Vé Mua', Ten as N'Tên Khách Hàng', CMND , SDT as'Số điện thoại',Giave 'Giá vé' from NguoiMua";
                 
                SqlCommand com = new SqlCommand(sql, connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connect.Close();
                datamua.DataSource = dt;
            
        }
        private DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            string con = @"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True";
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
        void them()
        {
            string sql = " sp_AddNguoiMua @idve , @ten , @cmnd , @sdt ";
            ExecuteQuery(sql, new object[] { IDVT.Text, Ten.Text,   CMND.Text,  SDT.Text });
        }
        int countve(string IDVT)
        {
            string sql = "select *from NguoiMua where IDVE = '" + IDVT + "'";
            DataTable result = ExecuteQuery(sql);
            return result.Rows.Count;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbanve_Click(object sender, EventArgs e)

        {
            if (countve(IDVT.Text) != 0)
            {
                MessageBox.Show("Trùng mã vé tàu", "Thông Báo");
                
            }
            else if(Ten.Text == "")
            {
                MessageBox.Show("Tên bị để trống", "Thông Báo");
            }
            else if(CMND.Text == "")
            {
                MessageBox.Show("CMND bị để trống", "Thông Báo");
            }
            else if( SDT.Text =="")
            {
                if(Regex.Match(SDT.Text, @"^(\+[0-9])$").Success)
                {
                    MessageBox.Show("SĐt phù hợp", "Thông Báo");
                }
            }

            else
            {
                them();
                loadata();

            }
        }

        private void NguoiMua_Load(object sender, EventArgs e)
        {
            loadata();
        }

        private void label6_Click(object sender, EventArgs e)
        {
                    
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
    }
}
