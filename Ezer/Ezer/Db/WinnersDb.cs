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
   public class WinnersDb:GeneralDb
    {
        protected List<Winners> list = new List<Winners>();
        public WinnersDb()
            :base("Winners")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Winners(dr));
            }
        }
        public List<Winners> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Winners Find(int product_code, int serial)
        {
            return this.GetList().Find(x => x.Product_code == product_code && x.Serial==serial);
        }
        public void DeleteRow(int product_code, int serial)
        {
            Winners winners = this.Find(product_code, serial);
            if (winners != null)
            {
                winners.DR.Delete();
                this.Update();
            }
        }
        
        public void UpDateRow(Winners w)
        {
            w.PutInto();
            this.Update();
        }
        public void AddNew(Winners w)
        {
            w.DR = table.NewRow();
            w.PutInto();
            this.Add(w.DR);
        }
        //public int GetNextKey()
        //{
        //    if (this.Size() == 0)
        //        return 1;
        //    return this.GetList().Max(x => x.ID) + 1;
        //}
    }
}
