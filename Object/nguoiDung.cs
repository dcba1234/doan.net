using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class nguoiDung
    {
        private string manv;
        private string ten;
        private string quyen;
        private string tendangnhap;
        private string matkhau;
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }

        public nguoiDung(string manv, string ten, string quyen, string tendangnhap)
        {
            this.manv = manv;
            this.ten = ten;
            this.quyen = quyen;
            this.tendangnhap = tendangnhap;
        }
        public nguoiDung()
        {
            
        }

    }
}
