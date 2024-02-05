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
   public class PaymentsDb:GeneralDb
    {
        protected List<Payments> list = new List<Payments>();
        public PaymentsDb()
            :base("Payments")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Payments(dr));
            }
        }
        public List<Payments> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Payments Find(int payment_code)
        {
            return this.GetList().Find(x => x.Payment_code == payment_code);
        }
        public void DeleteRow(int payment_code)
        {
            Payments payments = this.Find(payment_code);
            if (payments != null)
            {
                payments.DR.Delete();
                this.Update();
            }
        }
     
        public void UpDateRow(Payments p)
        {
            p.PutInto();
            this.Update();
        }
        public void AddNew(Payments p)
        {
            p.DR = table.NewRow();
            p.PutInto();
            this.Add(p.DR);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.Payment_code) + 1;
        }
    }
}
