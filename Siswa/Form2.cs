using Siswa.Controller;
using Siswa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siswa
{
    public partial class Form2 : Form
    {
        Siswa_m siswa = new Siswa_m();
        private readonly Form1 _parent;
        Koneksi koneksi = new Koneksi();
        public string id, nama, alamat, kelas, jurusan;


        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Ubah Siswa";
            btnSimpan.Text = "Ubah";
            Nama.Text = nama;
            Alamat.Text = alamat;
            Kelas.Text = kelas;
            Jurusan.Text = jurusan;
        }
        public void Clear()
        {
            Nama.Text = Alamat.Text = Kelas.Text = Jurusan.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (Nama.Text == "" || Alamat.Text == "" || Kelas.Text == "" || Jurusan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (btnSimpan.Text == "Simpan")
            {
                Siswa_c sw = new Siswa_c();
                siswa.Nama = Nama.Text;
                siswa.Alamat = Alamat.Text;
                siswa.Kelas = Kelas.Text;
                siswa.Jurusan = Jurusan.Text;

                sw.Insert(siswa);
                Nama.Text = "";
                Alamat.Text = "";
                Kelas.Text = "";
                Jurusan.Text = "";

                Clear();
            }
            if (btnSimpan.Text == "Ubah")
            {
                Siswa_c sw = new Siswa_c();
                siswa.Nama = Nama.Text;
                siswa.Alamat = Alamat.Text;
                siswa.Kelas = Kelas.Text;
                siswa.Jurusan = Jurusan.Text;

                sw.Update(siswa,id);
                Nama.Text = "";
                Alamat.Text = "";
                Kelas.Text = "";
                Jurusan.Text = "";
            }
            _parent.Tampil();
        }
    }
}
