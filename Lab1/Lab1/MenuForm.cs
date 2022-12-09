using Lab1.Classes;

namespace Lab1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table.isSetupped = false;
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}