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
   public class Booked_packagesDb:GeneralDb
    {
        protected List<Booked_packages> list = new List<Booked_packages>();
        public Booked_packagesDb()
            :base("Booked_packages")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Booked_packages(dr));
            }
        }
        public List<Booked_packages> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Booked_packages Find(int order_code,int package_code)
        {
            return this.GetList().Find(x => x.Order_code == order_code && x.Package_code== package_code);
        }
        public void DeleteRow(int order_code, int package_code)
        {
            Booked_packages booked_packages = this.Find(order_code, package_code);
            if (booked_packages != null)
            {
                booked_packages.DR.Delete();
                this.Update();
            }
        }

        public void UpDateRow(Booked_packages b)
        {
            b.PutInto();
            this.Update();
        }
        public void AddNew(Booked_packages b)
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
