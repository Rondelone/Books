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
    public partial class Genre : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public Genre()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.booksDataSet.Genre);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxNum.Text);
            string genre = textBoxGenre.Text;
            string query = "INSERT INTO Genre (IdGenre, GenreName) VALUES ('" + num + "','" + genre + "')";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о жанре обновлены");
            this.genreTableAdapter.Fill(this.booksDataSet.Genre);
        }
    }
}
