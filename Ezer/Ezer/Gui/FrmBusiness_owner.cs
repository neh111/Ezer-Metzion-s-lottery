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
    public partial class FrmBusiness_owner : Form
    {
        private Business_ownerDb tblBusiness_owner;
        private ProductsDb tblProducts;
        private CardsDb tblCards;
        private bool flagAdd;
        private bool flagUpdate;
        private Business_owner business_owner;
        private int y;
        private Form1 f;
        private FrmProducts fp;
          public FrmBusiness_owner()
        {
            InitializeComponent();
            y = 1;
            tblBusiness_owner = new Business_ownerDb();
            business_owner = tblBusiness_owner.GetList().FirstOrDefault();
            flagUpdate = false;
            flagAdd = false;
            NotPossible();
            //Fill(business_owner);
            tblProducts = new ProductsDb();
            tblCards = new CardsDb();
        }

        public FrmBusiness_owner(Form1 f):this()
        {
            this.f = f;
        }
        private void Possible()
        {
            btnSave.Visible = true;
            btnDel.Visible = true;
            txtId.ReadOnly = false;
             txtBusiness_name.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtZip_code.ReadOnly = false;
            txtPel.ReadOnly = false;
            txtBusiness_tel.ReadOnly = false;
            txtGmail.ReadOnly = false;
            txtF_name.ReadOnly = false;
            txtL_name.ReadOnly = false;
            txtItem_description.ReadOnly = false;
        }
        private void Fill(Business_owner bo)
        {
            if (tblBusiness_owner.Size() > 0)
            {
                txtId.Text = bo.Business_owner_id.ToString();
                txtBusiness_name.Text = bo.Business_name.ToString();
                txtAddress.Text = bo.Address.ToString();
                txtCity.Text = bo.City.ToString();
                chkStatus.Checked = (bo.Status.Equals(true));
                txtZip_code.Text = bo.Zip_code.ToString();
                txtPel.Text = bo.Pel.ToString();
                txtBusiness_tel.Text = bo.Business_tel.ToString();
                txtGmail.Text = bo.Gmail.ToString();
                txtF_name.Text = bo.F_name.ToString();
                txtL_name.Text = bo.L_name.ToString();
                txtItem_description.Text = bo.Item_description.ToString();
            }
            else
            {
                txtId.Text = " ";
                txtBusiness_name.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                chkStatus.Checked = false;
                txtZip_code.Text = " ";
                txtPel.Text = " ";
                txtBusiness_tel.Text = " ";
                txtGmail.Text = " ";
                txtF_name.Text = "";
                txtL_name.Text =" ";
                txtItem_description.Text = " ";
            }
        }
        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnDel.Visible = false;
            txtId.ReadOnly = true;
            txtBusiness_name.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtZip_code.ReadOnly = true;
            txtPel.ReadOnly = true;
            txtBusiness_tel.ReadOnly = true;
            txtGmail.ReadOnly = true;
            txtF_name.ReadOnly = true;
            txtL_name.ReadOnly = true;
            txtItem_description.ReadOnly = true;
            
        }
        private void lblZip_code_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblBusiness_owner.GetList().Select(x => new
            {
                תעודת_זהות = x.Business_owner_id,
                שם_עסק= x.Business_name,
                כתובת = x.Address,
                עיר = x.City,
                מיקוד = x.Zip_code,
                פלאפון=x.Pel,
                טלפון_עסק=x.Business_tel,
                מייל=x.Gmail,
                שם_פרטי=x.F_name,
                שם_משפחה=x.L_name,
                תאור_פריט_התרומה=x.Item_description,
                פעיל = x.Status
            }).ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
              txtId.Text = "";
            txtBusiness_name.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtZip_code.Text = "";
            txtPel.Text = "";
            txtBusiness_tel.Text = "";
            txtGmail.Text = "";
            txtF_name.Text = "";
            txtL_name.Text = "";
            txtItem_description.Text = "";
            chkStatus.Checked = true;
            Possible();
            flagAdd = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק בעל עסק זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].ToString();
                tblBusiness_owner.DeleteRow(st);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Business_owner bo = tblBusiness_owner.Find(st);
                Fill(bo);
                business_owner = bo;
                Possible();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Business_owner bo = tblBusiness_owner.Find(st);
                Fill(bo);
                business_owner = bo;
                Possible();
                flagUpdate = true;
            }
        }

        private void FrmBusiness_owner_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblBusiness_owner.Size())
            {
                Fill(tblBusiness_owner.GetList().ElementAt(y));
                y++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
            {
                if (CreateFields(business_owner))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן בעל עסק זה?", "עדכון אשור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblBusiness_owner.UpDateRow(business_owner);
                        NotPossible();
                    }
                }
            }
            if (flagAdd)
            {
                Business_owner bo = new Business_owner();
                if (this.tblBusiness_owner.Find(txtId.Text.ToString()) == null)
                {
                    if (CreateFields(bo))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף בעל עסק זה ?", "הוספה אשור",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblBusiness_owner.AddNew(bo);
                            NotPossible();
                            FrmProducts fp = new FrmProducts(this, txtId.Text,2);
                            fp.Show();
                            this.Hide();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("בעל עסק זה במערכת, בדוק את תעודת הזהות!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            
        }
        private bool CreateFields(Business_owner bo)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                bo.Business_owner_id = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                bo.Business_name = txtBusiness_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBusiness_name, ex.Message);
                ok = false;
            }
            try
            {
                bo.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                ok = false;
            }
            try
            {
                bo.City = txtCity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCity, ex.Message);
                ok = false;
            }
            try
            {
                bo.Zip_code =txtZip_code.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtZip_code, ex.Message);
                ok = false;
            }
            try
            {
                bo.Pel = txtPel.Text;
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(txtPel, ex.Message);
                ok = false;
            }
            try
            {
                bo.Business_tel = txtBusiness_tel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBusiness_tel, ex.Message);
                ok = false;
            }
            try
            {
                bo.Gmail = txtGmail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtGmail, ex.Message);
                ok = false;
            }
            try
            {
                bo.F_name = txtF_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtF_name, ex.Message);
                ok = false;
            }
            try
            {
                bo.L_name = txtL_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtL_name, ex.Message);
                ok = false;
            }
            try
            {
                bo.Item_description = txtItem_description.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtItem_description, ex.Message);
                ok = false;
            }
            bo.Status = (chkStatus.Checked == true);
            return ok;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }

        private void btnBefore_Click_1(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }
    }
}
