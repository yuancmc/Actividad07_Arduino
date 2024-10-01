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

namespace Actividad07_Arduino
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM7";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += Cerrandoform1;
            this.Encender.Click += button1_Click;
            this.Apagar.Click += Apagar_Click;
        


    }

    private void button1_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");

        }

        private void Cerrandoform1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();

        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
    }
}
