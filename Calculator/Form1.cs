using System;
using System.Windows.Forms;
using CalculatorManager;
namespace Calculator
{

    public partial class Form1 : Form
    {
        ArithmeticOperation oper = new ArithmeticOperation();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            // to get rid or the 0 when the user press any number
            if (textBox_Result.Text == "0" || oper.IsOperationPerformed)
                textBox_Result.ResetText();
            //or  textBox_Result.ResetText();

            Button button = (Button)sender;

            current_Operation.Text = oper.ResultValue + " " + oper.OperationPerformed;
            oper.IsOperationPerformed = false;

            // to allow the user to enter "." just one time !
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    // concatenate (So we can press the same number many times)
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // to show the result when we click on another operation  
            if (oper.ResultValue != 0)
            {
                // This action will perform same action as equal button
                equal.PerformClick();
                oper.OperationPerformed = button.Text;
                current_Operation.Text = oper.ResultValue + " " + oper.OperationPerformed;
                oper.IsOperationPerformed = true;

            }
            else
            {
                oper.OperationPerformed = button.Text;
                oper.ResultValue = Double.Parse(textBox_Result.Text);
                current_Operation.Text = oper.ResultValue + " " + oper.OperationPerformed;
                oper.IsOperationPerformed = true;
            }
        }

        private void ButtonClearEntry(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }
        private void ButtonClear(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            oper.ResultValue = 0;
        }

        private void btn_Equals(object sender, EventArgs e)
        {
            // i think there is no diffrence !!
            while (!oper.IsOperationPerformed) {
                
                double r;
                if (double.TryParse(textBox_Result.Text, out r))
                { 

                  textBox_Result.Text = ArthimaticFactory.Calculate(oper.OperationPerformed, oper.ResultValue, r).ToString();

                }
            oper.IsOperationPerformed = true;
            oper.ResultValue = Double.Parse(textBox_Result.Text);
            current_Operation.Text = "";

        } }
        // to open another windows form app
        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        public class calculate { 
        }

     
        
    }
    }
    