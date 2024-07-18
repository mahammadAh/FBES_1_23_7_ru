using Npgsql;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsyncApp2
{
    public partial class Form1 : Form
    {
        public string sqlServerConnectionString = string.Empty;
        public string postgreSqlConnectionString = string.Empty;

        public DbConnection connection = null;
        public DbCommand comm = null;

        public Form1()
        {
            InitializeComponent();

            sqlServerConnectionString = ConfigurationManager.ConnectionStrings["sqlServerConnectionString"].ConnectionString;

            postgreSqlConnectionString = ConfigurationManager.ConnectionStrings["postgreSqlConnectionString"].ConnectionString;
        }

        private async void runButton_Click(object sender, EventArgs e)
        {

            runButton_ClickAsync(sender, e);

            messageTextBox.Text = "CHECK ASYNC FUNCION";

        }




        private async Task runButton_ClickAsync(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
         
            try
            {


                var query = "WAITFOR DELAY '00:00:10' SELECT * FROM Authors";
                comm.CommandText = query;



                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Surname");


                await connection.OpenAsync();

                Task<DbDataReader> result = comm.ExecuteReaderAsync();
                var queryResult = await result;


                //SqlDataReader queryResult = await cmd.ExecuteReaderAsync();


                while (queryResult.Read())
                {
                    dataTable.Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
                }

                dataGridView.DataSource = dataTable;

            }
            catch(Exception ex)
            {
                errorRichTextBox.Text = ex.Message;
            }

            finally
            {
                await connection.CloseAsync();
            }

        }

        private void sqlServerButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlServerConnectionString);
            comm = connection.CreateCommand();


        }

        private void postgreSqlButton_Click(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(sqlServerConnectionString);
            comm = connection.CreateCommand();
        }
    }
}
