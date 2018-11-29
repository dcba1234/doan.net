using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Object;
namespace QuanLyNhaThuoc
{
    public partial class UserControl_khachhang : UserControl

    {
        public BUS_khachHang t = new BUS_khachHang();
        public DataTable tb = new DataTable();
        
        public string button = "insert";
        public UserControl_khachhang()
        {
            InitializeComponent();
            load();
            //
            DataGridViewImageColumn c = new DataGridViewImageColumn();
            c.Name = "Ảnh đơn thuốc";
            
            dg_khachhang.Columns.Insert(3, c);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            button = "insert";
            //loaithuoc = dg_thuoc.Rows[dg_thuoc.CurrentRow.Index].Cells[1].Value.ToString();
            frm_insert_khachhang f = new frm_insert_khachhang(this);
            f.ShowDialog();
        }
        public void load()
        {

            tb = t.select();
            dg_khachhang.DataSource = tb;
            if (dg_khachhang.RowCount == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            
        }
    }
}
