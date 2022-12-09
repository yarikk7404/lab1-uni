using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab1.Classes
{
    internal class Table
    {

        public static void Update()
        {
            isSetupped = false;
            dataGridView.Rows.Clear();

            if (modeValue)
            {
                for(int rowIndex = 0; rowIndex < tableValues.Count; rowIndex++)
                {
                    for(int columnIndex = 0; columnIndex < tableValues[rowIndex].Count; columnIndex++)
                    {
                        tableValues[rowIndex][columnIndex] = GetCellValue(rowIndex, columnIndex);
                    }
                }
                foreach (List <int> valuesRow in tableValues)
                {
                    string[] row = valuesRow.ToArray().Select(i => i.ToString()).ToArray();
                    dataGridView.Rows.Add(row);
                }
            }
            else
            {
                foreach (List<string> dataRow in tableData)
                {
                    dataGridView.Rows.Add(dataRow.ToArray());
                }
            }
            dataGridView.Rows[0].HeaderCell.Value = "1";
            dataGridView.Rows[1].HeaderCell.Value = "2";
            dataGridView.Rows[2].HeaderCell.Value = "3";
            dataGridView.Rows[3].HeaderCell.Value = "4";
            dataGridView.Rows[4].HeaderCell.Value = "5";
            dataGridView.Rows[5].HeaderCell.Value = "6";
            dataGridView.Rows[6].HeaderCell.Value = "7";
            dataGridView.Rows[7].HeaderCell.Value = "8";
            isSetupped = true;
        }

        public static void SetupDataGridView()
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 8;
            dataGridView.RowCount = 8;
            dataGridView.Columns[0].Name = "A";
            dataGridView.Columns[1].Name = "B";
            dataGridView.Columns[2].Name = "C";
            dataGridView.Columns[3].Name = "D";
            dataGridView.Columns[4].Name = "E";
            dataGridView.Columns[5].Name = "F";
            dataGridView.Columns[6].Name = "G";
            dataGridView.Columns[7].Name = "H";
            dataGridView.Rows[0].HeaderCell.Value = "1";
            dataGridView.Rows[1].HeaderCell.Value = "2";
            dataGridView.Rows[2].HeaderCell.Value = "3";
            dataGridView.Rows[3].HeaderCell.Value = "4";
            dataGridView.Rows[4].HeaderCell.Value = "5";
            dataGridView.Rows[5].HeaderCell.Value = "6";
            dataGridView.Rows[6].HeaderCell.Value = "7";
            dataGridView.Rows[7].HeaderCell.Value = "8";
            for(int i = 0; i < dataGridView.RowCount; i++)
            {
                tableData.Add(new List<string> { "", "", "", "", "", "", "", "" });
                tableValues.Add(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 });
            }
            isSetupped = true;
        }

        public static void ResetCell(int rowIndex, int columnIndex)
        {
            cellResetted = true;
            if (modeValue)
            {
                if(tableValues[rowIndex][columnIndex].ToString() != "0")
                {
                    dataGridView.Rows[rowIndex].Cells[columnIndex].Value =
                        tableValues[rowIndex][columnIndex].ToString();
                }
                else
                {
                    dataGridView.Rows[rowIndex].Cells[columnIndex].Value = "";
                }
            }
            else
            {
                dataGridView.Rows[rowIndex].Cells[columnIndex].Value =
                    tableData[rowIndex][columnIndex];
            }
        }

        public static int GetCellValue(int rowIndex, int columnIndex)
        {
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                var cellValue = tableData[rowIndex][columnIndex];
                if (cellValue == "")
                {
                    return 0;
                }
                Calculator.depth++;
                int numValue = Calculator.CalculateValue(cellValue);
                Calculator.depth = 0;
                return numValue;
            }
            return 0;
        }

        public static bool CheckCell(int rowIndex, int columnIndex)
        {
            if(rowIndex >= 0 && columnIndex >= 0)
            {
                var cellValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
                return Validator.AllConditionsCheck(cellValue + "");
            }
            return true;
        }

        public static void SaveCell(int rowIndex, int columnIndex)
        {
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                tableData[rowIndex][columnIndex] = dataGridView.Rows[rowIndex].Cells[columnIndex].Value + "";
                tableValues[rowIndex][columnIndex] = GetCellValue(rowIndex, columnIndex);
            }
        }

        public static void ClearAll()
        {
            tableData.Clear();
            tableValues.Clear();
            dataGridView.Rows.Clear();
            isSetupped = false;
        }

        public static List<List<string>> tableData = new List<List<string>>();
        public static List<List<int>> tableValues = new List<List<int>>();
        public static DataGridView dataGridView = new DataGridView();
        public static bool modeValue = false;
        public static bool isSetupped = false;
        public static bool cellResetted = false;    

        public const string DESERIALIZE_PATH = @".\data.json";
        public const string SERIALIZE_PATH = @".\result.json";
        public const string EXPORT_PATH = @".\output.txt";
        public const string IMPORT_PATH = @".\input.txt";
    }
}
