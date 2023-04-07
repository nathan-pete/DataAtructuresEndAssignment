namespace DataStructuresAssignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.searchSongName = new System.Windows.Forms.Label();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.LinearSearchButton = new System.Windows.Forms.Button();
            this.LinearSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchStreamsLabel = new System.Windows.Forms.Label();
            this.bucketSortButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ArtistListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(778, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.mainLabel.Location = new System.Drawing.Point(473, 29);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(222, 29);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Data about songs ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(308, 127);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(217, 34);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "song binary search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchBwutton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(28, 132);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(264, 26);
            this.SearchTextBox.TabIndex = 3;
            // 
            // searchSongName
            // 
            this.searchSongName.AutoSize = true;
            this.searchSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSongName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.searchSongName.Location = new System.Drawing.Point(24, 99);
            this.searchSongName.Name = "searchSongName";
            this.searchSongName.Size = new System.Drawing.Size(161, 20);
            this.searchSongName.TabIndex = 4;
            this.searchSongName.Text = "Enter a song name";
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(588, 465);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(75, 40);
            this.AddRowButton.TabIndex = 5;
            this.AddRowButton.Text = "Add row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(687, 465);
            this.RemoveRowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(138, 40);
            this.RemoveRowButton.TabIndex = 6;
            this.RemoveRowButton.Text = "Remove row";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // LinearSearchButton
            // 
            this.LinearSearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.LinearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearSearchButton.ForeColor = System.Drawing.Color.White;
            this.LinearSearchButton.Location = new System.Drawing.Point(311, 223);
            this.LinearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinearSearchButton.Name = "LinearSearchButton";
            this.LinearSearchButton.Size = new System.Drawing.Size(214, 44);
            this.LinearSearchButton.TabIndex = 8;
            this.LinearSearchButton.Text = "streams linear search ";
            this.LinearSearchButton.UseVisualStyleBackColor = false;
            this.LinearSearchButton.Click += new System.EventHandler(this.LenearSearchButton_Click);
            // 
            // LinearSearchTextBox
            // 
            this.LinearSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinearSearchTextBox.Location = new System.Drawing.Point(28, 229);
            this.LinearSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinearSearchTextBox.Name = "LinearSearchTextBox";
            this.LinearSearchTextBox.Size = new System.Drawing.Size(264, 26);
            this.LinearSearchTextBox.TabIndex = 9;
            // 
            // searchStreamsLabel
            // 
            this.searchStreamsLabel.AutoSize = true;
            this.searchStreamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStreamsLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.searchStreamsLabel.Location = new System.Drawing.Point(24, 189);
            this.searchStreamsLabel.Name = "searchStreamsLabel";
            this.searchStreamsLabel.Size = new System.Drawing.Size(202, 20);
            this.searchStreamsLabel.TabIndex = 10;
            this.searchStreamsLabel.Text = "Enter a streams number";
            // 
            // bucketSortButton
            // 
            this.bucketSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucketSortButton.Location = new System.Drawing.Point(24, 313);
            this.bucketSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bucketSortButton.Name = "bucketSortButton";
            this.bucketSortButton.Size = new System.Drawing.Size(161, 49);
            this.bucketSortButton.TabIndex = 11;
            this.bucketSortButton.Text = "Sort Artist ASC";
            this.bucketSortButton.UseVisualStyleBackColor = true;
            this.bucketSortButton.Click += new System.EventHandler(this.BucketSortButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sort Streams";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StreamSortButton_Click);
            // 
            // ArtistListBox
            // 
            this.ArtistListBox.FormattingEnabled = true;
            this.ArtistListBox.ItemHeight = 20;
            this.ArtistListBox.Location = new System.Drawing.Point(974, 447);
            this.ArtistListBox.Name = "ArtistListBox";
            this.ArtistListBox.Size = new System.Drawing.Size(153, 144);
            this.ArtistListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tap to add/remove the row to the table :)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Circular Std Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Unique artists ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1168, 447);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 144);
            this.listBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Circular Std Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1163, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Release dates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtistListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bucketSortButton);
            this.Controls.Add(this.searchStreamsLabel);
            this.Controls.Add(this.LinearSearchTextBox);
            this.Controls.Add(this.LinearSearchButton);
            this.Controls.Add(this.RemoveRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.searchSongName);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " (";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label searchSongName;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.Button LinearSearchButton;
        private System.Windows.Forms.TextBox LinearSearchTextBox;
        private System.Windows.Forms.Label searchStreamsLabel;
        private System.Windows.Forms.Button bucketSortButton;
        private System.Windows.Forms.ListBox ArtistListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}
