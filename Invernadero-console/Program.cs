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
        public static Arduino.Arduino arduino;

        static void Main(string[] args)
        {
            arduino = new Arduino.Arduino();
            arduino.EstadoArduino(true);

            var escritura = Console.ReadLine();
            Recursivo(escritura);
        }


        private static void Recursivo(string escritura)
        {
            if (escritura.ToUpper() != "N")
            {
                //Console.WriteLine("Datos");
                Console.WriteLine(arduino.DevuelveDatos());
                var r = Console.ReadLine();
                Recursivo(r);
            }
            else
                Console.ReadKey();
        }
    }
}
