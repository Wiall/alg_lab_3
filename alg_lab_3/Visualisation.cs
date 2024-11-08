using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace alg_lab_3
{
    public partial class Visualisation : Form
    {
        private List<IndexEntry> indexList = new List<IndexEntry>();
        private DatabaseManager dbManager;

        public Visualisation(List<IndexEntry> indicesToVisualize, DatabaseManager databaseManager)
        {
            InitializeComponent();
            indexList = indicesToVisualize;
            dbManager = databaseManager;
            
            dbManager.LoadIndex();

            // Налаштування DataGridView для індексної таблиці
            SetupIndexDataGridView();
            LoadDataIntoIndexGrid();

            // Налаштування DataGridView для основної таблиці
            SetupDataDataGridView();
        }

        private void SetupIndexDataGridView()
        {
            indexDataGridView.ColumnCount = 2;
            indexDataGridView.Columns[0].Name = "Key";
            indexDataGridView.Columns[1].Name = "Position";
            indexDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Додаємо обробник події для вибору рядка
            indexDataGridView.SelectionChanged += IndexDataGridView_SelectionChanged;
        }

        private void SetupDataDataGridView()
        {
            dataDataGridView.ColumnCount = 2;
            dataDataGridView.Columns[0].Name = "Key";
            dataDataGridView.Columns[1].Name = "Data";
            dataDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDataIntoIndexGrid()
        {
            indexDataGridView.Rows.Clear();

            foreach (var entry in indexList)
            {
                indexDataGridView.Rows.Add(entry.Key, entry.Position);
            }
        }

        private void LoadDataIntoDataGrid(int key)
        {
            dataDataGridView.Rows.Clear();

            var record = dbManager.SearchRecord(key);
            if (record != null)
            {
                dataDataGridView.Rows.Add(record.Key, record.Data);
            }
            else
            {
                MessageBox.Show("Запис не знайдено", "Помилка");
            }
        }

        private void IndexDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (indexDataGridView.SelectedRows.Count > 0)
            {
                int selectedKey = Convert.ToInt32(indexDataGridView.SelectedRows[0].Cells[0].Value);
                LoadDataIntoDataGrid(selectedKey);
            }
        }

        private void VisualizeButton_Click(object sender, EventArgs e)
        {
            LoadDataIntoIndexGrid();
            foreach (var i in indexList)
            {
               LoadDataIntoDataGrid(i.Key); 
            }
        }
    }
}
