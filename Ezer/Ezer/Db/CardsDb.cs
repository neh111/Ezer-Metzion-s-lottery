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

namespace Ezer.Db
{
   public class CardsDb:GeneralDb
    {
        protected List<Cards> list = new List<Cards>();
        public CardsDb()
            :base("Cards")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Cards(dr));
            }
        }
        public List<Cards> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Cards Find(int code)
        {
            return this.GetList().Find(x => x.Card_code == code);
        }
        public void DeleteRow(int code)
        {
            Cards cards = this.Find(code);
            if (cards != null)
            {
                cards.DR.Delete();
                this.Update();
            }
        }
       
        public void UpDateRow(Cards c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(Cards c)
        {
            c.DR = table.NewRow();
            c.PutInto();
            this.Add(c.DR);
        }
        public int GetNextKey()
        {
           if (this.Size() == 0)
               return 1;
            return this.GetList().Max(x => x.Card_code) + 1;
        }
    }
}

