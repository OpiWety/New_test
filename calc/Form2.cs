using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form2 : Form
    {
        char tav;
        private int a, b, c;
        public Form2()
        {
            InitializeComponent();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 1;
           else  if (tav == 'b')
                b = 1;
            else if (tav == 'c')
                c = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 1;
            else if (tav == 'b')
                b = 1;
            else if (tav == 'c')
                c = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 1;
            else if (tav == 'b')
                b = 1;
            else if (tav == 'c')
                c = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 1;
            else if (tav == 'b')
                b = 1;
            else if (tav == 'c')
                c = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 1;
            else if (tav == 'b')
                b = 1;
            else if (tav == 'c')
                c = 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 6;
            else if (tav == 'b')
                b = 6;
            else if (tav == 'c')
                c = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 7;
            else if (tav == 'b')
                b = 7;
            else if (tav == 'c')
                c = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 8;
            else if (tav == 'b')
                b = 8;
            else if (tav == 'c')
                c = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 9;
            else if (tav == 'b')
                b = 9;
            else if (tav == 'c')
                c = 9;

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tav == 'a')
                a = 0;
            else if (tav == 'b')
                b = 0;
            else if (tav == 'c')
                c = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tav = 'b';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tav = 'c';
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            tav = 'a';
        }

        private void more_Click(object sender, EventArgs e)
        {

        }
    }
}
