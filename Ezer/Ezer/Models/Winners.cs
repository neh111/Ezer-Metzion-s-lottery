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
   public class Winners
    {
        public int product_code;
        public int serial;
        public string id_donor;
        public DataRow DR { get; set; }
        public Winners()
        {

        }
        public Winners(DataRow dr)
        {
            this.DR = dr;
            this.product_code = Convert.ToInt32(dr["product_code"].ToString());
            this.serial = Convert.ToInt32(dr["serial"].ToString());
            this.id_donor =dr["id_donor"].ToString();
        }
        public void PutInto()
        {
            DR["product_code"] = this.product_code;
            DR["serial"] = this.serial;
            DR["id_donor"] = this.id_donor;

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
                    throw new Exception("הקש שנית קוד חבילה");

            }
        }
        public int Serial
        {
            get
            {
                return this.serial;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.serial = value;
                else
                    throw new Exception("שגוי, הקש שנית");
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
                    throw new Exception("תעודת זהות שניה, הקש שנית");
            }
        }
        public override string ToString()
        {
            return this.id_donor;
        }
        public Products ThisProducts()
        {
            ProductsDb k = new ProductsDb();
            return k.GetList().Find(x => x.Product_code == this.product_code);
        }
    }
}
