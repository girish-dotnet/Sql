using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppGridCellClick
{
    /// <summary>
    /// Interaction logic for EmpSearch.xaml
    /// </summary>
    public partial class EmpSearch : Window
    {

        static int empno;
        public EmpSearch()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        public void SearchEmp(int empno)
        {
            if(empno!=0)
            {
                string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
                conn = new SqlConnection(strcon);
                conn.Open();
                cmd = new SqlCommand("prcEmpSearch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empno", empno);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                txtName.Text = dr["nam"].ToString();
                txtDept.Text = dr["dept"].ToString();
                txtDesig.Text = dr["desig"].ToString();
                txtBasic.Text = dr["Basic"].ToString();
            }
          
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SearchEmp(Convert.ToInt32(txtEmpno.Text));
        }
    }
}
