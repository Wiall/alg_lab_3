using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace alg_lab_3
{
    public class Record
    {
        public int Key { get; set; }
        public string Data { get; set; }
    }

    public class IndexEntry
    {
        public int Key { get; set; }
        public long Position { get; set; }
    }

    public class DatabaseManager
    {
        private const string mainFilePath = "main.dat";
        private const string indexFilePath = "index.dat";
        private const int RecordLength = 128;

        private List<IndexEntry> indexList = new List<IndexEntry>();

        public DatabaseManager()
        {
            LoadIndex();
        }

        private void LoadIndex()
        {
            indexList.Clear();
            if (File.Exists(indexFilePath))
            {
                using (var reader = new BinaryReader(File.Open(indexFilePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int key = reader.ReadInt32();
                        long position = reader.ReadInt64();
                        indexList.Add(new IndexEntry { Key = key, Position = position });
                    }
                }
            }
        }

        private void SaveIndex()
        {
            using (var writer = new BinaryWriter(File.Open(indexFilePath, FileMode.Create)))
            {
                foreach (var entry in indexList)
                {
                    writer.Write(entry.Key);
                    writer.Write(entry.Position);
                }
            }
        }

        public (long position, int comparisons) BinarySearchWithComparisons(int key)
        {
            int comparisons = 0;
            int left = 0, right = indexList.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                comparisons++;
                if (indexList[mid].Key == key)
                    return (indexList[mid].Position, comparisons);
                else if (indexList[mid].Key < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return (-1, comparisons);
        }

        public void AddRecord(int key, string data)
        {
            if (BinarySearchWithComparisons(key).position != -1)
            {
                MessageBox.Show(@"Запис із таким ключем вже існує");
                return;
            }

            using (var writer = new BinaryWriter(File.Open(mainFilePath, FileMode.Append)))
            {
                long position = writer.BaseStream.Length;
                writer.Write(key);
                writer.Write(data.PadRight(RecordLength));

                indexList.Add(new IndexEntry { Key = key, Position = position });
                indexList = indexList.OrderBy(e => e.Key).ToList();
                SaveIndex();
            }
        }

        public void DeleteRecord(int key)
        {
            long position = BinarySearchWithComparisons(key).position;
            if (position == -1)
            {
                MessageBox.Show(@"Запис не знайдено");
                return;
            }

            indexList.RemoveAll(entry => entry.Key == key);
            SaveIndex();

            using (var writer = new BinaryWriter(File.Open(mainFilePath, FileMode.Open, FileAccess.Write)))
            {
                writer.Seek((int)position, SeekOrigin.Begin);
                writer.Write(-1);
            }
        }

        public void DeleteAllRecords()
        {
            indexList.Clear();
            SaveIndex();

            if (File.Exists(mainFilePath))
            {
                File.Delete(mainFilePath);
            }
        }

        public void EditRecord(int key, string newData)
        {
            long position = BinarySearchWithComparisons(key).position;
            if (position == -1)
            {
                MessageBox.Show(@"Запис не знайдено");
                return;
            }

            using (var writer = new BinaryWriter(File.Open(mainFilePath, FileMode.Open, FileAccess.Write)))
            {
                writer.Seek((int)position + sizeof(int), SeekOrigin.Begin);
                writer.Write(newData.PadRight(RecordLength));
            }
        }

        public string GetRecord(int key)
        {
            long position = BinarySearchWithComparisons(key).position;
            if (position == -1) return null;

            using (var reader = new BinaryReader(File.Open(mainFilePath, FileMode.Open)))
            {
                reader.BaseStream.Seek(position + sizeof(int), SeekOrigin.Begin);
                return reader.ReadString().Trim();
            }
        }
        

        public List<Record> GetAllRecords()
        {
            List<Record> records = new List<Record>();
            foreach (var entry in indexList)
            {
                string data = GetRecord(entry.Key);
                if (data != null)
                {
                    records.Add(new Record { Key = entry.Key, Data = data });
                }
            }
            return records;
        }

        public void PopulateDatabase(int count)
        {
            int duplicateAttempts = 0;
            const int maxDuplicates = 10;
            for (int i = 0; i < count; i++)
            {
                int key = i;
                if (BinarySearchWithComparisons(key).position != -1)
                {
                    duplicateAttempts++;

                    if (duplicateAttempts >= maxDuplicates)
                    {
                        MessageBox.Show($@"Заповнення перервано через {maxDuplicates} повторних ключів підряд.", "Попередження");
                        break;
                    }
                    continue;
                }
                string data = $"Data_{key}";
                AddRecord(key, data);
            }
        }

        public double MeasureAverageComparisons(int trials)
        {
            Random rand = new Random();
            int totalComparisons = 0;

            for (int i = 0; i < trials; i++)
            {
                int key = rand.Next(1, 1000000);
                var (position, comparisons) = BinarySearchWithComparisons(key);
                totalComparisons += comparisons;
            }

            return (double)totalComparisons / trials;
        }
        public Record SearchRecord(int key)
        {
            var result = BinarySearchWithComparisons(key);
            if (result.position == -1)
                return null;

            using (var reader = new BinaryReader(File.Open(mainFilePath, FileMode.Open)))
            {
                reader.BaseStream.Seek(result.position, SeekOrigin.Begin);
                int foundKey = reader.ReadInt32();
                string data = reader.ReadString().Trim();
                return new Record { Key = foundKey, Data = data };
            }
        }

    }
}
