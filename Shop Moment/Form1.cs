using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Shop_Moment
{
    public partial class Form1 : Form
    {
        int cricketAmount;
        int maddenAmount;
        int bitcoinAmount;
        int tender;
        double subTotal;
        double tax2;
        double taxEquation = 0.13;
        double cricketTotal;
        double maddenTotal;
        double bitcoinTotal;
        double cricketPrice = 22.99;
        double maddenPrice = 49.99;
        double bitcoinPrice = 5.27;
        double total;
        double tax = 1.13;
        double change;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void clickHere1_Click(object sender, EventArgs e)
        {
            
        }

        private void clickHere1_Click_1(object sender, EventArgs e)
        {
            try
            {
                cricketAmount = Convert.ToInt32(cricketInsert.Text);
                maddenAmount = Convert.ToInt32(maddenInput.Text);
                bitcoinAmount = Convert.ToInt32(bitcoinInput.Text);
                cricketTotal = cricketAmount * cricketPrice;
                maddenTotal = maddenAmount * maddenPrice;
                bitcoinTotal = bitcoinAmount * bitcoinPrice;
                    subTotal = cricketTotal + maddenTotal + bitcoinTotal;
                    tax2 = subTotal * taxEquation;
                    total = cricketTotal + maddenTotal + bitcoinTotal + tax2;
                subtotal.Text = $"Subtotal = {subTotal.ToString("C")}";
                taxes.Text = $"Tax = {tax2.ToString("C")}";
                totalTotal.Text = $"Total = {total.ToString("C")}";
                

            }
            catch
            {
                tempOutput.Text = $"You just made the worst mistake of your life.";
            }
        }

        private async Task tenderButton_ClickAsync(object sender, EventArgs e)
        {
           
        }

        private void tenderButton_Click(object sender, EventArgs e)
        {
            try
            {
                tender = Convert.ToInt32(tenderInsert.Text);
                change = total - tender;
                SoundPlayer printSound = new SoundPlayer(Properties.Resources.cashSound);
                printSound.Play();
                Thread.Sleep(500);
                Refresh();
                cricketAgain.Text = $"{cricketAmount} boxes purchased. {cricketTotal.ToString("C")}";
                Thread.Sleep(500);
                Refresh();
                maddenAgain.Text = $"{maddenAmount} Maddens purchased. {maddenTotal.ToString("C")}";
                Thread.Sleep(500);
                Refresh();
                bitcoinAgain.Text = $"{bitcoinAmount} fractions purchaed. {bitcoinTotal.ToString("C")}";
                Thread.Sleep(500);
                Refresh();
                permOutput.Text = $"Your total is {total.ToString("C")}.";
                Thread.Sleep(500);
                Refresh();
                permOutput2.Text = $"Your amount paid is {tender.ToString("C")}.";
                Thread.Sleep(500);
                Refresh();
                permOutput3.Text = $"Your change is {change.ToString("C")}.";
                Thread.Sleep(500);
                Refresh();
             
            }
            catch
            {
                tempOutput.Text = $"You just made the worst mistake of your life.";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cricketAmount = 0;
            maddenAmount = 0;
            bitcoinAmount = 0;
            cricketTotal = 0;
            maddenTotal = 0;
            bitcoinTotal = 0;
            tender = 0;
            change = 0;
            subTotal = 0;
            tax2 = 0;
            total = 0;
            cricketAgain.Text = " ";
            maddenAgain.Text = " ";
            bitcoinAgain.Text = " ";
            permOutput.Text = " ";
            permOutput2.Text = " ";
            permOutput3.Text = " ";

            
        }

        //private async Task tenderButton_ClickAsync(object sender, EventArgs e)
        //{

        //}
    }
}
