using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Machine
{
    public partial class Form1 : Form
    {
        const double SPRAY = 25.00;
        const double CURE_KIT = 30.00;
        const double WIPES = 18.00;
        const double TAX = 0.13;
        double subTotal, tax, total, tender, change;
        int numberOfCurekit, numberOfSpray, numberOfWipes;

        private void NewOrderLabel_Click(object sender, EventArgs e)
        {
            // object
            Graphics g = this.CreateGraphics();

            // resets the whole thing
            g.Clear(Color.Black);
            subTotalLabel.Text = "Subtotal:";
            taxLabel.Text = "Tax:   ";
            totalLabel.Text = "Total: ";
            changeLabel.Text = "";
            tenderedBox.Text = Convert.ToString("");
            // clearing everything
            numberOfCureKitBox.Value = 0;
            numberOfSprayBox.Value = 0;
            numberOfWipesBox.Value = 0;
            subTotal = 0;
            total = 0;
            tender = 0;
            change = 0;
            tax = 0;
            numberOfCurekit = 0;
            numberOfSpray = 0;
            numberOfWipes = 0;
            costOfCurekit = 0;
            costOfSpray = 0;
            costOfWipes = 0;

        }

        private void PrintReceipt_Click(object sender, EventArgs e)
        {
            // objected created for the receipt 
            Graphics g = this.CreateGraphics();
            Font drawrceipt = new Font("Segoe Print", 10, FontStyle.Regular);
            Font drawTitle = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush receiptBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush rectangleBrush = new SolidBrush(Color.White);
            SolidBrush TitleBrush = new SolidBrush(Color.Teal);
            Pen BorderPen = new Pen(Color.GhostWhite, 3);

            // sound
            SoundPlayer cashRegister = new SoundPlayer(Properties.Resources.cashRegister);
            // background 
            //g.FillRectangle(rectangleBrush, 330, 20, 300, 300);
            Thread.Sleep(350);
            g.DrawLine(BorderPen, 330, 20, 620, 20);
            Thread.Sleep(350);
            g.DrawLine(BorderPen, 330, 20, 330,320 );
            Thread.Sleep(350);
            g.DrawLine(BorderPen, 330, 320, 620, 320);
            Thread.Sleep(350);
            g.DrawLine(BorderPen, 620, 320, 620, 20);
            //title
            g.DrawString("Crep Protect", drawTitle, TitleBrush, 420, 30);
            //made a random order generator
            Random Order = new Random();
            int ordernumber = Order.Next(1, 500);
            //receipt 
            cashRegister.Play();
            g.DrawString("Tuesday October 8, 2019", drawrceipt, receiptBrush, 400, 60);
            g.DrawString("Order Number:  " + ordernumber, drawrceipt, receiptBrush, 400, 75);
            cashRegister.Play();
            Thread.Sleep(350);
            g.DrawString("001 Spray    x" + numberOfSpray, drawrceipt, receiptBrush, 350, 110);
            g.DrawString("" + costOfSpray.ToString("C"), drawrceipt, receiptBrush, 500, 110);
            cashRegister.Play();
            Thread.Sleep(350);
            g.DrawString("  002 CureKit   X" + numberOfCurekit, drawrceipt, receiptBrush, 340, 125);
            g.DrawString("" + costOfCurekit.ToString("C"), drawrceipt, receiptBrush, 500, 125);
            cashRegister.Play();
            Thread.Sleep(350);
            g.DrawString("003 Wipes   X" + numberOfWipes, drawrceipt, receiptBrush, 350, 140);
            g.DrawString("" + costOfWipes.ToString("C"), drawrceipt, receiptBrush, 500, 140);
            Thread.Sleep(350);
            cashRegister.Play();
            g.DrawString("Subtotal", drawrceipt, receiptBrush, 350, 165);
            g.DrawString("" + subTotal.ToString("C"), drawrceipt, receiptBrush, 500, 165);
            Thread.Sleep(350);
            cashRegister.Play();
            g.DrawString("Tax", drawrceipt, receiptBrush, 350, 180);
            g.DrawString("" + tax.ToString("C"), drawrceipt, receiptBrush, 500, 180);
            Thread.Sleep(350);
            cashRegister.Play();
            g.DrawString("Total", drawrceipt, receiptBrush, 350, 195);
            g.DrawString("" + total.ToString("C"), drawrceipt, receiptBrush, 500, 195);
            Thread.Sleep(350);
            cashRegister.Play();
            g.DrawString("Tendered", drawrceipt, receiptBrush, 350, 220);
            g.DrawString("" + tender.ToString("C"), drawrceipt, receiptBrush, 500, 220);
            Thread.Sleep(350);
            cashRegister.Play();
            g.DrawString("Change", drawrceipt, receiptBrush, 350, 235);
            g.DrawString("" + change.ToString("C"), drawrceipt, receiptBrush, 500, 235) ;
            Thread.Sleep(350);
            cashRegister.Play();
            g.DrawString("Have a nice day!", drawrceipt, receiptBrush, 430, 290);
            cashRegister.Play();

        }

        double costOfSpray, costOfCurekit, costOfWipes;

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfCurekit = Convert.ToInt16(numberOfCureKitBox.Text);
                numberOfSpray = Convert.ToInt16(numberOfSprayBox.Text);
                numberOfWipes = Convert.ToInt16(numberOfWipesBox.Text);
            }
            catch
            {
                totalLabel.Text = "Please enter a numeric value";
                return;
            }
            // calulation
            costOfCurekit = CURE_KIT * numberOfCurekit;
            costOfSpray = SPRAY * numberOfSpray;
            costOfWipes = WIPES * numberOfWipes;
            subTotal = costOfCurekit + costOfSpray + costOfWipes;
            tax = subTotal * TAX;
            total = subTotal + tax;

            // showing the total, subtotal and tax on a label
            subTotalLabel.Text = "Subtotal:   $" + subTotal;
            taxLabel.Text = "Tax:          $" + tax;
            totalLabel.Text = "Total:        $" + total;

            // calculating change
            try
            {
                tender = Convert.ToDouble(tenderedBox.Text);
            }
            catch
            {
                totalLabel.Text = "Please enter a numeric value";
            }
            change = tender - total;

            changeLabel.Text = change.ToString("C");
        }

        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfCurekit = Convert.ToInt16(numberOfCureKitBox.Text);
                numberOfSpray = Convert.ToInt16(numberOfSprayBox.Text);
                numberOfWipes = Convert.ToInt16(numberOfWipesBox.Text);
            }
            catch
            {
                totalLabel.Text = "Please enter a numeric value";
                return;
            }
            // calulation
            costOfCurekit = CURE_KIT * numberOfCurekit;
            costOfSpray = SPRAY * numberOfSpray;
            costOfWipes = WIPES * numberOfWipes;
            subTotal = costOfCurekit + costOfSpray + costOfWipes;
            tax = subTotal * TAX;
            total = subTotal + tax;

            // showing the total, subtotal and tax on a label
            subTotalLabel.Text = "Subtotal:   " + subTotal.ToString("C");
            taxLabel.Text = "Tax:          " + tax.ToString ("C");
            totalLabel.Text = "Total:        " + total.ToString("C");
        }

    }
}
