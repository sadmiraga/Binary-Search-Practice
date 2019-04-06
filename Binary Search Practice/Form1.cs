using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Search_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tab tabulator = new Tab();

        //ADD VALUE TO ARRAY
        private void dodajButton_Click(object sender, EventArgs e)
        {
            //get value from textbox and convert it to INT 
            string temp = inputTextBox.Text;
            int value = Convert.ToInt32(temp);

            //add value to array
            tabulator.dodaj(value);

            //empty textbox 
            inputTextBox.Text = "";

            //update label value 
            arrayLabel.Text = tabulator.ToString2();

        }

        //SHOW MINIMAL VALUE FROM ARRAY
        private void minButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabulator.Min().ToString());
        }

        //SHOW BIGGEST VALUE FROM ARRAY
        private void maxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabulator.Max().ToString());
        }

        //SHOW SUM OF ARRAY
        private void vsotaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabulator.vsota().ToString());
        }

        //SHOW AVARAGE OF THE ARRAY
        private void poprecjeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabulator.povprecje().ToString());
        }

        //CHECK IF GIVEN NUMBER IS IN ARRAY
        private void vsebujeButton_Click(object sender, EventArgs e)
        {
            //get value from textbox
            string temp = inputTextBox.Text;
            int givenNumber = Convert.ToInt32(temp);

            //empty textbox
            inputTextBox.Text = "";

            //check if array contains given number 
            bool result = tabulator.vsebuje(givenNumber);

            MessageBox.Show(result.ToString());

        }

        private void vsebujeBinarnoButton_Click(object sender, EventArgs e)
        {
            //get value from textbox
            string temp = inputTextBox.Text;
            int givenNumber = Convert.ToInt32(temp);

            //empty textbox
            inputTextBox.Text = "";

            //check if array contains given number 
            bool result = tabulator.vsebujeBinarno(givenNumber);
            MessageBox.Show(result.ToString());

        }
    }
}
