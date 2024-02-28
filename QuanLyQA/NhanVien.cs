using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQA
{
    class NhanVien
    {
        private string _manv;
        private string _ho;
        private string _ten;
        private string _gt;
        private DateTime _ns;
        private string _dc;
        private string _sdt;
        private string _macv;
        private string _soca;
        private string _thuong;
        private DateTime _ntd;

        public NhanVien()
        {
        }


        public NhanVien(string manv, string ho, string ten, string gt, DateTime ns, string dc, string sdt, string macv, string soca, string thuong, DateTime ntd)
        {
            _manv = manv;
            _ho = ho;
            _ten = ten;
            _gt = gt;
            _ns = ns;
            _dc = dc;
            _sdt = sdt;
            _macv = macv;
            _soca = soca;
            _thuong = thuong;
            _ntd = ntd;
        }

        public string Manv { get => _manv; set => _manv = value; }
        public string Ho { get => _ho; set => _ho = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string Gt { get => _gt; set => _gt = value; }
        public DateTime Ns { get => _ns; set => _ns = value; }
        public string Dc { get => _dc; set => _dc = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Macv { get => _macv; set => _macv = value; }
        public string Soca { get => _soca; set => _soca = value; }
        public string Thuong { get => _thuong; set => _thuong = value; }
        public DateTime Ntd { get => _ntd; set => _ntd = value; }
    }
}
