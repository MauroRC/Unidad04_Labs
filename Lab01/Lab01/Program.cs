using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //para tener acceso a las clases de entrada y salida: filestream

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            /*en el constructor de filestream se especifica:
             * el nombre del archivo que vamos a leer.
             * constante que determina como abrir o crear el archivo. En este caso especifica que el SO debe abrir un archivo existente.
             * constante que determina como puede obtener acceso al archivo el objeto Filestream. En este caso es de solo lectura.
             * constante que determina como compartiran el archivo los procesos. En este caso permite una posterior apertura del archivo para leerlo.
             */
            while (lector.Length > lector.Position) // inicialmente  lector.Position= 0.
            {
                Console.Write((char)lector.ReadByte()); // lee un byte y avanza una posicion
            }
            lector.Close();
            Console.ReadKey(); 
        }
    }
}
