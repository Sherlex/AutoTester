using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace AutoTester
{
    public static class Comparator
    {
        public static bool Comparison(string resultOracle_string, string resultStarter_string, string testType, double eps, int amount)
        {
            if (testType == "Позитивный (+)")
            {
                resultStarter_string = resultStarter_string.Substring(4, resultStarter_string.Length - 5);
                resultStarter_string = resultStarter_string.Trim(new char [] { '\r'});
                double resultStarter = double.Parse(resultStarter_string, System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.Float, 
                    System.Globalization.CultureInfo.InvariantCulture);
                double resultOracle = Convert.ToDouble(resultOracle_string);
                if (Math.Abs(resultStarter - resultOracle) <= eps)
                {
                    return true;
                }
                else
                    return false;
            } 
            else
            {
                if (amount != 0)
                {
                    resultStarter_string = resultStarter_string.Substring(4, resultStarter_string.Length - 5);
                    resultStarter_string = resultStarter_string.Trim(new char[] { '\r', '\n', 'S', ' ', '=' });
                    double resultStarter;
                    try
                    {
                        resultStarter = double.Parse(resultStarter_string, System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.Float,
                        System.Globalization.CultureInfo.InvariantCulture);
                        double resultOracle = Convert.ToDouble(resultOracle_string);
                        if (Math.Abs(resultStarter - resultOracle) <= eps)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                    catch
                    {
                        if (resultStarter_string == resultOracle_string)
                            return true;
                        else
                            return false;
                    }
                }
                else
                {
                    if (resultStarter_string == resultOracle_string)
                        return true;
                    else
                        return false;
                }
                
            }
        }

    }

}