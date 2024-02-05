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
     public class Business_ownerDb:GeneralDb
    {
        protected List<Business_owner> list = new List<Business_owner>();
        public Business_ownerDb()
            :base("Business_owner")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Business_owner(dr));
            }
        }
        public List<Business_owner> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Business_owner Find(string code)
        {
            return this.GetList().Find(x => x.Business_owner_id == code);
        }
        public void DeleteRow(string code)
        {
            Business_owner business_owner = this.Find(code);
            if (business_owner != null)
            {
                business_owner.DR.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Business_owner business_owner = this.Find(code);
            if (business_owner != null)
            {
                business_owner.Status = false;
                this.UpDateRow(business_owner);
            }
        }
        public void UpDateRow(Business_owner b)
        {
            b.PutInto();
            this.Update();
        }
        public void AddNew(Business_owner b)
        {
            b.DR = table.NewRow();
            b.PutInto();
            this.Add(b.DR);
        }
        //public int GetNextKey()
        //{
        //    if (this.Size() == 0)
        //        return 1;
        //    return this.GetList().Max(x => x.ID) + 1;
        //}
    }
}
