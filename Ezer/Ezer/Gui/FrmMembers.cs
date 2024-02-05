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
    public partial class FrmMembers : Form
    {
        private MembersDb tblMembers;
        private bool flagAdd;
        private bool flagUpdate;
        private Members members;
        private int y;
        Random rnd = new Random();
        private Form1 f;
        public FrmMembers()
        {
            InitializeComponent();
            y = 1;
            tblMembers = new MembersDb();
            members = tblMembers.GetList().FirstOrDefault();
            flagUpdate = false;
            flagAdd = false;
            NotPossible();
            //Fill(members);
            tblMembers = new MembersDb();
        }
        public FrmMembers
            (Form1 f) : this()
        {
            this.f = f;
        }
        private void Possible()
        {
            btnSave.Visible = true;
            btnDelete.Visible = true;
            txtId.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtTotal.ReadOnly = false;
            txtPel.ReadOnly = false;
            txtGmail.ReadOnly = false;
            txtF_name.ReadOnly = false;
            txtL_name.ReadOnly = false;
            txtCode.ReadOnly = true;

        }
        private void Fill(Members m)
        {
            if (tblMembers.Size() > 0)
            {
                txtId.Text = m.Id_member.ToString();
                txtF_name.Text = m.F_name.ToString();
                txtL_name.Text = m.L_name.ToString();
                chkStatus.Checked = (m.Status.Equals(true));
                txtTel.Text = m.Tel.ToString();
                txtPel.Text = m.Pel.ToString();
                txtGmail.Text = m.Gmail.ToString();
                txtTotal.Text = m.Total.ToString();
                txtCode.Text = m.Member_owner_code.ToString();
            }
            else
            {
                txtId.Text = " ";
                txtF_name.Text = "";
                txtL_name.Text = "";
                chkStatus.Checked = false;
                txtTel.Text = " ";
                txtPel.Text = " ";
                txtGmail.Text = " ";
                txtCode.Text = "";
                txtTotal.Text = " ";
            }
        }
        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;
            txtId.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtPel.ReadOnly = true;
            txtGmail.ReadOnly = true;
            txtF_name.ReadOnly = true;
            txtL_name.ReadOnly = true;
            txtCode.ReadOnly = true;
        }
        private bool CreateFields(Members m)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                m.Id_member = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                m.Member_owner_code = Convert.ToInt32(txtCode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCode, ex.Message);
                ok = false;
            }
            try
            {
                m.F_name = txtF_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtF_name, ex.Message);
                ok = false;
            }
            try
            {
                m.L_name = txtL_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtL_name, ex.Message);
                ok = false;
            }
            try
            {
                m.Tel = txtTel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTel, ex.Message);
                ok = false;
            }
            try
            {
                m.Pel = txtPel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPel, ex.Message);
                ok = false;
            }
            try
            {
                m.Gmail = txtGmail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtGmail, ex.Message);
                ok = false;
            }
            try
            {
                m.Total = Convert.ToDouble(txtTotal.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTel, ex.Message);
                ok = false;
            }
            m.Status = (chkStatus.Checked == true);
            return ok;
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Members m = tblMembers.Find(st);
                Fill(m);
                members = m;
                Possible();
                flagUpdate = true;
                //flagAdd = false;
            }
        }

        private void btnCode_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtCode.Text = rnd.Next(100000).ToString();
            txtF_name.Text = "";
            txtL_name.Text = "";
            txtTel.Text = "";
            txtPel.Text = "";
            txtGmail.Text = "";
            txtTotal.Text = 0.ToString();
            chkStatus.Checked = true;
            Possible();
            flagAdd = true;
            flagUpdate = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMembers.GetList().Select(x => new
            {
                תעודת_זהות = x.Id_member,
                קוד_אישי = x.Member_owner_code,
                שם_פרטי = x.F_name,
                שם_משפחה = x.L_name,
                פלאפון = x.Pel,
                טלפון = x.Tel,
                מייל = x.Gmail,
                הסכום_שהצטבר = x.Total,
                פעיל = x.Status
            }).ToList();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק נאמנת זו?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].ToString();
                tblMembers.DeleteRow(st);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Members m = tblMembers.Find(st);
                Fill(m);
                members = m;
                //Possible();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblMembers.Size())
            {
                Fill(tblMembers.GetList().ElementAt(y));
                members = tblMembers.GetList().ElementAt(y);
                y++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
            {
                if (CreateFields(members))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן נאמנת זו?", "עדכון אשור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblMembers.UpDateRow(members);
                        NotPossible();
                    }
                }
            }
            if (flagAdd)
            {
                Members m = new Members();
                if (this.tblMembers.Find(txtId.Text) == null)
                {
                    if (CreateFields(m))//לבדוק מה הבעיה בפעולה שהוא מחזיר false
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף נאמנת זו ?", "הוספה אשור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblMembers.AddNew(m);
                            NotPossible();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("נאמנת זו קיימת במערכת, בדוק את תעודת הזהות!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
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

