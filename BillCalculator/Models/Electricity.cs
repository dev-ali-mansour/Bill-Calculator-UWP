using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace BillCalculator.Models
{
    class Electricity
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
        public static void GetAmount(ToggleSwitch IsHomeToggleSw, TextBox PrevTextBox, TextBox CurTextBox, TextBox MonTextBox, ref TextBlock ConsTextBox, ref TextBlock AmountTextBox)
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
            // Home usage
            if (IsHomeToggleSw.IsOn == false)
            {
                /* Calculate Fees Here



                */
                // Calculate Consumption value
                if (IntMonthConsumption <= 100)
                {
                    if (IntMonthConsumption <= 50)
                    {
                        DoubleAmount = IntMonthConsumption * 0.075;
                    }
                    else
                    {
                        DoubleAmount = 3.75 + (IntMonthConsumption - 50) * 0.145;
                    }
                }
                else
                {
                    if (IntMonthConsumption <= 200)
                    {
                        DoubleAmount = IntMonthConsumption * 0.16;
                    }
                    else
                    {
                        if (IntMonthConsumption <= 350)
                        {
                            DoubleAmount = 32 + (IntMonthConsumption - 200) * 0.305;
                        }
                        else
                        {
                            if (IntMonthConsumption <= 650)
                            {
                                DoubleAmount = 77.75 + (IntMonthConsumption - 350) * 0.405;
                            }
                            else
                            {
                                if (IntMonthConsumption <= 1000)
                                {
                                    DoubleAmount = 199.25 + (IntMonthConsumption - 650) * 0.71;
                                }
                                else
                                {
                                    DoubleAmount = 447.75 + (IntMonthConsumption - 1000) * 0.84;
                                }
                            }
                        }
                    }
                }
            }
            // Commercial usage
            else
            {
                /* Calculate Fees Here



                */
                // Calculate Consumption value
                if (IntMonthConsumption <= 100)
                {
                    DoubleAmount = IntMonthConsumption * 0.32;
                }
                else
                {
                    if (IntMonthConsumption <= 250)
                    {
                        DoubleAmount = IntMonthConsumption * 0.5;
                    }
                    else
                    {
                        if (IntMonthConsumption <= 600)
                        {
                            DoubleAmount = 125 + (IntMonthConsumption - 250) * 0.61;
                        }
                        else
                        {
                            if (IntMonthConsumption <= 1000)
                            {
                                DoubleAmount = 388.5 + (IntMonthConsumption - 600) * 0.81;
                            }
                            else
                            {
                                DoubleAmount = 662.5 + (IntMonthConsumption - 1000) * 0.86;
                            }
                        }
                    }
                }
            }
            // Caculate Total Amount
            double DoubleTotalAmount = DoubleAmount * IntMonths + DoubleFees;
            AmountTextBox.Text = DoubleTotalAmount.ToString();
        }

    }
}
