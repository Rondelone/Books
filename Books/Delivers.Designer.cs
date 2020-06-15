namespace Books
{
    partial class Delivers
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksDataSet = new Books.BooksDataSet();
            this.deliversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliversTableAdapter = new Books.BooksDataSetTableAdapters.DeliversTableAdapter();
            this.idDeliversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofDeliversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new Books.BooksDataSetTableAdapters.PublisherTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.DataSource = this.publisherBindingSource;
            this.comboBoxPublisher.DisplayMember = "Publisher";
            this.comboBoxPublisher.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(503, 266);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(190, 29);
            this.comboBoxPublisher.TabIndex = 15;
            this.comboBoxPublisher.ValueMember = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(500, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Издательство";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(503, 168);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(169, 29);
            this.textBoxDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дата поставки";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNum.Location = new System.Drawing.Point(503, 61);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(169, 29);
            this.textBoxNum.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(500, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер поставки";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(503, 400);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 61);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить поставку";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeliversDataGridViewTextBoxColumn,
            this.dateofDeliversDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliversBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 447);
            this.dataGridView1.TabIndex = 8;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliversBindingSource
            // 
            this.deliversBindingSource.DataMember = "Delivers";
            this.deliversBindingSource.DataSource = this.booksDataSet;
            // 
            // deliversTableAdapter
            // 
            this.deliversTableAdapter.ClearBeforeFill = true;
            // 
            // idDeliversDataGridViewTextBoxColumn
            // 
            this.idDeliversDataGridViewTextBoxColumn.DataPropertyName = "IdDelivers";
            this.idDeliversDataGridViewTextBoxColumn.HeaderText = "IdDelivers";
            this.idDeliversDataGridViewTextBoxColumn.Name = "idDeliversDataGridViewTextBoxColumn";
            // 
            // dateofDeliversDataGridViewTextBoxColumn
            // 
            this.dateofDeliversDataGridViewTextBoxColumn.DataPropertyName = "DateofDelivers";
            this.dateofDeliversDataGridViewTextBoxColumn.HeaderText = "DateofDelivers";
            this.dateofDeliversDataGridViewTextBoxColumn.Name = "dateofDeliversDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.booksDataSet;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // Delivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 493);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delivers";
            this.Text = "Список поставок";
            this.Load += new System.EventHandler(this.Delivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource deliversBindingSource;
        private BooksDataSetTableAdapters.DeliversTableAdapter deliversTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeliversDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofDeliversDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private BooksDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
    }
}