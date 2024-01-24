using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.BMI_CALCULATOR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  height, weight, bmi;
            weight = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);

            bmi = (weight * 703) / (height * height);
            textBox3.Text = bmi.ToString();
            if (bmi<18.5)
            {
                textBox4.Text = bmi + "\nunderweight" + "\nplease take some multivitamin to get your ideal weight";
                   
               
                }
                   if (bmi>18 && bmi < 26)
            {
                textBox4.Text = bmi + "\noverweight" + "\n please diet and do some exercise";

            }
                   else if (bmi > 18)
            {
                textBox4.Text = bmi + "\nnobese " + "\nsee a doctor or dietician to have some consultation";
            }
            }

        }
        
    }

