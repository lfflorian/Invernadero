using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Arduino
{
    public class Arduino
    {
        SerialPort PuertoArduino;
        string Humedad;
        string Iluminosidad;
        string Temperatura;

        public Arduino()
        {
            PuertoArduino = new SerialPort()
            {
                PortName = "COM3",
                //  Baudio = numero de señales por segundo
                BaudRate = 9600,
            };
            PuertoArduino.DataReceived += new SerialDataReceivedEventHandler(Arduino_DataReceived);
        }

        public void EstadoArduino(bool estado)
        {
            if (estado)
                PuertoArduino.Open();
            else
                PuertoArduino.Close();
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // puerto serie que lanza el evento
            SerialPort currentSerialPort = (SerialPort)sender;
            // Leemos el dato recibido del puerto serie
            RegistroDatos(currentSerialPort.ReadLine());
        }

        private void RegistroDatos(string valor)
        {
            // se elimina el espacio que produce 'println' de arudio al final de una cadena
            var resultado = valor.Split('\r')[0];
            //Para separar los valores obtenidos se diferencia si contiene 'Temp', 'Lumi' o 'Hume' para colocarlo en su respectivo valor
            if (valor.Contains("Temp"))
            {
                Temperatura = resultado;
            } else if (valor.Contains("Lumi"))
            {
                Iluminosidad = resultado;
            } else if (valor.Contains("Hume"))
            {
                Humedad = resultado;
            }
        }

        public string DevuelveDatos()
        {
            var texto = $"{Temperatura} : { Iluminosidad }";
            return texto;
        }
    }
}
