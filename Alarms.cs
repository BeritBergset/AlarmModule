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
using Opc.UaFx.Client;

namespace AirHeater
{
    public partial class Alarms : Form
    {
        public OpcClient clientR;
        public int TT02H_State = 0; //styrer alarmstatus
        public int TT02L_State = 0;
        public SqlConnection SqlCon;
        //public string OPCString;
        public Alarms(string NewServer, string NewSqlServer, string NewDatabase, string NewOPCString, string AlarmHandlerName)
        {
            InitializeComponent();
            Timer2.Interval = 10000;
            SqlCon = new SqlConnection($"Data source = {NewServer}\\{NewSqlServer};Initial Catalog ={NewDatabase};Integrated Security=True;TrustServerCertificate=True");
            clientR = new OpcClient(NewOPCString);
            this.Text = "AlarmHandler: " + AlarmHandlerName;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            //connect to SQL
            SqlCon.Open();
            Timer2.Start();
            Timer2.Tick += new EventHandler(Timer2_Tick);
            SQLReadActiveAlarms();



            // connect to OPC

            clientR.Connect();

        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            OpcSqlTransfer(); // transfer data from OPC to SQL
        }
        private void OpcSqlTransfer()
        {
            //les inn alle variabler temperaturar pr syklustid
            string strTT02_H = "ns=2;s=TT02H_AL";
            string strTT02_L = "ns=2;s=TT02L_AL";

            Opc.UaFx.OpcValue opcData1 = clientR.ReadNode(strTT02_H).As<bool>();
            Opc.UaFx.OpcValue opcData2 = clientR.ReadNode(strTT02_L).As<bool>(); ;


            //registering alarms:
            //writing to SQL
            switch (TT02H_State)
            {
                case 0: //OK/OFF
                    if (opcData1 == true)
                    {
                        string SQLQueryWriteAlarmH1 = "update AlarmTag set AlarmStatus = 1, AlarmState=1 where AlarmTag ='TT02_H'";
                        SqlCommand SqlCmd1 = new SqlCommand(SQLQueryWriteAlarmH1, SqlCon);
                        SqlCmd1.ExecuteNonQuery();
                        TT02H_State = 1;
                        lstMessages.Items.Add(DateTime.Now + ": Alarm TT02_H activated");
                    }
                    break;
                case 1: // Aktivert, ikkje kvittert
                    {
                        if (opcData1 == false) //alarm er frågått, fortsatt ikkje kvittert. går til X dersom den blir frågått
                        {
                            string SQLQueryWriteAlarmH2 = "update AlarmTag set AlarmStatus = 0, AlarmState=3 where AlarmTag ='TT02_H'";
                            SqlCommand SqlCmd2 = new SqlCommand(SQLQueryWriteAlarmH2, SqlCon);
                            SqlCmd2.ExecuteNonQuery();
                            TT02H_State = 4;
                        }
                        break;
                    }
                case 2: // køyrer kun ein syklus. er Aktiv, men er blitt kvittert av operatør og går til 3
                    string SQLQueryWriteAlarmH3 = "update AlarmTag set AlarmState=2 where AlarmTag ='TT02_H'";
                    SqlCommand SqlCmd3 = new SqlCommand(SQLQueryWriteAlarmH3, SqlCon);
                    SqlCmd3.ExecuteNonQuery();
                    TT02H_State = 3;
                    break;
                case 3: // stabil, kvittert men aktiv
                    if (opcData1 == false)
                    {
                        string SQLQueryWriteAlarmH = "update AlarmTag set AlarmStatus = 0, AlarmState=0 where AlarmTag ='TT02_H'";
                        SqlCommand SqlCmd = new SqlCommand(SQLQueryWriteAlarmH, SqlCon);
                        SqlCmd.ExecuteNonQuery();
                        TT02H_State = 0;

                    }
                    break;
                case 4: //aktiv, ikkje kvittert
                    {
                        break;
                    }
                case 5: // alarm er kvittert og går til 0
                    {
                        TT02H_State = 3;
                        break;

                    }
            }
            switch (TT02L_State)
            {
                case 0: //OK/OFF
                    {
                        if (opcData2 == true)
                        {
                            string SQLQueryWriteAlarmL1 = "update AlarmTag set AlarmStatus = 1, AlarmState=1 where AlarmTag ='TT02_L'";
                            SqlCommand SqlCmdL1 = new SqlCommand(SQLQueryWriteAlarmL1, SqlCon);
                            SqlCmdL1.ExecuteNonQuery();
                            TT02L_State = 1;
                            lstMessages.Items.Add(DateTime.Now + ": Alarm TT02_L activated");
                        }
                        break;
                    }
                case 1: // Aktivert, ikkje kvittert
                    {
                        if (opcData2 == false) //alarm er frågått, fortsatt ikkje kvittert. går til X dersom den blir frågått
                        {
                            string SQLQueryWriteAlarmL2 = "update AlarmTag set AlarmStatus = 0, AlarmState=3 where AlarmTag ='TT02_L'";
                            SqlCommand SqlCmdL2 = new SqlCommand(SQLQueryWriteAlarmL2, SqlCon);
                            SqlCmdL2.ExecuteNonQuery();
                            TT02L_State = 4;
                        }
                        break;
                    }
                case 2: // køyrer kun ein syklus. er Aktiv, men er blitt kvittert av operatør og går til 3
                    {
                        string SQLQueryWriteAlarmL3 = "update AlarmTag set AlarmState=2 where AlarmTag ='TT02_L'";
                        SqlCommand SqlCmdL3 = new SqlCommand(SQLQueryWriteAlarmL3, SqlCon);
                        SqlCmdL3.ExecuteNonQuery();
                        TT02L_State = 3;
                        break;
                    }
                case 3: // stabil, kvittert men aktiv
                    {
                        if (opcData2 == false)
                        {
                            string SQLQueryWriteAlarmL = "update AlarmTag set AlarmStatus = 0, AlarmState=0 where AlarmTag ='TT02_L'";
                            SqlCommand SqlCmdL = new SqlCommand(SQLQueryWriteAlarmL, SqlCon);
                            SqlCmdL.ExecuteNonQuery();
                            TT02L_State = 0;
                        }
                        break;
                    }
                case 4: //aktiv, ikkje kvittert
                    {
                        break;
                    }
                case 5: // alarm er kvittert og går til 0
                    {
                        TT02L_State = 3;
                        break;
                    }
            }
        }
        private void SQLReadAlarms()
        {
            //lese alarmlogg i alarmdatabasen
            string SQLQueryReadAlarms = $"select Time, AlarmTag, AlarmState, Description from ViewAlarms order by Time Desc";

            using (var adapter = new SqlDataAdapter(SQLQueryReadAlarms, SqlCon))
            {
                var SensorTable = new DataTable();
                adapter.Fill(SensorTable);

                // Bind DataTable til DataGridView
                dgAlarms.DataSource = SensorTable;
            }

            dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlarms.Columns[0].Width = 100;
            dgAlarms.Columns[1].Width = 100;
            dgAlarms.Columns[2].Width = 120;

        }
        private void SQLReadActiveAlarms()
        {
            //lese alle active alarmar i alarmdatabasen
            //string SQLQueryReadAlarms = $"select ID, AlarmTag, Time, AlarmState, Description from ViewAlarms where AlarmState='Active' order by Time Desc";
            string SQLQueryReadAlarms = "select AlarmTag, Category, AlarmStatus, AlarmTagDescription from ViewActiveAlarms";
            using (var adapter = new SqlDataAdapter(SQLQueryReadAlarms, SqlCon))
            {
                var SensorTable = new DataTable();
                adapter.Fill(SensorTable);

                // Bind DataTable til DataGridView
                dgAlarms.DataSource = SensorTable;
            }
            dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlarms.Columns[0].Width = 100;
            dgAlarms.Columns[1].Width = 100;
            dgAlarms.Columns[2].Width = 120;
            //dgAlarms.Columns[3].Width = 150;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string AlarmID = dgAlarms.Rows[e.RowIndex].Cells[0].Value.ToString();
            lstMessages.Items.Add("Chosen Tag: " + AlarmID);
            if (AlarmID == "TT02_H" && TT02H_State >= 1)
            {
                TT02H_State++;

            }
            if (AlarmID == "TT02_L" && TT02L_State >= 1)
            {
                TT02L_State++;

            }
            lstMessages.Items.Add($"Acknowledged {AlarmID}");

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
