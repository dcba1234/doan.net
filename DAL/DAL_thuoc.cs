using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_thuoc
    {
        private string mathuoc;
        private string tenthuoc;

        private string loaithuoc;
        private string congdung;

        private string hanSD;
        private string thuocdacbiet;

        private string tacdungphu;
        private string chongchidinh;

        private int dongia;
        private string donvitinh;

        private string ghichu;



        public DAL_thuoc(String mathuoc, string tenthuoc, string loaithuoc, string congdung, string hanSD, string thuocdacbiet, string tacdungphu, string chongchidinh, int dongia, string donvitinh, string ghichu)
        {
            this.mathuoc = mathuoc;
            this.tenthuoc = tenthuoc;
            this.loaithuoc = loaithuoc;
            this.congdung = congdung;
            this.hanSD = hanSD;
            this.thuocdacbiet = thuocdacbiet;
            this.tacdungphu = tacdungphu;
            this.chongchidinh = chongchidinh;
            this.dongia = dongia;
            this.donvitinh = donvitinh;
            this.ghichu = ghichu;

        }
        public void ThuocRead(SqlDataReader dr)
        {
            mathuoc = dr["mathuoc"] is DBNull ? "" : dr["mathuoc"].ToString();
            tenthuoc = dr["tenthuoc"] is DBNull ? "" : dr["tenthuoc"].ToString();
            loaithuoc = dr["loaithuoc"] is DBNull ? "" : dr["loaithuoc"].ToString();
            congdung = dr["congdung"] is DBNull ? "" : dr["congdung"].ToString();
            hanSD = dr["hanSD"] is DBNull ? "" : dr["hanSD"].ToString();
            thuocdacbiet = dr["thuocdacbiet"] is DBNull ? "" : dr["thuocdacbiet"].ToString();
            tacdungphu = dr["tacdungphu"] is DBNull ? "" : dr["tacdungphu"].ToString();
            chongchidinh = dr["chongchidinh"] is DBNull ? "" : dr["chongchidinh"].ToString();
            dongia = dr["dongia"] is DBNull ? 0 :(int)dr["dongia"];
            donvitinh = dr["donvitinh"] is DBNull ? "" : dr["donvitinh"].ToString();
            ghichu = dr["ghichu"] is DBNull ? "" : dr["ghichu"].ToString();

        }
        public DAL_thuoc() { }

        public string Mathuoc
        {
            get { return mathuoc; }
            set { mathuoc = value; }
        }

        public string Tenthuoc
        {
            get { return tenthuoc; }
            set { tenthuoc = value; }
        }
        public string Loaithuoc
        {
            get { return loaithuoc; }
            set { loaithuoc = value; }
        }
        public string Congdung
        {
            get { return congdung; }
            set { congdung = value; }
        }
        public string HanSD
        {
            get { return hanSD; }
            set { hanSD = value; }
        }
        public string Thuocdacbiet
        {
            get { return thuocdacbiet; }
            set { thuocdacbiet = value; }
        }
        public string Tacdungphu
        {
            get { return tacdungphu; }
            set { tacdungphu = value; }
        }
        public string Chongchidinh
        {
            get { return chongchidinh; }
            set { chongchidinh = value; }
        }
        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public string Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }
        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
