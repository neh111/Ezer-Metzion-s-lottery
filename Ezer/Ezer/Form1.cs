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
using Ezer.Db;
using Ezer.Data;
using Ezer.Models;
using Ezer.Validate;
using Ezer.Gui;

namespace Ezer
{
    public partial class Form1 : Form
    {
       private string sismaOffice = 212508.ToString();
        private string sismaWin = 508220.ToString();
        private DonorsDb tblDonors;
        public Form1()
        {
            InitializeComponent();
            btnOffice.Visible = true;
            btnCustomer.Visible = true;
            btnPackages.Visible = false;
            btnMembers.Visible = false;
            btnDonors.Visible = false;
            btnCards.Visible = false;
            btnBusinessOwner.Visible = false;
            BtnOrders.Visible = false;
            btnBefore.Visible = false;
            btnWinners.Visible = false;
            btnFrmProducts.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblId.Visible = false;
            lblIfNew.Visible = false;
            txtId.Visible = false;
            tblDonors = new DonorsDb();
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            btnCustomer.Visible = false;
            lblSisma.Visible = true;
            txtSisma.Visible = true;
            btnOk.Visible = true;
            btnBefore.Visible = true;
            BtnOrders.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtSisma.Text != this.sismaOffice.ToString())
            {
                DialogResult r = MessageBox.Show("סיסמה שגויה, אנא הקש שנית ?", "הודעה",
                            MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.OK)
                {
                    txtSisma.Text = "";
                    btnPackages.Visible = false;
                    btnMembers.Visible = false;
                    btnDonors.Visible = false;
                    btnCards.Visible = false;
                    btnBusinessOwner.Visible = false;
                    btnWinners.Visible = false;
                }
            }
            else
            {
                btnPackages.Visible = true;
                btnMembers.Visible = true;
                btnDonors.Visible = true;
                btnCards.Visible = true;
                btnBusinessOwner.Visible = true;
                btnWinners.Visible = true;
                btnFrmProducts.Visible = true;
            }
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnCustomer.Visible = false;
            lblSisma.Visible = false;
            txtSisma.Visible =false;
            btnOk.Visible = false;
            btnOffice.Visible = false;
            btnYes.Visible = true;
            btnNo.Visible = true;
            lblIfNew.Visible = true;
            btnBefore.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            FrmDonors f = new FrmDonors(this);
            f.Show();
            this.Hide();
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            FrmCards f = new FrmCards(this);
            f.Show();
            this.Hide();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            FrmPackages f = new FrmPackages(this);
            f.Show();
            this.Hide();
        }

        private void btnBusinessOwner_Click(object sender, EventArgs e)
        {
            FrmBusiness_owner f = new FrmBusiness_owner(this);
            f.Show();
            this.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            FrmMembers f = new FrmMembers(this);
            f.Show();
            this.Hide();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            FrmOrders fo = new FrmOrders(this,2);
            fo.ShowIdDonorAndCreate(tblDonors.GetList().Find(x=>x.Id_donor==txtId.Text));// הצגת התז בראש טופס ההזמנות ויצירת עצם מסוג הזמנה
            fo.ShowDonorDetails(tblDonors.GetList().Find(x => x.Id_donor == txtId.Text));//הצגת פרטי תורם בדטהגרידויו
            fo.Show();
            this.Hide();
        }

        private void txtSisma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            btnDonors.Visible = false;
            btnPackages.Visible = false;
            btnOk.Visible = false;
            btnMembers.Visible = false;
            btnBusinessOwner.Visible = false;
            btnCards.Visible = false;
            btnWinners.Visible = false;
            btnFrmProducts.Visible = false;
            btnCustomer.Visible = true;
            BtnOrders.Visible = false;
            lblSisma.Visible = false;
            txtSisma.Visible = false;
            lblIfNew.Visible = false;
            txtId.Visible = false;
            lblId.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            btnOffice.Visible = true;
            txtSisma.Text = "";
        }

        private void btnWinners_Click(object sender, EventArgs e)
        {
            FrmWinners f = new FrmWinners(this);
            f.Show();
            this.Hide();
        }

        private void btnFrmProducts_Click(object sender, EventArgs e)
        {
           FrmProducts fp = new FrmProducts(this);
            fp.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FrmOrders f = new FrmOrders(this,1);
            f.Show();
            this.Hide();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            btnNo.Visible = false;
            lblId.Visible = true;
            txtId.Visible = true;
            BtnOrders.Visible = true;
        }
    }
    
}
