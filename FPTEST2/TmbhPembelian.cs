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
    public partial class TmbhPembelian : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public TmbhPembelian()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\#Kuliah\2018 - Semester 3\Pemrograman Lanjutan8\Data Barang.mdb;
            Persist Security Info = False;";
        }

        //hover tambah penjualan
        private void tbPnjln_MouseEnter_1(object sender, EventArgs e)
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


        // hover liiiiissssstttt dataaaa penjualan
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

        // hover inpuuuuuuuttttttttt suppplliiiierrr
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

        //hover inputttttt baraaaaaanggggggg
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

        //hoveer tambahhhhh pembeliaaaaannn
        private void tbPmbln_MouseEnter(object sender, EventArgs e)
        {
            this.tbPmbln .BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void tbPmbln_MouseLeave(object sender, EventArgs e)
        {
            this.tbPmbln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void tbPmbln_Click(object sender, EventArgs e)
        {
            this.tbPmbln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxJml.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void boxJml_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxSat.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void boxSat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxTotal.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void boxTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1, textBox2.Text, boxJml.Text, boxSat.Text, boxTotal.Text);
                this.dataGridView1.Rows.Add(row);
                this.ActiveControl = textBox2;
                {
                    textBox2.Text = string.Empty;
                    boxJml.Text = string.Empty;
                    boxSat.Text = string.Empty;
                    boxTotal.Text = string.Empty;
                }
            }
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            textBox1.Text = sum.ToString();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tbPembelian([nama_brg], [jumlah], [satuan], [total]) VALUES (" + dataGridView1.Rows[i].Cells["nama_brg"].Value + ", " + dataGridView1.Rows[i].Cells["jumlah"].Value + ", " + dataGridView1.Rows[i].Cells["satuan"].Value + ", " + dataGridView1.Rows[i].Cells["total"].Value + ");";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diinputkan");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Data Berhasil Diinputkan");
                    connection.Close();
                }
            }
        }
        
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value =
                                        (r.Index + 1).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(this.dataGridView1, textBox2.Text, boxJml.Text, boxSat.Text, boxTotal.Text);
            this.dataGridView1.Rows.Add(row);
            this.ActiveControl = textBox2;
            {
                textBox2.Text = string.Empty;
                boxJml.Text = string.Empty;
                boxSat.Text = string.Empty;
                boxTotal.Text = string.Empty;
            }          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
