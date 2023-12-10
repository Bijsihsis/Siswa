using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siswa.Model
{
    class Siswa_m
    {
        string  nama, alamat, kelas, jurusan;

        public Siswa_m() { }

        public Siswa_m(string nama, string alamat, string kelas, string jurusan)
        {
            this.Nama = nama;
            this.Alamat = alamat;
            this.Kelas = kelas;
            this.Jurusan = jurusan;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public string Jurusan { get => jurusan; set => jurusan = value; }

    }
}
