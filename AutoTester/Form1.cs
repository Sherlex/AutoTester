using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            methodComboBox.SelectedIndex = 0;
            TypeOfTestCasesComboBox.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Clear();
            string typeTestCases, method;
            double eps, leftBorder, rightBorder;
            string step;
            string input_for_test, arguments;
            string result_oracle;
            string result_starter;
            string message;
            int method_test;
            int amountTestCases = Convert.ToInt32(amountTestCasesTextBox.Text);
            typeTestCases = Convert.ToString(TypeOfTestCasesComboBox.Text);
            method = Convert.ToString(methodComboBox.Text);
            eps = Convert.ToDouble(epsTextBox.Text);
            leftBorder = Convert.ToDouble(leftBorderTextBox.Text);
            rightBorder = Convert.ToDouble(rightBorderTextBox.Text);
            step = stepTextBox.Text;
            if (method == "Парабол (Симпсона)")
                method_test = 1;
            else if (method == "Трапеций")
                method_test = 2;
            else
                method_test = 3;
                
            for (int i = 1; i < amountTestCases+1; i++)
            {
                arguments = Oracle.Generator(typeTestCases);
                int amount = arguments.Length;
                //парсить шаг 
                input_for_test = leftBorder.ToString() + " " + rightBorder.ToString() + " " + step
                    + " " + method_test + " " + arguments;

                if (typeTestCases == "Позитивный (+)")
                {
                    result_oracle = Oracle.PositiveTest(leftBorder, rightBorder, arguments).ToString();
                    result_starter = Starter.StartTest(input_for_test);
                    if (Comparator.Comparison(result_oracle, result_starter, typeTestCases, eps, amount))
                    {
                        message = "PASSED";
                    }
                    else
                    {
                        message = "NOT PASSED";
                    }

                    resultRichTextBox.Text += "TEST " + i + " POSITIVE\n" +
                    "Left border: " + leftBorder + "\nRight border: " + rightBorder +
                    "\nCoefficients: " + arguments + "\nStep: " + step + "\nMethod: " + method +
                    "\nEpsilon: " + eps + "\nIntegral3x: " + result_starter +
                    "\nOracle: S = " + result_oracle + "\n" + message + "\n\n\n";
                }
                else
                {
                    result_oracle = Oracle.NegativeTest(leftBorder, rightBorder, arguments);
                    result_starter = Starter.StartTest(input_for_test);
                    if(Comparator.Comparison(result_oracle, result_starter, typeTestCases, eps, amount))
                    {
                        message = "PASSED";
                    }
                    else
                    {
                        message = "NOT PASSED";
                    }
                    resultRichTextBox.Text += "TEST " + i + " NEGATIVE\n" +
                    "Left border: " + leftBorder + "\nRight border: " + rightBorder +
                    "\nCoefficients: " + arguments +
                    "\nStep: " + step + "\nMethod: " + method +
                    "\nEpsilon: " + eps + "\nIntegral3x: " + result_starter +
                    "\nOracle: S = " + result_oracle + "\n" + message + "\n\n\n";
                }
            }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((amountTestCasesTextBox.Text != "") && (epsTextBox.Text != "") && (leftBorderTextBox.Text != "") &&
                (rightBorderTextBox.Text != "") && (stepTextBox.Text != "") && (leftBorderTextBox.Text != "-") &&
                (Convert.ToDouble(amountTestCasesTextBox.Text) != 0) && (rightBorderTextBox.Text != "-") &&
                (Convert.ToDouble(epsTextBox.Text) != 0) && (Convert.ToDouble(stepTextBox.Text) != 0) && (Convert.ToDouble(leftBorderTextBox.Text) < Convert.ToDouble(rightBorderTextBox.Text)) &&
                (Convert.ToDouble(stepTextBox.Text) >= 0.000001) && (Convert.ToDouble(stepTextBox.Text) <= 0.5) &&
                (Convert.ToDouble(leftBorderTextBox.Text) >= double.MinValue) && (Convert.ToDouble(leftBorderTextBox.Text) <= double.MaxValue) &&
                (Convert.ToDouble(rightBorderTextBox.Text) >= double.MinValue) && (Convert.ToDouble(rightBorderTextBox.Text) <= double.MaxValue))
                startButton.Enabled = true;
                else startButton.Enabled = false;     
            }
            catch
            {
                MessageBox.Show("Переполнение типа данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void borderTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                if ((sender as TextBox).Text.IndexOf('-') > -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;           
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveResult = new SaveFileDialog();
            saveResult.Filter = "Текстовый файл(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if(saveResult.ShowDialog() == DialogResult.OK)
            {
                string filename = saveResult.FileName;
                File.WriteAllText(filename, resultRichTextBox.Text);
                MessageBox.Show("Файл сохранен!");
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Данная программа-тестировщик предназначена для автоматизированного " +
             "динамического тестирования приложения «Integral3x».\n\n",
             caption: "О программе",
             buttons: MessageBoxButtons.OK,
             icon: MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Корректные диапазоны величин можно увидеть при наведении на поле ввода.",
             caption: "О программе",
             buttons: MessageBoxButtons.OK,
             icon: MessageBoxIcon.Question);
        }
    }
}
