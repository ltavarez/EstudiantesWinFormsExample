using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;

namespace BusinessLayer
{
    public class ServicioEstudiante
    {

        public void Agregar(Estudiante item)
        {
            RepositorioEstudiante.Instancia.Estudiantes.Add(item);
        }

        public void Editar(int index,Estudiante item)
        {
            RepositorioEstudiante.Instancia.Estudiantes[index] = item;
        }

        public void Borrar(int index)
        {
            RepositorioEstudiante.Instancia.Estudiantes.RemoveAt(index);
        }

        public Estudiante GetEstudiante(int index)
        {
            return RepositorioEstudiante.Instancia.Estudiantes[index];
        }


    }
}
