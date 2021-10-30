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
    public partial class ThemVeTau : Form
        
    {
        SqlConnection connect = new SqlConnection(@"Data Source=JACKL\SQLEXPRESS;Initial Catalog=QLT;Integrated Security=True");
        int check = 0;

        public ThemVeTau()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            connect.Open();
            string sql =
             "select IDVE as N'Mã vé tàu',MaTau as N'Mã Tàu',Gadi as N'Ga đi', Gaden as N'Ga đến', Loaive as N'Loại vé', Tang as N'Tầng', Ngaydi as N'Ngày đi',  Giodi as N'Giờ đi',Ngayve as N'Ngày về', Giove as N'Giờ về', Toa, Loaicho as N'Loại chỗ' ,Ghe_Giuong as N'Số Ghế/Giường', Giave as N'Giá vé', Status as N'Tình trạng vé'  from ThemVe ";
            SqlCommand com = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            datathemvetau.DataSource = dt;
        }
        void xoatextbot()
        {

            Matau.Clear();
            Gadi.Clear();
            Gaden.Clear();
            Giatien.Clear();
            Toa.Clear();
            Ghe.Clear();
            Giodi.Clear();
            Giove.Clear();
        }
        public int countbill()
        {

            string sql = "select * from Hoadon";
            SqlCommand com = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            return dt.Rows.Count;
        }
        void Them()
        {
            connect.Open();
            string sql = "insert into ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave)  values(@Matau,@Gadi,@Gaden,@Loaive,@Tang,@Ngaydi,@Giodi,@Ngayve,@GioVe,@Toa,@Loaicho,@Ghe_Giuong,@Giave)";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("Matau", Matau.Text);
            cmd.Parameters.AddWithValue("Gadi", Gadi.Text);
            cmd.Parameters.AddWithValue("Gaden", Gaden.Text);
            cmd.Parameters.AddWithValue("Loaive", Loaive.Text);
            cmd.Parameters.AddWithValue("Tang", Tang.Text);
            cmd.Parameters.AddWithValue("Ngaydi", DateTime.Parse(Ngaydi.Text));
            cmd.Parameters.AddWithValue("Giodi", Giodi.Text);
            cmd.Parameters.AddWithValue("Ngayve", DateTime.Parse(Ngayve.Text));
            cmd.Parameters.AddWithValue("Giove", Giove.Text);
            cmd.Parameters.AddWithValue("Toa", Toa.Text);
            cmd.Parameters.AddWithValue("Loaicho", Loaicho.Text);
            cmd.Parameters.AddWithValue("Ghe_Giuong", Ghe.Text);
            cmd.Parameters.AddWithValue("Giave", Giatien.Text);
            cmd.ExecuteNonQuery();

            connect.Close();
            loaddata();
            xoatextbot();


        }
        //int countve(string IDVE)
        //{
        //    string sql = "select *from ThemVe where IDVE = '" + IDVE + "'";
        //    DataTable result = ExecuteQuery(sql);
        //    return result.Rows.Count;
        //}

        void Sua()
        {
            connect.Open();
            string sql = "UPDATE ThemVe SET  Matau =@Matau,Gadi =@Gadi,Gaden =@Gaden,Loaive =@Loaive,Tang = @Tang,Ngaydi= @Ngaydi,Giodi =@Giodi,Ngayve =@Ngayve,Giove = @GioVe,Toa =@Toa,Loaicho =@Loaicho,Ghe_Giuong =@Ghe_Giuong,Giave =@Giave WHERE IDVE = @IDVE";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("IDVE", IDVT.Text);
            cmd.Parameters.AddWithValue("Matau", Matau.Text);
            cmd.Parameters.AddWithValue("Gadi", Gadi.Text);
            cmd.Parameters.AddWithValue("Gaden", Gaden.Text);
            cmd.Parameters.AddWithValue("Loaive", Loaive.Text);
            cmd.Parameters.AddWithValue("Tang", Tang.Text);
            cmd.Parameters.AddWithValue("Ngaydi", DateTime.Parse(Ngaydi.Text));
            cmd.Parameters.AddWithValue("Giodi", Giodi.Text);
            cmd.Parameters.AddWithValue("Ngayve", DateTime.Parse(Ngayve.Text));
            cmd.Parameters.AddWithValue("Giove", Giove.Text);
            cmd.Parameters.AddWithValue("Toa", Toa.Text);
            cmd.Parameters.AddWithValue("Loaicho", Loaicho.Text);
            cmd.Parameters.AddWithValue("Ghe_Giuong", Ghe.Text);
            cmd.Parameters.AddWithValue("Giave", Giatien.Text);
            cmd.ExecuteNonQuery();

            connect.Close();
            loaddata();


        }
        void Status()
        {
            connect.Open();
            string sql = "UPDATE ThemVe SET Status =@Status WHERE IDVE = @IDVE";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("IDVE", IDVT.Text);
            cmd.Parameters.AddWithValue("Status", cmbstatus.Text);
            cmd.ExecuteNonQuery();

            connect.Close();
            loaddata();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "delete from ThemVe where IDVE= '" + IDVT.Text + "'";
            SqlCommand com = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            datathemvetau.DataSource = dt;
            xoatextbot();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Matau.Text == "")
            {
                MessageBox.Show("Bạn để trống mã tàu ", "Thông báo");
            }
            else if (Gadi.Text == "")
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
            else if (Tang.Text == "")
            {
                MessageBox.Show("Bạn để trống tầng ", "Thông báo");
            }
            else if (Ngaydi.Text == "")
            {
                MessageBox.Show("Bạn để trống ngày đi ", "Thông báo");
            }
            else if (Giodi.Text == "")
            {
                MessageBox.Show("Bạn để trống giờ đi ", "Thông báo");
            }
            else if (Ngayve.Text == "")
            {
                MessageBox.Show("Bạn để trống ngày về ", "Thông báo");
            }
            else if (Giove.Text == "")
            {
                MessageBox.Show("Bạn để trống giờ về ", "Thông báo");
            }
            else if (Toa.Text == "")
            {
                MessageBox.Show("Bạn để trống toa ", "Thông báo");
            }
            else if (Loaicho.Text == "")
            {
                MessageBox.Show("Bạn để trống loại chỗ ", "Thông báo");
            }
            else if (Ghe.Text == "")
            {
                
                MessageBox.Show("Bạn để trống ghế", "Thông báo");
            }
           else if (Giatien.Text == "")
            {
              
                MessageBox.Show("Bạn để trống giá tiền", "Thông báo");
            }
           
            else
            {
                if (int.TryParse(Giatien.Text, out check))
                {
                    Them();
                    MessageBox.Show("Bạn đã thêm vé", "Thông báo");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Bạn nhập tiền không hợp lệ", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
            loaddata();
        }

        private void ThemVeTau_Load(object sender, EventArgs e)
        {
            IDVT.Text = (countbill() + 1).ToString();
            loaddata();
        }

        private void datathemvetau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = datathemvetau.CurrentRow.Index;
            IDVT.Text = datathemvetau.Rows[i].Cells[0].Value.ToString();
            Matau.Text = datathemvetau.Rows[i].Cells[1].Value.ToString();
            Gadi.Text = datathemvetau.Rows[i].Cells[2].Value.ToString();
            Gaden.Text = datathemvetau.Rows[i].Cells[3].Value.ToString();
            Loaive.Text = datathemvetau.Rows[i].Cells[4].Value.ToString();
            Tang.Text = datathemvetau.Rows[i].Cells[5].Value.ToString();
            Ngaydi.Text = datathemvetau.Rows[i].Cells[6].Value.ToString();
            Giodi.Text = datathemvetau.Rows[i].Cells[7].Value.ToString();
            Ngayve.Text = datathemvetau.Rows[i].Cells[8].Value.ToString();
            Giove.Text = datathemvetau.Rows[i].Cells[9].Value.ToString();
            Toa.Text = datathemvetau.Rows[i].Cells[10].Value.ToString();
            Loaicho.Text = datathemvetau.Rows[i].Cells[11].Value.ToString();
            Ghe.Text = datathemvetau.Rows[i].Cells[12].Value.ToString();
            Giatien.Text = datathemvetau.Rows[i].Cells[13].Value.ToString();

        }
        private DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            string con = @"Data Source=PC01_22;Initial Catalog=QLT;Integrated Security=True";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Status();
            loaddata();
        }
    }
}
