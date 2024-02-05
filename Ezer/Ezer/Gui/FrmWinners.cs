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

namespace Ezer.Gui
{
    public partial class FrmWinners : Form
    {
        private WinnersDb tblWinners;
        private Winners winners;
        private Form1 f;
        private int y;
        public FrmWinners()
        {
            InitializeComponent();
            y = 1;
            tblWinners = new WinnersDb();
            winners = tblWinners.GetList().FirstOrDefault();
        }
        public FrmWinners(Form1 f) : this()
        {
            this.f = f;
        }
        private void Fill(Winners w)
        {
            if (tblWinners.Size() > 0)
            {
                txtProduct_code.Text = w.Product_code.ToString();
                txtId_donor.Text = w.Id_donor.ToString();
                txtSerial.Text = w.Serial.ToString();
            }
            else
            {
                txtProduct_code.Text = "";
                txtId_donor.Text = "";
                txtSerial.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearchAllWinners.DataSource = tblWinners.GetList().Select(x => new
            {
                קוד_מוצר=x.Product_code,
                תעודת_זהות = x.Id_donor,
                מספר_סידורי = x.Serial
            }).ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgSearchAllWinners.SelectedRows.Count > 0)
            {
                string stProduct_code = dgSearchAllWinners.SelectedRows[0].Cells[0].Value.ToString();
                string stSerial= dgSearchAllWinners.SelectedRows[1].Cells[1].Value.ToString();
                Winners w = tblWinners.Find(Convert.ToInt32(stProduct_code),Convert.ToInt32(stSerial));
                Fill(w);
                winners = w;
                //Possible();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblWinners.Size())
            {
                Fill(tblWinners.GetList().ElementAt(y));
                winners = tblWinners.GetList().ElementAt(y);
                y++;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }
    }
}
