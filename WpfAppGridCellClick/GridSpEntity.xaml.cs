using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Data.Entity.Core.Objects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppGridCellClick
{
    /// <summary>
    /// Interaction logic for GridSpEntity.xaml
    /// </summary>
    public partial class GridSpEntity : Window
    {
        sqlpracticeEntities entites = new sqlpracticeEntities();
        public GridSpEntity()
        {
            InitializeComponent();
            ShowEmp();
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public void ShowEmp()
        {
            ObjectResult<prcEmpShow_Result> dr = entites.prcEmpShow();
            List<prcEmpShow_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            grdEmp.DataContext = dt;
        }

        private void GrdEmp_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int empno = 0;
            foreach (DataGridCellInfo di in grdEmp.SelectedCells)
            {
                DataRowView dvr = (DataRowView)di.Item;
                empno = Convert.ToInt32(dvr[0]);

            }
            GridCellResult obj = new GridCellResult();
            
            obj.txtEmpno.Text = empno.ToString();
            obj.Show();
        }
    }
}
