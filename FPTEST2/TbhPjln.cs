using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FPTEST2
{
    public partial class TbhPjln : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public TbhPjln(string Username)
        {
            InitializeComponent();
            labelHi.Text = "Hi, " + Username + " Selamat Bekerja";
            SetupDataGridView();
        }

        public TbhPjln()
        {
            InitializeComponent();
            this.ActiveControl = textBoxIdbrg;
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            // Set gaya baris bergantian
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Buat kolom
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "No";
            col1.Name = "colNo";
            dataGridView1.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Id Barang";
            col2.Name = "colIdBarang";
            dataGridView1.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Nama Barang";
            col3.Name = "colNamaBarang";
            dataGridView1.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Harga";
            col4.Name = "colHarga";
            dataGridView1.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Quantity";
            col5.Name = "colQuantity";
            dataGridView1.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Sub-Total";
            col6.Name = "colSubTotal";
            dataGridView1.Columns.Add(col6);

            DataGridViewButtonColumn col7 = new DataGridViewButtonColumn();
            col7.HeaderText = "Aksi";
            col7.Name = "colAksi";
            col7.Text = "Hapus";
            col7.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(col7);
        }


        // hoverrrrrr tambah penjualan
        private void tbPnjln_MouseEnter(object sender, EventArgs e)
        {
            this.tbPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void tbPnjln_MouseLeave(object sender, EventArgs e)
        {
            this.tbPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void tbPnjln_Click(object sender, EventArgs e)
        {
            this.tbPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        // hoverrrrrrrrr list penjualan
        private void listPnjln_MouseEnter(object sender, EventArgs e)
        {
            this.listPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void listPnjln_MouseLeave(object sender, EventArgs e)
        {
            this.listPnjln.BackColor = ColorTranslator.FromHtml("Transparent");
        }

        private void listPnjln_Click(object sender, EventArgs e)
        {
            new LstPjln().Show();
            this.Hide();
        }

        // hoverrrrrrrr input supplier
        private void inputSup_MouseEnter(object sender, EventArgs e)
        {
            this.inputSup.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void inputSup_MouseLeave(object sender, EventArgs e)
        {
            this.inputSup.BackColor = ColorTranslator.FromHtml("Transparent");
        }

        private void inputSup_Click(object sender, EventArgs e)
        {
            new InputSupplier().Show();
            this.Hide();
        }

        // hover input barang
        private void inputBg_MouseEnter(object sender, EventArgs e)
        {
            this.inputBg.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void inputBg_MouseLeave(object sender, EventArgs e)
        {
            this.inputBg.BackColor = ColorTranslator.FromHtml("Transparent");
        }

        private void inputBg_Click(object sender, EventArgs e)
        {
            new InputBarang().Show();
            this.Hide();
        }

        //hover tambah pembelian
        private void tbPmbln_MouseEnter(object sender, EventArgs e)
        {
            this.tbPmbln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void tbPmbln_MouseLeave(object sender, EventArgs e)
        {
            this.tbPmbln.BackColor = ColorTranslator.FromHtml("Transparent");
        }

        private void tbPmbln_Click(object sender, EventArgs e)
        {
            new TmbhPembelian().Show();
            this.Hide();
        }

        private void textBoxNmBrg_TextChanged(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Akiraa\Videos\Pemrograman Lanjutan1\Data Barang.mdb;Persist Security Info=False;";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from ListBarang where Nama_Barang = '" + textBoxNmBrg.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBoxIdbrg.Text = reader["Id_Barang"].ToString();
                    textBoxHrg.Text = reader["Harga"].ToString();
                    textBoxQty.Text = reader["Stock"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error data" + ex);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(this.dataGridView1, textBoxIdbrg.Text, textBoxNmBrg.Text, textBoxHrg.Text, textBoxQty.Text);
            this.dataGridView1.Rows.Add(row);
            this.ActiveControl = textBoxIdbrg;
            {
                textBoxIdbrg.Text = string.Empty;
                textBoxNmBrg.Text = string.Empty;
                textBoxHrg.Text = string.Empty;
                textBoxQty.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tambahkan kode untuk aksi button2
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tambahkan kode untuk aksi pictureBox1
        }
    }
}
