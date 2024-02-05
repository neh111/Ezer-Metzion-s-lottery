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
   public class PackagesDb:GeneralDb
    {
        protected List<Packages> list = new List<Packages>();
        public PackagesDb()
            : base("Packages")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Packages(dr));
            }
        }
        public List<Packages> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Packages Find(int package_code)
        {
            return this.GetList().Find(x => x.Package_code == package_code);
        }
        public void DeleteRow(int package_code)
        {
            Packages packages = this.Find(package_code);
            if (packages != null)
            {
                packages.DR.Delete();
                this.Update();
            }
        }
        
        public void UpDateRow(Packages p)
        {
           p.PutInto();
            this.Update();
        }
        public void AddNew(Packages p)
        {
            p.DR = table.NewRow();
            p.PutInto();
            this.Add(p.DR);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.Package_code) + 1;
        }
    }
}
