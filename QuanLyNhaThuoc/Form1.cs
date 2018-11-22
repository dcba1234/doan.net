using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanLyNhaThuoc
{
    public partial class Form1 : Form
    {
        private BUS_nhanvien nv = new BUS_nhanvien();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = nv.dangNhap(txtid.Text, txtpassword.Text);
            if (kq == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            else
            {
                thuoc f = new thuoc();
                f.ShowDialog();
            }
           
        }

        private void txtid_Enter(object sender, EventArgs e)
        {   
            if (txtid.Text == "Tên đăng nhập")
            txtid.Text = "";
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
                txtid.Text = "Tên đăng nhập";
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Mật khẩu")
                txtpassword.Text = "";
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
                txtpassword.Text = "Mật khẩu";
        }
    }
}
