namespace AirHeater
{
    partial class Alarms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgAlarms = new DataGridView();
            lstMessages = new ListBox();
            Timer2 = new System.Windows.Forms.Timer(components);
            btnActiveAlarms = new Button();
            btnAllAlarms = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAlarms).BeginInit();
            SuspendLayout();
            // 
            // dgAlarms
            // 
            dgAlarms.AllowUserToAddRows = false;
            dgAlarms.AllowUserToDeleteRows = false;
            dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgAlarms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgAlarms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlarms.Location = new Point(41, 41);
            dgAlarms.Name = "dgAlarms";
            dgAlarms.ReadOnly = true;
            dgAlarms.RowHeadersWidth = 62;
            dgAlarms.Size = new Size(911, 452);
            dgAlarms.TabIndex = 0;
            dgAlarms.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(41, 539);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(1095, 129);
            lstMessages.TabIndex = 1;
            lstMessages.SelectedIndexChanged += lstMessages_SelectedIndexChanged;
            // 
            // Timer2
            // 
            Timer2.Enabled = true;
            // 
            // btnActiveAlarms
            // 
            btnActiveAlarms.Location = new Point(977, 41);
            btnActiveAlarms.Name = "btnActiveAlarms";
            btnActiveAlarms.Size = new Size(159, 34);
            btnActiveAlarms.TabIndex = 2;
            btnActiveAlarms.Text = "Active Alarms";
            btnActiveAlarms.UseVisualStyleBackColor = true;
            btnActiveAlarms.Click += button1_Click;
            // 
            // btnAllAlarms
            // 
            btnAllAlarms.Location = new Point(977, 81);
            btnAllAlarms.Name = "btnAllAlarms";
            btnAllAlarms.Size = new Size(159, 34);
            btnAllAlarms.TabIndex = 3;
            btnAllAlarms.Text = "Historical Alarms";
            btnAllAlarms.UseVisualStyleBackColor = true;
            btnAllAlarms.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 511);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 32;
            label6.Text = "Logg";
            // 
            // Alarms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 680);
            Controls.Add(label6);
            Controls.Add(btnAllAlarms);
            Controls.Add(btnActiveAlarms);
            Controls.Add(lstMessages);
            Controls.Add(dgAlarms);
            Name = "Alarms";
            Text = "Alarm Handler";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlarms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgAlarms;
        private ListBox lstMessages;
        private System.Windows.Forms.Timer Timer2;
        private Button btnActiveAlarms;
        private Button btnAllAlarms;
        private Label label6;
    }
}