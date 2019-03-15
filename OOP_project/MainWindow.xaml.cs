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
        public Person 
            {


        public MainWindow()
        {
            InitializeComponent();
        }
       private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txtfirstName = this.txtfirstName.Text;
            string txtlastName = this.txtlastName.Text;
            string txtmiddleName = this.txtmiddleName.Text;
            
            MessageBox.Show("You Have Been Registered To Our App, Mr./Mrs. " + txtfirstName);

            TransactionWindow transwin = new TransactionWindow();
            transwin.FirstName = this.txtfirstName.Text;
            transwin.Show();
        }


    }
}
