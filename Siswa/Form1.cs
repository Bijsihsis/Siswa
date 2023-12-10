using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siswa.Controller;
using Siswa.Model;


namespace Siswa
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        string id;
        Form2 form;


        public void Tampil()
        {
            DataTable.DataSource = koneksi.ShowData("SELECT id, nama, alamat, kelas, jurusan FROM tabelsiswa");
        }
        public Form1()
        {
            InitializeComponent();
            form = new Form2(this);

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.id = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nama = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.alamat = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.kelas = DataTable.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.jurusan = DataTable.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Delete
                DialogResult pesan = MessageBox.Show("Yakin ingin menghapus data ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pesan == DialogResult.Yes)
                {
                    Siswa_c sw = new Siswa_c();
                    sw.Delete(DataTable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Tampil();
                }
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM tabelsiswa WHERE nama LIKE '%' '" + CariData.Text + "' '%' OR alamat LIKE '%' '" + CariData.Text + "' '%' '%' OR alamat LIKE '%' '" + CariData.Text + "' '%' '%' OR kelas LIKE '%' '" + CariData.Text + "' '%' '%' OR jurusan LIKE '%' '" + CariData.Text + "' '%'");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
