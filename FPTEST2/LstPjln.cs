using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTEST2
{
    public partial class LstPjln : Form
    {
        public LstPjln()
        {
            InitializeComponent();
        }
        //asddadad
        //hoverr tambahhh penjuaalaaannn
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

        //hover listt penjualannnn
        private void listPnjln_MouseEnter(object sender, EventArgs e)
        {
            this.listPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void listPnjln_MouseLeave(object sender, EventArgs e)
        {
            this.listPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void listPnjln_Click(object sender, EventArgs e)
        {
            this.listPnjln.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        //hover innnnpuuuuuuuttttt suppppppplliierrrrr
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

        //hoverrrrr input baranggggg
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

        //hover tambaahhh pembeliannnnn
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
    }
}
