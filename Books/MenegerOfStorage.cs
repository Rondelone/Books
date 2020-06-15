using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Books
{
    public partial class MenegerOfStorage : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public MenegerOfStorage()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void MenegerOfStorage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.booksDataSet.Book);

        }
        private void BuyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
        }

        private void ViewDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivers delivers = new Delivers();
            delivers.Show();
        }

        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelBook del = new DelBook();
            del.Show();
        }


        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            Authors authors = new Authors();
            authors.Show();
        }

        private void buttonPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            publisher.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenegerOfStorage_MouseHover(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.booksDataSet.Book);
        }
    }
}
