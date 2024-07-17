using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsyncApp2
{
    public partial class Form1 : Form
    {
        public string connectionString = string.Empty;
        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["localDbConnection"].ConnectionString;
        }

        private async void runButton_Click(object sender, EventArgs e)
        {

            runButton_ClickAsync(sender, e);

            messageTextBox.Text = "CHECK ASYNC FUNCION";

        }




        private async Task runButton_ClickAsync(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            SqlConnection conn = null;
            try
            {

                conn = new SqlConnection(connectionString);

                var query = "WAITFOR DELAY '00:00:10' SELECT * FROM Authors";

                SqlCommand cmd = new SqlCommand(query, conn);

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Surname");


                await conn.OpenAsync();

                Task<SqlDataReader> result = cmd.ExecuteReaderAsync();
                var queryResult = await result;


                //SqlDataReader queryResult = await cmd.ExecuteReaderAsync();


                while (queryResult.Read())
                {
                    dataTable.Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
                }

                dataGridView.DataSource = dataTable;

            }

            finally
            {
                await conn.CloseAsync();
            }

        }
    }
}
