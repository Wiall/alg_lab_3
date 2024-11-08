using System;
using System.Collections.Generic;
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
            int key = int.Parse(KeyTextBox.Text);
            string data = DataTextBox.Text;
            dbManager.AddRecord(key, data);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int key = int.Parse(KeyTextBox.Text);
            dbManager.DeleteRecord(key);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int key = int.Parse(KeyTextBox.Text);
            string newData = DataTextBox.Text;
            dbManager.EditRecord(key, newData);
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List<Record> records = dbManager.GetAllRecords();
            RecordsListBox.Items.Clear();
            foreach (var record in records)
            {
                RecordsListBox.Items.Add($"Key: {record.Key}, Data: {record.Data}");
            }
        }
        private void PopulateButton_Click(object sender, EventArgs e)
        {
            dbManager.PopulateDatabase(10000);
            MessageBox.Show("База заповнена 10,000 випадковими записами");
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            double averageComparisons = dbManager.MeasureAverageComparisons(15);
            MessageBox.Show($"Середня кількість порівнянь: {averageComparisons:F2}");
        }
    }
}