using System;
using System.Collections.Generic;

namespace PR2_ListaAlumnos
{
    class Carreras
    {
        public List<Alumnos> alumno;

        public Carreras()
        {
            alumno = new List<Alumnos>();
        }

        public Alumnos ConsultarPorMatricula(int matricula)
        {
            for (int i = 0; i < alumno.Count; i++)
            {
                Console.WriteLine("Buscando alumno...");
                if (alumno[i].matricula == matricula)
                {
                    return alumno[i];
                }
            }
            return null;
        }

        public List<Alumnos> ConsultarTodosLosAlumnos()
        {
            return this.alumno;
        }
    }
}