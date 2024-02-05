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
    public partial class FrmProducts : Form
    {
        private ProductsDb tblProducts;
        private Booked_cardsDb tblBooked_cards;
        private Cards cards;
        private CardsDb tblCards;
        private Products products;
        private FrmOrders fo;
        private bool flagAdd;
        private bool flagUpdate;
        int count;
        int numCards;
        private int y;
        private Form1 f;
        private FrmBusiness_owner fbo;
        public FrmProducts()
        {
            InitializeComponent();
            //tblBooked_cards = new Booked_cardsDb();
            tblCards = new CardsDb();
            tblProducts = new ProductsDb();
            cards = tblCards.GetList().FirstOrDefault();
            products = tblProducts.GetList().FirstOrDefault();
            txtBusinessOwnerCode.ReadOnly = true;
            NotPossible();
            //Fill(products);
            y = 1;
        }
        public FrmProducts(FrmBusiness_owner fbo,string business_owner_id,int x):this()
        {
            txtProductCode.Text = tblProducts.GetNextKey().ToString();
            this.fbo = fbo;
            txtBusinessOwnerCode.Text = business_owner_id;
            txtxCardCode.Text = txtProductCode.Text;
            txtAmount.ReadOnly = false;
            if (x == 1)
                flagUpdate = true;
            else
                flagAdd = true;
           // Possible();
            btnNext.Visible = false;
            btnRefresh.Visible = false;
            btnShow.Visible = false;
            btnUpdate.Visible = false;
            btnForm1Before.Visible = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            txtProductName.ReadOnly = false;
        }
        public FrmProducts(Form1 f):this()
        {
            this.f = f;
            btnNext.Visible = true;
            btnRefresh.Visible = true;
            btnShow.Visible = true;
            btnUpdate.Visible = true;
            btnBusinessOwnerBefore.Visible = false;
            btnNew.Visible = false;
        }
        private void Possible()
        {
            btnSave.Visible = true;
            //btnDel.Visible = true;
            //txtId.ReadOnly = false;
            //txtProductCode.ReadOnly = false;
            txtProductName.ReadOnly = false;
            //txtxCardCode.ReadOnly = false;
            txtAmount.ReadOnly = false;
        }
        private void Fill(Products p)
        {
            if (tblProducts.Size() > 0)
            {
                txtProductCode.Text = p.Product_code.ToString();
                txtProductName.Text = p.Product_name.ToString();
                txtBusinessOwnerCode.Text = p.Business_owner_code.ToString();//לבדוק מה קורה כי מקבלים נתונים מבעלי עסק
                txtxCardCode.Text = p.Card_code.ToString();
                txtAmount.Text = p.Amount.ToString();
            }
            else
            {
                txtProductCode.Text = " ";
                txtProductName.Text = "";
                txtBusinessOwnerCode.Text = "";//לבדוק מה קורה כי מקבלים מטבלת בעלי עסק
                txtxCardCode.Text = "";
                txtAmount.Text = " ";
            }
        }
        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            txtProductCode.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtBusinessOwnerCode.ReadOnly = true;
            txtxCardCode.ReadOnly = true;
            txtAmount.ReadOnly = true;
            btnNew.Visible = true;

        }
        private bool CreateFields(Products p)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                p.Product_code = Convert.ToInt32(txtProductCode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtProductCode, ex.Message);
                ok = false;
            }
            try
            {
               p.Product_name = txtProductName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtProductName, ex.Message);
                ok = false;
            }
            try
            {
                p.Business_owner_code = txtBusinessOwnerCode.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBusinessOwnerCode, ex.Message);
                ok = false;
            }
            try
            {
                p.Card_code = Convert.ToInt32(txtxCardCode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtxCardCode, ex.Message);
                ok = false;
            }
            try
            {
                p.Amount = Convert.ToInt32(txtAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAmount, ex.Message);
                ok = false;
            }
            return ok;
        }


        private void FrmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgProducts.DataSource = tblProducts.GetList().Select(x => new
            {
                קוד_מוצר = x.Product_code,
                שם_מוצר = x.Product_name,
                תעודת_זהות_של__תורם_המוצר = x.Business_owner_code,
                קוד_כרטיס_שאליו_משויך_המוצר = x.Card_code,
                כמות_זכיות = x.Amount
            }).ToList();
        }
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblProducts.Size())
            {
                Fill(tblProducts.GetList().ElementAt(y));
                y++;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgProducts.SelectedRows.Count > 0)
            {
                string st = dgProducts.SelectedRows[0].Cells[0].Value.ToString();
                Products p = tblProducts.Find(Convert.ToInt32(st));
                Fill(p);
                products = p;
                Possible();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)//לעשות לכרטיסים
        {
            if (flagUpdate)
            {
                if (CreateFields(products))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן מוצר זה?", "עדכון אשור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblProducts.UpDateRow(products);
                        Cards c=tblCards.GetList().Find(x => x.Card_code == products.Product_code);
                        c.Card_name = products.Product_name;
                        tblCards.UpDateRow(c);
                        NotPossible();
                    }
                }
            }
            if (flagAdd)
            {
                Products p=new Products();
                if (this.tblProducts.Find(Convert.ToInt32(txtProductCode.Text)) == null)
                {
                    if (CreateFields(p))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף מוצר זה ?", "הוספה אשור",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblProducts.AddNew(p);
                            Cards c = new Cards();
                            c.Card_code = Convert.ToInt32(txtxCardCode.Text);
                            c.Card_name = txtProductName.Text;
                            tblCards.AddNew(c);
                            NotPossible();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("מוצר זה קיים במערכת, בדוק את הקוד!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }
        }

        private void btnForm1Before_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtBusinessOwnerCode.Text = "";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtxCardCode.Text = "";
            this.f.Show();
            this.Hide();
        }

        private void btnBusinessOwnerBefore_Click(object sender, EventArgs e)
        {
            this.fbo.Show();
            this.Hide();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string st = dgProducts.SelectedRows[0].Cells[0].Value.ToString();
            Products p = tblProducts.Find(Convert.ToInt32(st));
            Fill(p);
            products = p;
            Possible();
            txtProductCode.ReadOnly = true;
            txtxCardCode.ReadOnly = true;
            flagUpdate = true;
            flagAdd = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = tblProducts.GetNextKey().ToString();
            txtxCardCode.Text = txtProductCode.Text;
            Possible();
            flagAdd = true;
        }
    }
}
