using System;
using System.Collections.Generic;
namespace ExamenPP
{
    public class Equipo
    {
        public Equipo(string T, string ET, string N)
        {
            tipo = T;
            espTipo = ET;
            nombre = N;
        }

        private string tipo; // Nacional - Liga
        private string espTipo; // Nombre de la nacion - Nombre de la liga
        private string nombre; // Nombre del equipo

        private List<Jugadores> JugadoresEquipo;
        

        public string Tipo { get => tipo; set => tipo = value; }
        public string EspTipo { get => espTipo; set => espTipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void FullTeamInfo()
        {
            Console.WriteLine("Nombre del equipo: "+nombre);
            Console.WriteLine("Tipo de equipo: "+tipo+" -> "+espTipo);
            Console.WriteLine("Plantel de Jugadores:");
            foreach (Jugadores JugadorRandom in JugadoresEquipo)
            {
                Console.WriteLine(JugadorRandom.GetInfo());
            }
        }

        public void AgregarJugador(string No, int Ed, string Na, int Su, string Po, int PtA, int PtD, int NuC)
        {
            
            if (tipo == "Nacional" && espTipo == Na)
            {
                Jugadores JX = new Jugadores();
                JX.Nombre = No;
                JX.Edad = Ed;
                JX.Nacion = Na;
                JX.Sueldo = Su;
                JX.Posicion = Po;
                JX.PtosAtaque1 = PtA;
                JX.PtosDefensa1 = PtD;
                JX.NumeroCamiseta1 = NuC;
                JugadoresEquipo.Add(JX);
            }
            else if (tipo == "Nacional" && espTipo != Na)
            {
                Console.WriteLine("Si el equipo es nacional el pais del equipo debe ser igual a la nacionalidad del jugador. Intentelo de nuevo.");
            }
            else if (tipo == "Liga")
            {
                Jugadores JX = new Jugadores();
                JX.Nombre = No;
                JX.Edad = Ed;
                JX.Nacion = Na;
                JX.Sueldo = Su;
                JX.Posicion = Po;
                JX.PtosAtaque1 = PtA;
                JX.PtosDefensa1 = PtD;
                JX.NumeroCamiseta1 = NuC;
                JugadoresEquipo.Add(JX);
            }     
        }
    }
}
