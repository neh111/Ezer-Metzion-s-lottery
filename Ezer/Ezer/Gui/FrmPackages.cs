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
    public partial class FrmPackages : Form
    {
        private PackagesDb tblPackages;
        private bool flagAdd;
        private bool flagUpdate;
        private Packages packages;
        private int y;
        private Form1 f;
        private FrmOrders fo;
        public FrmPackages()
        {
            InitializeComponent();
            y = 1;
            tblPackages = new PackagesDb();
            packages = tblPackages.GetList().FirstOrDefault();
            flagUpdate = false;
        }
        public FrmPackages(Form1 f) : this()
        {
            this.f = f;
            btnBeforeOrders.Visible = false;
        }
        
        public FrmPackages(FrmOrders fo) : this()
        {
            this.fo = fo;
            btnDelete.Visible = false;
            btnErase.Visible = false;
            btnNew.Visible = false;
            btnSave.Visible = false;
            btnUpdate.Visible = false;
            btnBeforeMain.Visible = false;
        }
        private void Fill(Packages p)
        {
            if (tblPackages.Size() > 0)
            {
                txtCode.Text = p.Package_code.ToString();
                txtName.Text = p.Package_name.ToString();
                txtPrice.Text = p.Package_price.ToString();
                txtCards_num.Text = p.Cards_num.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtCards_num.Text = "";
            }
        }
        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;
            txtCode.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtCards_num.ReadOnly = false;

        }
        private void Possible()
        {
            btnSave.Visible = true;
            btnDelete.Visible = true;
            txtCode.ReadOnly = true;
            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtPrice.ReadOnly = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPackages_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Packages p = tblPackages.Find(Convert.ToInt32(st));
                Fill(p);
                packages = p;
                Possible();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק חבילה זו?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].ToString();
                tblPackages.DeleteRow(Convert.ToInt32(st));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCode.Text = tblPackages.GetNextKey().ToString();
            txtName.Text = "";
            txtPrice.Text = "";
            txtCards_num.Text = "";
            Possible();
            flagAdd = true;
            flagUpdate = false;
        }
        private bool CreateFields(Packages p)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                p.Package_code = Convert.ToInt32(txtCode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCode, ex.Message);
                ok = false;
            }
            try
            {
                p.Package_name = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try
            {
                p.Package_price = Convert.ToDouble(txtPrice.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPrice, ex.Message);
                ok = false;
            }
            try
            {
                p.Cards_num = Convert.ToInt32(txtCards_num.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCards_num, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPackages.GetList().Select(x => new
            {
                קוד_חבילה = x.Package_code,
                שם_חבילה = x.Package_name,
                מחיר_חבילה = x.Package_price,
                כמות_כרטיסים = x.Cards_num
            }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
                if (CreateFields(packages))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן חבילה זו?", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblPackages.UpDateRow(packages);
                        NotPossible();
                    }
                }
            if (flagAdd)
            {
                Packages p = new Packages();

                if (this.tblPackages.Find(Convert.ToInt32(txtCode.Text.ToString())) == null)
                {
                    if (CreateFields(p))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף חבילה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblPackages.AddNew(p);
                            NotPossible();

                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            Possible();
            flagUpdate = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblPackages.Size())
            {
                Fill(tblPackages.GetList().ElementAt(y));
                y++;
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuyPackage_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Packages p = tblPackages.Find(Convert.ToInt32(st));
                fo.ShowPackage(p);
                
            }
        }

        private void btnBeforeOrders_Click(object sender, EventArgs e)
        {
            this.fo.Show();
            this.Hide();
        }
    }
}

