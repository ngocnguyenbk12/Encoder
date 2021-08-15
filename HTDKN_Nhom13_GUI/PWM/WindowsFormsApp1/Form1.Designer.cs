namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regularbtn = new System.Windows.Forms.Button();
            this.maxbtn = new System.Windows.Forms.Button();
            this.minbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btndis = new System.Windows.Forms.Button();
            this.btncon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parityBits = new System.Windows.Forms.ComboBox();
            this.stopBits = new System.Windows.Forms.ComboBox();
            this.dataBits = new System.Windows.Forms.ComboBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.namePort = new System.Windows.Forms.ComboBox();
            this.btnget = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clrbtn = new System.Windows.Forms.Button();
            this.recbtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mode = new System.Windows.Forms.ComboBox();
            this.setpoint = new System.Windows.Forms.TextBox();
            this.kd = new System.Windows.Forms.TextBox();
            this.ki = new System.Windows.Forms.TextBox();
            this.kp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sendbtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(427, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 18);
            label1.TabIndex = 26;
            label1.Text = "Setpoint";
            label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(427, 50);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 18);
            label7.TabIndex = 31;
            label7.Text = "Mode";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.regularbtn);
            this.panel1.Controls.Add(this.maxbtn);
            this.panel1.Controls.Add(this.minbtn);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // regularbtn
            // 
            this.regularbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regularbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.regularbtn.FlatAppearance.BorderSize = 0;
            this.regularbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularbtn.ForeColor = System.Drawing.Color.White;
            this.regularbtn.Location = new System.Drawing.Point(1303, 2);
            this.regularbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regularbtn.Name = "regularbtn";
            this.regularbtn.Size = new System.Drawing.Size(44, 30);
            this.regularbtn.TabIndex = 4;
            this.regularbtn.Text = "C";
            this.regularbtn.UseVisualStyleBackColor = false;
            this.regularbtn.Visible = false;
            this.regularbtn.Click += new System.EventHandler(this.regularbtn_Click);
            // 
            // maxbtn
            // 
            this.maxbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.maxbtn.FlatAppearance.BorderSize = 0;
            this.maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxbtn.ForeColor = System.Drawing.Color.White;
            this.maxbtn.Location = new System.Drawing.Point(1303, 2);
            this.maxbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxbtn.Name = "maxbtn";
            this.maxbtn.Size = new System.Drawing.Size(44, 30);
            this.maxbtn.TabIndex = 3;
            this.maxbtn.Text = "O";
            this.maxbtn.UseVisualStyleBackColor = false;
            this.maxbtn.Click += new System.EventHandler(this.maxbtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.ForeColor = System.Drawing.Color.White;
            this.minbtn.Location = new System.Drawing.Point(1253, 2);
            this.minbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(44, 30);
            this.minbtn.TabIndex = 2;
            this.minbtn.Text = "_";
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click_1);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(1353, 2);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(44, 30);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnget);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 863);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btndis);
            this.groupBox1.Controls.Add(this.btncon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.parityBits);
            this.groupBox1.Controls.Add(this.stopBits);
            this.groupBox1.Controls.Add(this.dataBits);
            this.groupBox1.Controls.Add(this.baudRate);
            this.groupBox1.Controls.Add(this.namePort);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(7, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 615);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "PARITY BITS";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "STOP BITS";
            // 
            // btndis
            // 
            this.btndis.AutoSize = true;
            this.btndis.BackColor = System.Drawing.Color.LightGray;
            this.btndis.Enabled = false;
            this.btndis.FlatAppearance.BorderSize = 0;
            this.btndis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndis.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btndis.Location = new System.Drawing.Point(60, 490);
            this.btndis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(160, 80);
            this.btndis.TabIndex = 13;
            this.btndis.Text = "Disconnect";
            this.btndis.UseVisualStyleBackColor = false;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // btncon
            // 
            this.btncon.AutoSize = true;
            this.btncon.BackColor = System.Drawing.Color.LightGray;
            this.btncon.Enabled = false;
            this.btncon.FlatAppearance.BorderSize = 0;
            this.btncon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncon.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btncon.Location = new System.Drawing.Point(60, 380);
            this.btncon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(160, 80);
            this.btncon.TabIndex = 10;
            this.btncon.Text = "Connect";
            this.btncon.UseVisualStyleBackColor = false;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "DATA BITS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "BAUD RATE";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "COM PORT";
            // 
            // parityBits
            // 
            this.parityBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parityBits.FormattingEnabled = true;
            this.parityBits.Items.AddRange(new object[] {
            "None ",
            "Even",
            "Odd"});
            this.parityBits.Location = new System.Drawing.Point(129, 295);
            this.parityBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parityBits.Name = "parityBits";
            this.parityBits.Size = new System.Drawing.Size(123, 24);
            this.parityBits.TabIndex = 17;
            // 
            // stopBits
            // 
            this.stopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBits.FormattingEnabled = true;
            this.stopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.stopBits.Location = new System.Drawing.Point(129, 234);
            this.stopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBits.Name = "stopBits";
            this.stopBits.Size = new System.Drawing.Size(123, 24);
            this.stopBits.TabIndex = 16;
            // 
            // dataBits
            // 
            this.dataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBits.FormattingEnabled = true;
            this.dataBits.Items.AddRange(new object[] {
            "8",
            "9",
            "10"});
            this.dataBits.Location = new System.Drawing.Point(129, 174);
            this.dataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBits.Name = "dataBits";
            this.dataBits.Size = new System.Drawing.Size(123, 24);
            this.dataBits.TabIndex = 15;
            // 
            // baudRate
            // 
            this.baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.baudRate.Location = new System.Drawing.Point(129, 112);
            this.baudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(123, 24);
            this.baudRate.TabIndex = 14;
            // 
            // namePort
            // 
            this.namePort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namePort.FormattingEnabled = true;
            this.namePort.Location = new System.Drawing.Point(129, 50);
            this.namePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namePort.Name = "namePort";
            this.namePort.Size = new System.Drawing.Size(123, 24);
            this.namePort.TabIndex = 7;
            this.namePort.SelectedIndexChanged += new System.EventHandler(this.namePort_SelectedIndexChanged);
            // 
            // btnget
            // 
            this.btnget.BackColor = System.Drawing.Color.LightGray;
            this.btnget.FlatAppearance.BorderSize = 0;
            this.btnget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnget.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnget.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnget.Location = new System.Drawing.Point(67, 18);
            this.btnget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(160, 80);
            this.btnget.TabIndex = 15;
            this.btnget.Text = "Get Port";
            this.btnget.UseVisualStyleBackColor = false;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.clrbtn);
            this.panel2.Controls.Add(this.recbtn);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(280, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 740);
            this.panel2.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Vận tốc";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(5, 130);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Vận tốc";
            series3.Name = "Data";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Vận tốc";
            series4.Name = "Setpoint";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1111, 599);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.LightGray;
            this.clrbtn.Enabled = false;
            this.clrbtn.FlatAppearance.BorderSize = 0;
            this.clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrbtn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clrbtn.Location = new System.Drawing.Point(203, 25);
            this.clrbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(141, 80);
            this.clrbtn.TabIndex = 7;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // recbtn
            // 
            this.recbtn.BackColor = System.Drawing.Color.LightGray;
            this.recbtn.Enabled = false;
            this.recbtn.FlatAppearance.BorderSize = 0;
            this.recbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recbtn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.recbtn.Location = new System.Drawing.Point(24, 25);
            this.recbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recbtn.Name = "recbtn";
            this.recbtn.Size = new System.Drawing.Size(141, 80);
            this.recbtn.TabIndex = 6;
            this.recbtn.Text = "Receive";
            this.recbtn.UseVisualStyleBackColor = false;
            this.recbtn.Click += new System.EventHandler(this.recbtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(381, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(141, 80);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.mode);
            this.panel4.Controls.Add(label7);
            this.panel4.Controls.Add(this.setpoint);
            this.panel4.Controls.Add(this.kd);
            this.panel4.Controls.Add(this.ki);
            this.panel4.Controls.Add(this.kp);
            this.panel4.Controls.Add(label1);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.sendbtn);
            this.panel4.Location = new System.Drawing.Point(280, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 124);
            this.panel4.TabIndex = 4;
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Vị trí",
            "Vận tốc"});
            this.mode.Location = new System.Drawing.Point(499, 50);
            this.mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(101, 24);
            this.mode.TabIndex = 32;
            // 
            // setpoint
            // 
            this.setpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.setpoint.Location = new System.Drawing.Point(500, 18);
            this.setpoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setpoint.Name = "setpoint";
            this.setpoint.Size = new System.Drawing.Size(100, 22);
            this.setpoint.TabIndex = 30;
            // 
            // kd
            // 
            this.kd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kd.Location = new System.Drawing.Point(244, 80);
            this.kd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kd.Name = "kd";
            this.kd.Size = new System.Drawing.Size(100, 22);
            this.kd.TabIndex = 29;
            // 
            // ki
            // 
            this.ki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ki.Location = new System.Drawing.Point(244, 47);
            this.ki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ki.Name = "ki";
            this.ki.Size = new System.Drawing.Size(100, 22);
            this.ki.TabIndex = 28;
            // 
            // kp
            // 
            this.kp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kp.Location = new System.Drawing.Point(244, 17);
            this.kp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kp.Name = "kp";
            this.kp.Size = new System.Drawing.Size(100, 22);
            this.kp.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(200, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Kd";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(200, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ki";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(200, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Kp";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.LightGray;
            this.sendbtn.Enabled = false;
            this.sendbtn.FlatAppearance.BorderSize = 0;
            this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbtn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sendbtn.Location = new System.Drawing.Point(24, 18);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(141, 80);
            this.sendbtn.TabIndex = 9;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button maxbtn;
        private System.Windows.Forms.Button regularbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox parityBits;
        private System.Windows.Forms.ComboBox stopBits;
        private System.Windows.Forms.ComboBox dataBits;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.ComboBox namePort;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btncon;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button recbtn;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox kp;
        private System.Windows.Forms.TextBox kd;
        private System.Windows.Forms.TextBox ki;
        private System.Windows.Forms.TextBox setpoint;
        private System.Windows.Forms.ComboBox mode;
    }
}

