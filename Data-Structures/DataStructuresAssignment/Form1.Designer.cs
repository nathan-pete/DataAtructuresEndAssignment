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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(728, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.mainLabel.Location = new System.Drawing.Point(285, 34);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(222, 29);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Data about songs ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(816, 170);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(192, 34);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Song Binary Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchBwutton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(816, 124);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(242, 26);
            this.SearchTextBox.TabIndex = 3;
            // 
            // searchSongName
            // 
            this.searchSongName.AutoSize = true;
            this.searchSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSongName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.searchSongName.Location = new System.Drawing.Point(812, 91);
            this.searchSongName.Name = "searchSongName";
            this.searchSongName.Size = new System.Drawing.Size(268, 20);
            this.searchSongName.TabIndex = 4;
            this.searchSongName.Text = "Enter a name of song for search";
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(28, 456);
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
            this.RemoveRowButton.Location = new System.Drawing.Point(137, 456);
            this.RemoveRowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(128, 40);
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
            this.LinearSearchButton.Location = new System.Drawing.Point(816, 406);
            this.LinearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinearSearchButton.Name = "LinearSearchButton";
            this.LinearSearchButton.Size = new System.Drawing.Size(214, 34);
            this.LinearSearchButton.TabIndex = 8;
            this.LinearSearchButton.Text = "Streams Linear Search";
            this.LinearSearchButton.UseVisualStyleBackColor = false;
            this.LinearSearchButton.Click += new System.EventHandler(this.LenearSearchButton_Click);
            // 
            // LinearSearchTextBox
            // 
            this.LinearSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinearSearchTextBox.Location = new System.Drawing.Point(816, 365);
            this.LinearSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinearSearchTextBox.Name = "LinearSearchTextBox";
            this.LinearSearchTextBox.Size = new System.Drawing.Size(242, 26);
            this.LinearSearchTextBox.TabIndex = 9;
            // 
            // searchStreamsLabel
            // 
            this.searchStreamsLabel.AutoSize = true;
            this.searchStreamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStreamsLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.searchStreamsLabel.Location = new System.Drawing.Point(812, 329);
            this.searchStreamsLabel.Name = "searchStreamsLabel";
            this.searchStreamsLabel.Size = new System.Drawing.Size(355, 20);
            this.searchStreamsLabel.TabIndex = 10;
            this.searchStreamsLabel.Text = "Enter a streams number for jump searching";
            // 
            // bucketSortButton
            // 
            this.bucketSortButton.Location = new System.Drawing.Point(554, 452);
            this.bucketSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bucketSortButton.Name = "bucketSortButton";
            this.bucketSortButton.Size = new System.Drawing.Size(202, 49);
            this.bucketSortButton.TabIndex = 11;
            this.bucketSortButton.Text = "BucketSortButton";
            this.bucketSortButton.UseVisualStyleBackColor = true;
            this.bucketSortButton.Click += new System.EventHandler(this.BucketSortButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "StreamSortButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StreamSortButton_Click);
            // 
            // ArtistListBox
            // 
            this.ArtistListBox.FormattingEnabled = true;
            this.ArtistListBox.ItemHeight = 20;
            this.ArtistListBox.Location = new System.Drawing.Point(860, 537);
            this.ArtistListBox.Name = "ArtistListBox";
            this.ArtistListBox.Size = new System.Drawing.Size(120, 84);
            this.ArtistListBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 644);
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
    }
}
