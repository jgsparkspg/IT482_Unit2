using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    static class Business
    {
        static DataAccess database = new DataAccess("Server=JOSH-PC\\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True");
        static DataTable nametable = database.GetNames();


        public static DataTable GetNames()
        {
            return nametable;
        }

        public static int GetTotal()
        {
            return nametable.Rows.Count;
        }
    }
}
