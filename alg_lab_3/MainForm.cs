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
            string data = DataTextBox.Text;
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Поле даних не може бути порожнім!");
                return;
            }

            if (int.TryParse(KeyTextBox.Text, out int key))
            {
                try
                {
                    dbManager.AddRecord(key, data);
                    MessageBox.Show("Запис успішно додано");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Введіть коректний цілий ключ!");  
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(KeyTextBox.Text, out int key))
            {
                try
                {
                    dbManager.DeleteRecord(key);
                    MessageBox.Show("Запис успішно видалено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Введіть коректний цілий ключ!");
            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            dbManager.DeleteAllRecords();
            MessageBox.Show("Всі записи видалено.");
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            string newData = DataTextBox.Text;

            // Перевірка на коректність ключа та на порожнє значення data
            if (!int.TryParse(KeyTextBox.Text, out int key))
            {
                MessageBox.Show("Введіть коректний цілий ключ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(newData))
            {
                MessageBox.Show("Поле даних не може бути порожнім!");
                return;
            }

            try
            {
                dbManager.EditRecord(key, newData);
                MessageBox.Show("Запис успішно змінено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
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