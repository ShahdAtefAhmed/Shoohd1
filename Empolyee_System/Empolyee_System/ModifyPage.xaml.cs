using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ModifyPage.xaml
    /// </summary>
    public partial class ModifyPage : Page
    {
        WPF_projectEntities1 db = new WPF_projectEntities1();
        public ModifyPage()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("id generated automatic");
            }
            ExpenseReport ex=new ExpenseReport();
            ex.Id =int.Parse(ID.Text);
            ex.Names = Name.Text;
            ex.Amount = decimal.Parse(Amount.Text);
            ex.Department = Department.Text;
            db.ExpenseReports.Add(ex);
            db.SaveChanges();
            MessageBox.Show("data saved successfully");
            DataGridForUpdate.ItemsSource = db.ExpenseReports.ToList();
        }

        private void Update_button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport ex = new ExpenseReport();
            int idtext = int.Parse(ID.Text);
            ex = db.ExpenseReports.First(x => x.Id == idtext);
            ex.Names=Name.Text;
            ex.Amount = decimal.Parse(Amount.Text);
            ex.Department = Department.Text;
            ex.ExpenseType=ExpenseType.Text;
            db.ExpenseReports.AddOrUpdate(ex);
            db.SaveChanges();
            MessageBox.Show("data saved successfully");
            DataGridForUpdate.ItemsSource = db.ExpenseReports.ToList();
        }

        private void Delete_button_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(ID.Text);
            db.ExpenseReports.Remove(db.ExpenseReports.First(x=>x.Id==id));
            MessageBox.Show("record deleted");
            db.SaveChanges();
            DataGridForUpdate.ItemsSource = db.ExpenseReports.ToList();
        }

        private void Refresh_button_Click(object sender, RoutedEventArgs e)
        {
           DataGridForUpdate.ItemsSource= db.ExpenseReports.ToList();
        }
    }
}
