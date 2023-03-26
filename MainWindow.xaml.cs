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

namespace Check_Boxe_and_Radio_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            Preload();

        }
        void Preload()
        {
         //   rbSmall.IsChecked = true;
           // rbDrinkSmall.IsChecked =;
        }

        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {
            runReciept.Text = "IT'S gotta be  ->  " + txtCustomerName.Text + "\n ";
         
            double amount = 0;


            bool hasPepperoni = ckPepperoni.IsChecked.Value;
            bool hasExtraCheese = ckexCheese.IsChecked.Value;
            bool hasspinach = ckspinach.IsChecked.Value;
            bool hasPineapple = ckPineapple.IsChecked.Value;

            bool sizeSmall = rbSmall.IsChecked.Value;
            bool sizeLarge = rbLarge.IsChecked.Value;
            bool sizemedium = rbMedium.IsChecked.Value;
            bool sizeExtraLarge = rbExtraLarge.IsChecked.Value;

            bool drinkSmall = rbDrinkSmall.IsChecked.Value;
            bool drinkmedium = rbDrinkMedium.IsChecked.Value;
            bool drinklarge = rbDrinkLarge.IsChecked.Value;
            bool drinkextralatge = rbDrinkExtraLarge.IsChecked.Value;


            double price = 0;
            
            runReciept.Text += "\n Size\n \n";
            if (sizeSmall)
            {
                price = 20;
                runReciept.Text += "Small";
            }
            else if (sizemedium)
            {
                runReciept.Text += "Medium";
                price = 25;
            }
            else if (sizeLarge)
            {
                runReciept.Text += "Large";
                price = 30;
            }
            else if (sizeExtraLarge)
            {
                runReciept.Text += "Extra Large";
                price = 47;
            }
            runReciept.Text += " - " + price.ToString(".");
            amount += price;


            //BEVYSize
            runReciept.Text += "\n BEVY Size\n \n";
            if (drinkSmall)
            {
                double drinkPrice = 4;
                runReciept.Text += $"Small Drink - {drinkPrice.ToString(".")}\n";
                amount += drinkPrice;
            }
            else if (drinkmedium)
            {
                double drinkPrice = 4.25;
                runReciept.Text += $"Medium Drink - {drinkPrice.ToString(".")}\n";
                amount += drinkPrice;
            }
            else if (drinklarge)
            {
                double drinkPrice = 5;
                runReciept.Text += $"Large Drink - {drinkPrice.ToString(".")}\n";
                amount += drinkPrice;
            }
            else if (drinkextralatge)
            {
                double drinkPrice = 6.30;
                runReciept.Text += $"Extra Large Drink - {drinkPrice.ToString(".")}\n";
                FormatItem("Extra Large Drink", drinkPrice);
                amount += drinkPrice;
            }

            double taxAmount = .1;
            double calculatedTax = amount * taxAmount;
            double totalAmount = amount + taxAmount;


            runReciept.Text += "\nTopping:\n \n";

            
            if (hasPepperoni == true)
            {
                double toppingPrice = 2;
                runReciept.Text += $"Pepperoni - {toppingPrice.ToString(".")}\n";
                amount += toppingPrice;
            }

            if (hasExtraCheese)
            {
                double toppingPrice = 7;
                runReciept.Text += $"Extra Cheese - {toppingPrice.ToString(".")}\n";
                amount += toppingPrice;
            }

            if (hasspinach)
            {
                double toppingPrice = 3;
                runReciept.Text += $"spinach - {toppingPrice.ToString(".")}\n";
                amount += toppingPrice;
            }
            if (hasPineapple)
            {
                double toppingPrice = .20;
                runReciept.Text += $"Pineapples - {toppingPrice.ToString(".")}\n";
                amount += toppingPrice;
            }

         

            runReciept.Text += $"\n\n" +
                $"Subtotal: {amount.ToString("c")}\n" +
                $"Tax Amount: {calculatedTax.ToString(".")}\n" +
                $"Total Price: {totalAmount.ToString(".")}";

        }
        public string FormatItem(string item, double amount)
        {
            return $"\n {item} - {amount.ToString(".")}\n";
        }
    }

    //   Check boxes and radio buttons both return a type of __  of Boolean___
    //    How what property do you use to get the true / false value from your individual check boxes / radio buttons   isChecked property.
    //When using check boxes you need to use a __ContentPresenter__ for each check box
    //When working with radio buttons you need an ItemsControl/ItemsSource/DataTemplate structure
    //You need to __group together radio buttons using RadioButtonGroup_____ together radio buttons, otherwise they may not work properly
    //You can use a ___StackPanel _____ layout to accomplish this
}
