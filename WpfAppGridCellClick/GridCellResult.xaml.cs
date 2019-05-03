using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppGridCellClick
{
    /// <summary>
    /// Interaction logic for GridCellResult.xaml
    /// </summary>
    public partial class GridCellResult : Window
    {
        public GridCellResult()
        {
            InitializeComponent();
        }
        sqlpracticeEntities entities = new sqlpracticeEntities();

        public void SearchEmp(int empno)
        {

            prcEmpSearch_Result result = entities.prcEmpSearch(empno).FirstOrDefault();
            if(result!=null)
            {
                txtName.Text = result.nam.ToString();
                txtDept.Text = result.dept.ToString();
                txtDesig.Text = result.desig.ToString();
                txtBasic.Text = result.basic.ToString();
            }
               
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SearchEmp(Convert.ToInt32(txtEmpno.Text));
        }
    }
}

