using System;


namespace AutoTester
{
    public static class Oracle
    {
        public static string Generator(string testType)
        {
            Random rnd = new Random();
            if (testType == "Позитивный (+)")
            {
                int amount = rnd.Next(1, 16);
                string coefficients_string = string.Empty;
                for (int i = 0; i < amount; i++)
                {
                    if (i == 0)
                    {
                        coefficients_string += Math.Round(rnd.Next(-100, 101) + rnd.NextDouble(), 3).ToString();
                    }
                    else
                    {
                        coefficients_string += ' '+ Math.Round(rnd.Next(-100, 101) + rnd.NextDouble(), 3).ToString();
                    }
                }
                return coefficients_string;
            }
            else
            {
                string coefficients_string = string.Empty;
                int amount = rnd.Next(0, 16);
                string[] coefficients = new string[amount];
                string[] wrong_format = new string[5] { double.MaxValue.ToString(), "NaN", double.MinValue.ToString(), "0,15", "*" };
                if (amount != 0)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        coefficients[i] = Math.Round(rnd.Next(-100, 101) + rnd.NextDouble(), 3).ToString();
                    }
                    int j = rnd.Next(0, amount);
                    int wrong = rnd.Next(0, 5);
                    coefficients[j] = wrong_format[wrong];
                    coefficients_string = string.Join(" ", coefficients);
                    return coefficients_string;
                }
                else
                {
                    return coefficients_string;
                }
            }

        }

        public static double PositiveTest(double left, double right, string arguments_string)
        {
            double result = 0;
            string[] arguments = arguments_string.Split(' ');
            int amount = arguments.Length;
            double[] coefficients = new double[amount];
            for (int i = 0; i < amount; i++)
            {
                coefficients[i] = Convert.ToDouble(arguments[i]);
            }
            for (int i = 0; i < amount; i++)
            {
                result += coefficients[i] * ((Math.Pow(right, i + 1) / (i + 1)) - (Math.Pow(left, i + 1) / (i + 1)));
            }
            return result;
        }
        public static string NegativeTest(double left, double right, string arguments_string)
        {
            string result_string;
            double result = 0;
            string[] coefficients_string;
            if (arguments_string.Length == 0)
            {
                result_string = "Число параметров не соответствует ожидаемому и должно быть, как минимум 5!\r\n";
                return result_string;
            }
            else
            {
                coefficients_string = arguments_string.Split(' ');
                int amount = coefficients_string.Length;
                double[] coefficients = new double[amount];  
                for (int i = 0; i < amount; i++)
                {
                    if (!double.TryParse(coefficients_string[i], out coefficients[i]))
                        coefficients[i] = 0;
                    result += coefficients[i] * ((Math.Pow(right, i + 1) / (i + 1)) - (Math.Pow(left, i + 1) / (i + 1)));
                }
                return result.ToString();
            }
           
        }

    }
}