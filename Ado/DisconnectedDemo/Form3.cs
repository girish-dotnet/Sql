using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter adapter;
        SqlCommandBuilder cmd;
        DataSet dsEmp;
      
        private void Form3_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.
                ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            string strSelect = "SELECT * FROM EMP";
            adapter = new SqlDataAdapter(strSelect, cnSqlpractice);
            cmd = new SqlCommandBuilder(adapter);
            dsEmp = new DataSet();
            adapter.Fill(dsEmp, "EmpDummy");
            DataTable dt = dsEmp.Tables["EmpDummy"];
            DataView dv = new DataView(dt, "Dept='Dotnet'", "Nam ASC",
                    DataViewRowState.OriginalRows);
            dgEmp.DataSource = dv;
        }

        private void btnFinalChanges_Click(object sender, EventArgs e)
        {
            adapter.Update(dsEmp, "EmpDummy");
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            dsEmp.WriteXml("c:\\csh\\Emp.xml");
        }
    }
}
