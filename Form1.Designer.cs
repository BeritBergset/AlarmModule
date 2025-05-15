namespace AlarmModule
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtServer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSqlServer = new TextBox();
            label3 = new Label();
            txtDatabase = new TextBox();
            BtnNewAlarmModule = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtIpAdresse = new TextBox();
            label4 = new Label();
            txtPort = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtOpcServerName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            lstMessages = new ListBox();
            label9 = new Label();
            txtPCSName = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtServer
            // 
            resources.ApplyResources(txtServer, "txtServer");
            txtServer.Name = "txtServer";
            txtServer.TextChanged += txtServer_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtSqlServer
            // 
            resources.ApplyResources(txtSqlServer, "txtSqlServer");
            txtSqlServer.Name = "txtSqlServer";
            txtSqlServer.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtDatabase
            // 
            resources.ApplyResources(txtDatabase, "txtDatabase");
            txtDatabase.Name = "txtDatabase";
            // 
            // BtnNewAlarmModule
            // 
            resources.ApplyResources(BtnNewAlarmModule, "BtnNewAlarmModule");
            BtnNewAlarmModule.Name = "BtnNewAlarmModule";
            BtnNewAlarmModule.UseVisualStyleBackColor = true;
            BtnNewAlarmModule.Click += button1_Click;
            // 
            // txtIpAdresse
            // 
            resources.ApplyResources(txtIpAdresse, "txtIpAdresse");
            txtIpAdresse.Name = "txtIpAdresse";
            txtIpAdresse.TextChanged += textBox1_TextChanged_1;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // txtPort
            // 
            resources.ApplyResources(txtPort, "txtPort");
            txtPort.Name = "txtPort";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            label6.Click += label6_Click;
            // 
            // txtOpcServerName
            // 
            resources.ApplyResources(txtOpcServerName, "txtOpcServerName");
            txtOpcServerName.Name = "txtOpcServerName";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            resources.ApplyResources(lstMessages, "lstMessages");
            lstMessages.Name = "lstMessages";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // txtPCSName
            // 
            resources.ApplyResources(txtPCSName, "txtPCSName");
            txtPCSName.Name = "txtPCSName";
            txtPCSName.TextChanged += textBox1_TextChanged_2;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(txtPCSName);
            Controls.Add(label9);
            Controls.Add(lstMessages);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtOpcServerName);
            Controls.Add(label5);
            Controls.Add(txtPort);
            Controls.Add(label4);
            Controls.Add(txtIpAdresse);
            Controls.Add(BtnNewAlarmModule);
            Controls.Add(label3);
            Controls.Add(txtDatabase);
            Controls.Add(label2);
            Controls.Add(txtSqlServer);
            Controls.Add(label1);
            Controls.Add(txtServer);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServer;
        private Label label1;
        private Label label2;
        private TextBox txtSqlServer;
        private Label label3;
        private TextBox txtDatabase;
        private Button BtnNewAlarmModule;
        public System.Windows.Forms.Timer timer1;
        private TextBox txtIpAdresse;
        private Label label4;
        private TextBox txtPort;
        private Label label5;
        private Label label6;
        private TextBox txtOpcServerName;
        private Label label7;
        private Label label8;
        private ListBox lstMessages;
        private Label label9;
        private TextBox txtPCSName;
        private Label label10;
    }
}
