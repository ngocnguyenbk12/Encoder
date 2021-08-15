using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool i = true;
        int g = 0;
        float setpointdraw;
        public Form1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minbtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maxbtn.Visible = false;
            regularbtn.Visible = true;
        }

        private void regularbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maxbtn.Visible = true;
            regularbtn.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            namePort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();     //lay cong COM
            namePort.Items.AddRange(ports);   // Them cong COM vao combobox

            btncon.Enabled = true;
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = namePort.Text;
               
                if (string.IsNullOrEmpty(baudRate.Text) == false)
                    serialPort1.BaudRate = int.Parse(baudRate.Text);
                if (string.IsNullOrEmpty(dataBits.Text) == false)
                    serialPort1.DataBits = int.Parse(dataBits.Text);
                if (string.IsNullOrEmpty(parityBits.Text) == false)
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parityBits.Text);
                if (string.IsNullOrEmpty(stopBits.Text) == false)
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits.Text);
                if (serialPort1.IsOpen)
                { serialPort1.Close(); };

                serialPort1.Open();
                btncon.Enabled = false;
                btndis.Enabled = true;
                btnget.Enabled = false;
                recbtn.Enabled = true;
                clrbtn.Enabled = true;
                sendbtn.Enabled = true;

                namePort.Enabled = false;
                baudRate.Enabled = false;
                stopBits.Enabled = false;
                parityBits.Enabled = false;
                dataBits.Enabled = false;


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btndis_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            btncon.Enabled = true;
            btndis.Enabled = false;
            btnget.Enabled = true;
            clrbtn.Enabled = false;
            sendbtn.Enabled = false;
            recbtn.Enabled = false;



            namePort.Enabled = true;
            baudRate.Enabled = true;
            stopBits.Enabled = true;
            parityBits.Enabled = true;
            dataBits.Enabled = true;
        }

        private void namePort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recbtn_Click(object sender, EventArgs e)
        {
            if (i)
            {
                recbtn.Text = "Stop";
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(something);
            }
            else
            {
                recbtn.Text = "Receive";
                serialPort1.DataReceived -= new SerialDataReceivedEventHandler(something);


            }
            i = !i;
        }

        private void something(object sender, SerialDataReceivedEventArgs e)
        {
                byte[] data = new byte[4];
                serialPort1.Read(data, 0, 4);
                //Array.Reverse(data);
                float myFloat = System.BitConverter.ToSingle(data, 0);

                
                Invoke(new MethodInvoker(() => this.chart1.Series["Data"].Points.AddXY(g, myFloat)));
                Invoke(new MethodInvoker(() => this.chart1.Series["Setpoint"].Points.AddXY(g, setpointdraw))); 
                g++;

                //Invoke(new MethodInvoker(() => this.chart1.Series["series1"].Points.Add(myFloat)));
                //Invoke(new MethodInvoker(() => richTextBox1.Text += myFloat.ToString() + "\r\n"));
                Invoke(new MethodInvoker(() => richTextBox1.AppendText(myFloat.ToString() + "\r\n")));
                Invoke(new MethodInvoker(() => richTextBox1.ScrollToCaret()));

        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            serialPort1.DiscardInBuffer();
            richTextBox1.Clear();
            chart1.Series["Data"].Points.Clear();

            chart1.Series["Setpoint"].Points.Clear();
            g = 0;
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            float kpf, kif, kdf, setpointf;
            kpf = float.Parse(kp.Text);
            serialPort1.Write("P");
            sendData(kpf);
            kif = float.Parse(ki.Text);
            serialPort1.Write("I");
            sendData(kif);
            kdf = float.Parse(kd.Text);
            serialPort1.Write("D");
            sendData(kdf);

            if (mode.Text == "Vị trí")
            {
                setpointf = float.Parse(setpoint.Text);
                serialPort1.Write("A");
            }
            else
            {
                setpointf = float.Parse(setpoint.Text);
                serialPort1.Write("B");
            }
            sendData(setpointf);
            setpointdraw = setpointf;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendData(float a)
        {
            byte[] data = BitConverter.GetBytes(a);
           // Array.Reverse(data);
            serialPort1.Write(data, 0, 4);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
