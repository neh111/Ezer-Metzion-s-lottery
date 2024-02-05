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
   public class Booked_cards
    {
        private int order_code;
        private int package_code;
        private int product_code;
        private int cards_amount;
        public DataRow DR { get; set; }
        public Booked_cards()
        {

        }
        public Booked_cards(DataRow dr)
        {
            this.DR = dr;
            this.order_code = Convert.ToInt32(dr["order_code"].ToString());
            this.package_code = Convert.ToInt32(dr["package_code"].ToString());
            this.product_code = Convert.ToInt32(dr["product_code"].ToString());
            this.cards_amount = Convert.ToInt32(dr["cards_amount"].ToString());

        }
        public void PutInto()
        {
            DR["order_code"] = this.order_code;
            DR["package_code"] = this.package_code;
            DR["product_code"] = this.product_code;
            DR["cards_amount"] = this.cards_amount;

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
                    throw new Exception("קוד הזמנה שגוי, הקש שוב");

            }
        }
        public int Package_code
        {
            get
            {
                return this.package_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.package_code = value;
                else
                    throw new Exception("קוד חבילה שגוי, הקש שנית");
            }


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
                    throw new Exception("קוד מוצר שגוי, הקש שנית");
            }
        }
        public int Cards_amount
        {
            get
            {
                return this.cards_amount;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.cards_amount = value;
                else
                    throw new Exception("כמות כרטיסים שגויה, הקש שנית");

            }
        }
        public Booked_packages ThisBooked_packages()
        {
            Booked_packagesDb k = new Booked_packagesDb();
            return k.GetList().Find(x => x.Order_code == this.order_code&& x.Package_code == this.package_code);
        }
        public Products ThisProducts()
        {
            ProductsDb k= new ProductsDb();
            return k.GetList().Find(x => x.Product_code == this.product_code);
        }
       // public override string ToString()
        //{
           // return base.ToString();
        //}

    }
}
