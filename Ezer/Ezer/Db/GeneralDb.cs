using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ezer.Db;
using System.Data;
using System.Data.OleDb;
using Ezer.Data;
using Ezer.Models;
using Ezer.Gui;

namespace Ezer.Db
{
    public abstract class GeneralDb
    {
        protected DataTable table;
        public GeneralDb(string tablename)
        {
            Dal.GetInstance().AddTable(tablename);
            table = Dal.GetInstance().GetTable(tablename);
        }
        public int Size()
        {
            return table.Rows.Count;
        }
        public bool IsEmpty()
        {
            return table.Rows.Count == 0;
        }
        public virtual void Save()
        {
            Dal.GetInstance().Update(table.TableName);
        }
        public void Add(DataRow dr)
        {
            table.Rows.Add(dr);
            this.Save();
        }
        public DataTable GetTable()
        {
            return this.table;
        }
        public void Update()
        {
            Dal.GetInstance().Update(table.TableName);
        }
    }
}
