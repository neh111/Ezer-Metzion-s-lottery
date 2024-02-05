using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezer
{
    public partial class frmBusiness_owner : Form
    {
        private Business_ownerDb tblBusiness_owner;
        private bool flagAdd;
        private bool flagUpdate;
        private Business_owner business_owner;
        private int y;
          public frmBusiness_owner()
        {
            InitializeComponent();
            y = 1;
            tblJewllery = new JewlleryDB();
            jewllery = tblJewllery.GetList().FirstOrDefault();
            flagUpdate = false;
            flagAdd = false;
            NotPossible();
            Fill(jewllery);
            tblkinds = new KindsDB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBusiness_owner_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }
    }
}
