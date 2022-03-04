using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_System
{

    public partial class Form1 : Form
    {
        int customerNumber = 000001;
        double subtotal = 0;
        double total = 0;
        const double tax = .1;
        string[] drinks = { "Coke", "Sprite", "Powerade", "Mountain Dew", "Desani" };

        public Form1()
        {
            InitializeComponent();
            preload();
        } // Form1()

        public void preload()
        {
            rbSmall.Checked = true;
            populateDrinkCombo();
        } // preload()

        private void btnCompleteTransaction_Click(object sender, EventArgs e)
        {
            if(!validateFields())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            displayFullRecipet();

        } // btnCompleteTransaction_Click

        private void updateCustomerNumber()
        {
            lblCustomerNumber.Text = $"Customer #: {customerNumber.ToString("D8")}";
        }

        private void displayFullRecipet()
        {
            rtbReciept.Text = "House of Pi(e)\n";
            rtbReciept.Text += $"Customer #: {customerNumber.ToString("D8")}\n\n";
            updateCustomerNumber();
            customerNumber++;

            rtbReciept.Text += "\n";
            rtbReciept.Text += pizzaSize() + "\n";
            rtbReciept.Text += "\n";
            rtbReciept.Text += toppings();
            rtbReciept.Text += "\n";
            rtbReciept.Text += drinkOrder() + "\n";
            rtbReciept.Text += "\n";
            rtbReciept.Text += displayPrice();
            rtbReciept.Text += "\n";
            rtbReciept.Text += address();
            rtbReciept.Text += "\n";

        } // displayFullRecipet()

        public string pizzaSize()
        {
            string pizza = $"Pizza Size: ";
            if(rbSmall.Checked)
            {
                pizza += "Small";
                subtotal += 10;
            }
            else if (rbMedium.Checked)
            {
                pizza += "Medium";
                subtotal += 13;
            }
            else if (rbLarge.Checked)
            {
                pizza += "Large";
                subtotal += 17;
            }
            else
            {
                pizza += "Extra Large";
                subtotal += 20;
            }

            return pizza;
        }

        public string toppings()
        {
            string topping = $"Toppings: \n";
            // Pepperoni
            if (cbPepperoni.Checked)
            {
                topping += "Pepperoni\n";
                subtotal += 2;
            }
            // Mushroom
            if (cbMushroom.Checked)
            {
                topping += "Mushroom\n";
                subtotal += 1.5;
            }
            // Extra Cheese
            if (cbExtraCheese.Checked)
            {
                topping += "Extra Cheese\n";
                subtotal += 1;
            }
            // Sausage
            if (cbSausage.Checked)
            {
                topping += "Sausage\n";
                subtotal += 2;
            }
            // Onion
            if (cbOnion.Checked)
            {
                topping += "Onion\n";
                subtotal += 1.5;
            }
            // Black Olives
            if (cbBlackOlives.Checked)
            {
                topping += "Black Olives\n";
                subtotal += 1.5;
            }
            // Green Peppers
            if (cbGreenPeppers.Checked)
            {
                topping += "Green Peppers\n";
                subtotal += 1;
            }
            // Fresh Garlic
            if (cbGarlic.Checked)
            {
                topping += "Fresh Garlic\n";
                subtotal += 2;
            }
            // Tomato
            if (cbTomato.Checked)
            {
                topping += "Tomato\n";
                subtotal += 1;
            }
            // Fresh Basil
            if (cbFreshBasil.Checked)
            {
                topping += "Fresh Basil\n";
                subtotal += 3;
            }

            return topping;
        } // toppings


        private string drinkOrder()
        {
            string drink = "Drink: \n";
            int selectedDrink = cmbDrink.SelectedIndex;
            int selectedSize = cmbDrink.SelectedIndex;
            double[] drinkPrices = { 1.50, 1.75, 2.00, 2.25 };

            drink += drinks[selectedDrink] + "\n";
            subtotal += drinkPrices[selectedSize];

            switch(selectedSize)
            {
                case 0:
                    drink += "Small";
                    break;
                case 1:
                    drink += "Medium";

                    break;
                case 2:
                    drink += "Large";

                    break;
                case 3:
                    drink += "Extra Large";

                    break;

            }

            return drink;
        } // drinkOrder

        public bool validateFields()
        {
            
            if(
                txtName.Text.Equals("") ||
                txtAddress.Text.Equals("") ||
                txtCityState.Text.Equals("") ||
                txtZip.Text.Equals("") ||
                txtPhone.Text.Equals(""))
            {
                return false;
            }

            return true;
        } // validateFields()

        public string address()
        {
            string delivery = "Delivery: \n";
            delivery += $"Name: {txtName.Text}\n";
            delivery += $"Address: {txtAddress.Text}\n";
            delivery += $"City and State: {txtCityState.Text}\n";
            delivery += $"Zip: {txtZip.Text}\n";
            delivery += $"Phone: {txtPhone.Text}\n";

            return delivery;
        }

        private void populateDrinkCombo()
        {
            foreach(string drink in drinks)
            {
                cmbDrink.Items.Add(drink);
            }
            cmbDrink.SelectedIndex = 0;

            cmbSize.Items.Add("Small - $1.50");
            cmbSize.Items.Add("Medium - $1.75");
            cmbSize.Items.Add("Large - $2.00");
            cmbSize.Items.Add("Extra Large - $2.25");
            cmbSize.SelectedIndex = 0;


        } // populateDrinkCombo

        public void calculatePrice()
        {
            total = subtotal * (1 + tax);
        } // calculatePrice()

        public string displayPrice()
        {
            string price = "Price: \n";
            price += $"Subtotal: {subtotal.ToString("C")}\n";
            price += $"Tax: {(subtotal * .1).ToString("C")}\n";
            calculatePrice();
            price += $"Price: {total.ToString("C")}\n";

            return price;
        }

    } // Form1

} // namespace


