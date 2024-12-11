namespace WinFormsApp1
{
    partial class UserControlVinyls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            vinylIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            artistDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            collectionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vinylBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vinylBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vinylIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, artistDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, collectionsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vinylBindingSource;
            dataGridView1.Location = new Point(24, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(709, 429);
            dataGridView1.TabIndex = 0;
            // 
            // vinylIdDataGridViewTextBoxColumn
            // 
            vinylIdDataGridViewTextBoxColumn.DataPropertyName = "VinylId";
            vinylIdDataGridViewTextBoxColumn.HeaderText = "VinylId";
            vinylIdDataGridViewTextBoxColumn.Name = "vinylIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // collectionsDataGridViewTextBoxColumn
            // 
            collectionsDataGridViewTextBoxColumn.DataPropertyName = "Collections";
            collectionsDataGridViewTextBoxColumn.HeaderText = "Collections";
            collectionsDataGridViewTextBoxColumn.Name = "collectionsDataGridViewTextBoxColumn";
            // 
            // vinylBindingSource
            // 
            vinylBindingSource.DataSource = typeof(Models.Vinyl);
            // 
            // UserControlVinyls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Name = "UserControlVinyls";
            Size = new Size(764, 470);
            Load += UserControlVinyls_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vinylBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vinylIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collectionsDataGridViewTextBoxColumn;
        private BindingSource vinylBindingSource;
    }
}
