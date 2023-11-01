using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhHuuDuc_Buoi09
{
    public partial class frmSinhVien : Form
    {
        ConnectionDB db = new ConnectionDB();

        public frmSinhVien()
        {
            InitializeComponent();
            
        }

        public DataTable getSinhVien()
        {
            string sql = "Select * from SINHVIEN";
            DataTable dt = new DataTable();
            dt = db.gettable(sql);
            return dt;
        }

        private void btn_HienThiDuLieu_Click(object sender, EventArgs e)
        {
            lsV_SinhVien.Columns.Add("Mã Sinh Viên");
            lsV_SinhVien.Columns.Add("Tên Sinh Viên");
            lsV_SinhVien.Columns.Add("Ngày Sinh");
            lsV_SinhVien.Columns.Add("Mã Lớp");
            lsV_SinhVien.View = View.Details;
            
            DataTable dt = new DataTable();
            dt = getSinhVien();
            //ListViewItem dong;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(subitem);
                lsV_SinhVien.Items.Add(item);
            }
            lsV_SinhVien.View = View.Details;
            lsV_SinhVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsV_SinhVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemSinhVien themSV = new frmThemSinhVien();
            themSV.Show();
        }


    }
}
