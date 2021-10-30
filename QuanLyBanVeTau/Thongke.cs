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
    public partial class Thongke : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True");
        private DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (connect)
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
        void loadbill(DateTime date )
        {
            string sql = "sp_CheckBill @datecheck";
            datathongke.DataSource = ExecuteQuery(sql, new object[] { date });
        }
        public Thongke()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime date = dataNgay.Value;
            loadbill(date);
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            DateTime date = dataNgay.Value;
            loadbill(date);
        }

        private void dataNgay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
