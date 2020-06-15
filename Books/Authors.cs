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
    public partial class Authors : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public Authors()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Author". При необходимости она может быть перемещена или удалена.
            this.authorTableAdapter.Fill(this.booksDataSet.Author);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxNum.Text);
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string query = "INSERT INTO Author (IdAuthor, NameAuthor, LastName) VALUES ('" + num + "','" + name + "','" + lastname + "')";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные об авторе обновлены");
            this.authorTableAdapter.Fill(this.booksDataSet.Author);
        }
    }
}
