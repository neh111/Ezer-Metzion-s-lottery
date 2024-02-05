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
    public partial class FrmBookedCaeds : Form
    {
        private ProductsDb tblProducts;
        private Booked_cardsDb tblBooked_cards;
        private CardsDb tblCards;
        private Cards cards;
        private FrmOrders fo;
        private Booked_packages bp;
        int count;
        int numCards;
        int y;
        public FrmBookedCaeds()
        {
            InitializeComponent();
            tblBooked_cards = new Booked_cardsDb();
            tblCards = new CardsDb();
            cards = tblCards.GetList().FirstOrDefault();
            lblNumCards.Visible = false;
            txtNumCards.Visible = false;
            btnSaveNumCards.Visible = false;
            y = 1;
        }
        public FrmBookedCaeds(FrmOrders fo, Booked_packages bp, int numCards) : this()
        {
            this.fo = fo;
            this.bp = bp;
            count = 0;
            this.numCards = numCards;
            txtRestCards.Text = numCards.ToString();
            btnChoose.Visible = false;
            btnNext.Visible = false;
            btnSaveNumCards.Visible = false;
            btnShow.Visible = false;
        }

            private void btnShowCards_Click(object sender, EventArgs e)
        {
            if (bp.Package_code == 1)
            {
                dgBookedCards.DataSource = tblCards.GetList().Where(x => x.Card_code == 1).Select(x => new
                {
                    קוד_כרטיס = x.Card_code,
                    שם_כרטיס = x.Card_name
                }).ToList();
            }
            else
            {
                dgBookedCards.DataSource = tblCards.GetList().Where(x => x.Card_code != 1).Select(x => new
                {
                    קוד_כרטיס = x.Card_code,
                    שם_כרטיס = x.Card_name
                }).ToList();
            }
            btnShow.Visible = true;
        }

        private void btnSaveBookedCards_Click(object sender, EventArgs e)
        {
            if (count + Convert.ToInt32(txtNumCards.Text) > numCards)
            {
                MessageBox.Show("בחרת מספר גבוה של כרטיסים,עליך לבחור מספר כרטיסים לפי החבילה שרכשת",
                                   "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (tblBooked_cards.Find(bp.Order_code, bp.Package_code, Convert.ToInt32(txtCardCode.Text)) == null)
                {
                    Booked_cards bc = new Booked_cards();
                    bc.Order_code = bp.Order_code;
                    bc.Package_code = bp.Package_code;
                    bc.Product_code = Convert.ToInt32(txtCardCode.Text);
                    bc.Cards_amount = Convert.ToInt32(txtNumCards.Text);
                    tblBooked_cards.AddNew(bc);
                    fo.ShowBookedCards(bc);
                }
                else
                {
                    Booked_cards bc = tblBooked_cards.Find(bp.Order_code, bp.Package_code, Convert.ToInt32(txtCardCode.Text));
                    bc.Cards_amount += Convert.ToInt32(txtNumCards.Text);
                    tblBooked_cards.UpDateRow(bc);
                    fo.ShowBookedCards(bc);
                }
                count += Convert.ToInt32(txtNumCards.Text);
                txtRestCards.Text = Convert.ToString(numCards - count);
                if(Convert.ToInt32(txtRestCards.Text)>1)
                    MessageBox.Show("הזמנת הכרטיסים בוצעה בהצלחה,ביכולתך לבחור כרטיסים נוספים",
                                   "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (Convert.ToInt32(txtRestCards.Text) ==1)
                    MessageBox.Show("הזמנת הכרטיסים בוצעה בהצלחה,ביכולתך לבחור כרטיס נוסף",
                                   "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (Convert.ToInt32(txtRestCards.Text) ==0)
                    MessageBox.Show("הזמנת הכרטיסים בוצעה בהצלחה",
                                   "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); 
            }
            
            txtNumCards.Text = "";
            txtCardCode.Text = "";
            txtCardName.Text = "";
            lblNumCards.Visible = false;
            txtNumCards.Visible = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            lblNumCards.Visible = true;
            txtNumCards.Visible = true;
            btnSaveNumCards.Visible = true;
            btnChoose.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (y < tblCards.Size())
            {
                Fill(tblCards.GetList().ElementAt(y));
               y++;
            }
        }
        private void Fill(Cards c)
        {
            if (tblCards.Size() > 0)
            {
                txtCardCode.Text = c.Card_code.ToString();
                txtCardName.Text = c.Card_name.ToString();
            }
            else
            {
                txtCardCode.Text = "";
                txtCardName.Text = "";
            }
        }


        private void FrmBookedCaeds_Load(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.fo.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgBookedCards.SelectedRows.Count > 0)
            {
                string st = dgBookedCards.SelectedRows[0].Cells[0].Value.ToString();
                Cards c = tblCards.Find(Convert.ToInt32(st));
                Fill(c);
                cards = c;
                btnChoose.Visible = true;
                btnNext.Visible = true;
            }
        }
    }
}
