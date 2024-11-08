using System;
using System.Windows.Forms;

namespace alg_lab_3
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //int key = int.Parse(KeyTextBox.Text);
            //string data = DataTextBox.Text;
            //dbManager.AddRecord(key, data);
        }
    }

}