/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 2/11/2024
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace elclub.Clases
{
    public class Deporte
    {
        private string nombreDepo;
        private int anioCategoria;
        private int cupoCat;
        private int dniEntrenador;
        private string nombreEntrenador;
        private string apellidoEntrenador;
        private int cantInscriptos;
        private List<string> diasYHorarios;
        private int costoCuota;
        private int descuentoSocio;
        

        public string NombreDepo
        {
            get { return nombreDepo; }
            set { nombreDepo = value; }
        }

        public int AnioCategoria
        {
            get { return anioCategoria; }
            set { anioCategoria = value; }
        }

        public int CupoCat
        {
            get { return cupoCat; }
            set { cupoCat = value; }
        }

        public int DniEntrenador
        { 
            get { return dniEntrenador; }
            set { dniEntrenador = value; }
        }

        public string NombreEntrenador
        {
            get { return nombreEntrenador; }
            set { nombreEntrenador = value; }
        }

        public string ApellidoEntrenador
        {
            get { return apellidoEntrenador; }
            set { apellidoEntrenador = value; }
        }

        public int CantInscriptos
        {
            get { return cantInscriptos; }
            set { cantInscriptos = value; }
        }

        public List<string> DiasYHorarios
        { 
            get { return diasYHorarios; }
            set { diasYHorarios = value; }
        }

        public int CostoCuota
        {
            get { return costoCuota; }
            set { costoCuota = value; }
        }

        public int DescuentoSocio
        {
            get { return descuentoSocio; }
            set { descuentoSocio = value; }
        }
               
        public Deporte(string nombreDepo, int anioCategoria, int cupoCat, string nombreEntrenador, string apellidoEntrenador, int dniEntrenador, List<string> diasYHorarios, int costoCuota, int descuentoSocio)
        {
            this.nombreDepo = nombreDepo;
            this.anioCategoria = anioCategoria;
            this.cupoCat = cupoCat;
            this.nombreEntrenador = nombreEntrenador;
            this.apellidoEntrenador = apellidoEntrenador;
            this.dniEntrenador = dniEntrenador; 
            this.diasYHorarios = diasYHorarios;
            this.costoCuota = costoCuota;            
            this.descuentoSocio = descuentoSocio;
        }
    }
}
