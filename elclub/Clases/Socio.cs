﻿/*
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
    public class Socio : Ninio
    {
        private double descuento;

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        /*public Socio(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }*/

        public Socio(string nombre, string apellido, int edad, int dni, DateTime ultimoMesPago, double descuento) : base(dni, ultimoMesPago)
        {
            this.descuento = descuento;
        }
    }
}
