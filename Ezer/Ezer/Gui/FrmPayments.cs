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
    public partial class FrmPayments : Form
    {
        private PaymentsDb tblPayments;
        private bool flagAdd;
        private bool flagUpdate;
        private Payments payments;
        private int y;
        private OrdersDb tblOrders;
        private FrmOrders fo;
        private Form1 f;
        public FrmPayments()
        {
            InitializeComponent();
            y = 1;
            tblPayments = new PaymentsDb();
            payments = tblPayments.GetList().FirstOrDefault();
            tblOrders = new OrdersDb();
           // flagUpdate = false;
            flagAdd = true;
            //NotPossible();
            //Fill(payments);
            f = new Form1();
        }
        public FrmPayments(FrmOrders fo,int order_code,int payment_amount) : this()
        {
            this.fo = fo;
            txtOrder_code.Text = order_code.ToString();
            txtPayment_code.Text = tblPayments.GetNextKey().ToString();
            txtPayment_amount.Text = payment_amount.ToString();
            btnSave.Visible = true;
        }
        private void Possible()
        {
            btnSave.Visible = true;
            txtPayment_code.ReadOnly = true;
            txtOrder_code.ReadOnly = true;
            txtPayment_amount.ReadOnly = true;
            dtpPayment.Enabled = true;
            dtpTokef.Enabled = true;
            txtCvv.ReadOnly = false;
            txtMastercard_mis.ReadOnly = false;
            txtNum_of_payments.ReadOnly = false;
        }
        private void Fill(Payments p)
        {
            if (tblPayments.Size() > 0)
            {
                txtPayment_code.Text = p.Payment_code.ToString();
                txtOrder_code.Text = p.Order_code.ToString();
                txtPayment_amount.Text = p.Payment_amount.ToString();
                dtpPayment.Value = p.Payment_date;
                dtpTokef.Value = DateTime.Today;
                txtCvv.Text = p.Cvv.ToString();
                txtMastercard_mis.Text = p.Mastercard_mis.ToString();
                txtNum_of_payments.Text = p.Num_of_payment.ToString();
            }
            else
            {
                txtPayment_code.Text = " ";
                txtOrder_code.Text = "";
                txtPayment_amount.Text = "";
                dtpPayment.Value = DateTime.Today;
                dtpTokef.Value = DateTime.Today;
                txtCvv.Text = " ";
                txtMastercard_mis.Text = " ";
                txtNum_of_payments.Text = "";
            }
        }
        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            txtPayment_code.ReadOnly = true;
            txtOrder_code.ReadOnly = true;
            txtPayment_amount.ReadOnly = true;
            dtpPayment.Enabled = false;
            dtpTokef.Enabled = false;
            txtCvv.ReadOnly = true;
            txtMastercard_mis.ReadOnly = true;
            txtNum_of_payments.ReadOnly = true;
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Payments p = tblPayments.Find(Convert.ToInt32(st));
                Fill(p);
                payments = p;
                Possible();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPayments.GetList().Select(x => new
            {
                קוד_תשלום = x.Payment_code,
                קוד_הזמנה = x.Order_code,
                סכום_לתשלום = x.Payment_amount,
                תאריך_תשלום = x.Payment_date,
                מספר_אשראי = x.Mastercard_mis,
                תוקף = x.Expiration,
                cvv = x.Cvv,
                מספר_תשלומים = x.Num_of_payment
            }).ToList();
        }

        

        private void cmbOrder_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders o = tblOrders.Find(Convert.ToInt32(txtOrder_code.Text));
            txtPayment_amount.Text = o.Order_amount.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
            {
                if (CreateFields(payments))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן תשלום זה?", "עדכון אשור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblPayments.UpDateRow(payments);
                        NotPossible();
                    }
                }
            }
            if (flagAdd)
            {
                Payments p = new Payments();
                if (this.tblPayments.Find(Convert.ToInt32(txtPayment_code.Text)) == null)
                {
                    if (CreateFields(p))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף תשלום זה ?", "הוספה אשור",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblPayments.AddNew(p);
                            NotPossible();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("קוד תשלום זה נמצא במערכת!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            MessageBox.Show("!הזמנתך בוצעה בהצלחה! תודה רבה! בזכותך נוכל להציל חיים",
                                  "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Hide();
            f.Show();
           
        }
        private bool CreateFields(Payments p)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                p.Payment_code = Convert.ToInt32(txtPayment_code.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPayment_code, ex.Message);
                ok = false;
            }
            try
            {
                p.Order_code = Convert.ToInt32(txtOrder_code.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtOrder_code, ex.Message);
                ok = false;
            }
            try
            {
                p.Payment_amount = Convert.ToDouble(txtPayment_amount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPayment_amount, ex.Message);
                ok = false;
            }
            try
            {
                p.Payment_date = Convert.ToDateTime(dtpPayment.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpPayment, ex.Message);
                ok = false;
            }
            try
            {
                p.Expiration = Convert.ToDateTime(dtpTokef.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpTokef, ex.Message);
                ok = false;
            }
            try
            {
                p.Cvv = txtCvv.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCvv, ex.Message);
                ok = false;
            }
            try
            {
                p.Mastercard_mis = txtMastercard_mis.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMastercard_mis, ex.Message);
                ok = false;
            }
            try
            {
                p.Num_of_payment = Convert.ToInt32(txtNum_of_payments.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNum_of_payments, ex.Message);
                ok = false;
            }

            return ok;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                Payments p = tblPayments.Find(Convert.ToInt32(st));
                Fill(p);
                payments = p;
                Possible();
                flagUpdate = true;
            }
        }

        private void txtPayment_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.fo.Show();
            this.Hide();
        }
    }
}