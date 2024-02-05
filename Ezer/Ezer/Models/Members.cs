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
   public class Members
    {
        public string id_member;
        public int member_owner_code;
        public string f_name;
        public string l_name;
        public string tel;
        public string pel;
        public string gmail;
        public double total;
        public bool status;
        public DataRow Dr { get; set; }
        public Members()
        {

        }
        public Members(DataRow dr)
        {
            this.Dr = dr;
            this.id_member = dr["id_member"].ToString();
            this.member_owner_code = Convert.ToInt32(dr["member_owner_code"].ToString());
            this.f_name = dr["f_name"].ToString();
            this.l_name = dr["l_name"].ToString();
            this.tel = dr["tel"].ToString();
            this.pel = dr["pel"].ToString();
            this.gmail = dr["gmail"].ToString();
            this.total = Convert.ToDouble(dr["total"].ToString());
            if (dr["status"].Equals(true))
                this.status = true;
            else
                this.status = false;
        }
        public void PutInto()
        {
            Dr["id_member"] = this.id_member;
            Dr["member_owner_code"] = this.member_owner_code;
            Dr["f_name"] = this.f_name;
            Dr["l_name"] = this.l_name;
            Dr["tel"] = this.tel;
            Dr["pel"] = this.pel;
            Dr["pel"] = this.pel;
            Dr["gmail"] = this.gmail;
            Dr["total"] = this.total;
            Dr["status"] = this.status;

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
                    throw new Exception("תעודת זהות אינה תקינה, הקש שנית");

            }
        }
        public int Member_owner_code
        {
            get
            {
                return this.member_owner_code;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.member_owner_code = value;
                else
                    throw new Exception("קוד שגוי, הקישי שנית");
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
                    throw new Exception("מהקש שם בעברית בלבד");
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
        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.total = value;
                else
                    throw new Exception("שגוי, הקש שנית");
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
        public override string ToString()
        {
            return this.f_name+" "+this.l_name+"\n"+this.id_member;
        }
    }
}
