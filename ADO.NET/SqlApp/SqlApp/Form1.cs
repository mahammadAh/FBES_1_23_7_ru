using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SqlApp
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;

        private  DataSet  dataSet = null ;

        SqlDataAdapter sqlDataAdapter = null;

        SqlCommandBuilder sqlCommandBuilder = null;

      
        public Form1()
        {
            InitializeComponent();

            var connString = ConfigurationManager.ConnectionStrings["localDbConnection"].ConnectionString;

            conn = new SqlConnection(connString);

            dataSet = new DataSet();


        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            // DataTable dataTable = new DataTable();

            // dataTable.Columns.Add("Id");
            // dataTable.Columns.Add("Name");
            // dataTable.Columns.Add("Surname");

            // SqlCommand cmd = new SqlCommand(queryTextBox.Text, conn);

            // conn.Open();

            // SqlDataReader queryResult =  cmd.ExecuteReader();

            // while (queryResult.Read())
            // {
            //     dataTable.Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
            // }

            //resultDataGridView.DataSource = dataTable;


            //DataSet dataSet = new DataSet();

            //dataSet.Tables.Add("Authors");
            //dataSet.Tables["Authors"].Columns.Add("Id");
            //dataSet.Tables["Authors"].Columns.Add("Name");
            //dataSet.Tables["Authors"].Columns.Add("Surname");

            //SqlCommand cmd = new SqlCommand(queryTextBox.Text, conn);

            //conn.Open();

            //SqlDataReader queryResult = cmd.ExecuteReader();

            //do
            //{
            //    while (queryResult.Read())
            //    {
            //        dataSet.Tables["Authors"].Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
            //    }
            //}
            //while (queryResult.NextResult());


            //resultDataGridView.DataSource = dataSet.Tables["Authors"];

             sqlDataAdapter = new SqlDataAdapter(queryTextBox.Text, conn);

            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

      
            // sqlDataAdapter.UpdateCommand 
            // sqlDataAdapter.InsertCommand  = new SqlCommand(@"INSERT INTO @Table VALUES(@Name,@Sur)")
            // sqlDataAdapter.DeleteCommand


            sqlDataAdapter.Fill(dataSet);


            richTextBox1.Text = sqlCommandBuilder.GetUpdateCommand().CommandText;

            resultDataGridView.DataSource = dataSet.Tables[0];



        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlDataAdapter.Update(dataSet);
        }
    }
}
