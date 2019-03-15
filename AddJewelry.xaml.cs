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
    /// Interaction logic for AddJewelry.xaml
    /// </summary>
    public partial class AddJewelry : Window
    {
        public DataStorage data;
        public Product pro;
        
        
        public AddJewelry()
        {
            InitializeComponent();
        }

      
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{

        //}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow main = new MainWindow();
            //main.data = data;
            ////Class1 qualityValue = new Class1(Convert.ToInt16(txt21kvalue.Text), Convert.ToInt16(txt18kvalue.Text), Convert.ToInt16(txt10kvalue.Text));
            //decimal[] prices = new decimal[3];
            //prices[0] = Convert.ToDecimal(txt10kvalue.Text);
            //prices[1] = Convert.ToDecimal(txt18kvalue.Text);
            //prices[2] = Convert.ToDecimal(txt21kvalue.Text);

            //foreach (decimal qwe in prices)
            //    data.price.Add(qwe);
            //foreach (decimal rty in data.price)
            //    MessageBox.Show(rty.ToString());

            //TransactionWindow addedItems = new TransactionWindow();
            //addedItems.data = data;
            //addedItems.Show();
            //this.Hide();
            
          
            if (txt10kvalue.Text == "" || txt18kvalue.Text == "" || txt21kvalue.Text == "")
            {
                MessageBox.Show("Entered Invalid Amount");
                this.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.data = data;

                decimal[] prices = new decimal[3];
                prices[0] = Convert.ToDecimal(txt10kvalue.Text);
                prices[1] = Convert.ToDecimal(txt18kvalue.Text);
                prices[2] = Convert.ToDecimal(txt21kvalue.Text);

                foreach (decimal val in prices)
                    data.price.Add(val);

                
                mainWindow.Show();
                
                this.Hide();
            }
            



        }


    } 
}
