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
   public class Packages
    {
        private int package_code;
        private string package_name;
        private double package_price;
        private int cards_num;
        public DataRow DR { get; set; }
        public Packages()
        {

        }
        public Packages(DataRow dr)
        {
            this.DR = dr;
            this.package_code = Convert.ToInt32(dr["package_code"].ToString());
            this.package_name = dr["package_name"].ToString();
            this.package_price = Convert.ToDouble(dr["package_price"].ToString());
            this.cards_num = Convert.ToInt32(dr["cards_num"].ToString());
           
        }
        public void PutInto()
        {
            DR["package_code"] = this.package_code;
            DR["package_name"] = this.package_name;
            DR["package_price"] = this.package_price;
            DR["cards_num"] = this.cards_num;
           
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
                    throw new Exception("קוד חבילה שגוי, הקש שוב");

            }
        }
        public string Package_name
        {
            get
            {
                return this.package_name;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.package_name = value;
                else
                    throw new Exception("הקש שם בעברית בלבד");
            }


        }
        public double Package_price
        {
            get
            {
                return this.package_price;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.package_price = value;
                else
                    throw new Exception("מחיר חבילה שגוי, הקש שנית");
            }
        }
        public int Cards_num
        {
            get
            {
                return this.cards_num;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.cards_num = value;
                else
                    throw new Exception("מספר כרטיסים לחבילה שגוי, הקש שנית");
            }

        }
      
    }
}
