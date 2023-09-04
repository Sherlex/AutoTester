using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace AutoTester
{
    public static class Starter
    {
        public static string StartTest(string coefficients)
        {
            //string result;
            Process Test = new Process();
            Test.StartInfo.FileName = @"Integral3x.exe";
            Test.StartInfo.Arguments = coefficients;
            Test.StartInfo.RedirectStandardOutput = true;
            Test.StartInfo.RedirectStandardInput = true;
            Test.StartInfo.UseShellExecute = false;
            Test.StartInfo.CreateNoWindow = true;
            Test.Start();
            StringBuilder sb = new StringBuilder();
            string result;
            char symbol;
            while (!Test.StandardOutput.EndOfStream)
            {
                symbol = (char)Test.StandardOutput.Peek();
                if (symbol == '„')
                {
                    Test.StandardInput.Write(Key.Enter);
                    break;
                }
                string buffer = Test.StandardOutput.ReadLine();
                sb.AppendLine(buffer);
            }
            result = sb.ToString();
            return result;

        }
    }

}