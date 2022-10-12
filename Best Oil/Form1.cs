using System.Data;
using System.Text.RegularExpressions;
#nullable disable

namespace Best_Oil
{
    public partial class Form1 : Form
    {
        string gasquantityPattern = @"^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$";
        string cafequantityPattern = "^[0-9]*$";

        public Form1()
        {
            InitializeComponent();
        }

        private void GasolineCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantitySumGB.Enabled = true;
            switch (GasolineCB.SelectedIndex)
            {
                case 0:
                    PriceTB.Text = "1.00";
                    break;
                case 1:
                    PriceTB.Text = "2.00";
                    break;
                case 2:
                    PriceTB.Text = "2.30";
                    break;
            }
            SumInput.Text = string.Empty;
            QuantityInput.Text = string.Empty;
            GasPayLabel.Text = "0.00";
        }

        private void GasolineRB_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                if (rb.Name == QuantityRB.Name)
                {
                    QuantityInput.Enabled = true;
                    SumInput.Enabled = false;
                    SumInput.Text = String.Empty;
                    GasPayLabel.Text = "0.00";
                }
                else if (rb.Name == SumRB.Name)
                {
                    QuantityInput.Enabled = false;
                    SumInput.Enabled = true;
                    QuantityInput.Text = String.Empty;
                    GasPayLabel.Text = "0.00";
                }
            }
        }

        private void GasolineCB_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            cb.Text = String.Empty;

            if (cb.Text == String.Empty)
            {
                PriceTB.Text = String.Empty;
                QuantitySumGB.Enabled = false;
            }
        }

        private void QuantityInput_TextChanged(object sender, EventArgs e)
        {
            Regex rg = new Regex(gasquantityPattern);
            TextBox tb = sender as TextBox;
            if (!rg.IsMatch(tb.Text))
            {
                tb.Text = String.Empty;
                GasPayLabel.Text = "0.00";
            }
            else
            {
                string totalPrice = PriceTB.Text + '*' + QuantityInput.Text;
                double result = double.Parse(new DataTable().Compute(totalPrice, null).ToString()!);
                GasPayLabel.Text = result.ToString("0.00");
            }

            if (string.IsNullOrWhiteSpace(tb.Text))
                GasPayLabel.Text = "0.00";
        }

        private void SumInput_TextChanged(object sender, EventArgs e)
        {

            Regex rg = new Regex(gasquantityPattern);
            TextBox tb = sender as TextBox;
            if (!rg.IsMatch(tb.Text))
            {
                tb.Text = String.Empty;
                GasPayLabel.Text = "0.00";
            }
            else
                GasPayLabel.Text = tb.Text;
        }

        private void CafeQuantity_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new(cafequantityPattern);
            TextBox textBox = sender as TextBox;
            double totalPrice = 0;
            if (!regex.IsMatch(textBox.Text))
                textBox.Text = String.Empty;

            foreach (var item in UserQuantityPanel.Controls)
            {
                TextBox tb = item as TextBox;
                if (!string.IsNullOrWhiteSpace(tb.Text))
                    totalPrice += double.Parse(new DataTable().Compute($"{tb.Text} * {(tb.Tag as TextBox).Text}", null).ToString()!);
            }

            CafePayLabel.Text = totalPrice.ToString("0.00");
        }

        private void CafeCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            TextBox tb = chk.Tag as TextBox;
            if (chk.Checked)
                tb.Enabled = true;
            else
            {
                tb.Text = String.Empty;
                tb.Enabled = false;
            }
        }

        private void PayLabel_TextChanged(object sender, EventArgs e) => TotalAmountLabel.Text = double.Parse(new DataTable().Compute($"{GasPayLabel.Text} + {CafePayLabel.Text}", null).ToString()).ToString("0.00");

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show($"Are you willing to pay ${TotalAmountLabel.Text}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                MessageBox.Show($"You paid ${TotalAmountLabel.Text}!", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void QuantitySumGB_EnabledChanged(object sender, EventArgs e)
        {
            if (!(sender as GroupBox).Enabled)
            {
                GasPayLabel.Text = "0.00";
                SumInput.Text = String.Empty;
                QuantityInput.Text = String.Empty;
            }
        }
    }
}