using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace BillCalculator.Models
{
    class Gas
    {
        private static int FormatValue(TextBox ValueTextBox)
        {           
            // Format TextBoxs Text
            int IntDigit;
            try
            {
                if (ValueTextBox.Text == null || ValueTextBox.Text == "")
                {
                    ValueTextBox.Text = "0";
                }
                IntDigit = int.Parse(ValueTextBox.Text);
            }
            catch (Exception)
            {
                ValueTextBox.Text = "0";
                IntDigit = 0;
            }
            return IntDigit;
        }
        private static int FormatMonths(TextBox MonthesTextBox)
        {
            // Format TextBoxs Text
            int IntDigit;
            try
            {
                if (MonthesTextBox.Text == null || MonthesTextBox.Text == "")
                {
                    MonthesTextBox.Text = "1";
                }
                IntDigit = int.Parse(MonthesTextBox.Text);
            }
            catch (Exception)
            {
                MonthesTextBox.Text = "1";
                IntDigit = 1;
            }
            return IntDigit;
        }


        public static void GetAmount(TextBox PrevTextBox, TextBox CurTextBox, TextBox MonTextBox, ref TextBlock ConsTextBox, ref TextBlock AmountTextBox)
        {
            // Count the monthly consumption
            int IntPrevious = FormatValue(PrevTextBox);
            int IntCurrent = FormatValue(CurTextBox);
            int IntMonths = FormatMonths(MonTextBox);
            int IntDif = 0;
            double DoubleAmount = 0;
            double DoubleFees = 0;
            // If the counter reached 10000 KWH it count from 0
            //if (IntCurrent > IntPrevious)
            //{
            IntDif = IntCurrent - IntPrevious;
            //}
            //else if (IntCurrent < IntPrevious)
            //{
            //    IntDif = (10000 - IntPrevious) + IntCurrent;
            //}
            ConsTextBox.Text = IntDif.ToString();
            int IntMonthConsumption = IntDif / IntMonths;
            // Home usage
            /* Calculate Fees Here



            */
            // Calculate Consumption value
            if (IntMonthConsumption <= 25)
            {

                DoubleAmount = IntMonthConsumption * 0.4;

            }
            else
            {
                if (IntMonthConsumption <= 50)
                {
                    DoubleAmount = 10 + IntMonthConsumption;
                }
                else
                {
                    DoubleAmount = 35 + (IntMonthConsumption - 50) * 1.5;
                }
            }
            // Caculate Total Amount
            double DoubleTotalAmount = DoubleAmount * IntMonths + DoubleFees;
            AmountTextBox.Text = DoubleTotalAmount.ToString();
        }
    }
}
