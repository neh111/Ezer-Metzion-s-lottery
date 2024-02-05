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
   public class OrdersDb:GeneralDb
    {
        protected List<Orders> list = new List<Orders>();
        public OrdersDb()
            :base("Orders")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Orders(dr));
            }
        }
        public List<Orders> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Orders Find(int order_code)
        {
            return this.GetList().Find(x => x.Order_code == order_code);
        }
        public void DeleteRow(int order_code)
        {
            Orders orders = this.Find(order_code);
            if (orders != null)
            {
                orders.DR.Delete();
                this.Update();
            }
        }
        
        public void UpDateRow(Orders o)
        {
            o.PutInto();
            this.Update();
        }
        public void AddNew(Orders o)
        {
            o.DR = table.NewRow();
            o.PutInto();
            this.Add(o.DR);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.Order_code) + 1;
        }
    }
}
