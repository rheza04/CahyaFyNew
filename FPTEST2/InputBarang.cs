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
    public partial class InputBarang : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public object Username { get; private set; }

        public InputBarang()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\#Kuliah\2018 - Semester 3\Pemrograman Lanjutan8\Data Barang.mdb;
            Persist Security Info = False;";
        }

        //hover tambah penjualan
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
            new TbhPjln().Show(); Hide();
        }

        //hover list penjualan
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

        //hover input suplliiiiierrrr
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
            new InputSupplier().Show(); this.Hide();
        }

        //hover input barang
        private void inputBg_MouseEnter(object sender, EventArgs e)
        {
            this.inputBg.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void inputBg_MouseLeave(object sender, EventArgs e)
        {
            this.inputBg.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void inputBg_Click(object sender, EventArgs e)
        {
            this.inputBg.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        //hover tambah pembeliannn
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

        private void buttonTmbh_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into ListBarang (Id_Barang,Nama_Barang,Harga,Stock) Values('" + textBoxIdBrg.Text + "','" + textBoxNmBrg.Text + "','" + textBoxHrg.Text + "','" + textBoxStck.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diinputkan");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error data" + ex);
                connection.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Update ListBarang set Nama_Barang = '" + textBoxNmBrg.Text + "', Harga = '" + textBoxHrg.Text + "', Stock = '" + textBoxStck.Text + "' Where Id_Barang = '" + textBoxIdBrg.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diupdate");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error data" + ex);
                connection.Close();
            }
            {
                textBoxIdBrg.Text = string.Empty;
                textBoxNmBrg.Text = string.Empty;
                textBoxHrg.Text = string.Empty;
                textBoxStck.Text = string.Empty;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Delete from ListBarang where Id_Barang ='" + textBoxIdBrg.Text + "'";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error data" + ex);
                connection.Close();
            }
        }

        private void textBoxIdBrg_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textBoxNmBrg.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxNmBrg_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textBoxStck.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxStck_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                comboBoxStn.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void comboBoxStn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxHrg.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxHrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonTmbh.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonRstck_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Update ListBarang SET Stock = Stock+'" + this.textBoxStck.Text + "' where [Nama_Barang] = '" + this.textBoxNmBrg.Text + "';";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Stock Berhasil Ditambah");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error data" + ex);
                connection.Close();
            }
        }

        private void textBoxIdBrg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
