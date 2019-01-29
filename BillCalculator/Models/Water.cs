using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace BillCalculator.Models
{
    class Water
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

        public static void GetAmount(int IntType, TextBox PrevTextBox, TextBox CurTextBox, TextBox MonTextBox, ref TextBlock ConsTextBox, ref TextBlock AmountTextBox)
        {
            // Count the monthly consumption
            int IntPrevious = FormatValue(PrevTextBox);
            int IntCurrent = FormatValue(CurTextBox);
            int IntMonths = FormatMonths(MonTextBox);
            int IntDif = 0;
            double DoubleAmount = 0;
            double DoubleFees = 0;
            // If the counter reached 10000 KWH it count from 0
            if (IntCurrent > IntPrevious)
            {
                IntDif = IntCurrent - IntPrevious;
            }
            else if (IntCurrent < IntPrevious)
            {
                IntDif = (10000 - IntPrevious) + IntCurrent;
            }
            ConsTextBox.Text = IntDif.ToString();
            int IntMonthConsumption = IntDif / IntMonths;
            if (IntType == 0)
            {
                /* Calculate Fees Here



                */
                // Calculate Consumption value
                if (IntMonthConsumption <= 10)
                {
                    DoubleAmount = IntMonthConsumption * 0.30;
                }
                else
                {
                    if (IntMonthConsumption <= 20)
                    {
                        DoubleAmount = 3 + (IntMonthConsumption - 10) * 0.7;
                    }
                    else
                    {
                        if (IntMonthConsumption <= 40)
                        {
                            DoubleAmount = 10 + (IntMonthConsumption - 20) * 1.05;
                        }
                        else
                        {
                            DoubleAmount = 31 + (IntMonthConsumption - 40) * 1.55;
                        }
                    }
                }
            }
            else if (IntType == 1)
            {
                DoubleAmount = IntMonthConsumption * 2;
            }
            else if (IntType == 2)
            {
                DoubleAmount = IntMonthConsumption * 1.8;
            }
            else if (IntType == 3)
            {
                DoubleAmount = IntMonthConsumption * 2.85;
            }
            else
            {
                DoubleAmount = IntMonthConsumption * 2.9;
            }
            // Caculate Total Amount
            double DoubleTotalAmount = DoubleAmount * IntMonths + DoubleFees;
            AmountTextBox.Text = DoubleTotalAmount.ToString();
        }
    }
}
