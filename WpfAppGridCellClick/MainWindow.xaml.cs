using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppGridCellClick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int sempno = 0;
        public MainWindow()
        {
            InitializeComponent();
            ShowEmploy();
        }
        SqlConnection conn;
        SqlCommand cmd;
        
        public void ShowEmploy()
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            conn = new SqlConnection(strcon);
            conn.Open();
            cmd = new SqlCommand("prcEmpShow", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdEmp.DataContext = dt;
        }

        private void GrdEmp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hi");
            if (sender != null)
            {
                Grid _grid = sender as Grid;
                int _row = (int)_grid.GetValue(Grid.RowProperty);
                int _column = (int)_grid.GetValue(Grid.ColumnProperty);
                MessageBox.Show(string.Format("Grid clicked at column {0}, row {1}", _column, _row));
                App.Current.Properties["empno"] = 5;
            }
        }

        private void GrdEmp_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int empno = 0;
            foreach (DataGridCellInfo di in grdEmp.SelectedCells)
            {
                DataRowView dvr = (DataRowView)di.Item;
                empno = Convert.ToInt32(dvr[0]);
               
            }
           // MessageBox.Show("Selected Empno is  " + empno.ToString());
            EmpSearch obj = new EmpSearch();
            sempno = empno;
            obj.txtEmpno.Text = empno.ToString();
            obj.Show();
           }
        }
    
}
