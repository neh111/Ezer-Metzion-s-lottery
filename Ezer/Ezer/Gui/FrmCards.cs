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
    public partial class FrmCards : Form
    {
        private bool flagAdd;
        private bool flagUpdate;
        private Cards cards;
        private CardsDb tblCards;
        private int y;
        private Form1 f;
        

        public FrmCards()
        {
            InitializeComponent();
            y = 1;
            tblCards = new CardsDb();
            cards = tblCards.GetList().FirstOrDefault();
            flagUpdate = false;
            flagAdd = false;
            NotPossible();
           // Fill(cards);
        }
        public FrmCards(Form1 f) : this()
        {
            this.f = f;
        }
       /* public FrmCards(FrmOrders fo,Booked_packages bp,int numCards) : this()
        {
            this.fo = fo;
            this.bp = bp;
            count = 0;
            btnBefore.Visible = false;
            btnCancel.Visible = false;
            btnErase.Visible = false;
            btnNew.Visible = false;
            btnSave.Visible = false;
            btnUpdate.Visible = false;
            this.numCards = numCards;
            txtRestCards.Text = numCards.ToString();
        }*/
        private void Fill(Cards c)
        {
            if (tblCards.Size() > 0)
            {
                txtCode.Text = c.Card_code.ToString();
                txtName.Text = c.Card_name.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtName.Text = "";
            }
        }

        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
           // btnCancel.Visible = false;
            txtCode.ReadOnly = true;
            txtName.ReadOnly = true;

        }
        private void Possible()
        {
            //btnCancel.Visible = true;
            txtCode.ReadOnly = true;
            txtName.ReadOnly = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCards_Load(object sender, EventArgs e)
        {

        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCards.GetList().Select(x => new
            {
                קוד_כרטיס = x.Card_code,
                שם_כרטיס = x.Card_name
            }).ToList();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק כרטיס זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].ToString();
                tblCards.DeleteRow(Convert.ToInt32(st));
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Cards c = tblCards.Find(Convert.ToInt32(st));
                Fill(c);
                cards = c;
                Possible();

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
            if (y < tblCards.Size())
            {
                Fill(tblCards.GetList().ElementAt(y));
                y++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
                if (CreateFields(cards))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן כרטיס זה?", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblCards.UpDateRow(cards);
                        NotPossible();
                    }
                }
            if (flagAdd)
            {
                Cards c = new Cards();

                if (this.tblCards.Find(Convert.ToInt32(txtCode.Text.ToString())) == null)
                {
                    if (CreateFields(c))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף כרטיס זה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblCards.AddNew(c);
                            NotPossible();

                        }
                    }
                    else
                    {
                        MessageBox.Show("כרטיס זה קיים במערכת, בדוק את הקוד!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
        private bool CreateFields(Cards c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.Card_code = Convert.ToInt32(txtCode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCode, ex.Message);
                ok = false;
            }

            try
            {
                c.Card_name = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            return ok;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            
        }
    }
}

