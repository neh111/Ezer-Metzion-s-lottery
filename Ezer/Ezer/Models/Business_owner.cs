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
   public class Business_owner
    {
        private string business_owner_id;
        private string business_name;
        private string address;
        private string city;
        private string zip_code;
        private string pel;
        private string business_tel;
        private string gmail;
        private string f_name;
        private string l_name;
        private string item_description;
        private bool status;
        public DataRow DR { get; set; }
        public Business_owner()
        {

        }
        public Business_owner(DataRow dr)
        {
            this.DR = dr;
            this.business_owner_id = dr["business_owner_id"].ToString();
            this.business_name = dr["business_name"].ToString();
            this.f_name = dr["f_name"].ToString();
            this.l_name = dr["l_name"].ToString();
            this.address = dr["address"].ToString();
            this.city = dr["city"].ToString();
            this.business_tel = dr["business_tel"].ToString();
            this.pel = dr["pel"].ToString();
            this.gmail = dr["gmail"].ToString();
            this.zip_code = dr["zip_code"].ToString();
            this.item_description = dr["item_description"].ToString();
            if (dr["status"].Equals(true))
                this.status = true;
            else
                this.status = false;
        }
        public void PutInto()
        {
            DR["business_owner_id"] = this.business_owner_id;
            DR["business_name"] = this.business_name;
            DR["f_name"] = this.f_name;
            DR["l_name"] = this.l_name;
            DR["address"] = this.address;
            DR["business_tel"] = this.business_tel;
            DR["city"] = this.city;
            DR["pel"] = this.pel;
            DR["gmail"] = this.gmail;
            DR["zip_code"] = this.zip_code;
            DR["item_description"] = this.item_description;
            DR["status"] = this.status;

        }

        public string Business_owner_id
        {
            get
            {
                return this.business_owner_id;
            }
            set
            {
                if (ValidateUtil.LegalId(value))
                    this.business_owner_id = value;
                else
                    throw new Exception("תעודת זהות אינה תקינה, הקש שנית");

            }
        }
        public string Business_name
        {
            get
            {
                return this.business_name;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.business_name = value;
                else
                    throw new Exception("הקש שם בעברית בלבד");
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
        public string Business_tel
        {
            get
            {
                return this.business_tel;
            }
            set
            {
                if (ValidateUtil.IsTelPhone(value))
                    this.business_tel = value;
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
        public string Gmail
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
        public string Item_description
        {
            get
            {
                return this.item_description;
            }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.item_description = value;
                else
                    throw new Exception("הקש תאור פריט התרומה בעברית בלבד");
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
        public Business_owner ThisBusiness_owner()
        {
            Business_ownerDb k = new Business_ownerDb();
            return k.GetList().Find(x => x.Business_owner_id == this.business_owner_id);
        }
        public override string ToString()
        {
            return this.l_name + " " + this.f_name;
        }
    }
}
