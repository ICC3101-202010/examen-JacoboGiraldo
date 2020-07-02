using System;

namespace ExamenPP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tipo de equipo (Liga/Nacional)");
            string tipo = Console.ReadLine();
            Console.WriteLine("Especifique el nombre de la liga o nacinalidad del equipo:");
            string espTipo = Console.ReadLine();
            Console.WriteLine("Inserte el nombre del equipo:");
            string nombre = Console.ReadLine();

            Equipo NewTeam = new Equipo(tipo, espTipo, nombre);

            







        }
    }
}
