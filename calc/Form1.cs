namespace calc
{
    public partial class Form1 : Form
    {   int MathCount;
        int count = 1;
        double num1, num2 ,num3;
        string number1, number2;
        private bool flag = true;
        // This is my first commit!
        public Form1()
        {
            InitializeComponent();
            button16.Enabled = false;
            button17.Enabled = false;
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
            button3.BackColor = Color.Bisque;
            button4.BackColor = Color.Bisque;
            button5.BackColor = Color.Bisque;
            button6.BackColor = Color.Bisque;
            button7.BackColor = Color.Bisque;
            button8.BackColor = Color.Bisque;
            button9.BackColor = Color.Bisque;
            button10.BackColor = Color.Bisque;
            button1.ForeColor= Color.Brown;
            button2.ForeColor = Color.Brown;
            button3.ForeColor = Color.Brown;
            button4.ForeColor = Color.Brown;
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
            if (count == 1)
            {
                if (flag == true)
                    num1 = num1 * 10 + 1;
                else
                {
                    num1 = 1;
                }
                if (flag == false)
                    count = 2;
                
               number1 = num1.ToString();
               button17.Text = number1;


            }
            else if (count == 2)
            {
                if (flag == true)
                    num1 = num1 * 10 + 1;
                else
                {
                    num1 = 1;
                }
                if (flag == false)
                    count = 1;
                number2 = num2.ToString();
                button17.Text = number2;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                if (flag == true)
                    num1 = num1*10+2;
                else
                {
                    num1 = 2;
                }
                if (flag == false)
                    count = 2;

                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                if (flag == true)
                    num1 = num1 * 10 + 2;
                else
                {
                    num1 = 2;
                }
                if (flag == false)
                    count = 1;
                number2 = num2.ToString();
                button17.Text = number2;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
         
                num1 = 3;
                
                    count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count ==  2)
            {
    
                num2 = 3;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                num1 = 4;
                
                    count = 2;
                
                number1 = num1.ToString();
                button17.Text = number1;
            }
            else if (count == 2)
            {
                num2 = 4;
                count = 1;
                number2 = num2.ToString();
                button17.Text += number2;
            }

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
                num3 = num1 + num2;
                button17.Text = num3.ToString();
            }
            else if (MathCount == 2)
            {
                num3 = num1 - num2;
                button17.Text = num3.ToString();
            }
            else if (MathCount == 3)
            {
                num3 = num1 * num2;
                button17.Text = num3.ToString();
            }
            else if (MathCount == 4)
            {
                num3 = num1 / num2;
                button17.Text = num3.ToString();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            button17.Text = num1.ToString() + " + ";
            MathCount = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button17.Text = num1.ToString() + " - ";
            MathCount = 2;
        }

   

        private void button14_Click(object sender, EventArgs e)
        {
            button17.Text = num1.ToString() + " * ";
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
            num1 = num3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button17.Text = num1.ToString() + " / ";
            MathCount = 4;
        }
        private void button17_Click(object sender, EventArgs e)
        {

        }


    }
}
