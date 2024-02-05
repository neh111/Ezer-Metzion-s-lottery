using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Ezer.Db;
using Ezer.Data;
using Ezer.Models;
using Ezer.Validate;
using Ezer.Gui;


namespace Ezer.Models
{
   public class Orders
    {
        private int order_code;
        private DateTime order_date;
        private string id_donor;
        private int order_amount;
        private string id_member;
        public DataRow DR { get; set; }
        public Orders()
        {

        }
        public Orders(DataRow dr)
        {
            this.DR = dr;
            this.order_code = Convert.ToInt32(dr["order_code"].ToString());
            this.order_date = Convert.ToDateTime(dr["order_date"].ToString());
            this.id_donor = dr["id_donor"].ToString();
            this.order_amount = Convert.ToInt32(dr["order_amount"].ToString());
            this.id_member = dr["id_member"].ToString();
           
        }
        public void PutInto()
        {
            DR["order_code"] = this.order_code;
            DR["order_date"] = this.order_date;
            DR["id_donor"] = this.id_donor;
            DR["order_amount"] = this.order_amount;
            DR["id_member"] = this.id_member;
         
        }

        public int Order_code
        {
            get
            {
                return this.order_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.order_code = value;
                else
                    throw new Exception("הקש קוד הזמנה במספרים בלבד");

            }
        }
        public DateTime Order_date
        {
            get
            {
                return this.order_date;
            }
            set
            {
               // if (ValidateUtil.IsTokef(value.ToString()))//האם מתאים לבדיקה על תאריך
                    this.order_date = value;
               // else
                    //throw new Exception("תאריך הזמנה שגוי, הקש שנית");
            }


        }
        public string Id_donor
        {
            get
            {
                return this.id_donor;
            }
            set
            {
                if (ValidateUtil.LegalId(value))
                    this.id_donor = value;
                else
                    throw new Exception("תעודת זהות שגויה, הקש שנית");
            }
        }
        public int Order_amount
        {
            get
            {
                return this.order_amount;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.order_amount = value;
                else
                    throw new Exception("הקש במספרים בלבד");
            }

        }
        public string Id_member
        {
            get
            {
                return this.id_member;
            }
            set
            {
                if (ValidateUtil.LegalId(value))
                    this.id_member = value;
                else
                    throw new Exception("תעודת זהות שגויה, הקש שנית");
            }
        }
        public Donors ThisDonors()
        {
            DonorsDb k = new DonorsDb();
            return k.GetList().Find(x => x.Id_donor == this.id_donor);
        }
        public Members ThisMembers()
        {
            MembersDb k = new MembersDb();
            return k.GetList().Find(x => x.Id_member == this.id_member);
        }

        public override string ToString()
        {
            return this.order_code + " " + this.order_date;
        }
    }
}
