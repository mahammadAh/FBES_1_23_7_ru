using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AsyncApp
{
    public partial class Form1 : Form
    {
        public string connectionString;
        private readonly SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["localDbConnection"].ConnectionString;

            conn = new SqlConnection(connectionString);

        }

        private void GetData(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Surname");


                var query = "WAITFOR DELAY '00:00:10' SELECT * FROM Authors";

                SqlCommand cmd = new SqlCommand(query, conn);



                conn.Open();

                SqlDataReader queryResult = cmd.ExecuteReader();


                int currentValue = int.Parse(TestButton.Text);
                currentValue++;
                TestButton.Text = currentValue.ToString();

                while (queryResult.Read())
                {
                    dataTable.Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
                }

                dataGridView1.DataSource = dataTable;
            }
            finally
            {
                conn.Close();
            }

        }



        private void asyncGetDataButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            SqlCommand comm = conn.CreateCommand();
            
            comm.CommandText = "WAITFOR DELAY '00:00:05' SELECT * FROM Authors";
            comm.CommandTimeout = 20;
            comm.CommandType = CommandType.Text;

            AsyncCallback callback = new AsyncCallback(GetData);

            conn.Open();

            comm.BeginExecuteReader(callback, comm);


            int currentValue = int.Parse(TestButton.Text);
            currentValue++;
            TestButton.Text = currentValue.ToString();


        }


        public void GetData(IAsyncResult result)
        {

            SqlCommand comm = (SqlCommand)result.AsyncState;

            SqlDataReader queryResult = comm.EndExecuteReader(result);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");


            while (queryResult.Read())
            {
                dataTable.Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
            }

            conn.Close();

            PrintDataIntoDataGridDelegate del =
            new PrintDataIntoDataGridDelegate(PrintDataIntoDataGrid);

            this.Invoke(del, dataTable);

        }


        private delegate void PrintDataIntoDataGridDelegate(DataTable data);




        public void PrintDataIntoDataGrid(DataTable data)
        {
            dataGridView1.DataSource = data;
        }

        private void GetDataAsyncHanldeButton_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "WAITFOR DELAY '00:00:05' SELECT * FROM Authors";
            comm.CommandTimeout = 20;
            comm.CommandType = CommandType.Text;

            //AsyncCallback callback = new AsyncCallback(GetData);

            conn.Open();

            IAsyncResult iar = comm.BeginExecuteReader();



            WaitHandle handle = iar.AsyncWaitHandle;

            while (handle.WaitOne(6000))
            {
                GetDataHandle(iar, comm);
            }


            int currentValue = int.Parse(TestButton.Text);
            currentValue++;
            TestButton.Text = currentValue.ToString();
        }


        public void GetDataHandle(IAsyncResult result, SqlCommand comm)
        {

            SqlDataReader queryResult = comm.EndExecuteReader(result);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");


            while (queryResult.Read())
            {
                dataTable.Rows.Add(queryResult[0], queryResult[1], queryResult[2]);
            }

            conn.Close();

            PrintDataIntoDataGridDelegate del =
            new PrintDataIntoDataGridDelegate(PrintDataIntoDataGrid);

            this.Invoke(del, dataTable);

        }
    }
}
