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
   public class Donors
    {
        private string id_donor;
        private string f_name;
        private string l_name;
        private string address;
        private string city;
        private string tel;
        private string pel;
        private string gmail;
        private string zip_code;
        private bool status;
        public DataRow Dr { get; set; }
        public Donors()
        {

        }
        public Donors(DataRow dr)
        {
            this.Dr = dr;
            this.id_donor = dr["id_donor"].ToString();
            this.f_name = dr["f_name"].ToString();
            this.l_name = dr["l_name"].ToString();
            this.address = dr["address"].ToString();
            this.city = dr["city"].ToString();
            this.tel = dr["tel"].ToString();
            this.pel = dr["pel"].ToString();
            this.gmail = dr["gmail"].ToString();
            this.zip_code = dr["zip_code"].ToString();
            if (dr["status"].Equals(true))
                this.status = true;
            else
                this.status = false;
        }
        public void PutInto()
        {
            Dr["id_donor"] = this.id_donor;
            Dr["f_name"] = this.f_name;
            Dr["l_name"] = this.l_name;
            Dr["address"] = this.address;
            Dr["tel"] = this.tel;
            Dr["city"] = this.city;
            Dr["pel"] = this.pel;
            Dr["gmail"] = this.gmail;
            Dr["zip_code"] = this.zip_code;
            Dr["status"] = this.status;

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
                    throw new Exception("תעודת זהות אינה תקינה, הקש שנית");

            }
        }
        public string F_name
        {
            get
            {
                return this.f_name;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.f_name = value;
                else
                    throw new Exception("הקש שם בעברית בלבד");
            }


        }
        public string L_name
        {
            get
            {
                return this.l_name;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.l_name = value;
                else
                    throw new Exception("הקש שם בעברית בלבד");
            }
        }
        public string Pel
        {
            get
            {
                return this.pel;
            }
            set
            {
                if (ValidateUtil.IsCellPhone(value))
                    this.pel = value;
                else
                    throw new Exception("מספר פלאפון שגוי, הקש שנית");
            }

        }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (ValidateUtil.IsTelPhone(value))
                    this.tel = value;
                else
                    throw new Exception("מספר טלפון שגוי, הקש שנית");
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (ValidateUtil.IsAlfa(value))
                    this.address = value;
                else
                    throw new Exception("כתובת שגויה, הקש שנית");
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.city = value;
                else
                    throw new Exception("הקש שם עיר בעברית בלבד");
            }
        }
        public string Gmail//להכין בדיקת תקינות
        {
            get
            {
                return this.gmail;
            }
            set
            {
                if (ValidateUtil.IsEmail(value))
                    this.gmail = value;
                else
                    throw new Exception("כתובת מייל שגויה, הקש שנית");                 
            }



        }
        public bool Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        public string Zip_code
        {
            get
            {
                return this.zip_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value))//האם בדיקה זו מתאימה למחרוזת string
                    this.zip_code = value;
                else
                    throw new Exception("מיקוד שגוי, הקש שוב");
            }
        }
        public override string ToString()
        {
            return this.l_name + " " + this.f_name;
        }
    }
}
