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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataStorage data = new DataStorage();
        public List<string> names = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            TransactionWindow t1 = new TransactionWindow();
            t1.data = data;
            t1.Show();
            this.Hide();
        }   
            
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PaymentWindow p1 = new PaymentWindow();
            p1.Show();
            this.Hide();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddJewelry addJewelry = new AddJewelry();
            addJewelry.data = data;
            addJewelry.Show();
            this.Hide();
        }
    }
    public class DataStorage
    {
        public List<Person> customers = new List<Person>();
        public List<Product> jewelries = new List<Product>();
        public List<decimal> price = new List<decimal>();
    }
    
} 
