using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBitHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToggleButtons(bool enabled)
        {
            btnFlipBits.Enabled = enabled;
            btnSwapEndianness.Enabled = enabled;
            btnRightShift.Enabled = enabled;
            btnLeftShift.Enabled = enabled;
        }

        private string FormatBiinary(string input)
        {
            var list = Enumerable
                   .Range(0, input.Length / 4)
                   .Select(i => input.Substring(i * 4, 4))
                   .ToList();
            return string.Join(" ", list);
        }

        private void SetTextBoxes(ulong input)
        {
            txtDecimalValue.Text = input.ToString("N0");
            txtHexValue.Text = string.Format("0x{0}", input.ToString("X16").Replace("0x", ""));
            string binaryResult = Convert.ToString((long)input, 2).PadLeft(64, '0');
            txtBinary.Text = FormatBiinary(binaryResult);
        }


        #region Button Click Events
        private void btnConvertFromHex_Click(object sender, EventArgs e)
        {
            try
            {
                ulong decValue = Convert.ToUInt64(txtHexValue.Text, 16);
                SetTextBoxes(decValue);
                ToggleButtons(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Trying to parse hex value", "Parsing Error");
            }
        }

        private void btnConvertFromDecimal_Click(object sender, EventArgs e)
        {
            if (ulong.TryParse(txtDecimalValue.Text.Replace(",", ""), out ulong result))
            {
                SetTextBoxes(result);
                ToggleButtons(true);
            }
            else
            {
                MessageBox.Show("Error Trying to parse decimal value", "Parsing Error");
            }
        }

        private void btnConvertFromBinary_Click(object sender, EventArgs e)
        {
            try
            {
                ulong result = Convert.ToUInt64(txtBinary.Text, 2);
                SetTextBoxes(result);
                ToggleButtons(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to parse binary valye", "Parsing Error");
            }
        }

        private void btnSwapEndianness_Click(object sender, EventArgs e)
        {
            if (ulong.TryParse(txtDecimalValue.Text.Replace(",", ""), out ulong result))
            {
                result = (result >> 32) | (result << 32);
                // swap adjacent 16-bit blocks
                result = ((result & 0xFFFF0000FFFF0000) >> 16) | ((result & 0x0000FFFF0000FFFF) << 16);
                // swap adjacent 8-bit blocks
                result = ((result & 0xFF00FF00FF00FF00) >> 8) | ((result & 0x00FF00FF00FF00FF) << 8);
                SetTextBoxes(result);
                ToggleButtons(true);
            }
            else
            {
                MessageBox.Show("Input a decimal value", "Endianess swapping Error");
            }
        }

        private void btnFlipBits_Click(object sender, EventArgs e)
        {
            if (ulong.TryParse(txtDecimalValue.Text.Replace(",", ""), out ulong result))
            {
                result = ~result;
                SetTextBoxes(result);
                ToggleButtons(true);
            }
            else
            {
                MessageBox.Show("Input a decimal value", "Bit Flipping Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBinary.Text = string.Empty;
            txtDecimalValue.Text = string.Empty;
            txtHexValue.Text = string.Empty;
            txtShiftAmount.Text = string.Empty;
            txtUnsignedByte.Text = string.Empty;
            txtSignedByte.Text = string.Empty;
        }

        private void btnLeftShift_Click(object sender, EventArgs e)
        {
            if (ulong.TryParse(txtDecimalValue.Text.Replace(",", ""), out ulong result) &&
                byte.TryParse(txtShiftAmount.Text, out byte shiftAmount))
            {
                result = (result << shiftAmount);
                SetTextBoxes(result);
                ToggleButtons(true);
            }
            else
            {
                MessageBox.Show("Input a decimal value", "Bit Flipping Error");
            }
        }

        private void btnRightShift_Click(object sender, EventArgs e)
        {
            if (ulong.TryParse(txtDecimalValue.Text.Replace(",", ""), out ulong result) &&
                byte.TryParse(txtShiftAmount.Text, out byte shiftAmount))
            {
                result = (result >> shiftAmount);
                SetTextBoxes(result);
                ToggleButtons(true);
            }
            else
            {
                MessageBox.Show("Input a decimal value", "Bit Flipping Error");
            }
        }

        #endregion


        #region Text Changed Events
        private void OnTextChanged(object sender, EventArgs e)
        {
            ToggleButtons(false);
        }
        
        private void txtUnsignedByte_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnsignedByte.Text))
            {
                txtSignedByte.Text = string.Empty;
            }

            if (byte.TryParse(txtUnsignedByte.Text, out byte unsignedByte))
            {
                txtSignedByte.Text = ((sbyte)unsignedByte).ToString();
            }
            else
            {
                txtSignedByte.Text = string.Empty;
                txtUnsignedByte.Text = string.Empty;
            }
        }

        private void txtSignedByte_TextChanged(object sender, EventArgs e)
        {
            if (string.Equals(txtSignedByte.Text, "-"))
                return;
            if (string.IsNullOrWhiteSpace(txtSignedByte.Text))
                txtUnsignedByte.Text = string.Empty;

            if (sbyte.TryParse(txtSignedByte.Text, out sbyte signedByte))
                txtUnsignedByte.Text = ((byte)signedByte).ToString();
            else
            {
                txtSignedByte.Text = string.Empty;
                txtUnsignedByte.Text = string.Empty;
            }
        }
        #endregion
    }
}
