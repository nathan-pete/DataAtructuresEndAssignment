using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

        private DateNode LoadDates(string filePath)
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
                    DateNode newNode = new DateNode { Value = dateValue }; // Create a new DateNode with the parsed value
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);
            DateNode dates = LoadDates(filePath); // Load the dates using the new method


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

            // Display the sorted artist names in a ListBox control
            ArtistListBox.DataSource = sortedArtistNames;

            // Clear the ListBox and add each date to it
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

        // Hashset datastructures
        private void HashSetExample()
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            HashSet<string> artists = new HashSet<string>();

            // Add each artist to the hash set
            foreach (string[] row in data)
            {
                artists.Add(row[1]);
            }

            //Display the number of unique artists
            MessageBox.Show($"Number of unique artists: {artists.Count}");

            // Set the ArtistNames property
            ArtistNames = artists;
        }

        //Binary search algorithm
        private void SearchBwutton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
                List<string[]> data = LoadCSV(filePath);
                
                Stopwatch binaryTime = new Stopwatch();
                binaryTime.Start();
                string[] result = BinarySearch(data, searchTerm);

                if (result != null)
                {
                    binaryTime.Stop();
                    TimeSpan binaryTimeElapsed = (binaryTime.Elapsed);
                    MessageBox.Show($"Song: {result[0]}\nArtist: {result[1]}\nStreams (Billions): {result[2]}\nRelease Date: {result[3]}\nTime elapsed: {binaryTimeElapsed.TotalSeconds} seconds");
                }
                else
                {
                    binaryTime.Stop();
                    TimeSpan binaryTimeElapsed = binaryTime.Elapsed;
                    MessageBox.Show($"Not found\nTime elapsed: {binaryTimeElapsed.TotalSeconds} seconds");
                }
            }
        }

        private string[] BinarySearch(List<string[]> data, string searchTerm)
        {
            string[] result = null;

            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compareResult = string.Compare(data[mid][0], searchTerm, StringComparison.OrdinalIgnoreCase);

                if (compareResult == 0)
                {
                    result = data[mid];
                    break;
                }
                else if (compareResult < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
        private void AddRowButton_Click(object sender, EventArgs e)
        {

            string[] newRow = new string[] { "New Song", "New Artist", "0.5", "2023-03-24" };
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);
            data.Add(newRow);


            dataGridView1.Rows.Clear();
            foreach (string[] row in data)
            {
                dataGridView1.Rows.Add(row);
            }

            using (var writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine(string.Join(",", newRow));
            }
        }

        /*----------------------------------------------- Remove Row -------------------------------------------------*/
        private void RemoveRowButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }

        /*----------------------------------------------- Bucket Sort ------------------------------------------------*/
        private void BucketSortButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            // Create a dictionary to store the buckets
            Dictionary<string, List<string[]>> buckets = new Dictionary<string, List<string[]>>();

            Stopwatch bucketSortTime = new Stopwatch();
            bucketSortTime.Start();
            // Iterate over each row in the data and add it to the appropriate bucket
            foreach (string[] row in data)
            {
                string artist = row[1];
                if (buckets.ContainsKey(artist))
                {
                    buckets[artist].Add(row);
                }
                else
                {
                    buckets.Add(artist, new List<string[]> { row });
                }
            }

            // Sort the buckets by artist name
            List<string[]> sortedData = new List<string[]>();
            foreach (var bucket in buckets.OrderBy(x => x.Key))
            {
                sortedData.AddRange(bucket.Value);
            }

            // Clear the data grid view and add the sorted data
            dataGridView1.Rows.Clear();
            foreach (string[] row in sortedData)
            {
                dataGridView1.Rows.Add(row);
                
            }
            bucketSortTime.Stop();
            TimeSpan bucketSortTimeElapsed = (bucketSortTime.Elapsed);
            MessageBox.Show($"Time elapsed: {bucketSortTimeElapsed.TotalSeconds} seconds");
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

        private SortedList<string, Song> songsList = new SortedList<string, Song>();

        public SortedList<string, Song> SongsList
        {
            get { return songsList; }
            set { songsList = value; }
        }

        private void LenearSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = LinearSearchTextBox.Text;
            bool searchResultFound = false;
            
            Stopwatch linearTime = new Stopwatch();
            linearTime.Start();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow currentRow = dataGridView1.Rows[i];
                string cellValue = currentRow.Cells["Streams (Billions)"].Value.ToString();

                if (cellValue.Equals(searchTerm))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    linearTime.Stop();
                    TimeSpan linearTimeElapsed = (linearTime.Elapsed);
                    MessageBox.Show($"Song: {currentRow.Cells[0].Value.ToString()}\nArtist: {currentRow.Cells[1].Value.ToString()}\nStreams (Billions): {currentRow.Cells[2].Value.ToString()}\nRelease Date: {currentRow.Cells[3].Value.ToString()}\nTime elapsed: {linearTimeElapsed.TotalSeconds} seconds");
                    searchResultFound = true;
                    break;
                }
                else
                {
                    linearTime.Stop();
                    TimeSpan linearTimeElapsed = (linearTime.Elapsed);
                    MessageBox.Show($"The search result wasn't found, try again.\nTime elapsed: {linearTimeElapsed.TotalSeconds} seconds");
                    break;
                }
            }

            if (!searchResultFound)
            {
                linearTime.Stop();
                TimeSpan linearTimeElapsed = (linearTime.Elapsed);
                MessageBox.Show($"The search result wasn't found, try again.\nTime elapsed: {linearTimeElapsed.TotalSeconds} seconds");
            }
        }

        /*---------------------------------------------- Bubble Sort -------------------------------------------------*/
        private void StreamSortButton_Click(object sender, EventArgs e)
        {
            //Reads and store CSV data
            List<string> lines = new List<string>();
            //StreamReader reads the file and dispose of it when done
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
            for (int x = 0; x < lines.Count; x++) //Iterates through the list
            {
                data[x] = float.Parse(lines[x]); //Converts the string to a float
            }

            Stopwatch bubbleSortTime = new Stopwatch();
            bubbleSortTime.Start();
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
            bubbleSortTime.Stop();
            TimeSpan bubbleSortTimeElapsed = (bubbleSortTime.Elapsed);
            MessageBox.Show($"Time elapsed: {bubbleSortTimeElapsed.TotalSeconds} seconds");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}