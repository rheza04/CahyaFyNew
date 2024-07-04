using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace FPTEST2
{
    public partial class LoginForm : Form
    {
        private SQLiteConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data Barang.db");
            connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                labelCheckConnection.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM ListSupplier WHERE Username = @Username AND Password = @Password";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                command.Parameters.AddWithValue("@Password", textBoxPwd.Text);

                SQLiteDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("IdSupplier dan Password benar");
                    connection.Close();
                    this.Hide();
                    TbhPjln TbhPjln2 = new TbhPjln(textBoxUsername.Text);
                    TbhPjln2.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate IdSupplier dan Password");
                }
                else
                {
                    MessageBox.Show("IdSupplier dan Password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBoxIdsp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPwd.Focus();
            }
        }

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPwd.Focus();
            }
        }
    }
}
