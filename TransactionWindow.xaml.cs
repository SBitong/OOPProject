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
   
    public partial class TransactionWindow : Window
    {
        //public Person Customer;
        //public Product Jewelry;  
        public MainWindow maine;
        string[] JewelryType = { "Bracelet", "Rings", "Necklace", "Earrings" };
        string[] Quality = { "10K", "18K", "21K" };
        public DataStorage data;
        public Product pro = new Product();
        
        public TransactionWindow()
        {
            InitializeComponent();
            foreach (string qualities in Quality)
                cmbQuality.Items.Add(qualities);

            //foreach (string type in JewelryType)
            //    cmbJewelry.Items.Add(type);
            
           
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            foreach (Person customer in data.customers)
                cmbCustom.Items.Add(customer.GetFullName());
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //lstTransactions.Items.Add(Customer.GetFullName() + " " + Jewelry.Name);
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.data = data;
            addCustomer.Show();
            this.Hide();
            
        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.data = data;
            mainWindow.Show();
            this.Hide();
        }

        private void CmbJewelry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddJewelry addJewelry = new AddJewelry();
            addJewelry.data = data;
            addJewelry.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow returnmain = new MainWindow();
            returnmain.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            decimal discountedValue = Convert.ToDecimal(txtDiscount.Text);
            decimal weightValue = Convert.ToDecimal(txtWeight.Text);
            decimal finalValue;
            decimal trueValue;


            trueValue = weightValue - discountedValue;
            txtWeight.Text = trueValue.ToString();

            finalValue = trueValue * pro.Price;
            txtCalculatedPrice.Text = finalValue.ToString();

        }

        //private void Button_Click_4(object sender, RoutedEventArgs e)
        //{

        //   


        //}

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbQuality.SelectedItem.ToString())
            {
                case "21K":

                    pro.Price = data.price[2];
                    break;

                case "18K":
                    pro.Price = data.price[1];
                    break;

                case "10K":
                    pro.Price = data.price[0];
                    break;
            }
        }

        //private void CmbQuality_DropDownClosed(object sender, EventArgs e)
        //{
        //    switch (cmbQuality.SelectedItem.ToString())
        //    {
        //        case "21K":

        //            pro.Price = data.price[2];
        //            break;

        //        case "18K":
        //            pro.Price = data.price[1];
        //            break;

        //        case "10K":
        //            pro.Price = data.price[0];
        //            break;
        //    }
        //}

        //private void TxtWeight_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    decimal weight;
        //    decimal totalPrice;

        //    switch (cmbQuality.SelectedItem.ToString())
        //    {
        //        case "21K":

        //            decimal value21K = data.price[2];
        //            if (txtWeight.Text == "")
        //                weight = 0;
        //            else
        //                weight = Convert.ToDecimal(txtWeight.Text);

        //            totalPrice = value21K * weight;
        //            txtCalculatedPrice.Text = totalPrice.ToString();
        //            break;

        //        case "18K":
        //            decimal value18K = data.price[1];
        //            if (txtWeight.Text == "")
        //                weight = 0;
        //            else
        //                weight = Convert.ToDecimal(txtWeight.Text);

        //            totalPrice = value18K * weight;
        //            txtCalculatedPrice.Text = totalPrice.ToString();
        //            break;

        //        case "10K":
        //            decimal value10K = data.price[0];
        //            if (txtWeight.Text == "")
        //                weight = 0;
        //            else
        //                weight = Convert.ToDecimal(txtWeight.Text);

        //            totalPrice = value10K * weight;
        //            txtCalculatedPrice.Text = totalPrice.ToString();
        //            break;
        //    }

    }
    
}
