using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class thuoc
    {
        private String mathuoc;
        private String tenthuoc;
        private String loaithuoc;
        private String congdung;
        private String hanSD;
        private String thuocdacbiet;
        private String tacdungphu;
        private String chongchidinh;
        private String dongia;
        private String donvitinh;
        private String ghichu;

       
        public thuoc()
        {
            
        }

        public thuoc(string mathuoc, string tenthuoc, string loaithuoc, string congdung, string hanSD, string thuocdacbiet, string tacdungphu, string chongchidinh, string dongia, string donvitinh, string ghichu)
        {
            Mathuoc = mathuoc;
            Tenthuoc = tenthuoc;
            Loaithuoc = loaithuoc;
            Congdung = congdung;
            HanSD = hanSD;
            Thuocdacbiet = thuocdacbiet;
            Tacdungphu = tacdungphu;
            Chongchidinh = chongchidinh;
            Dongia = dongia;
            Donvitinh = donvitinh;
            Ghichu = ghichu;
        }

        public string Mathuoc { get => mathuoc; set => mathuoc = value; }
        public string Tenthuoc { get => tenthuoc; set => tenthuoc = value; }
        public string Loaithuoc { get => loaithuoc; set => loaithuoc = value; }
        public string Congdung { get => congdung; set => congdung = value; }
        public string HanSD { get => hanSD; set => hanSD = value; }
        public string Thuocdacbiet { get => thuocdacbiet; set => thuocdacbiet = value; }
        public string Tacdungphu { get => tacdungphu; set => tacdungphu = value; }
        public string Chongchidinh { get => chongchidinh; set => chongchidinh = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
