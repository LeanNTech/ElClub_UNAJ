/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 2/11/2024
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace elclub.Clases
{
    public class Categoria
    {
        private string nombreCat; 
        private Entrenador entrenadorx; 
        private Ninio ninios; 
        private int cupo;
        private string dia;
        private int horario; 
        private int cantidadN;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
    }
}
