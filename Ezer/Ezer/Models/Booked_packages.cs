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
   public class Booked_packages
    {
        private int order_code;
        private int package_code;
        private int packages_amount;
        public DataRow DR { get; set; }
        public Booked_packages()
        {

        }
        public Booked_packages(DataRow dr)
        {
            this.DR = dr;
            this.order_code = Convert.ToInt32(dr["order_code"].ToString());
            this.package_code = Convert.ToInt32(dr["package_code"].ToString());
            this.packages_amount = Convert.ToInt32(dr["packages_amount"].ToString());
       
        }
        public void PutInto()
        {
            DR["order_code"] = this.order_code;
            DR["package_code"] = this.package_code;
            DR["packages_amount"] = this.packages_amount;
        
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
        public int Packages_amount
        {
            get
            {
                return this.packages_amount;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.packages_amount = value;
                else
                    throw new Exception("שגוי, הקש שנית");
            }
        }
       
        public Packages ThisPackages()
        {
            PackagesDb k = new PackagesDb();
            return k.GetList().Find(x => x.Package_code == this.package_code);
        }
        public Orders ThisOrders()
        {
            OrdersDb k = new OrdersDb();
            return k.GetList().Find(x => x.Order_code == this.order_code);
        }
        public override string ToString()
        {
            return this.order_code.ToString() ;
        }
    }
}
