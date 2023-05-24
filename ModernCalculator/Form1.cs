using System.Diagnostics.Eventing.Reader;

namespace ModernCalculator
{
    public partial class Form1 : Form
    {

        Double result = 0;
        string operation = string.Empty;
        string num1, num2;
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (txtFinal1.Text == "0" || enterValue) txtFinal1.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (txtFinal1.Text.Contains("."))
                    return;
   
            }
            txtFinal1.Text = txtFinal1.Text + button.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = txtFinal1.Text;
            txtFinal2.Text = $"{txtFinal2.Text}{txtFinal1.Text}";
            if (txtFinal1.Text != string.Empty)
            {
                if (txtFinal1.Text == "0") txtFinal2.Text = string.Empty;
                switch (operation)
                {

                    case "+":
                        txtFinal1.Text = (result + Double.Parse(txtFinal1.Text)).ToString();
                        break;
                    case "-":
                        txtFinal1.Text = (result - Double.Parse(txtFinal1.Text)).ToString();
                        break;
                    case "x":
                        txtFinal1.Text = (result * Double.Parse(txtFinal1.Text)).ToString();
                        break;
                    case "/":

                        if (txtFinal1.Text == "0")
                        {
                            txtFinal2.Text = "you cant device by 0";
                        }
                        else
                        {
                            txtFinal1.Text = (result / Double.Parse(txtFinal1.Text)).ToString();
                        }

                        break;
                    default:
                        txtFinal2.Text = $"{txtFinal1.Text}";
                        
                        break;
                }

                result = Double.Parse(txtFinal1.Text);
                operation = string.Empty;
               


            }
        }

        private void btnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) btnEquals.PerformClick();
            else result = Double.Parse(txtFinal1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (txtFinal1.Text != "0")
            {
                txtFinal2.Text = num1 = $"{result}{operation}";
                txtFinal1.Text = string.Empty;
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtFinal1.Text.Length > 0)

                txtFinal1.Text = txtFinal1.Text.Remove(txtFinal1.Text.Length - 1, 1);
            if (txtFinal1.Text == string.Empty) txtFinal1.Text = "0";


        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtFinal1.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFinal1.Text = "0";
            txtFinal2.Text = "0";
            result = 0;

        }

        private void btnOperations(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√":
                    txtFinal2.Text = $"√({txtFinal1.Text})";
                    txtFinal1.Text = Convert.ToString(Math.Sqrt(Double.Parse(txtFinal1.Text)));
                    break;

                case "x^2":
                    txtFinal2.Text = $"({txtFinal1.Text})x^2";
                    txtFinal1.Text = Convert.ToString(Convert.ToDouble(txtFinal1.Text) * Convert.ToDouble(txtFinal1.Text));
                    break;
                case "⅟x":
                    txtFinal2.Text = $"({txtFinal1.Text})⅟x";
                    txtFinal1.Text = Convert.ToString(1.0 / Convert.ToDouble(txtFinal1.Text));

                    break;
                case "%":
                    txtFinal2.Text = $"({txtFinal1.Text})%";
                    txtFinal1.Text = Convert.ToString(Convert.ToDouble(txtFinal1.Text) / Convert.ToDouble(100));
                    break;
                case "+/-":
                    txtFinal2.Text = $"({txtFinal1.Text}+/-";
                    txtFinal1.Text = Convert.ToString(-1 * Convert.ToDouble(txtFinal1.Text));
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFinal2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}