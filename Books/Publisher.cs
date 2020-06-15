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
    public partial class Publisher : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public Publisher()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxNum.Text);
            string name = textBoxName.Text;
            string query = "INSERT INTO Publisher (IdPublisher, Publisher) VALUES ('" + num + "','" + name + "')";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о издателе обновлены");
            this.publisherTableAdapter.Fill(this.booksDataSet.Publisher);

        }

        private void Publisher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.booksDataSet.Publisher);

        }
    }
}
