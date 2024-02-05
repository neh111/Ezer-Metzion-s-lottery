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
   public class MembersDb:GeneralDb
    {
        protected List<Members> list = new List<Members>();
        public MembersDb()
            :base("Members")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Members(dr));
            }
        }
        public List<Members> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Members Find(string code)
        {
            return this.GetList().Find(x => x.Id_member == code);
        }
        public void DeleteRow(string code)
        {
            Members members = this.Find(code);
            if (members != null)
            {
                members.Dr.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Members members = this.Find(code);
            if (members != null)
            {
                members.Status = false;
                this.UpDateRow(members);
            }
        }
        public void UpDateRow(Members m)
        {
            m.PutInto();
            this.Update();
        }
        public void AddNew(Members m)
        {
            m.Dr = table.NewRow();
            m.PutInto();
            this.Add(m.Dr);
        }
        //public int GetNextKey()
        //{
        //    if (this.Size() == 0)
        //        return 1;
        //    return this.GetList().Max(x => x.ID) + 1;
        //}
    }
}
