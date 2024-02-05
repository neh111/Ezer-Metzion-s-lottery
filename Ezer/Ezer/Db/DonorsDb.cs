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
   public class DonorsDb:GeneralDb
    {
        protected List<Donors> list = new List<Donors>();
        public DonorsDb()
            :base("Donors")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Donors(dr));
            }
        }
        public List<Donors> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Donors Find(string code)
        {
            return this.GetList().Find(x => x.Id_donor == code);
        }
        public void DeleteRow(string code)
        {
            Donors donors = this.Find(code);
            if (donors != null)
            {
                donors.Dr.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Donors donors = this.Find(code);
            if (donors != null)
            {
                donors.Status = false;
                this.UpDateRow(donors);
            }
        }
        public void UpDateRow(Donors d)
        {
            d.PutInto();
            this.Update();
        }
        public void AddNew(Donors d)
        {
            d.Dr = table.NewRow();
            d.PutInto();
            this.Add(d.Dr);
        }
        //public int GetNextKey()
        //{
        //    if (this.Size() == 0)
        //        return 1;
        //    return this.GetList().Max(x => x.ID) + 1;
        //}
    }
}

