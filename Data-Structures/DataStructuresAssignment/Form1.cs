using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DataStructuresAssignment
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        /*----------------------------------------------- Hashset data structure -----------------------------------------*/

        private HashSet<string> artistNames = new HashSet<string>();
        public HashSet<string> ArtistNames
        {
            get { return artistNames; }
            set { artistNames = value; }
        }
        /*----------------------------------------------- Linked list data structure -----------------------------------------*/

        public class DateNode
        {
            public DateTime Value { get; set; }
            public DateNode Next { get; set; }
        }

        private DateNode LoadingDates(string filePath)
        {
            DateNode head = null;
            DateNode tail = null;
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    DateTime dateValue = DateTime.Parse(values[3]); // Parse the date string into a DateTime object
                    DateNode newNode = new DateNode { Value = dateValue };
                    if (head == null) // If this is the first node, set it as the head
                    {
                        head = newNode;
                    }
                    if (tail != null)
                    {
                        tail.Next = newNode;
                    }
                    tail = newNode;
                }
            }
            return head;
        }

        /*------------------------------------------------------------ Loading CSV file --------------------------------------------------*/

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);
            DateNode dates = LoadingDates(filePath); // Load the dates using the new method


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Song", "Song");
            dataGridView1.Columns.Add("Artist", "Artist");
            dataGridView1.Columns.Add("Streams (Billions)", "Streams (Billions)");
            dataGridView1.Columns.Add("Release Date", "Release Date");

            dataGridView1.Rows.Clear();
            foreach (string[] row in data)
            {
                dataGridView1.Rows.Add(row);
            }

            // Add each artist name to the HashSet
            foreach (string[] row in data)
            {
                artistNames.Add(row[1]);
            }

            List<string> sortedArtistNames = artistNames.ToList();
            sortedArtistNames.Sort();

            // Display the sorted artist names in a ListBox
            ArtistListBox.DataSource = sortedArtistNames;

            listBox1.Items.Clear();
            DateNode currentNode = dates;
            while (currentNode != null)
            {
                listBox1.Items.Add(currentNode.Value.ToShortDateString());
                currentNode = currentNode.Next;
            }
        }

        private List<string[]> LoadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    data.Add(values);
                }
            }

            // Sort the data by the song name
            data.Sort((x, y) => string.Compare(x[0], y[0], StringComparison.OrdinalIgnoreCase));

            return data;
        }

        /* --------------------------------------------------------- Hashset datastructures --------------------------------------------------*/

        private void HashSetExample()
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            HashSet<string> artists = new HashSet<string>();

            // Add each artist to hashset
            foreach (string[] row in data)
            {
                artists.Add(row[1]);
            }

            // Display the number of artists
            MessageBox.Show($"Number of unique artists: {artists.Count}");

            // Set the ArtistNames property
            ArtistNames = artists;
        }

        /* --------------------------------------------------------------  Binary search algorithm --------------------------------------------*/

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
                List<string[]> dataSearch = LoadCSV(filePath);

                string[] resultSearch = BinarySearch(dataSearch, searchTerm);

                if (resultSearch != null)
                {
                    MessageBox.Show($"Song: {resultSearch[0]}\nArtist: {resultSearch[1]}\nStreams (Billions): {resultSearch[2]}\nRelease Date: {resultSearch[3]}");
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }

        private string[] BinarySearch(List<string[]> data, string term)
        {
            string[] binaryResult = null;

            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparing = string.Compare(data[mid][0], term, StringComparison.OrdinalIgnoreCase);

                if (comparing == 0)
                {
                    binaryResult = data[mid];
                    break;
                }
                else if (comparing < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return binaryResult;
        }

        /* ---------------------------------------------------------- Add row -------------------------------------------*/

        private void AddRow_Click(object sender, EventArgs e)
        {

            string[] row = new string[] { "New Song", "New Artist", "0.1", "2023-03-24" };
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);
            data.Add(row);


            dataGridView1.Rows.Clear();
            foreach (string[] rowAdd in data)
            {
                dataGridView1.Rows.Add(rowAdd);
            }

            using (var paste = new StreamWriter(filePath, append: true))
            {
                paste.WriteLine(string.Join(",", row));
            }
        }

        /*----------------------------------------------- Remove Row -------------------------------------------------*/

        private void RemoveRow_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        /*----------------------------------------------- Bucket Sort ------------------------------------------------*/

        private void BucketSort_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> dataPath = LoadCSV(filePath);

            // Create a dictionary for data
            Dictionary<string, List<string[]>> bucketSort = new Dictionary<string, List<string[]>>();

            foreach (string[] row in dataPath)
            {
                string artist = row[1];
                if (bucketSort.ContainsKey(artist))
                {
                    bucketSort[artist].Add(row);
                }
                else
                {
                    bucketSort.Add(artist, new List<string[]> { row });
                }
            }

            // Sort by artist name
            List<string[]> sortedData = new List<string[]>();
            foreach (var bucket in bucketSort.OrderBy(x => x.Key))
            {
                sortedData.AddRange(bucket.Value);
            }

            dataGridView1.Rows.Clear();
            foreach (string[] row in sortedData)
            {
                dataGridView1.Rows.Add(row);
            }
        }

        /*---------------------------------------------- Linear Sort -------------------------------------------------*/

        public class Song
        {
            public string Name { get; set; }
            public string Artist { get; set; }
            public string Streams { get; set; }
            public string ReleaseDate { get; set; }
            public int RowIndex { get; set; }

            public Song(string name, string artist, string streams, string releaseDate, int rowIndex)
            {
                Name = name;
                Artist = artist;
                Streams = streams;
                ReleaseDate = releaseDate;
                RowIndex = rowIndex;
            }
        }

        private SortedList<string, Song> songList = new SortedList<string, Song>();
        public SortedList<string, Song> SongsList
        {
            get { return songList; }
            set { songList = value; }
        }

        private void LenearSearch_Click(object sender, EventArgs e)
        {
            string search = LinearSearchTextBox.Text;
            bool searchResultFound = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow currentRow = dataGridView1.Rows[i];
                string cellValue = currentRow.Cells["Streams (Billions)"].Value.ToString();

                if (cellValue.Equals(search))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    MessageBox.Show($"Song: {currentRow.Cells[0].Value.ToString()}\nArtist: {currentRow.Cells[1].Value.ToString()}\nStreams (Billions): {currentRow.Cells[2].Value.ToString()}\nRelease Date: {currentRow.Cells[3].Value.ToString()}");
                    searchResultFound = true;
                    break;
                }
            }

            if (!searchResultFound)
            {
                MessageBox.Show("The search result is failed");
            }
        }

        /*---------------------------------------------- Bubble Sort -------------------------------------------------*/

        private void StreamSort_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader("Streams.csv"))
            {
                //Saves CSV contents to a lists
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(','); //Splits at the delimiter
                    lines.Add(values[2]); //Adds 3rd element to the list (Streams column)
                }
            }

            // Convert the strings to floats
            float[] data = new float[lines.Count];
            for (int x = 0; x < lines.Count; x++)
            {
                data[x] = float.Parse(lines[x]); //Converts the string to a float
            }

            // Bubble sort Algorithm
            for (int x = 0; x < data.Length - 1; x++)
            {
                for (int y = 0; y < data.Length - x - 1; y++)
                {
                    if (data[y] > data[y + 1])
                    {
                        float temp = data[y];
                        data[y] = data[y + 1];
                        data[y + 1] = temp;
                    }
                }
            }

            // Rearrange the WinForm table
            for (int x = 0; x < dataGridView1.Rows.Count & x < data.Length; x++)
            {
                dataGridView1.Rows[x].Cells[2].Value = data[x]; //Sets the 3rd column to the sorted data
            }
        }
    }
}

