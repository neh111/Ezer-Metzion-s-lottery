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
   public class Products
    {
        private int product_code;
        private string product_name;
        private string business_owner_code;
        private int card_code;
        private int amount;
        public DataRow DR { get; set; }
        public Products()
        {

        }
        public Products(DataRow dr)
        {
            this.DR = dr;
            this.product_code = Convert.ToInt32(dr["product_code"].ToString());
            this.product_name = dr["product_name"].ToString();
            this.business_owner_code = dr["business_owner_code"].ToString();
            this.card_code = Convert.ToInt32(dr["card_code"].ToString());
            this.amount = Convert.ToInt32(dr["amount"].ToString());
            
        }
        public void PutInto()
        {
            DR["product_code"] = this.product_code;
            DR["product_name"] = this.product_name;
            DR["business_owner_code"] = this.business_owner_code;
            DR["card_code"] = this.card_code;
            DR["amount"] = this.amount;
          
        }

        public int Product_code
        {
            get
            {
                return this.product_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.product_code = value;
                else
                    throw new Exception("הקש במספרים בלבד");

            }
        }
        public string Product_name
        {
            get
            {
                return this.product_name;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.product_name = value;
                else
                    throw new Exception("הקש שם בעברית בלבד");
            }


        }
        public string Business_owner_code
        {
            get
            {
                return this.business_owner_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.business_owner_code = value;
                else
                    throw new Exception("הקש במספרים בלבד");
            }
        }
        public int Card_code
        {
            get
            {
                return this.card_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.card_code = value;
                else
                    throw new Exception("הקש במספרים בלבד");
            }

        }
        public int Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.amount = value;
                else
                    throw new Exception("הקש במספרים בלבד");
            }
        }
        public Business_owner ThisBusiness_owner()
        {
            Business_ownerDb k = new Business_ownerDb();
            return k.GetList().Find(x => x.Business_owner_id == this.business_owner_code);//לסדר באקסס
        }
        public Cards ThisCards()
        {
            CardsDb k = new CardsDb();
            return k.GetList().Find(x => x.Card_code == this.card_code);
        }

    }
}
