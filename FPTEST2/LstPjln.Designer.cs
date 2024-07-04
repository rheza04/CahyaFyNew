namespace FPTEST2
{
    partial class LstPjln
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label15 = new System.Windows.Forms.Label();
            this.dataListPnjln = new System.Windows.Forms.DataGridView();
            this.dataBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_BarangDataSet = new FPTEST2.Data_BarangDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPmbln = new System.Windows.Forms.Label();
            this.inputBg = new System.Windows.Forms.Label();
            this.inputSup = new System.Windows.Forms.Label();
            this.listPnjln = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPnjln = new System.Windows.Forms.Label();
            this.data_BarangTableAdapter = new FPTEST2.Data_BarangDataSetTableAdapters.Data_BarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataListPnjln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_BarangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(630, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 37);
            this.label15.TabIndex = 13;
            this.label15.Text = "Dobit";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataListPnjln
            // 
            this.dataListPnjln.AllowUserToAddRows = false;
            this.dataListPnjln.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataListPnjln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListPnjln.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataListPnjln.Location = new System.Drawing.Point(262, 128);
            this.dataListPnjln.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataListPnjln.Name = "dataListPnjln";
            this.dataListPnjln.ReadOnly = true;
            this.dataListPnjln.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataListPnjln.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataListPnjln.RowTemplate.Height = 24;
            this.dataListPnjln.Size = new System.Drawing.Size(1014, 410);
            this.dataListPnjln.TabIndex = 14;
            // 
            // dataBarangBindingSource
            // 
            this.dataBarangBindingSource.DataMember = "Data Barang";
            this.dataBarangBindingSource.DataSource = this.data_BarangDataSet;
            // 
            // data_BarangDataSet
            // 
            this.data_BarangDataSet.DataSetName = "Data_BarangDataSet";
            this.data_BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-52, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1711, 93);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(979, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1032, 544);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPmbln);
            this.groupBox1.Controls.Add(this.inputBg);
            this.groupBox1.Controls.Add(this.inputSup);
            this.groupBox1.Controls.Add(this.listPnjln);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbPnjln);
            this.groupBox1.Location = new System.Drawing.Point(10, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 323);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // tbPmbln
            // 
            this.tbPmbln.BackColor = System.Drawing.Color.Transparent;
            this.tbPmbln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPmbln.ForeColor = System.Drawing.Color.Black;
            this.tbPmbln.Location = new System.Drawing.Point(23, 232);
            this.tbPmbln.Name = "tbPmbln";
            this.tbPmbln.Size = new System.Drawing.Size(177, 39);
            this.tbPmbln.TabIndex = 30;
            this.tbPmbln.Text = "Tambah Pembelian";
            this.tbPmbln.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPmbln.Click += new System.EventHandler(this.tbPmbln_Click);
            this.tbPmbln.MouseEnter += new System.EventHandler(this.tbPmbln_MouseEnter);
            this.tbPmbln.MouseLeave += new System.EventHandler(this.tbPmbln_MouseLeave);
            // 
            // inputBg
            // 
            this.inputBg.BackColor = System.Drawing.Color.Transparent;
            this.inputBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBg.ForeColor = System.Drawing.Color.Black;
            this.inputBg.Location = new System.Drawing.Point(23, 197);
            this.inputBg.Name = "inputBg";
            this.inputBg.Size = new System.Drawing.Size(177, 39);
            this.inputBg.TabIndex = 29;
            this.inputBg.Text = "Input Barang";
            this.inputBg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputBg.Click += new System.EventHandler(this.inputBg_Click);
            this.inputBg.MouseEnter += new System.EventHandler(this.inputBg_MouseEnter);
            this.inputBg.MouseLeave += new System.EventHandler(this.inputBg_MouseLeave);
            // 
            // inputSup
            // 
            this.inputSup.BackColor = System.Drawing.Color.Transparent;
            this.inputSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSup.ForeColor = System.Drawing.Color.Black;
            this.inputSup.Location = new System.Drawing.Point(23, 158);
            this.inputSup.Name = "inputSup";
            this.inputSup.Size = new System.Drawing.Size(177, 39);
            this.inputSup.TabIndex = 28;
            this.inputSup.Text = "Input Supplier";
            this.inputSup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputSup.Click += new System.EventHandler(this.inputSup_Click);
            this.inputSup.MouseEnter += new System.EventHandler(this.inputSup_MouseEnter);
            this.inputSup.MouseLeave += new System.EventHandler(this.inputSup_MouseLeave);
            // 
            // listPnjln
            // 
            this.listPnjln.BackColor = System.Drawing.Color.Transparent;
            this.listPnjln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPnjln.ForeColor = System.Drawing.Color.Black;
            this.listPnjln.Location = new System.Drawing.Point(23, 76);
            this.listPnjln.Name = "listPnjln";
            this.listPnjln.Size = new System.Drawing.Size(177, 39);
            this.listPnjln.TabIndex = 26;
            this.listPnjln.Text = "List Data Penjualan";
            this.listPnjln.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listPnjln.Click += new System.EventHandler(this.listPnjln_Click);
            this.listPnjln.MouseEnter += new System.EventHandler(this.listPnjln_MouseEnter);
            this.listPnjln.MouseLeave += new System.EventHandler(this.listPnjln_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Pembelian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Penjualan";
            // 
            // tbPnjln
            // 
            this.tbPnjln.BackColor = System.Drawing.Color.Transparent;
            this.tbPnjln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPnjln.ForeColor = System.Drawing.Color.Black;
            this.tbPnjln.Location = new System.Drawing.Point(23, 37);
            this.tbPnjln.Name = "tbPnjln";
            this.tbPnjln.Size = new System.Drawing.Size(177, 39);
            this.tbPnjln.TabIndex = 13;
            this.tbPnjln.Text = "Tambah Penjualan";
            this.tbPnjln.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPnjln.Click += new System.EventHandler(this.tbPnjln_Click);
            this.tbPnjln.MouseEnter += new System.EventHandler(this.tbPnjln_MouseEnter);
            this.tbPnjln.MouseLeave += new System.EventHandler(this.tbPnjln_MouseLeave);
            // 
            // data_BarangTableAdapter
            // 
            this.data_BarangTableAdapter.ClearBeforeFill = true;
            // 
            // LstPjln
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1330, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataListPnjln);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LstPjln";
            this.Text = "Form_ListPenjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataListPnjln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_BarangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataListPnjln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tbPmbln;
        private System.Windows.Forms.Label inputBg;
        private System.Windows.Forms.Label inputSup;
        private System.Windows.Forms.Label listPnjln;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tbPnjln;
        private Data_BarangDataSet data_BarangDataSet;
        private System.Windows.Forms.BindingSource dataBarangBindingSource;
        private Data_BarangDataSetTableAdapters.Data_BarangTableAdapter data_BarangTableAdapter;
    }
}

