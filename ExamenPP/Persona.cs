using System;
using System.Collections.Generic;
namespace ExamenPP
{
    public abstract class Persona
    {
        public Persona()
        {
        }

        private string nombre;
        private int edad;
        private string nacion;
        private int sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nacion { get => nacion; set => nacion = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

        public string GetInfo()
        {
            string str = "Nombre: " + Nombre + "\nEdad: " + Edad.ToString() + "\nNacionalidad: " + Nacion + "\nSueldo: " + Sueldo.ToString();
            return str;
        }
    }
}
