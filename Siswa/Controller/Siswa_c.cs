using Siswa.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siswa.Model;
using System.Windows.Forms;

namespace Siswa.Controller
{
    class Siswa_c
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(Siswa_m siswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO tabelsiswa (nama, alamat, kelas, jurusan) VALUES ('" + siswa.Nama + "', '" + siswa.Alamat + "', '" + siswa.Kelas + "', '" + siswa.Jurusan + "' )");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Update(Siswa_m siswa, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE tabelsiswa SET nama='" + siswa.Nama + "', " + "Alamat='" + siswa.Alamat + "', " + "kelas='" + siswa.Kelas + "', " + "jurusan='" + siswa.Jurusan + "' WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM tabelsiswa WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
