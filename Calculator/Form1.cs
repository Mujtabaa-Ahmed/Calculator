namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        string labl;
        string oper;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string number = richTextBox1.Text;
            if (number.Length > 0)
            {
                string delnumber = number.Substring(0, number.Length - 1);

                richTextBox1.Text = delnumber;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            oper = "+";
            num1 = double.Parse(richTextBox1.Text);
            labl = Convert.ToString(num1 + oper);
            label2.Text = labl;
            //richTextBox1.Text = labl;
            richTextBox1.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            oper = "-";
            num1 = double.Parse(richTextBox1.Text);
            labl = Convert.ToString(num1 + oper);
            label2.Text = labl;
            //richTextBox1.Text = labl;
            richTextBox1.Clear();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            oper = "*";
            num1 = double.Parse(richTextBox1.Text);
            labl = Convert.ToString(num1 + "×");
            label2.Text = labl;
            //richTextBox1.Text = labl;
            richTextBox1.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            oper = "÷";
            num1 = double.Parse(richTextBox1.Text);
            labl = Convert.ToString(num1 + "÷");
            label2.Text = labl;
            //richTextBox1.Text = labl;
            richTextBox1.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(richTextBox1.Text);
            label2.Text = "";
            label2.Text = labl + num2 + "=";
            richTextBox1.Clear();
            if (oper == "+")
            {
                result = num1 + num2;
                richTextBox1.Text = Convert.ToString(result);
            }
            else if (oper == "-")
            {
                result = num1 - num2;
                richTextBox1.Text = Convert.ToString(result);
            }
            else if (oper == "*")
            {
                result = num1 * num2;
                richTextBox1.Text = Convert.ToString(result);
            }
            else if (oper == "÷")
            {
                result = num1 / num2;
                richTextBox1.Text = Convert.ToString(result);
            }
        }

        
    }
}
