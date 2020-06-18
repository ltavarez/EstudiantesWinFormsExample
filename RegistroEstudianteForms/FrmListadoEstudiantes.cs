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
    public sealed partial class FrmListadoEstudiantes : Form
    {
        private readonly ServicioEstudiante servicio;
        public static FrmListadoEstudiantes Instancia { get; } = new FrmListadoEstudiantes();

        private FrmListadoEstudiantes()
        {
            servicio = new ServicioEstudiante();
            InitializeComponent();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            FrmEstudianteFormulario newForm = new FrmEstudianteFormulario();
            newForm.Show();
            this.Hide();
        }

        private void FrmListadoEstudiantes_Load(object sender, EventArgs e)
        {
            LoadEstudiantes();
        }

        private void LoadEstudiantes()
        {
            LboxEstudiantes.BeginUpdate();

            LboxEstudiantes.Items.Clear();

            var estudiantes = RepositorioEstudiante.Instancia.Estudiantes;

            foreach (var estudiante in estudiantes)
            {
                LboxEstudiantes.Items.Add(estudiante.Datos);
            }
        
            LboxEstudiantes.EndUpdate();

        }

        private void FrmListadoEstudiantes_VisibleChanged(object sender, EventArgs e)
        {
            LoadEstudiantes();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            var index = LboxEstudiantes.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Debe seleccionar un estudiante", "Notificacion");
            }else
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar a este estudiante", "Notificacion",MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    servicio.Borrar(index);
                    LoadEstudiantes();
                }

            }

            

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            var index = LboxEstudiantes.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Debe seleccionar un estudiante", "Notificacion");
            }
            else
            {
                FrmEstudianteFormulario newForm = new FrmEstudianteFormulario();
                newForm.indexEstudiante = index;
                newForm.Show();
                this.Hide();
            }

          

        }
    }
}
