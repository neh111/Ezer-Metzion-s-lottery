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
   public class Booked_cardsDb:GeneralDb
    {
        protected List<Booked_cards> list = new List<Booked_cards>();
        public Booked_cardsDb()
            : base("Booked_cards")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Booked_cards(dr));
            }
        }
        public List<Booked_cards> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Booked_cards Find(int order_code, int package_code,int product_code)
        {
            return this.GetList().Find(x => x.Order_code == order_code && x.Package_code == 
            package_code && x.Product_code== product_code);
        }
        public void DeleteRow(int order_code, int package_code, int product_code)
        {
            Booked_cards booked_cards = this.Find(order_code, package_code, product_code);
            if (booked_cards != null)
            {
                booked_cards.DR.Delete();
                this.Update();
            }
        }
        
        public void UpDateRow(Booked_cards b)
        {
            b.PutInto();
            this.Update();
        }
        public void AddNew(Booked_cards b)
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
