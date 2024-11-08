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

        public long BinarySearch(int key)
        {
            int left = 0, right = indexList.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (indexList[mid].Key == key)
                    return indexList[mid].Position;
                else if (indexList[mid].Key < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        public void AddRecord(int key, string data)
        {
            if (BinarySearch(key) != -1)
            {
                MessageBox.Show("Запис із таким ключем вже існує");
                return;
            }

            using (var writer = new BinaryWriter(File.Open(mainFilePath, FileMode.Append)))
            {
                long position = writer.BaseStream.Length;
                writer.Write(key);
                writer.Write(data.PadRight(RecordLength));
            }

            indexList.Add(new IndexEntry { Key = key, Position = indexList.Count });
            SaveIndex();
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
    }
}