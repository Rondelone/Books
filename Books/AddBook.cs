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
    public partial class AddBook : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public AddBook()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxNumber.Text);
            string name = textBoxName.Text;
            string genre = comboBoxGenre.Text;
            string author = comboBoxAuthor.Text;
            string year = textBoxYear.Text;
            string publisher = comboBoxPublisher.Text;
            int pages = Convert.ToInt32(textBoxPages.Text);
            int cost = Convert.ToInt32(textBoxCost.Text);
            string query = "INSERT INTO Book (Id, NameBook, Gende, Author, Years, Publisher, AmountPages, Cost) VALUES ('" + num + "','" + name + "','" + genre + "','" + author + "','" + year + "','" + publisher + "','" + pages + "','" + cost + "')";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о книге обновлены");
        }
    }
}
