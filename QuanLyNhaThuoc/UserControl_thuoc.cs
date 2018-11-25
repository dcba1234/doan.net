using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
namespace QuanLyNhaThuoc
{
    public partial class UserControl_thuoc : UserControl
    {
        public BUS_thuoc t = new BUS_thuoc();
        public UserControl_thuoc()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_thuoc_Load(object sender, EventArgs e)
        {
            dg_thuoc.DataSource = t.select();
        }
    }
}
