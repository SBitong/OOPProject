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

namespace OOP_project
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        //AddCustomer bioData = new AddCustomer();
        //public MainWindow main;
        public DataStorage data = new DataStorage();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person customer = new Person(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text);
            bool exist = false;
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == "" || txtBirthDate.Text == "" || txtAddress.Text == "" || txtContactNumber.Text == "")
            {
                MessageBox.Show("Invalid Data");
                AddCustomer ac = new AddCustomer();
                ac.Close();
                this.Show();
            }
            else
            {
                foreach (Person cus in data.customers)
                {
                    if (customer.GetFullName() == cus.GetFullName())
                    {
                        exist = true;
                        break;
                    }

                }
                if (!exist)
                    data.customers.Add(customer);
                else
                    MessageBox.Show("Name already exists!");

                TransactionWindow transactionWindow = new TransactionWindow();
                transactionWindow.data = data;
                transactionWindow.Show();
                this.Hide();
            }
          

            
        }
    }
}
