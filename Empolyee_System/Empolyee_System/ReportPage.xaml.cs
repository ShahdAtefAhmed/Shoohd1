using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Empolyee_System
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        person p = new person();

        public ReportPage(string data)
        {
            InitializeComponent();
            var d = data.Split(' ');
            string personName = d.Last();
            p.name= personName;
            this.DataContext = p;

            ShowByEntities();
        }
        public void ShowTheReport()
        {

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=WPF_project;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ExpenseReport WHERE Names = @name", conn);
            cmd.Parameters.AddWithValue("@name", p.name);
            

            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Name not found in the table.");
            }
            else
            {
                while (reader.Read())
                {
                    DepData.Content = reader["Department"];
                }
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            hasan.ItemsSource = dt.DefaultView;
            conn.Close();
        }
        public void ShowByEntities()
        {
            WPF_projectEntities1 wPF_Project=new WPF_projectEntities1(); 
            hasan.ItemsSource=wPF_Project.ExpenseReports.Where( y=> y.Names == p.name).ToList();
           var reslut= wPF_Project.ExpenseReports.Where(x => x.Names == p.name).Select(x => x.Department);
            DepData.Content = reslut.FirstOrDefault();
        }
        public class person
        {
            public string name { get; set; }
        }
        private void hasan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ModifyPage modifyPage = new ModifyPage();
            this.NavigationService.Navigate(modifyPage);
        }
    }
}
