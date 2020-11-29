using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numbuffer = "";
        string opbuffer = "";
        double tmp = 0;
        Boolean isNewValue = true;

        private void specialButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double num;
            switch(button.Name)
            {
                case "clear":
                    textBox1.Text = "";
                    tmp = 0;
                    numbuffer = "";
                    opbuffer = "";
                    isNewValue = true;
                    break;
                case "root":
                    if (numbuffer == "") return;
                    num = double.Parse(numbuffer);
                    numbuffer = Math.Sqrt(num).ToString();
                    break;
                case "percent":
                    if (opbuffer == "" || numbuffer == "") return;
                    num = tmp * double.Parse(numbuffer) / 100;
                    numbuffer = num.ToString();
                    break;
            }
        }

        private void numButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isNewValue)
            {
                if (button.Name == "point") return;
                textBox1.Text = "";
                numbuffer = "";
                isNewValue = false;
            }
            textBox1.Text += button.Text;
            numbuffer += button.Text;
        }

        private void operatorButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (numbuffer == "") return;
            if (opbuffer == "")
            {
                tmp = double.Parse(numbuffer);
                if (button.Name == "calculate")
                   textBox1.Text = tmp.ToString();
                isNewValue = true;
                if(button.Name != "calculate")
                    opbuffer = button.Text;
            }
            else
            {
                if(button.Name == "calculate")
                {
                    switch (opbuffer)
                    {
                        case "+":
                            tmp += double.Parse(numbuffer);
                            break;
                        case "-":
                            tmp -= double.Parse(numbuffer);
                            break;
                        case "*":
                            tmp *= double.Parse(numbuffer);
                            break;
                        case "/":
                            tmp /= double.Parse(numbuffer);
                            break;
                    }
                    textBox1.Text = tmp.ToString();
                    numbuffer = tmp.ToString();
                    opbuffer = "";
                    isNewValue = true;
                    return;
                }

                switch (opbuffer)
                {
                    case "+":
                        tmp += double.Parse(numbuffer);
                        break;
                    case "-":
                        tmp -= double.Parse(numbuffer);
                        break;
                    case "*":
                        tmp *= double.Parse(numbuffer);
                        break;
                    case "/":
                        tmp /= double.Parse(numbuffer);
                        break;
                }
                numbuffer = "";
                isNewValue = true;
                opbuffer = button.Text;
            }
        }
    }
}
