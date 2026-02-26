using Registro_de_alumnos.Controlles;
using Registro_de_alumnos.Entendades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_alumnos
{
    public partial class Form1 : Form
    {
        //Llamar a la clase AlumnoControlle para usar sus metodos
        private AlumnoControlle alumnoControlle = new AlumnoControlle();
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarAlumnos(Alumno[] alumnos)
        {
            dtgalumnos.DataSource = null;
            dtgalumnos.DataSource = alumnos;
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(txtcodigo.Text == "" || txtnombre.Text == "" || txtpromedio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            //crear un nuevo alumno
            Alumno alumno = new Alumno
            {
                Codigo = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Promedio = double.Parse(txtpromedio.Text)
            };

            //Registrar el alumno usando el controlador
            alumnoControlle.Registrar(alumno);
            //Mostrar la lista actualizada de alumnos
            MostrarAlumnos(alumnoControlle.ListarTodo());
            limpiarCampos();
        }
        public void limpiarCampos()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtpromedio.Clear();
            txtBuscarcod.Clear();
        }
        //validacion de selecion
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(dtgalumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.");
                return;
            }
            //Obtener el codigo del alumno seleccionado
            String codigo = dtgalumnos.SelectedRows[0].Cells[0].Value.ToString();

            //Eliminar el alumno usando el controlador
            alumnoControlle.Eliminar(codigo);
            
            //Mostrar la lista actualizada de alumnos
            MostrarAlumnos(alumnoControlle.ListarTodo());
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoControlle.Ordenar());
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //Validar que el campo de búsqueda no esté vacío
            if(btnbuscar.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un código para buscar.");
                return;
            }
            //Buscar el alumno por código usando el controlador
            String codigo = txtBuscarcod.Text;

            //Mostrar el resultado de la búsqueda
            MostrarAlumnos(alumnoControlle.BuscarPorCodigo(codigo));
        }
    }
}
