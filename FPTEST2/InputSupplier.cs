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
    public partial class InputSupplier : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public InputSupplier()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\#Kuliah\2018 - Semester 3\Pemrograman Lanjutan8\Data Barang.mdb;
            Persist Security Info = False;";
            this.ActiveControl = boxIdSup;
        }

        //hoverrr tambah penjualan
        private void tbPnjln_MouseEnter(object sender, EventArgs e)
        {
            this.tbPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void tbPnjln_MouseLeave(object sender, EventArgs e)
        {
            this.tbPnjln.BackColor = ColorTranslator.FromHtml("Transparent");
        }

        private void tbPnjln_Click(object sender, EventArgs e)
        {
            new TbhPjln().Show(); this.Hide();
        }

        //hover listttt penjualan
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
            new LstPjln().Show(); this.Hide();
        }

        //hover inputt supllier
        private void inputSup_MouseEnter(object sender, EventArgs e)
        {
            this.inputSup.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void inputSup_MouseLeave(object sender, EventArgs e)
        {
            this.inputSup.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void inputSup_Click(object sender, EventArgs e)
        {
            this.inputSup.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        //hover input barang
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
            new InputBarang().Show(); this.Hide();
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
            new TmbhPembelian().Show(); this.Hide();
        }

        private void tambahSup_Click(object sender, EventArgs e)
        {
            
        }

        private void boxIdSup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxNamaSup.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void boxNamaSup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxNope.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void boxNope_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxAlamat.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void boxAlamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into dataSupplier (is_sup,nama_sup,nope,alamat) Values('" + boxIdSup.Text + "','" + boxNamaSup.Text + "','" + boxNope.Text + "','" + boxAlamat.Text + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diinputkan");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error data" + ex);
                    connection.Close();

                }
                {
                    boxIdSup.Text = string.Empty;
                    boxNamaSup.Text = string.Empty;
                    boxNope.Text = string.Empty;
                    boxAlamat.Text = string.Empty;
                }
            }
        }
    }
}
