namespace BusinessLayer
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string MateriaFavorita { get; set; }

        public string Datos
        {
            get
            {
                return Nombre + " " + Apellido + ", Materia Favorita: " + MateriaFavorita;

            }
        }
    }
}
