using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Create(object sender, EventArgs e)
        {
            string conStr = "Data Source=.; Initial Catalog = Tuan8; Intergrated Security = True";
            SqlConnection conn = new SqlConnection(conStr);
        }
    }
}

