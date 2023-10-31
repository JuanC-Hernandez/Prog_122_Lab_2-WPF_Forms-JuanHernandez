/////////////////////////////////////////////////
///Juan Hernandez
///10/30/2023
///Lab - Text Boxes, Labels, and Buttons
////////////////////////////////////////////////

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

namespace Prog_122_Lab_2_WPF_Forms_JuanHernandez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaring Variables
        //will use to tryparse text boxes in Preload()
        int userNum1 = 0;
        bool isNum1 = false; 
        int userNum2 = 0;
        bool isNum2 = false;
        int userNum3 = 0;
        bool isNum3 = false;
        int userNum4 = 0;
        bool isNum4 = false;
        double addSum = 0;
        bool addSum2 = false;
        double multDiv = 0;
        bool multDiv2 = false;   
        //End of Declaring Variables

        public MainWindow()
        {
            InitializeComponent();
        }//MainWindow
        public void Preload()
        {
            // checks if user input is int true or false, passes to buttons to catch if false
            isNum1 = int.TryParse(txtASNumber1.Text, out userNum1);
            isNum2 = int.TryParse(txtASNumber2.Text, out userNum2);
            isNum3 = int.TryParse(txtMDNumber1.Text, out userNum3);
            isNum4 = int.TryParse(txtMDNumber2.Text, out userNum4);

            addSum2 = double.TryParse(txtASTotal.Text, out addSum);
            multDiv2 = double.TryParse(txtMDTotal.Text, out multDiv);

        }//Preload

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            //preloads try parse
            Preload();
            if (!isNum1)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            if (!isNum2)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            //addition formula
            txtASTotal.Text = "";
            txtASTotal.Text += userNum1 + userNum2;
            lblAddSum.Content = "    +";
        }//Add button

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            //preloads try parse
            Preload();
            if (!isNum1)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            if (!isNum2)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            //subtraction formula
            txtASTotal.Text = "";
            txtASTotal.Text += userNum1 - userNum2;
            lblAddSum.Content = "    -";

        }//Subtract button
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //preloads try parse
            Preload();
            if (!isNum3)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            if (!isNum3)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            //multiplication formula
            txtMDTotal.Text = "";
            txtMDTotal.Text += userNum3 * userNum4;
            lblMultiDiv.Content = "    x";

        }//Multiply button

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //preloads try parse
            Preload();
            if (!isNum3)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            if (!isNum3)
            {
                MessageBox.Show("Please Enter Valid Number!");
            }
            //Division formula
            txtMDTotal.Text = "";
            txtMDTotal.Text += userNum3 / userNum4;
            lblMultiDiv.Content = "    /";
        }//Divide button

        private void btnAvg_Click(object sender, RoutedEventArgs e)
        {
            //preloads try parse
            Preload();

            //average formula
            txtAvg.Text = "";
            txtAvg.Text += (addSum + multDiv) / 2;
        }//Average button
    }//MainWindow : Window
}//namespace
