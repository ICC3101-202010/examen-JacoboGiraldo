using System;

namespace ExamenPP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Menu = "1) Crear Equipo \n2) Salir";
            string Menu2 = "1) Agregar Jugadores \n2) Ver Informacion del Equipo \n3) Salir";
            while (true)
            {
                Console.WriteLine(Menu);
                string Seleccion = Console.ReadLine();

                if (Seleccion == "1")
                {
                    Console.WriteLine("Ingrese el tipo de equipo (Liga/Nacional)");
                    string tipo = Console.ReadLine();
                    Console.WriteLine("Especifique el nombre de la liga o nacinalidad del equipo:");
                    string espTipo = Console.ReadLine();
                    Console.WriteLine("Inserte el nombre del equipo:");
                    string nombre = Console.ReadLine();

                    Equipo NewTeam = new Equipo(tipo, espTipo, nombre);

                    
                    while(true)
                    {
                        Console.WriteLine(Menu2);
                        string Seleccion2 = Console.ReadLine();
                        if (Seleccion2 == "1")
                        {

                            Console.WriteLine("Ingrese el nombre del jugador:");
                            string No = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad del jugador:");
                            int Ed = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el pais de origen del jugador: ");
                            string Na = Console.ReadLine();
                            Console.WriteLine("Ingrese el sueldo del jugador: ");
                            int Su = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la posicion del jugador (Medio-Defensa-Delantero-Arquero): ");
                            string Po = Console.ReadLine();
                            Console.WriteLine("Ingrese sus puntos de ataque: ");
                            int PtA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese sus puntos de defensa: ");
                            int PtD = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el numero de su camiseta: ");
                            int NuC = int.Parse(Console.ReadLine());
                            NewTeam.AgregarJugador(No, Ed, Na, Su, Po, PtA, PtD, NuC);

                        }
                        if (Seleccion2 == "2")
                        {
                            NewTeam.FullTeamInfo();
                        }
                        if (Seleccion2 == "3")
                            break;
                    }
                    
                }
                if (Seleccion == "2")
                    break;









            }


        }
    }
}
