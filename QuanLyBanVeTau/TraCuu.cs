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
    public partial class TraCuu : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True");
        public TraCuu()
        {
            InitializeComponent();
        }
        //public int countbill()
        //{

        //    string sql = "select * from Hoadon";
        //    SqlCommand com = new SqlCommand(sql, connect);
        //    SqlDataAdapter da = new SqlDataAdapter(com);
        //    DataTable dt = new DataTable();
        //   return dt.Rows.Count;
        //}
        void xoatextbox()
        {
            Gaden.Clear();
            Gadi.Clear();
            
        }
      
        void caulenhSQL()
        {
            connect.Open();
            string sql = "select * from ThemVe where Gadi = @Gadi and Gaden = @Gaden and Loaive = @Loaive and Ngaydi = @Ngaydi  and Ngayve = @Ngayve ";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("Gadi", Gadi.Text);
            cmd.Parameters.AddWithValue("Gaden", Gaden.Text);
            cmd.Parameters.AddWithValue("Loaive", Loaive.Text);
            cmd.Parameters.AddWithValue("Ngaydi", DateTime.Parse(Ngaydi.Text));
            
            cmd.Parameters.AddWithValue("Ngayve", DateTime.Parse(Ngayve.Text));

            cmd.ExecuteNonQuery();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
          
            connect.Close();
            data4.DataSource = dt;



        }
        void BanVe()
        {
            string sql = " sp_AddHoadon @idve ";
            ExecuteQuery(sql, new object[] { IDVT.Text });
        }
        int countve(string IDVE)
        {
            string sql = "select *from Hoadon where IDVE = '"+IDVE+"'";
            DataTable result = ExecuteQuery(sql);
            return result.Rows.Count;
        }
        //int counthd(string idhd)
        //{
        //    string sql = "select *from Hoadon where IDHD = '" + idhd + "'";
        //    DataTable result = ExecuteQuery(sql);
        //    return result.Rows.Count;
        //}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            //IDHD.Text = (countbill() + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (Gadi.Text == "")
            {
                MessageBox.Show("Bạn để trống ga đi ", "Thông báo");
            }
            else if (Gaden.Text == "")
            {
                MessageBox.Show("Bạn để trống ga đến ", "Thông báo");
            }
            else if (Loaive.Text == "")
            {
                MessageBox.Show("Bạn để trống loại vé ", "Thông báo");
            }
            else if (Ngaydi.Text == "")
            {
                MessageBox.Show("Bạn để trống ngày đi ", "Thông báo");
            }
            else if (Ngayve.Text == "")
            {
                MessageBox.Show("Bạn để trống ngày về ", "Thông báo");
            }

            else {
                MessageBox.Show("Đây là những vé tra cứu được ", "Thông báo");
                caulenhSQL();
            }
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
                if (countve(IDVT.Text) == 0) {
                    BanVe();
                    MessageBox.Show("Đã lưu vào hóa đơn", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vé đã được bán hoặc không tồn tại", "Thông báo");
                }
            }
            //IDHD.Text = (countbill() + 1).ToString();
        private DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            string con = @"Data Source = JACKL\SQLEXPRESS; Initial Catalog = QLT; Integrated Security = True";
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(con) ) 
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            NguoiMua nguoimua = new NguoiMua();
            nguoimua.Show();
        }
    }
}
