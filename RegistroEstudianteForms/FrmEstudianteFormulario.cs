using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace RegistroEstudianteForms
{
    public partial class FrmEstudianteFormulario : Form
    {

        private readonly ServicioEstudiante servicio;

        public int? indexEstudiante;
        public FrmEstudianteFormulario()
        {
            servicio  = new ServicioEstudiante();
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmListadoEstudiantes newForm = FrmListadoEstudiantes.Instancia;
            newForm.Show();
            this.Close();
        }

        private void FrmEstudianteFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmListadoEstudiantes newForm = FrmListadoEstudiantes.Instancia;
            newForm.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Estudiante estudiante = new Estudiante
            {
                Nombre = TxtNombreEstudiante.Text,
                Apellido = TxtApellidoEstudiante.Text,
                MateriaFavorita = TxtApellidoEstudiante.Text
            };


            if (indexEstudiante != null)
            {
                servicio.Editar(indexEstudiante.Value,estudiante);
            }
            else
            {
                servicio.Agregar(estudiante);
            }


            MessageBox.Show("Se ha guardado correctamente","Notificacion");
            this.Close();
        }

        private void FrmEstudianteFormulario_Load(object sender, EventArgs e)
        {

            if (indexEstudiante != null)
            {
                var estudianteEditado = servicio.GetEstudiante(indexEstudiante.Value);
                TxtNombreEstudiante.Text = estudianteEditado.Nombre;
                TxtApellidoEstudiante.Text = estudianteEditado.Apellido;
                TxtMateriaFavorita.Text = estudianteEditado.MateriaFavorita;
            }
            


        }
    }
}
