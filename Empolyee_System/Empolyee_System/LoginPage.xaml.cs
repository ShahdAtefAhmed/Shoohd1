using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Empolyee_System
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(username.Text) && string.IsNullOrEmpty(password.Password)))
            {
                Checklogin();
            }  
            else
            {
                MessageBox.Show("enter the username or password");
            }
        }
        public void Checklogin()
        {
            SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=WPF_project;Integrated Security=True");
            sql.Open();
            SqlCommand command = new SqlCommand("select * from login where username=@username and password = @password ",sql);
            command.Parameters.AddWithValue("@username", username.Text);
            command.Parameters.AddWithValue("@password", password.Password);
            SqlDataReader data= command.ExecuteReader();
            if (data.HasRows)
            {
                MessageBox.Show("login succeed");
                HomePage home = new HomePage(username.Text);
                this.NavigationService.Navigate(home);
            }
            else
            {
                MessageBox.Show("Error try again");
            }
            sql.Close();
        }
    }
}
