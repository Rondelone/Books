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
    public partial class Delivers : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public Delivers()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxNum.Text);
            string date = textBoxDate.Text;
            string publisher = comboBoxPublisher.Text;
            string query = "INSERT INTO Delivers (IdDelivers, DateofDelivers, Publisher) VALUES ('" + num + "','" + date + "','" + publisher + "')";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            this.deliversTableAdapter.Fill(this.booksDataSet.Delivers);
            command.ExecuteNonQuery();

        }

        private void Delivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.booksDataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Delivers". При необходимости она может быть перемещена или удалена.
            this.deliversTableAdapter.Fill(this.booksDataSet.Delivers);

        }
    }
}
