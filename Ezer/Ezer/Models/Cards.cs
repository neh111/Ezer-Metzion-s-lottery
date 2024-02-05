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
   public class Cards
    {
        private int card_code;
        private string card_name;
        public DataRow DR { get; set; }
        public Cards()
        {

        }
        public Cards(DataRow dr)
        {
            this.DR = dr;
            this.card_code = Convert.ToInt32(dr["card_code"].ToString());
            this.card_name = dr["card_name"].ToString();
        }     
        public void PutInto()
        {
            DR["card_code"] = this.card_code;
            DR["card_name"] = this.card_name;
        }

        public int Card_code
        {
            get
            {
                return this.card_code;
            }
            set
            {
                //if (ValidateUtil.IsNum(value.ToString()))
                    this.card_code = value;
                //else
                   // throw new Exception("הקש שנית קוד כרטיס");

            }
        }
        public string Card_name
        {
            get
            {
                return this.card_name;
            }
            set
            {
               // if (ValidateUtil.IsHebrew(value))
                    this.card_name = value;
                //else
                   // throw new Exception("הקש שם בעברית בלבד");
            }


        }
        
        public Cards ThisCards()
        {
            CardsDb k = new CardsDb();
            return k.GetList().Find(x => x.Card_code == this.card_code);
        }
        public override string ToString()
        {
            return this.card_name;
        }

    }
}
