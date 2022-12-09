using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    internal class Calculator
    {
        public static int depth = 0;
        public static int CalculateValue(string expression)
        {
            if (Validator.NumbersCheck(expression))
            {
                return int.Parse(expression);
            }
            if (expression.Contains('^'))
            {
                List<string> partExpressions = new List<string>();
                int openBracketsCount = 0;
                int lastEndIndex = 0;
                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] == '(')
                    {
                        openBracketsCount++;
                        continue;
                    }
                    if (expression[i] == ')')
                    {
                        openBracketsCount--;
                    }
                    if (expression[i] == '^' && openBracketsCount == 0)
                    {
                        partExpressions.Add(expression[lastEndIndex..i]);
                        lastEndIndex = i + 1;
                    }
                }
                partExpressions.Add(expression[lastEndIndex..(expression.Length - 1)]);

                //dataGridView.Rows.Add(partExpressions.ToArray());

                var result = CalculateValue(partExpressions[partExpressions.Count - 1]);
                for (int i = partExpressions.Count - 2; i >= 0; i--)
                {
                    result = (int)Math.Pow(
                        CalculateValue(partExpressions[i]),
                        result
                        );
                }
                return result;
            }
            try
            {
                if (expression[0..5] == "mmin(" && expression[expression.Length - 1] == ')')
                {
                    List<string> mminExpressions = new List<string>();
                    int openBracketsCount = 1;
                    int lastEndIndex = 5;
                    for (int i = 5; i < expression.Length; i++)
                    {
                        if (expression[i] == '(')
                        {
                            openBracketsCount++;
                            continue;
                        }
                        if (expression[i] == ')')
                        {
                            openBracketsCount--;
                        }
                        if (expression[i] == ',' && openBracketsCount == 1)
                        {
                            mminExpressions.Add(expression[lastEndIndex..i]);
                            lastEndIndex = i + 1;
                        }
                    }
                    mminExpressions.Add(expression[lastEndIndex..(expression.Length - 1)]);

                    var result = CalculateValue(mminExpressions[mminExpressions.Count - 1]);
                    for (int i = mminExpressions.Count - 2; i >= 0; i--)
                    {
                        result = Math.Min(
                            CalculateValue(mminExpressions[i]),
                            result
                            );
                    }
                    return result;
                }
                if (expression[0..5] == "mmax(" && expression[expression.Length - 1] == ')')
                {
                    List<string> mminExpressions = new List<string>();
                    int openBracketsCount = 1;
                    int lastEndIndex = 5;
                    for (int i = 5; i < expression.Length; i++)
                    {
                        if (expression[i] == '(')
                        {
                            openBracketsCount++;
                            continue;
                        }
                        if (expression[i] == ')')
                        {
                            openBracketsCount--;
                        }
                        if (expression[i] == ',' && openBracketsCount == 1)
                        {
                            mminExpressions.Add(expression[lastEndIndex..i]);
                            lastEndIndex = i + 1;
                        }
                    }
                    mminExpressions.Add(expression[lastEndIndex..(expression.Length - 1)]);

                    var result = CalculateValue(mminExpressions[mminExpressions.Count - 1]);
                    for (int i = mminExpressions.Count - 2; i >= 0; i--)
                    {
                        result = Math.Max(
                            CalculateValue(mminExpressions[i]),
                            result
                            );
                    }
                    return result;
                }
                if (expression[0..4] == "min(" && expression[expression.Length - 1] == ')')
                {
                    int openBracketsCount = 1;
                    for (int i = 4; i < expression.Length; i++)
                    {
                        if (expression[i] == '(')
                        {
                            openBracketsCount++;
                            continue;
                        }
                        if (expression[i] == ')')
                        {
                            openBracketsCount--;
                        }
                        if (expression[i] == ',' && openBracketsCount == 1)
                        {
                            return Math.Min(
                                CalculateValue(expression[4..i]),
                                CalculateValue(expression[(i + 1)..(expression.Length - 1)])
                                );
                        }
                    }
                }
                if (expression[0..4] == "max(" && expression[expression.Length - 1] == ')')
                {
                    int openBracketsCount = 1;
                    for (int i = 4; i < expression.Length; i++)
                    {
                        if (expression[i] == '(')
                        {
                            openBracketsCount++;
                            continue;
                        }
                        if (expression[i] == ')')
                        {
                            openBracketsCount--;
                        }
                        if (expression[i] == ',' && openBracketsCount == 1)
                        {
                            return Math.Max(
                                CalculateValue(expression[4..i]),
                                CalculateValue(expression[(i + 1)..(expression.Length - 1)])
                                );
                        }
                    }
                }
                if (expression[0] == '+')
                {
                    return CalculateValue(expression[1..]);
                }
                if (expression[0] == '-')
                {
                    return -CalculateValue(expression[1..]);
                }
            }
            catch (Exception ex)
            {

            }
            try
            {

                if (expression[0] >= 'A' && expression[0] <= 'H')
                {
                    if (depth > 10) 
                    {
                        MessageBox.Show("Помилка зациклювання. Змініть вирази, або в клітинках з зациклюванням будуть нулі.", "Помилка");
                        throw new Exception();
                    }
                    int columnIndex = expression[0] - 'A';
                    int rowIndex = expression[1] - '1';
                    return Table.GetCellValue(rowIndex, columnIndex);
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

            return 0;
        }
    }
}
