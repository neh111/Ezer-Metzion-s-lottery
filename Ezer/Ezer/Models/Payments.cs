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
   public class Payments
    {
        private int payment_code;
        private int order_code;
        private double payment_amount;
        private DateTime payment_date;
        private string mastercard_name;
        private DateTime expiration;
        private string cvv;
        private string mastercard_mis;
        private int num_of_payments;
        public DataRow DR { get; set; }
        public Payments()
        {

        }
        public Payments(DataRow dr)
        {
            this.DR = dr;
            this.payment_code =Convert.ToInt32(dr["payment_code"].ToString());
            this.order_code = Convert.ToInt32(dr["order_code"].ToString());
            this.payment_amount = Convert.ToDouble(dr["payment_amount"].ToString());
            this.payment_date = Convert.ToDateTime(dr["payment_date"].ToString());
            this.mastercard_name = dr["mastercard_name"].ToString();
            this.expiration = Convert.ToDateTime(dr["expiration"].ToString());
            this.cvv = dr["cvv"].ToString();
            this.mastercard_mis = dr["mastercard_mis"].ToString();
            this.num_of_payments = Convert.ToInt32(dr["num_of_payments"].ToString());
            
        }
        public void PutInto()
        {
            DR["payment_code"] = this.payment_code;
            DR["order_code"] = this.order_code;
            DR["payment_amount"] = this.payment_amount;
            DR["payment_date"] = this.payment_date;
            DR["mastercard_name"] = this.mastercard_name;
            DR["expiration"] = this.expiration;
            DR["cvv"] = this.cvv;
            DR["mastercard_mis"] = this.mastercard_mis;
            DR["num_of_payments"] = this.num_of_payments;
         
        }

        public int Payment_code
        {
            get
            {
                return this.payment_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.payment_code = value;
                else
                    throw new Exception("קוד תשלום אינו תקין, הקש שוב");

            }
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
                    throw new Exception("קוד הזמנה אינו תקין, הקש שוב");
            }


        }
        public double Payment_amount
        {
            get
            {
                return this.payment_amount;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.payment_amount = value;
                else
                    throw new Exception("הקש תשלום במספרים בלבד");
            }
        }
        public DateTime Payment_date
        {
            get
            {
                return this.payment_date;
            }
            set
            {
                    this.payment_date = value;
            }

        }
        public DateTime Expiration
        {
            get
            {
                return this.expiration;
            }
            set
            {
                if (value>DateTime.Today)
                    this.expiration = value;
                else
                    throw new Exception("תוקף שגוי, הקש שנית");
            }
        }
        public string Cvv
        {
            get
            {
                return this.cvv;
            }
            set
            {
                if (ValidateUtil.IsNum(value))
                    this.cvv = value;
                else
                    throw new Exception("הקש במספרים בלבד");
            }
        }
        public string Mastercard_mis
        {
            get
            {
                return this.mastercard_mis;
            }
            set
            {
                if (ValidateUtil.IsNum(value))
                    this.mastercard_mis = value;
                else
                    throw new Exception("מספר כרטיס שגוי, הקש שנית");
            }
        }
   
        public int Num_of_payment
        {
            get
            {
                return this.num_of_payments;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString())&&value<=3)
                    this.num_of_payments = value;
                else
                    throw new Exception("הקש במספרים בלבד"+"\n"+
                        "יש אפשרות עד שלושה תשלומים");
            }
        }
        public Orders ThisOrders()
        {
            OrdersDb k = new OrdersDb();
            return k.GetList().Find(x => x.Order_code == this.order_code);
        }
        public override string ToString()
        {
            return this.payment_code.ToString();
        }
    }
}
