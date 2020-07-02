using System;
using System.Collections.Generic;
namespace ExamenPP
{
    public class Persona
    {
        public Persona()
        {
        }

        private string nombre;
        private int edad;
        private string nacion;
        private int sueldo;

        public string GetInfo()
        {
            string str = "Nombre: " + nombre + "\nEdad: " + edad.ToString() + "\nNacionalidad: " + nacion + "\nSueldo: " + sueldo.ToString();
            return str;
        }




    }
}
