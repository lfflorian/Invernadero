using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Arduino;

namespace Invernadero_App
{
    public partial class Form1 : Form
    {
        DataTable dt;
        Arduino.Arduino arduino;

        public Form1()
        {
            InitializeComponent();
            arduino = new Arduino.Arduino();
            /* Data Grid View */
            dt = new DataTable();
            dt.Columns.Add("Temperatura");
            dt.Columns.Add("Humedad");
            dt.Columns.Add("Luminocidad");
            dgbDatos.DataSource = dt;
        }
        
        private void btnConectarArduino_Click(object sender, EventArgs e)
        {
            if (txtPuerto.Text == "")
            {
                arduino.EstadoArduino(true);
            } else
            {
                arduino.CambiarPuerto(txtPuerto.Text);
                MessageBox.Show("Puerto asignado correctamente");
            }

            TiempoActualizacion.Enabled = true;
            btnConectarArduino.Text = "Cambiar puerto";
            btnDesconectar.Enabled = true;
        }

        private void TiempoActualizacion_Tick(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["Temperatura"] = ObtenerSoloDato(arduino.Temperatura);
            row["Humedad"] = ObtenerSoloDato(arduino.Humedad);
            row["Luminocidad"] = ObtenerSoloDato(arduino.Iluminosidad);
            dt.Rows.Add(row);
        }

        public string ObtenerSoloDato(string dato)
        {
            return dato.Split(' ')[1];
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            arduino.EstadoArduino(false);
            btnConectarArduino.Text = "Conectar Arduino";
            btnDesconectar.Enabled = false;
        }

        /* Socket */
        delegate void SetTextCallback(string text);
        TcpListener listener;
        TcpClient client;
        NetworkStream ns;
        Thread t = null;

        public void InicializacionDatosSocket()
        {
            listener = new TcpListener(2020);
            listener.Start();
            client = listener.AcceptTcpClient();
            ns = client.GetStream();
            t = new Thread(DoWork);
            t.Start();
        }

        public void DoWork()
        {
            try
            {

                byte[] bytes = new byte[1024];
                while (true)
                {
                    int bytesRead = ns.Read(bytes, 0, bytes.Length);
                    //this.SetText(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                    //se intercambia "Datos Arduino" por los datos a envíar 
                    byte[] byteTime = Encoding.ASCII.GetBytes("Datos Arduino");
                        //byte[] byteTime = Encoding.ASCII.GetBytes(arduino.DevuelveDatos());
                    ns.Write(byteTime, 0, byteTime.Length);
                }
            }
            catch (Exception)
            {
                piThread.Abort();
            }
        }

        Thread piThread;

        private void btnInitSocket_Click(object sender, EventArgs e)
        {
            piThread = new Thread(new ThreadStart(InicializacionDatosSocket));
            piThread.Start();
            lblSocketInit.Visible = true;
            btnInitSocket.Enabled = false;
        }
        
    }
}
