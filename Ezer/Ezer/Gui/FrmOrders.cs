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
    public partial class FrmOrders : Form
    {
        private MembersDb tblMembers;
        private DonorsDb tblDonors;
        private PackagesDb tblPackages;
        private OrdersDb tblOrders;
        private CardsDb tblCards;
        private PaymentsDb tblPayments;
        private ProductsDb tblProducts;
        private Booked_packagesDb tblBooked_packages;
        private Booked_cardsDb tblBooked_cards;
        private Orders orders;
        private Members members;
        private Donors donors;
        private Packages packages;
        private Cards cards;
        private Payments payments;
        private Products products;
        private Booked_packages booked_packages; 
        private Booked_cards boked_cards;
        private Form1 f;
        private int schumSofi;
        public FrmOrders()
        {
            InitializeComponent();
            tblMembers = new MembersDb();
            tblDonors = new DonorsDb();
            tblOrders = new OrdersDb();
            orders = new Orders();
            tblBooked_cards = new Booked_cardsDb();
            tblBooked_packages = new Booked_packagesDb();
            tblCards = new CardsDb();
            tblPackages = new PackagesDb();
            tblPayments = new PaymentsDb();
            cmbMembers.DataSource = tblMembers.GetList();
            txtOrderCode.Text = tblOrders.GetNextKey().ToString();
            lblAmount.Visible = false;
            txtAmount.Visible = false;
            btnChoose.Visible = false;
            chooseCards.Visible = false;
            lblNumCards.Visible = false;
            txtNumCards.Visible = false;
            schumSofi = 0;
            txtOrderAmount.Text = Convert.ToString(schumSofi);
        }
        public FrmOrders(Form1 f,int x):this()
        {
            this.f = f;
            if (x == 1)
                btnUpdateDonorDetails.Visible = false;
            else
                btnGetDetailsDonors.Visible = false;
        }
        public void ShowIdDonorAndCreate(Donors d)
        {
            txtIdDonor.Text = d.Id_donor;
            Orders o = new Orders();
            o.Order_code = Convert.ToInt32(txtOrderCode.Text);
            o.Order_date = dtpOrderDate.Value;
            o.Id_donor = d.Id_donor;
            o.Order_amount = schumSofi;
            o.Id_member = ((Members)cmbMembers.SelectedItem).Id_member;
            tblOrders.AddNew(o);
            orders = o;
        }
        public void ShowDonorDetails(Donors d)
        {
            
            dgDonor.DataSource = tblDonors.GetList().Where(x=> x.Id_donor==d.Id_donor).Select(x => new
            {
                תעודת_זהות_תורם = x.Id_donor,
                שם_פרטי = x.F_name,
                שם_משפחה = x.L_name,
                עיר = x.City,
                כתובת = x.Address,
                מיקוד = x.Zip_code,
                טלפון = x.Tel,
                פלאפון = x.Pel,
                מייל = x.Gmail,
                פעיל = x.Status
            }).ToList();
            donors = d;
        }
        public void ShowPackage(Packages p)
        {
            dgPackages.DataSource = tblPackages.GetList().Select(x => new
            {
                קוד_חבילה = p.Package_code,
                שם_חבילה = p.Package_name,
                מחיר_חבילה = p.Package_price,
                כמות_כרטיסים = p.Cards_num
            }).ToList();
        }
        public void ShowBookedCards(Booked_cards bc)
        {
            dgBookedCards.DataSource = tblBooked_cards.GetList().Where(x => x.Order_code == bc.Order_code)
            .Select(x => new
            {
                תאריך_הזמנה = x.Order_code,
                קוד_חבילה = x.Package_code,
                קוד_מוצר = x.ThisProducts().Product_code,
                מספר_כרטיסים = x.Cards_amount
            }).ToList();
        }

        private void btnDeleteO_Click(object sender, EventArgs e)
        {
            
        }

        private void txtOrderCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם בחרת מיהי הנאמנת ששיתפה אותך בהגרלה?", "הודעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
            orders.Id_member = ((Members)cmbMembers.SelectedItem).Id_member;
            tblOrders.UpDateRow(orders);
            Members m = tblMembers.GetList().Find(x => x.Id_member == orders.Id_member);
            m.Total += Convert.ToInt32(txtOrderAmount.Text);
            tblMembers.UpDateRow(m);
            orders.Order_amount = Convert.ToInt32(txtOrderAmount.Text);
            tblOrders.UpDateRow(orders);
            FrmPayments f = new FrmPayments(this,Convert.ToInt32(txtOrderCode.Text),Convert.ToInt32(txtOrderAmount.Text));
            f.Show();
            this.Hide();
                }  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void optMember_CheckedChanged(object sender, EventArgs e)
        {
            cmbMembers.Enabled = false;
        }

        

        private void btnView_Click(object sender, EventArgs e)
        {
            dgDonor.DataSource = tblDonors.GetList().Where(x => x.Id_donor == txtIdDonor.Text).Select(x => new
            {
                תעודת_זהות_תורם = x.Id_donor,
                שם_פרטי = x.F_name,
                שם_משפחה=x.L_name,
                עיר=x.City,
                כתובת=x.Address,
                מיקוד=x.Zip_code,
                טלפון=x.Tel,
                פלאפון=x.Pel,
                מייל=x.Gmail,
                פעיל=x.Status
            }).ToList();
        }
        private void FrmOrders_Load(object sender, EventArgs e)
        {
             
        }
        private void Fill(Orders o)//פעולה שממלאת את השדות
        {
            if (tblOrders.Size() > 0)
            {
                txtOrderCode.Text = o.Order_code.ToString();
                dtpOrderDate.Value = o.Order_date;
                txtIdDonor.Text = o.Id_donor.ToString();
                cmbMembers.SelectedItem = o.ThisMembers();
                cmbMembers.Text = o.ThisMembers().Id_member.ToString();
                txtOrderAmount.Text = o.Order_amount.ToString();
            }
            else
            {
                txtOrderCode.Text = "";
                dtpOrderDate.Text = DateTime.Today.ToLongDateString();
                txtIdDonor.Text = "";
                cmbMembers.Text = "";
                txtOrderAmount.Text = ""; 
                
            }
        }
        private bool CreateFields(Orders o)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                o.Order_code = Convert.ToInt32(txtOrderCode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtOrderCode, ex.Message);
                ok = false;
            }
            try
            {
               o.Order_date = Convert.ToDateTime(dtpOrderDate.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpOrderDate, ex.Message);
                ok = false;
            }
            try
            {
                o.Id_donor = txtIdDonor.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtIdDonor, ex.Message);
                ok = false;
            }
            try
            {
                o.Order_amount = Convert.ToInt32(txtOrderAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtOrderAmount, ex.Message);
                ok = false;
            }
            try
            {
                o.Id_member = cmbMembers.SelectedItem.ToString();//מה לכתוב
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbMembers, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
        }

        private void btnMorePackage_Click(object sender, EventArgs e)
        {
            FrmPackages f = new FrmPackages(this);
            f.Show();
            this.Hide();
        }

        private void btnChoosePackage_Click(object sender, EventArgs e)
        {
            lblAmount.Visible = true;
            txtAmount.Visible = true;
            btnChoose.Visible = true;
            chooseCards.Visible = true;
            dgPackages.DataSource = tblPackages.GetList().Select(x => new
            {
                קוד_חבילה = x.Package_code,
                שם_חבילה = x.Package_name,
                מחיר_חבילה = x.Package_price,
                כמות_כרטיסים = x.Cards_num
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDonors f = new FrmDonors(this);
            f.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Booked_packages bp = new Booked_packages();
            bp.Order_code = Convert.ToInt32(txtOrderCode.Text);
            string st = dgPackages.SelectedRows[0].Cells[0].Value.ToString();
            bp.Package_code = Convert.ToInt32(st);
            bp.Packages_amount = Convert.ToInt32(txtAmount.Text.ToString());
            tblBooked_packages.AddNew(bp);
            dgBookedPackages.DataSource = tblBooked_packages.GetList().Where(x => x.Order_code == bp.Order_code &&
              x.Package_code == bp.Package_code).Select(x => new
              {
                  קוד_הזמנה = x.Order_code,
                  קוד_חבילה = x.Package_code,
                  כמות_חבילות_מוזמנות = x.Packages_amount
              }).ToList();
            lblAmount.Visible = false;
            txtAmount.Visible = false;
            double price = tblPackages.GetList().Find(x => x.Package_code == bp.Package_code).Package_price;
            txtOrderAmount.Text = Convert.ToString(bp.Packages_amount * price+schumSofi);
            schumSofi = Convert.ToInt32(txtOrderAmount.Text);
            lblNumCards.Visible = true;
            txtNumCards.Visible = true;
            int numCards = tblPackages.GetList().Find(x => x.Package_code == bp.Package_code).Cards_num;
            txtNumCards.Text =Convert.ToString(Convert.ToInt32(txtAmount.Text)*bp.ThisPackages().Cards_num);
            booked_packages = bp;
            
        }

        private void dgPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }

        private void dgDonor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewBp_Click(object sender, EventArgs e)
        {

        }

        private void chooseCards_Click(object sender, EventArgs e)
        {
            FrmBookedCaeds fbc = new FrmBookedCaeds(this,booked_packages,Convert.ToInt32(txtNumCards.Text));
            fbc.Show();
            this.Hide();
        }
        public void Fresh(Donors d)
        {
            dgDonor.DataSource = tblDonors.GetList().Where(x=>x.Id_donor==d.Id_donor).Select(x => new
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
        private void btnUpdateBp_Click(object sender, EventArgs e)
        {

        }

        private void cmbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateBookedCards_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {

        }

        private void txtNumCards_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateDonorDetails_Click(object sender, EventArgs e)
        {
            if (dgDonor.SelectedRows.Count > 0)
            {
                string st = dgDonor.SelectedRows[0].Cells[0].Value.ToString();
                Donors d = tblDonors.Find(st);
                FrmDonors fd = new FrmDonors(this, d);
                fd.Show();
                this.Hide();
            }
        }
            
    }
}
