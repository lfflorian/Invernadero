using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arduino;

namespace Invernadero_console
{
    class Program
    {
        //Programa que solo muestra los datos recividos del arduino
        public static Arduino.Arduino arduino;

        static void Main(string[] args)
        {
            arduino = new Arduino.Arduino();
            arduino.EstadoArduino(true);

            var escritura = Console.ReadLine();
            Recursivo(escritura);
        }

        //Se preciona una tecla diferente de N para mostrar los datos sin cerrar el programa, N cierra el programa
        private static void Recursivo(string escritura)
        {
            if (escritura.ToUpper() != "N")
            {
                Console.WriteLine(arduino.DevuelveDatos());
                var r = Console.ReadLine();
                Recursivo(r);
            }
            else
                Console.ReadKey();
        }
    }
}
