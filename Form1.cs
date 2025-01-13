using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTable(Business.GetNames());
            SetTotal(Business.GetTotal().ToString());

        }

        private void PopulateTable(DataTable table)
        {
            dataGridView1.DataSource = table;
        }

        private void SetTotal(String labelstring)
        {
            label1.Text = labelstring;
        }
    }
}
