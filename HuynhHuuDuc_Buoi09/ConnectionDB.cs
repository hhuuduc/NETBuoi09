using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HuynhHuuDuc_Buoi09
{
    class ConnectionDB
    {
        //public string conStr = "Data Source=A209PC39;Initial Catalog=QLSV;Integrated Security=True";
        //public List<SinhVien> getDataSinhVien()
        //{
        //    List<SinhVien> listSinhViens = new List<SinhVien>();

        //    SqlConnection con = new SqlConnection(conStr);
        //    string sql = "Select * from SINHVIEN";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.Text;

        //    con.Open();
        //    SqlDataReader rdr = cmd.ExecuteReader();
        //    while (rdr.Read())
        //    {
        //        SinhVien emp = new SinhVien();
        //        emp.MaSV = Convert.ToInt32(rdr.GetValue(0).ToString());
        //        emp.TenSV = rdr.GetValue(1).ToString();
        //        emp.NgaySinh = Convert.ToDateTime(rdr.GetValue(2).ToString());
        //        emp.MaLop = rdr.GetValue(3).ToString();

        //        listSinhViens.Add(emp);
        //    }
        //    return (listSinhViens);
        //}

        public SqlConnection getconnect()
        {
            return new SqlConnection("Data Source=A209PC39;Initial Catalog=QLSV;Integrated Security=True");
        }
        //#### Lấy giá trị bảng
        public DataTable gettable(string sql)
        {
            SqlConnection con = getconnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
