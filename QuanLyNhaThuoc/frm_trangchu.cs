using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class frm_trangchu : Form
    {
        private Form ff;
        public frm_trangchu(Form f)
        {
            InitializeComponent();
            ff = f;
        }

        private void userControl_thuoc1_Load(object sender, EventArgs e)
        {
            userControl_thuoc1.btn_them.Enabled = false;
        }

        private void frm_trangchu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
                ff.Close();
            }
            
        }

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_thuoc.Height;
            panel_side.Top = btn_thuoc.Top;
            userControl_thuoc1.BringToFront();
           // MessageBox.Show("s");
            
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_banhang.Height;
            userControl_banhang1.BringToFront();
            panel_side.Top = btn_banhang.Top;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
