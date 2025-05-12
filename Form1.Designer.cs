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
            txtServer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSqlServer = new TextBox();
            label3 = new Label();
            txtDatabase = new TextBox();
            BtnNewAlarmModule = new Button();
            SuspendLayout();
            // 
            // txtServer
            // 
            txtServer.Location = new Point(63, 87);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(467, 31);
            txtServer.TabIndex = 0;
            txtServer.TextChanged += txtServer_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 57);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 134);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "SQLserver";
            // 
            // txtSqlServer
            // 
            txtSqlServer.Location = new Point(66, 164);
            txtSqlServer.Name = "txtSqlServer";
            txtSqlServer.Size = new Size(467, 31);
            txtSqlServer.TabIndex = 2;
            txtSqlServer.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 218);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 5;
            label3.Text = "Database Name";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(69, 248);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(467, 31);
            txtDatabase.TabIndex = 4;
            // 
            // BtnNewAlarmModule
            // 
            BtnNewAlarmModule.Location = new Point(71, 322);
            BtnNewAlarmModule.Name = "BtnNewAlarmModule";
            BtnNewAlarmModule.Size = new Size(465, 34);
            BtnNewAlarmModule.TabIndex = 6;
            BtnNewAlarmModule.Text = "Start Alarm Module";
            BtnNewAlarmModule.UseVisualStyleBackColor = true;
            BtnNewAlarmModule.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 652);
            Controls.Add(BtnNewAlarmModule);
            Controls.Add(label3);
            Controls.Add(txtDatabase);
            Controls.Add(label2);
            Controls.Add(txtSqlServer);
            Controls.Add(label1);
            Controls.Add(txtServer);
            Name = "Form1";
            Text = "Alarm Module";
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
    }
}
