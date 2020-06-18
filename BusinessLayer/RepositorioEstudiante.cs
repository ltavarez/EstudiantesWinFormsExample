using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;

namespace BusinessLayer
{
    public sealed class RepositorioEstudiante
    {

        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public static RepositorioEstudiante Instancia { get; } = new RepositorioEstudiante();

        private RepositorioEstudiante()
        {

        }
    }
}
