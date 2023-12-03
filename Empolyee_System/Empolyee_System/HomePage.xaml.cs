using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public class Username
        {
            public string Name { get; set; }
        }
        public HomePage(string name)
        {
            InitializeComponent();
            Username username = new Username(); 
            username.Name = name;
            WelcomeLabel.DataContext = username;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ListBoxx.SelectedItem != null)
                {
                    ReportPage s = new ReportPage(ListBoxx.SelectedItem.ToString());
                    this.NavigationService.Navigate(s);
                }
                else
                {
                    throw new Exception("please Select Name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
