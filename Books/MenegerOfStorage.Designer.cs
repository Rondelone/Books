namespace Books
{
    partial class MenegerOfStorage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gendeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new Books.BooksDataSet();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.buttonPublisher = new System.Windows.Forms.Button();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BuyBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDeliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTableAdapter = new Books.BooksDataSetTableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameBookDataGridViewTextBoxColumn,
            this.gendeDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.yearsDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.amountPagesDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 334);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            this.nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.HeaderText = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            // 
            // gendeDataGridViewTextBoxColumn
            // 
            this.gendeDataGridViewTextBoxColumn.DataPropertyName = "Gende";
            this.gendeDataGridViewTextBoxColumn.HeaderText = "Gende";
            this.gendeDataGridViewTextBoxColumn.Name = "gendeDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // yearsDataGridViewTextBoxColumn
            // 
            this.yearsDataGridViewTextBoxColumn.DataPropertyName = "Years";
            this.yearsDataGridViewTextBoxColumn.HeaderText = "Years";
            this.yearsDataGridViewTextBoxColumn.Name = "yearsDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // amountPagesDataGridViewTextBoxColumn
            // 
            this.amountPagesDataGridViewTextBoxColumn.DataPropertyName = "AmountPages";
            this.amountPagesDataGridViewTextBoxColumn.HeaderText = "AmountPages";
            this.amountPagesDataGridViewTextBoxColumn.Name = "amountPagesDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.booksDataSet;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonGenre
            // 
            this.buttonGenre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenre.Location = new System.Drawing.Point(917, 290);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(192, 96);
            this.buttonGenre.TabIndex = 13;
            this.buttonGenre.Text = "Список жанров";
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // buttonPublisher
            // 
            this.buttonPublisher.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPublisher.Location = new System.Drawing.Point(917, 169);
            this.buttonPublisher.Name = "buttonPublisher";
            this.buttonPublisher.Size = new System.Drawing.Size(192, 96);
            this.buttonPublisher.TabIndex = 12;
            this.buttonPublisher.Text = "Список издателей";
            this.buttonPublisher.UseVisualStyleBackColor = true;
            this.buttonPublisher.Click += new System.EventHandler(this.buttonPublisher_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthor.Location = new System.Drawing.Point(917, 48);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(192, 96);
            this.buttonAuthor.TabIndex = 11;
            this.buttonAuthor.Text = "Список авторов";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuyBookToolStripMenuItem,
            this.DeleteBookToolStripMenuItem,
            this.ViewDeliveriesToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BuyBookToolStripMenuItem
            // 
            this.BuyBookToolStripMenuItem.Name = "BuyBookToolStripMenuItem";
            this.BuyBookToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.BuyBookToolStripMenuItem.Text = "Добавить книгу";
            this.BuyBookToolStripMenuItem.Click += new System.EventHandler(this.BuyBookToolStripMenuItem_Click);
            // 
            // DeleteBookToolStripMenuItem
            // 
            this.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem";
            this.DeleteBookToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.DeleteBookToolStripMenuItem.Text = "Удалить книгу";
            this.DeleteBookToolStripMenuItem.Click += new System.EventHandler(this.DeleteBookToolStripMenuItem_Click);
            // 
            // ViewDeliveriesToolStripMenuItem
            // 
            this.ViewDeliveriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПоставкуToolStripMenuItem});
            this.ViewDeliveriesToolStripMenuItem.Name = "ViewDeliveriesToolStripMenuItem";
            this.ViewDeliveriesToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.ViewDeliveriesToolStripMenuItem.Text = "Посмотреть поставки";
            this.ViewDeliveriesToolStripMenuItem.Click += new System.EventHandler(this.ViewDeliveriesToolStripMenuItem_Click);
            // 
            // добавитьПоставкуToolStripMenuItem
            // 
            this.добавитьПоставкуToolStripMenuItem.Name = "добавитьПоставкуToolStripMenuItem";
            this.добавитьПоставкуToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.добавитьПоставкуToolStripMenuItem.Text = "Добавить поставку";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // MenegerOfStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGenre);
            this.Controls.Add(this.buttonPublisher);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenegerOfStorage";
            this.Text = "Менеджер склада";
            this.Load += new System.EventHandler(this.MenegerOfStorage_Load);
            this.MouseHover += new System.EventHandler(this.MenegerOfStorage_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Button buttonPublisher;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BuyBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewDeliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BooksDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}

