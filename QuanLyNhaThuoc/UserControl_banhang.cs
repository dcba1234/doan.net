using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class UserControl_banhang : UserControl
    {
        public int soluongMax=0;
        int tongtien = 0;
        public UserControl_banhang()
        {
            InitializeComponent();
            txt_tien.Text = tongtien.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txt_makhachhang.Text = "";

                btn_mkh.Enabled = false;
            }
            else
            {
                
                btn_mkh.Enabled = true;
            }
        }

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            frm_chonthuoc f = new frm_chonthuoc(this);
            f.ShowDialog();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mathuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa chọn thuốc");
                btn_thuoc.Focus();

            }
            else
            {
                if(Int32.Parse(txt_soluong.Value.ToString()) == 0)
                {
                    MessageBox.Show("Chọn số lượng");
                }
                else
                {
                    if (!check(txt_mathuoc.Text,txt_solo.Text))
                    {
                        this.dg_ctiet.Rows.Add(txt_mathuoc.Text, txt_tenthuoc.Text, txt_soluong.Value, txt_gia.Value, dateTimePicker_nsx.Value.ToString("MM/dd/yyyy"), dateTimePicker_hsd.Value.ToString("MM/dd/yyyy"), txt_solo.Text);
                        int dongia = Int32.Parse(txt_dongia.Text);
                        tongtien += dongia * (int)txt_soluong.Value;
                        txt_tien.Text = tongtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại mặt hàng này ");
                    }
                }

            }
        }
        private bool check(string ma,string solo)
        {
            bool c = false;
            // true = tồn tại
            for (int i = 0; i < dg_ctiet.RowCount; i++)
            {
                if (ma == dg_ctiet.Rows[i].Cells[0].Value.ToString().Trim() && solo == dg_ctiet.Rows[i].Cells[6].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return c;
        }
        private void UserControl_banhang_Load(object sender, EventArgs e)
        {
          //  txt_soluong.Maximum = soluongMax;
        }

        private void txt_soluong_ValueChanged(object sender, EventArgs e)
        {   
          
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }
    }
}
