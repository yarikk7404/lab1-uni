using Lab1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Table.ClearAll();
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Table.dataGridView = mainDataGridView;
            Table.SetupDataGridView();
        }

        private void mode1Button_Click(object sender, EventArgs e)
        {
            Table.modeValue = false;
            Table.Update();
        }

        private void mode2Button_Click(object sender, EventArgs e)
        {
            Table.modeValue = true;
            Table.Update();
        }

        private void mainDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(Table.isSetupped && !Table.cellResetted)
            {
                var rowIndex = e.RowIndex;
                var columnIndex = e.ColumnIndex;
                if(Table.modeValue)
                {
                    Table.ResetCell(rowIndex, columnIndex);
                    MessageBox.Show("Не можна змінювати поля в режимі значень", "Невдача");
                }
                else if(Table.CheckCell(rowIndex, columnIndex))
                {
                    Table.SaveCell(rowIndex, columnIndex);
                }
                else
                {
                    Table.ResetCell(rowIndex, columnIndex);
                    MessageBox.Show(
                        "Помилка вводу. " +
                        "Допустимі символи: цілі числа, круглі дужки, імена клітинок, " +
                        "операції +, - (унарні), ^, max, min, mmax, mmin", "Невдача");
                }
            }
            else
            {
                Table.cellResetted = false;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
