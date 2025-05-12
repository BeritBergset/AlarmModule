using AirHeater;

namespace AlarmModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string NewServer = txtServer.Text;
            string NewSQLServer = txtSqlServer.Text;
            string NewDatabase = txtDatabase.Text;

            Alarms AlarmHandler = new Alarms(NewServer, NewSQLServer,NewDatabase);
            AlarmHandler.Show();

        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
