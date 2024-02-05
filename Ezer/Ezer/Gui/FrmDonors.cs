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
    public partial class FrmDonors : Form
    {
        private DonorsDb tblDonors;
        private bool flagAdd;
        private bool flagUpdate;
        private Donors donors;
        private int y;
        private Form1 f;
        private FrmOrders fo;
        public FrmDonors()
        {
            InitializeComponent();
            y = 1;
            tblDonors = new DonorsDb();
            donors = tblDonors.GetList().FirstOrDefault();
            flagUpdate = false;
            flagAdd = false;
            NotPossible();
            //Fill(donors);
        }
        public FrmDonors(Form1 f):this()
        {
            //ClearTxt();
            btnErase.Visible = false;
            btnNew.Visible = false;
            btnBeforeOrders.Visible = false;
            this.f = f;
        }
        public FrmDonors(FrmOrders fo):this()
        {
            btnShow.Visible = false;
            btnErase.Visible = false;
            btnRefresh.Visible = false;
            btnBeforeMain.Visible = false;
            btnNext.Visible = false;
            btnSave.Visible = true;
            btnNew.Visible = false;
            flagAdd = true;
            flagUpdate = false;
            txtId.Text = "";
            txtF_name.Text = "";
            txtL_mame.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtZip_code.Text = "";
            txtTel.Text = "";
            txtPel.Text = "";
            txtGmail.Text = "";
            chkStatus.Checked = true;
            Possible();
            this.fo = fo;
        }
        public FrmDonors(FrmOrders fo,Donors d):this()//לעשות על עדכון
        {
            flagUpdate = true;
            flagAdd = false;
            btnShow.Visible = false;
            btnErase.Visible = false;
            btnRefresh.Visible = false;
            btnBeforeMain.Visible = false;
            btnNext.Visible = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            this.fo = fo;
            Fill(d);
            donors = d;
            Possible();
            txtId.ReadOnly = true;
        }
        
        private void Possible()
        {
            btnSave.Visible = true;
            txtId.ReadOnly = false;
            txtF_name.ReadOnly = false;
            txtL_mame.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtZip_code.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtPel.ReadOnly = false;
            txtGmail.ReadOnly = false;
        }
        private void Fill(Donors d)
        {
            if (tblDonors.Size() > 0)
            {
                txtId.Text = d.Id_donor.ToString();
                txtF_name.Text = d.F_name.ToString();
                txtL_mame.Text = d.L_name.ToString();
                txtAddress.Text = d.Address.ToString();
                chkStatus.Checked = (d.Status.Equals(true));
                txtCity.Text = d.City.ToString();
                txtZip_code.Text = d.Zip_code.ToString();
                txtTel.Text = d.Tel.ToString();
                txtPel.Text = d.Pel.ToString();
                txtGmail.Text = d.Gmail.ToString();
            }
            else
            {
                txtId.Text = "";
                txtF_name.Text = "";
                txtL_mame.Text = "";
                txtAddress.Text = "";
                chkStatus.Checked = false;
                txtCity.Text = "";
                txtZip_code.Text = "";
                txtTel.Text = "";
                txtPel.Text = "";
                txtGmail.Text = "";
            }
        }
        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            txtId.ReadOnly = true;
            txtF_name.ReadOnly = true;
            txtL_mame.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtZip_code.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtPel.ReadOnly = true;
            txtGmail.ReadOnly = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Donors d = tblDonors.Find(st);
                Fill(d);
                donors = d;
                Possible();
                btnSave.Visible = false;
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק תורם זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].ToString();
                tblDonors.DeleteRow(st);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)//לא שומר
        {
            if (flagUpdate)
            {
                if (CreateFields(donors))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן תורם זה?", "עדכון אשור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblDonors.UpDateRow(donors);
                        NotPossible();
                        this.fo.Fresh(donors);
                        ClearTxt();
                        this.fo.Show();
                        this.Hide();
                    }
                }
            }
            if (flagAdd)
            {
                Donors d = new Donors();
                if (this.tblDonors.Find(txtId.Text.ToString()) == null)
                {
                    if (CreateFields(d))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף תורם זה ?", "הוספה אשור",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblDonors.AddNew(d);
                            NotPossible();
                            fo.ShowIdDonorAndCreate(d);// הצגת התז בראש טופס ההזמנות ויצירת עצם מסוג הזמנה
                            fo.ShowDonorDetails(d);//הצגת פרטי תורם בדטהגרידויו
                                                   //FrmOrders f1 = new FrmOrders(fo, txtId.Text);
                            //this.fo.Fresh(d);
                            ClearTxt();
                            this.fo.Show();
                            this.Hide();
                            //f1 .Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("תורם זה קיים במערכת, בדוק את תעודת הזהות!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                
            }
        }
        private bool CreateFields(Donors d)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                d.Id_donor = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                d.F_name = txtF_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtF_name, ex.Message);
                ok = false;
            }
            try
            {
                d.L_name = txtL_mame.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtL_mame, ex.Message);
                ok = false;
            }
            try
            {
                d.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                ok = false;
            }
            try
            {
                d.City = txtCity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCity, ex.Message);
                ok = false;
            }
            try
            {
                d.Zip_code = txtZip_code.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtZip_code, ex.Message);
                ok = false;
            }
            try
            {
                d.Tel = txtTel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTel, ex.Message);
                ok = false;
            }
            try
            {
                d.Pel = txtPel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPel, ex.Message);
                ok = false;
            }
            try
            {
                d.Gmail = txtGmail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtGmail, ex.Message);
                ok = false;
            }
            d.Status = (chkStatus.Checked == true);
            return ok;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblDonors.GetList().Select(x => new
            {
                תעודת_זהות = x.Id_donor,
                שם_פרטי = x.F_name,
                שם_משפחה = x.L_name,
                כתובת = x.Address,
                מיקוד = x.Zip_code,
                עיר = x.City,
                טלפון = x.Tel,
                פלאפון = x.Pel,
                מייל = x.Gmail,
                פעיל = x.Status
            }).ToList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblDonors.Size())
            {
                Fill(tblDonors.GetList().ElementAt(y));
                donors = tblDonors.GetList().ElementAt(y);
                y++;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Donors d = tblDonors.Find(st);
                Fill(d);
                donors = d;
                Possible();
                flagUpdate = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtF_name.Text = "";
            txtL_mame.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtZip_code.Text = "";
            txtTel.Text = "";
            txtPel.Text = "";
            txtGmail.Text = "";
            chkStatus.Checked = true;
            Possible();
            flagAdd = true;
        }
        private void ClearTxt()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtF_name.Text = "";
            txtGmail.Text = "";
            txtId.Text = "";
            txtL_mame.Text = "";
            txtPel.Text = "";
            txtTel.Text = "";
            txtZip_code.Text = "";
        }

        private void FrmDonors_Load(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            ClearTxt();
            this.f.Show(); 
            this.Hide();
        }

        private void btnBeforeOrders_Click(object sender, EventArgs e)
        {
            this.fo.Fresh(donors);
            ClearTxt();
            this.fo.Show();
            this.Hide();
        }
    }
}

