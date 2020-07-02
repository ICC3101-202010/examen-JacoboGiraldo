using System;
using System.Collections.Generic;
namespace ExamenPP
{
    public class Jugadores:Persona
    {
        private string posicion;
        private int PtosAtaque;
        private int PtosDefensa;
        private int NumeroCamiseta;

        public Jugadores()
        {
        }

        public string Posicion { get => posicion; set => posicion = value; }
        public int PtosAtaque1 { get => PtosAtaque; set => PtosAtaque = value; }
        public int PtosDefensa1 { get => PtosDefensa; set => PtosDefensa = value; }
        public int NumeroCamiseta1 { get => NumeroCamiseta; set => NumeroCamiseta = value; }


    }
}
