using System;

namespace PR2_ListaAlumnos
{
    class Alumnos
    {
        public string nombre;
        public string apellido;
        public int matricula;

        public Alumnos(string nombre, string apellido, int matricula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.matricula = matricula;
        }
    }
}