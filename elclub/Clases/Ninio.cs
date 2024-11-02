/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 2/11/2024
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace elclub.Clases
{
    public class Ninio : Persona
    {
        protected DateTime ultimoMesPago;

        public DateTime UltimoMesPago
        {
            get { return ultimoMesPago; }
            set { ultimoMesPago = value; }
        }

        /*public Ninio()
        {

        }*/

        public Ninio(int dni, DateTime ultimoMesPago)
        {
            this.dni = dni;
            this.ultimoMesPago=ultimoMesPago;
        }

        public Ninio(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public Ninio (string nombre, string apellido, int edad, int dni, DateTime ultimoMesPago)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            this.ultimoMesPago = ultimoMesPago;
        }
    }
}