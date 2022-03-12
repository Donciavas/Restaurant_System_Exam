using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblTax_Click(object sender, EventArgs e)
        {

        }

        private void LblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to Exit the System", "Restaurant System", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //=====================================EnableTextBoxes()=========================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //=====================================ClearTextBoxes()=========================
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //====================================RestCheckBoxes()======================================

        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            RestCheckBoxes();
            ClearTextBoxes();

            lblSubTotalFood.Text = "";
            lblSubTotalDrinks.Text = "";
            lblTotal.Text = "";
            rtReceipt.Clear();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
            RestCheckBoxes();
            ClearTextBoxes();
            
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            Drinks Cost_of_Meal = new Drinks();

            double iSubTotalFood, iSubTotalDrinks, iTotal;

            DateTime iDateNTime;

            Cost_of_Meal.WaterBottle = Cost_of_Meal.Price_BottleWater * Double.Parse(txtBottleWater.Text);
            Cost_of_Meal.CheeseSandwich = Cost_of_Meal.Price_CheeseSandwich * Double.Parse(txtCheeseSandwich.Text);
            Cost_of_Meal.ChocolateMilkShake = Cost_of_Meal.Price_ChocolateMilkShake * Double.Parse(txtChocolateMilkShake.Text);
            Cost_of_Meal.ChickenSalad = Cost_of_Meal.Price_ChickenSalad * Double.Parse(txtChickenSalad.Text);
            Cost_of_Meal.Coffee = Cost_of_Meal.Price_Coffee * Double.Parse(txtCoffee.Text);
            Cost_of_Meal.Cola = Cost_of_Meal.Price_Cola * Double.Parse(txtCola.Text);

            Cost_of_Meal.FishSandwich = Cost_of_Meal.Price_FishSandwich * Double.Parse(txtFishSandwich.Text);
            Cost_of_Meal.Fries = Cost_of_Meal.Price_Fries * Double.Parse(txtFries.Text);
            Cost_of_Meal.Hamburger = Cost_of_Meal.Price_Hamburger * Double.Parse(txtHamburger.Text);
            Cost_of_Meal.ChickenSandwich = Cost_of_Meal.Price_ChickenSandwich * Double.Parse(txtChickenSandwich.Text);
            Cost_of_Meal.OnionRings = Cost_of_Meal.Price_OnionRings * Double.Parse(txtOnionRings.Text);
            Cost_of_Meal.Orange = Cost_of_Meal.Price_Orange * Double.Parse(txtOrange.Text);

            Cost_of_Meal.Salad = Cost_of_Meal.Price_Salad * Double.Parse(txtSalad.Text);
            Cost_of_Meal.Strawberry = Cost_of_Meal.Price_Strawberry * Double.Parse(txtStrawberry.Text);
            Cost_of_Meal.Tea = Cost_of_Meal.Price_Tea * Double.Parse(txtTea.Text);
            Cost_of_Meal.BerryShake = Cost_of_Meal.Price_BerryShake * Double.Parse(txtVanillaCone.Text);
            Cost_of_Meal.VanillaShake = Cost_of_Meal.Price_VanillaShake * Double.Parse(txtVanillaShake.Text);
     
            iSubTotalFood = Cost_of_Meal.GetAmountFood();
            iSubTotalDrinks = Cost_of_Meal.GetAmountDrinks();
            iTotal = iSubTotalFood + iSubTotalDrinks;
            iDateNTime = DateTime.Now;

            lblSubTotalFood.Text = String.Format("{0:C}", iSubTotalFood);
            lblSubTotalDrinks.Text= String.Format("{0:C}", iSubTotalDrinks);
            lblTotal.Text = String.Format("{0:C}", iTotal);

            //==========================Receipt============================================
            
            rtReceipt.AppendText("\t\t  Restaurant Management\n\n" +
                "=========================Food==========================\n" +
                "Fries:\t\t\t\t\t\t" + Cost_of_Meal.Fries + "\n" +
                "Salad:\t\t\t\t\t\t" + Cost_of_Meal.Salad + "\n" +
                "Hamburger:\t\t\t\t\t" + Cost_of_Meal.Hamburger + "\n" +
                "Onion Rings:\t\t\t\t\t" + Cost_of_Meal.OnionRings + "\n" +
                "Chicken Salad:\t\t\t\t\t" + Cost_of_Meal.ChickenSalad + "\n" +
                "Fish Sandwich:\t\t\t\t\t" + Cost_of_Meal.FishSandwich + "\n" +
                "Cheese Sandwich:\t\t\t\t" + Cost_of_Meal.CheeseSandwich + "\n" +
                "Chicken Sandwich:\t\t\t\t" + Cost_of_Meal.ChickenSandwich + "\n" +
                "=========================Drinks=========================\n" +
                "Tea:\t\t\t\t\t\t" + Cost_of_Meal.Tea + "\n" +
                "Cola:\t\t\t\t\t\t" + Cost_of_Meal.Cola + "\n" +
                "Coffee:\t\t\t\t\t\t" + Cost_of_Meal.Coffee + "\n" +
                "Orange:\t\t\t\t\t" + Cost_of_Meal.Orange + "\n" +
                "WaterBottle:\t\t\t\t\t" + Cost_of_Meal.WaterBottle + "\n" +
                "Vanilla Cone:\t\t\t\t\t" + Cost_of_Meal.BerryShake + "\n" +
                "Vanilla Shake:\t\t\t\t\t" + Cost_of_Meal.VanillaShake + "\n" +
                "Strawberry Shake:\t\t\t\t" + Cost_of_Meal.Strawberry + "\n" +
                "Chocolate Milk Shake:\t\t\t\t" + Cost_of_Meal.ChocolateMilkShake + "\n" +
                "=========================Total Cost======================\n" +
                "Food: \t\t\t\t\t\t" + lblSubTotalFood.Text + "\n" +
                "Drinks: \t\t\t\t\t\t" + lblSubTotalDrinks.Text + "\n" +
                "Total: \t\t\t\t\t\t" + lblTotal.Text + "\n" +
                "Date and Time: \t\t\t\t " + iDateNTime + "\n");
        }

        

        private void ChkFries_CheckChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked == true )
            {
                txtFries.Text = "";
                txtFries.Enabled = true;
                txtFries.Focus();
            }
            else
            {
                txtFries.Text = "0";
                txtFries.Enabled = false;
                
            }
        }

        private void ChkSalad_CheckChanged(object sender, EventArgs e)
        {
            if (chkSalad.Checked == true)
            {
                txtSalad.Text = "";
                txtSalad.Enabled = true;
                txtSalad.Focus();
            }
            else
            {
                txtSalad.Text = "0";
                txtSalad.Enabled = false;

            }
        }

        private void ChkHamburger_CheckChanged(object sender, EventArgs e)
        {
            if (chkHamburger.Checked == true)
            {
                txtHamburger.Text = "";
                txtHamburger.Enabled = true;
                txtHamburger.Focus();
            }
            else
            {
                txtHamburger.Text = "0";
                txtHamburger.Enabled = false;

            }
        }

        private void ChkOnionRings_CheckChanged(object sender, EventArgs e)
        {
            if (chkOnionRings.Checked == true)
            {
                txtOnionRings.Text = "";
                txtOnionRings.Enabled = true;
                txtOnionRings.Focus();
            }
            else
            {
                txtOnionRings.Text = "0";
                txtOnionRings.Enabled = false;

            }
        }

        private void ChkChickenSalad_CheckChanged(object sender, EventArgs e)
        {
            if (chkChickenSalad.Checked == true)
            {
                txtChickenSalad.Text = "";
                txtChickenSalad.Enabled = true;
                txtChickenSalad.Focus();
            }
            else
            {
                txtChickenSalad.Text = "0";
                txtChickenSalad.Enabled = false;

            }
        }

        private void ChkFishSandwich_CheckChanged(object sender, EventArgs e)
        {
            if (chkFishSandwich.Checked == true)
            {
                txtFishSandwich.Text = "";
                txtFishSandwich.Enabled = true;
                txtFishSandwich.Focus();
            }
            else
            {
                txtFishSandwich.Text = "0";
                txtFishSandwich.Enabled = false;

            }
        }

        private void ChkCheeseSandwich_CheckChanged(object sender, EventArgs e)
        {
            if (chkCheeseSandwich.Checked == true)
            {
                txtCheeseSandwich.Text = "";
                txtCheeseSandwich.Enabled = true;
                txtCheeseSandwich.Focus();
            }
            else
            {
                txtCheeseSandwich.Text = "0";
                txtCheeseSandwich.Enabled = false;

            }
        }

        private void ChkChickenSandwich_CheckChanged(object sender, EventArgs e)
        {
            if (chkChickenSandwich.Checked == true)
            {
                txtChickenSandwich.Text = "";
                txtChickenSandwich.Enabled = true;
                txtChickenSandwich.Focus();
            }
            else
            {
                txtChickenSandwich.Text = "0";
                txtChickenSandwich.Enabled = false;

            }
        }

        private void ChkChocolateMilkShake_CheckChanged(object sender, EventArgs e)
        {
            if (chkChocolateMilkShake.Checked == true)
            {
                txtChocolateMilkShake.Text = "";
                txtChocolateMilkShake.Enabled = true;
                txtChocolateMilkShake.Focus();
            }
            else
            {
                txtChocolateMilkShake.Text = "0";
                txtChocolateMilkShake.Enabled = false;

            }
        }

        private void ChkStrawberry_CheckChanged(object sender, EventArgs e)
        {
            if (chkStrawberry.Checked == true)
            {
                txtStrawberry.Text = "";
                txtStrawberry.Enabled = true;
                txtStrawberry.Focus();
            }
            else
            {
                txtStrawberry.Text = "0";
                txtStrawberry.Enabled = false;

            }
        }

        private void ChkVanillaShake_CheckChanged(object sender, EventArgs e)
        {
            if (chkVanillaShake.Checked == true)
            {
                txtVanillaShake.Text = "";
                txtVanillaShake.Enabled = true;
                txtVanillaShake.Focus();
            }
            else
            {
                txtVanillaShake.Text = "0";
                txtVanillaShake.Enabled = false;
            }
        }

        private void ChkVanillaCone_CheckChanged(object sender, EventArgs e)
        {
            if (chkVanillaCone.Checked == true)
            {
                txtVanillaCone.Text = "";
                txtVanillaCone.Enabled = true;
                txtVanillaCone.Focus();
            }
            else
            {
                txtVanillaCone.Text = "0";
                txtVanillaCone.Enabled = false;

            }
        }

        private void ChkBottleWater_CheckChanged(object sender, EventArgs e)
        {
            if (chkBottleWater.Checked == true)
            {
                txtBottleWater.Text = "";
                txtBottleWater.Enabled = true;
                txtBottleWater.Focus();
            }
            else
            {
                txtBottleWater.Text = "0";
                txtBottleWater.Enabled = false;

            }
        }

        private void ChkOrange_CheckChanged(object sender, EventArgs e)
        {
            if (chkOrange.Checked == true)
            {
                txtOrange.Text = "";
                txtOrange.Enabled = true;
                txtOrange.Focus();
            }
            else
            {
                txtOrange.Text = "0";
                txtOrange.Enabled = false;

            }
        }

        private void ChkCoffee_CheckChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                txtCoffee.Text = "";
                txtCoffee.Enabled = true;
                txtCoffee.Focus();
            }
            else
            {
                txtCoffee.Text = "0";
                txtCoffee.Enabled = false;

            }
        }

        private void ChkCola_CheckChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked == true)
            {
                txtCola.Text = "";
                txtCola.Enabled = true;
                txtCola.Focus();
            }
            else
            {
                txtCola.Text = "0";
                txtCola.Enabled = false;

            }
        }

        private void ChkTea_CheckChanged(object sender, EventArgs e)
        {
            if (chkTea.Checked == true)
            {
                txtTea.Text = "";
                txtTea.Enabled = true;
                txtTea.Focus();
            }
            else
            {
                txtTea.Text = "0";
                txtTea.Enabled = false;

            }
        }

        private void Number_Only(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit (c) && c != 8)
            {
                e.Handled = true;
            }
        }

       

        private void Text_Validated(object sender, EventArgs e)
        {
            TextBox b = sender as TextBox;

            if (b.Text == "")
            {
                b.Text = "0";
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);*/
        }
    }
}
