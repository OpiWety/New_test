// ReSharper disable LocalizableElement
// ReSharper disable SpecifyACultureInStringConversionExplicitly
namespace calc
{
    public partial class Form1 : Form
    {
        int MathCount;
        int count = 1;
        public double num1;
        public double num2;
        public int num1Count;
        public int num2Count;
        public int foucsOnNum = 1;
        string number1, number2;
        private bool flag = true;

        private CalculatorHelper helper;
        // This is my first commit!
        public Form1()
        {
            InitializeComponent();
            helper = new CalculatorHelper(this);
            button16.Enabled = false;
            button17.Enabled = false;
            Number2Button.BackColor = Color.Bisque;
            Number3Button.BackColor = Color.Bisque;
            Number4Button.BackColor = Color.Bisque;
            button5.BackColor = Color.Bisque;
            button6.BackColor = Color.Bisque;
            button7.BackColor = Color.Bisque;
            button8.BackColor = Color.Bisque;
            button9.BackColor = Color.Bisque;
            button10.BackColor = Color.Bisque;
            Number2Button.ForeColor = Color.Brown;
            Number3Button.ForeColor = Color.Brown;
            Number4Button.ForeColor = Color.Brown;
            button5.ForeColor = Color.Brown;
            button6.ForeColor = Color.Brown;
            button7.ForeColor = Color.Brown;
            button8.ForeColor = Color.Brown;
            button9.ForeColor = Color.Brown;
            button10.ForeColor = Color.Brown;
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helper.NumberButtonPressed(Number1Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helper.NumberButtonPressed(Number2Button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helper.NumberButtonPressed(Number3Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helper.NumberButtonPressed(Number4Button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 5;

                    count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 5;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 6;
               
                    count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 6;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 7;
              
                    count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 7;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 8;

                count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 8;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 9;
                
                count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 9;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 0;
               
                count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 0;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MathCount == 1)
            {
                var n = num1 + num2;
                button17.Text = n.ToString();
            }
            else if (MathCount == 2)
            {
                var n = num1 - num2;
                button17.Text = n.ToString();
            }
            else if (MathCount == 3)
            {
                var n = num1 * num2;
                button17.Text = n.ToString();
            }
            else if (MathCount == 4)
            {
                var n = num1 / num2;
                
                button17.Text = n.ToString();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button17.Text = num1 + " + ";
            MathCount = 1;
            foucsOnNum++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button17.Text = num1 + " - ";
            MathCount = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button17.Text = num1 + " * ";
            MathCount = 3;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button17.Text = " ";
            num1 = 0;
            num2 = 0;
            count = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form a = new Form2();
            a.Show();
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //num1 = num3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button17.Text = num1 + " / ";
            MathCount = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        
    }
}
