namespace Calc3
{
    public partial class Calculadora : Form
    {
        private double valueFirst = 0;
        private double valueSecond = 0;
        private double Result = 0;
        private string operators = "+";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else textBox1.Text += "0";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else textBox1.Text += "1";
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else textBox1.Text += "2";
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else textBox1.Text += "3";
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else textBox1.Text += "4";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else textBox1.Text += "5";
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else textBox1.Text += "6";
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else textBox1.Text += "7";
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else textBox1.Text += "8";
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else textBox1.Text += "9";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "+";
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "/";
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "*";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = double.Parse(textBox1.Text);
                    Result = valueFirst - valueSecond;
                    textBox1.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = double.Parse(textBox1.Text);
                    Result = valueFirst + valueSecond;
                    textBox1.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = double.Parse(textBox1.Text);
                    if (valueSecond == 0)
                    { textBox1.Text = "error"; }
                    else
                    {
                        Result = valueFirst / valueSecond;
                        textBox1.Text = Result.ToString();
                    }

                    break;
                case "*":
                    valueSecond = double.Parse(textBox1.Text);
                    Result = valueFirst * valueSecond;
                    textBox1.Text = Result.ToString();
                    break;

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}