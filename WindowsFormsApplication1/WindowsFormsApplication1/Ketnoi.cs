using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace WindowsFormsApplication1
{
    class Ketnoi
    {
        public SqlConnection connect;
        public Ketnoi()
        {
            connect = new SqlConnection("Data Source =.; Initial Catalog =Tuan8;User ID=...; Pass=...");
        }
        public Ketnoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
