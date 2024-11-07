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
        private string nombreCategoria;
        private int cupoCat;

        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

        public int CupoCat
        {
            get { return cupoCat; }
            set { cupoCat = value; }
        }

        public Categoria(string nombreCategoria, int cupoCat)
        {
            this.nombreCategoria = nombreCategoria;
            this.cupoCat = cupoCat;
        }
    }
}
