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
    public partial class DelBook : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Books.mdb";
        private OleDbConnection DBConnection;
        public DelBook()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectString);
            DBConnection.Open();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxNumber.Text);
            string query = "DELETE FROM Book WHERE [Id] = " + num;
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
        }
    }
}
