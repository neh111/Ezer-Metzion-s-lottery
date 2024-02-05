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
   public class ProductsDb:GeneralDb
    {
        protected List<Products> list = new List<Products>();
        public ProductsDb()
            :base("Products")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Products(dr));
            }
        }
        public List<Products> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Products Find(int product_code)
        {
            return this.GetList().Find(x => x.Product_code == product_code);
        }
        public void DeleteRow(int product_code)
        {
            Products products = this.Find(product_code);
            if (products != null)
            {
                products.DR.Delete();
                this.Update();
            }
        }
        
        public void UpDateRow(Products p)
        {
            p.PutInto();
            this.Update();
        }
        public void AddNew(Products p)
        {
            p.DR = table.NewRow();
            p.PutInto();
            this.Add(p.DR);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.Product_code) + 1;
        }
    }
}
