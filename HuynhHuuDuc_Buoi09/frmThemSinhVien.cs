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


namespace HuynhHuuDuc_Buoi09
{
    public partial class frmThemSinhVien : Form
    {
        SqlConnection connsql;

        public frmThemSinhVien()
        {
            InitializeComponent();
            connsql = new SqlConnection("Data Source=A209PC39;Initial Catalog=QLSV;Integrated Security=True");
            Load_MaLop();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int age = DateTime.Today.Year - txt_NgaySinh.Value.Year;
                if (KT_MaSinhVien(Convert.ToInt32(txt_MaSinhVien.Text)) == true || age <= 17)
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }
                    string insertString;
                    insertString = "insert into SINHVIEN values('" + txt_MaSinhVien + "', N'" + txt_HoTen + "', '" + txt_NgaySinh + "', '" + txt_MaLop + "')";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    MessageBox.Show("Thêm thành công!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }

        bool KT_MaSinhVien(int ma)
        {
            try
            {
                connsql.Open();
                string selectString = "select count(*) from SINHVIEN where MaSV == '" + ma + "'";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                int count = (int)cmd.ExecuteScalar();
                connsql.Close();
                if (count >= 1)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void Load_MaLop()
        {
            connsql.Open();
            string selectString = "select * from LOP";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txt_MaLop.Items.Add(rd["MaLop"].ToString());
            }
            rd.Close();

        }

    }
}
