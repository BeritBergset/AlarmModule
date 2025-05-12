using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace AirHeater
{
    public partial class Alarms : Form
    {
        public SqlConnection SqlCon;
        public Alarms(string Newserver,string NewSqlServer, string NewDatabase)
        {
            InitializeComponent();
            Timer2.Interval = 10000;
            lstMessages.Items.Add("New AlarmModule: "+ Newserver +":"+ NewSqlServer+":"+ NewDatabase);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //opne kontakt mot SQL
            SqlCon = new SqlConnection("Data source = DESKTOP-MHK7BOK\\SQLEXPRESS;Initial Catalog =AirHeater;Integrated Security=True;TrustServerCertificate=True");
            SqlCon.Open();
            Timer2.Start();
            Timer2.Tick += new EventHandler(Timer2_Tick);
            SQLReadActiveAlarms();
            lstMessages.Items.Add("Alarm form loaded");

            ////lese alle alarmar i alarmdatabasen
            //string SQLQueryReadAlarms = $"select ID, AlarmTag, Time, AlarmState, Description from ViewAlarms";

            //using (var adapter = new SqlDataAdapter(SQLQueryReadAlarms, SqlCon))
            //{
            //    var SensorTable = new DataTable();
            //    adapter.Fill(SensorTable);

            //    // Bind DataTable til DataGridView
            //    dgAlarms.DataSource = SensorTable;
            //}

            ////dgAlarms.Columns[0].Width = 50;
            //dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {

            SQLReadAlarms();


        }
        private void SQLReadAlarms()
        {
            //lese alle alarmar i alarmdatabasen
            string SQLQueryReadAlarms = $"select ID, AlarmTag, Time, AlarmState, Description from ViewAlarms order by Time Desc";

            using (var adapter = new SqlDataAdapter(SQLQueryReadAlarms, SqlCon))
            {
                var SensorTable = new DataTable();
                adapter.Fill(SensorTable);

                // Bind DataTable til DataGridView
                dgAlarms.DataSource = SensorTable;
            }

            dgAlarms.Columns[0].Width = 50;
            dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SQLReadActiveAlarms()
        {
            //lese alle active alarmar i alarmdatabasen
            string SQLQueryReadAlarms = $"select ID, AlarmTag, Time, AlarmState, Description from ViewAlarms where AlarmState='Active' order by Time Desc";

            using (var adapter = new SqlDataAdapter(SQLQueryReadAlarms, SqlCon))
            {
                var SensorTable = new DataTable();
                adapter.Fill(SensorTable);

                // Bind DataTable til DataGridView
                dgAlarms.DataSource = SensorTable;
            }

            dgAlarms.Columns[0].Width = 50;
            dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var AlarmID = dgAlarms.Rows[e.RowIndex].Cells[0].Value;
            var AlarmState = dgAlarms.Rows[e.RowIndex].Cells[3].Value.ToString();
            lstMessages.Items.Add("Chosen AlarmID: " + AlarmID + " Chosen AlarmState: " + AlarmState);
            if (AlarmState == "Active")
            {
                string SQLQueryUpdateAlarms1 = $"update AlarmSample set AlarmState=2 where ID={AlarmID}";
                SqlCommand SqlCmd1 = new SqlCommand(SQLQueryUpdateAlarms1, SqlCon);
                SqlCmd1.ExecuteNonQuery();
                lstMessages.Items.Add(DateTime.Now + " AlarmID: " + AlarmID + " acknowledged");
                SQLReadAlarms();
            }
            //string SQLQueryUpdateAlarms = $"update AlarmSample set AlarmState";


        }

        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLReadAlarms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLReadActiveAlarms();
        }
    }
}
