using System;
using System.Windows.Forms;
using CalculatorManager;
namespace Calculator
{
   
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Button button = new Button();
            string r = AgeCalculator.Substract(int.Parse(current.Text), int.Parse(born.Text)).ToString();
            MessageBox.Show("Your age is:" +r);
        }
    }
}
