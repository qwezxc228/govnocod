namespace govnocod
{
    public partial class Form1 : Form
    {
        string chislo;
        string Znak;
        bool pereklicka = false;
        string num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "7";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "7";
                textBox2.Text = chislo;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "8";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "8";
                textBox2.Text = chislo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "9";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "9";
                textBox2.Text = chislo;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "4";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "4";
                textBox2.Text = chislo;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "5";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "5";
                textBox2.Text = chislo;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "6";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "6";
                textBox2.Text = chislo;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "1";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "1";
                textBox2.Text = chislo;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "2";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "2";
                textBox2.Text = chislo;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "3";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "3";
                textBox2.Text = chislo;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (pereklicka == false)
            {
                chislo += "0";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "0";
                textBox2.Text = chislo;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Znak += "/";
            textBox4.Text = "/";
            pereklicka = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Znak += "*";
            textBox4.Text = "*";
            pereklicka = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Znak += "-";
            textBox4.Text = "-";
            pereklicka = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Znak += "+";
            textBox4.Text = "+";
            pereklicka = true;
        }

        int chislo1;
        int chislo2;
        int otVet;
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                switch (Znak)
                {
                    case "+":
                        if (textBox1.Text != "" && textBox2.Text != "")
                        {
                            chislo1 = int.Parse(textBox1.Text);
                            chislo2 = int.Parse(textBox2.Text);
                            otVet = chislo1 + chislo2;
                            textBox3.Text = otVet.ToString();
                        }
                        else
                        {
                            textBox3.Text = "OSHIBKA";
                        }
                        break;
                    case "-":
                        if (textBox1.Text != "" && textBox2.Text != "")
                        {
                            chislo1 = int.Parse(textBox1.Text);
                            chislo2 = int.Parse(textBox2.Text);
                            otVet = chislo1 - chislo2;
                            textBox3.Text = otVet.ToString();
                        }
                        else
                        {
                            textBox3.Text = "OSHIBKA";
                        }
                        break;
                    case "*":
                        if (textBox1.Text != "" && textBox2.Text != "")
                        {
                            chislo1 = int.Parse(textBox1.Text);
                            chislo2 = int.Parse(textBox2.Text);
                            otVet = chislo1 * chislo2;
                            textBox3.Text = otVet.ToString();
                        }
                        else
                        {
                            textBox3.Text = "OSHIBKA";
                        }
                        break;
                    case "/":
                        if (textBox1.Text != "" && textBox2.Text != "")
                        {
                            chislo1 = int.Parse(textBox1.Text);
                            chislo2 = int.Parse(textBox2.Text);
                            otVet = chislo1 / chislo2;
                            textBox3.Text = otVet.ToString();
                        }
                        else
                        {
                            textBox3.Text = "OSHIBKA";
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chislo = "";
            chislo1 = 0;
            chislo2 = 0;
            otVet = 0;
            Znak = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            num2 = "";
            pereklicka = false;
        }
    }
}
