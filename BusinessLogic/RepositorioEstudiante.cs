using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public sealed class RepositorioEstudiante
    {

        public List<Estudiante> Estudiantes { get; set; }

        public static RepositorioEstudiante Instancia { get; } = new RepositorioEstudiante();

        private RepositorioEstudiante()
        {

        }
    }
}
