using System;
using System.Collections.Generic;
namespace ExamenPP
{
    public class Equipo
    {
        public Equipo()
        {
        }

        private string tipo;
        private string espTipo;
        private string nombre;

        private List<Jugadores> JugadoresEquipo;

        public string Tipo { get => tipo; set => tipo = value; }
        public string EspTipo { get => espTipo; set => espTipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void FullTeamInfo()
        {
            foreach (Jugadores JugadorRandom in JugadoresEquipo)
            {
                Console.WriteLine(JugadorRandom.GetInfo());
            }
        }

        public void AgregarJugador(string No, int Ed, string Na, int Su, string Po, int PtA, int PtD, int NuC)
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
