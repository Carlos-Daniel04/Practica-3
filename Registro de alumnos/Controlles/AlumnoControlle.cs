using Registro_de_alumnos.Entendades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_alumnos.Controlles
{
    internal class AlumnoControlle
    {
        // Areglo de alumnos
        private Alumno[] alumnos = new Alumno[100];
        private int contador = 0;

        // Listar todos los alumnos
        public Alumno[] ListarTodo() { return alumnos; }

        //Registrar Alumnos
        public void Registrar(Alumno alumno )
        {
            alumnos[contador] = alumno;
            contador++;
        }

        // Eliminar alumno del arreglo
        public void Eliminar(string codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno != null && alumno.Codigo == codigo);

            //Logica para eliminar el alumno del arreglo
            for (int i = 0; i < contador; i++)
            {
                if (i >= posicion)
                {
                    alumnos[i] = alumnos[i + 1];
                }
            }
            contador--;
        }

        //conparar el promedio de dos alumnos
        private class MetodoConparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (((Alumno)x).Promedio < ((Alumno)y).Promedio) return -1;
                else if (((Alumno)x).Promedio < ((Alumno)y).Promedio) return 0;
                else return 1;
            }
        }
         
        public Alumno[] Ordenar()
        {
            Array.Sort(alumnos, 0, contador, new MetodoConparacion());
            return alumnos;
        }
        //Bucar alumno segugub su codigo
        public Alumno[] BuscarPorCodigo(String codigo)
        {
            return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
        }



    }
}
