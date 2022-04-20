namespace clacultor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool turn = false;
        double prev = 0;
        double total1 = 0;
        double total2 = 0;
        bool first = true;
        string i = "";
        void changeTurn(string x)
        {
            if (!first)
            {
                if (x == "+")
                {
                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev += total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }

                }
                else if (x == "*")
                {

                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev *= total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                }
                else if (x == "-")
                {
                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev -= total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                }
                else if (x == "/")
                {
                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        label3.Text = prev.ToString() + " " + x;
                        prev /= total1;
                        i = x;
                        label1.Text = "";
                    }
                }
            }
            else
            {
                if (x == "+")
                {
                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev = total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                        first = false;
                    }

                }
                else if (x == "*")
                {

                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev = total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                        first = false;
                    }
                }
                else if (x == "-")
                {
                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev = total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                        first = false;

                    }
                }
                else if (x == "/")
                {
                    if (label1.Text.Length == 0 || label1.Text == "")
                    {

                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                    }
                    else
                    {
                        total1 = double.Parse(label1.Text);
                        prev = total1;
                        label3.Text = prev.ToString() + " " + x;
                        i = x;
                        label1.Text = "";
                        first = false;
                    
                    }
                

            }
        }
            turn = true;
        }
        void change(double a)
        {
            if(!turn)
            {
                if (label1.Text.Length + 1 < 9)
                {
                    label1.Text += a.ToString();

                }
                else
                {
                    string temp = label1.Text;
                    label1.Text = "max Value reached";
                    Task.Delay(1000);
                    label1.Text = temp;
                }
            }
            else
            {
                if (label1.Text.Length + 1 < 9)
                {
                    label1.Text += a.ToString();

                }
                else
                {
                    string temp = label1.Text;
                    label1.Text = "max Value reached";
                    Task.Delay(1000);
                    label1.Text = temp;
                }
            }
            
        }
        private void button11_Click(object sender, EventArgs e)
        { changeTurn("*"); }
        private void button2_Click(object sender, EventArgs e)
        { change(2); }
        private void button3_Click(object sender, EventArgs e)
        { change(3); }
        private void button4_Click(object sender, EventArgs e)
        { change(4); }
        private void button5_Click(object sender, EventArgs e)
        { change(5); }
        private void button6_Click(object sender, EventArgs e)
        { change(6); }
        private void button7_Click(object sender, EventArgs e)
        { change(7); }
        private void button8_Click(object sender, EventArgs e)
        { change(8); }
        private void button9_Click(object sender, EventArgs e)
        { change(9); }
        private void button10_Click(object sender, EventArgs e)
        { change(0); }
        private void button1_Click(object sender, EventArgs e)
        { change(1); }
        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            changeTurn("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            if(i=="+")
            {
                if(label1.Text.Length == 0 || label1.Text == "")
                {
                    label1.Text = prev.ToString();
                }
                else
                {
                    total2 = double.Parse(label1.Text);
                    label1.Text = (prev + total2).ToString();
                }
            }
            else if (i=="*")
            {
                if (label1.Text.Length == 0 || label1.Text == "")
                {
                    label1.Text = prev.ToString();
                }
                else
                {
                    total2 = double.Parse(label1.Text);
                    label1.Text = (prev * total2).ToString();
                }
            }
            else if (i == "/")
            {
                if (label1.Text.Length == 0 || label1.Text == "")
                {
                    label1.Text = prev.ToString();
                }
                else
                {
                    total2 = double.Parse(label1.Text);
                    label1.Text = (prev / total2).ToString();
                }
            }
            else if (i == "-")
            {
                if (label1.Text.Length == 0 || label1.Text == "")
                {
                    label1.Text = prev.ToString();
                }
                else
                {
                    total2 = double.Parse(label1.Text);
                    label1.Text = (prev - total2).ToString();
                }
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            changeTurn("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            changeTurn("-");
        }
    }
}
